using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpecToCode1.Model;
using SpecToCode1.Model.ViewModels;
using SpecToCode1.Services;
using System.Security.Claims;

namespace SpecToCode1.Presentation.Controllers;

/// <summary>
/// Controller to handle requests related to User Education History.
/// </summary>
[Authorize]
public class EducationController : Controller
{
    private readonly IEducationService _educationService;

    /// <summary>
    /// Initializes a new instance of the <see cref="EducationController"/> class.
    /// </summary>
    /// <param name="educationService">The education service injected via DI.</param>
    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    /// <summary>
    /// Displays the education history for the currently authenticated user.
    /// </summary>
    /// <returns>A view with the user's education records.</returns>
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = GetUserId();
        if (userId == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var educationList = await _educationService.GetEducationListAsync(userId.Value);

        var viewModelList = educationList.Select(e => new EducationViewModel
        {
            Id = e.Id,
            EducationType = e.EducationType,
            InstitutionName = e.InstitutionName,
            AddressLine1 = e.InstitutionAddressLine1,
            AddressLine2 = e.InstitutionAddressLine2,
            City = e.InstitutionCity,
            State = e.InstitutionState,
            Pincode = e.InstitutionPincode
        }).ToList();

        return View(viewModelList);
    }

    /// <summary>
    /// Displays the form to add a new education record.
    /// </summary>
    /// <returns>The Create view.</returns>
    [HttpGet]
    public IActionResult Create()
    {
        return View(new EducationViewModel());
    }

    /// <summary>
    /// Handles the submission of the new education record.
    /// </summary>
    /// <param name="model">The education view model from the form.</param>
    /// <returns>A redirect to the Index action on success, or the Create view with errors on failure.</returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(EducationViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var userId = GetUserId();
        if (userId == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var education = new UserEducationHistory
        {
            EducationType = model.EducationType,
            InstitutionName = model.InstitutionName,
            InstitutionAddressLine1 = model.AddressLine1,
            InstitutionAddressLine2 = model.AddressLine2,
            InstitutionCity = model.City,
            InstitutionState = model.State,
            InstitutionPincode = model.Pincode,
            UserId = userId.Value
        };

        await _educationService.CreateEducationAsync(education);

        TempData["SuccessMessage"] = "Education history added successfully.";
        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Displays the form to edit an existing education record.
    /// </summary>
    /// <param name="id">The ID of the education record to edit.</param>
    /// <returns>The Edit view or a 403 Forbidden if not authorized.</returns>
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var userId = GetUserId();
        if (userId == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var education = await _educationService.GetEducationByIdAsync(id, userId.Value);
        if (education == null)
        {
            return Forbid();
        }

        var viewModel = new EducationViewModel
        {
            Id = education.Id,
            EducationType = education.EducationType,
            InstitutionName = education.InstitutionName,
            AddressLine1 = education.InstitutionAddressLine1,
            AddressLine2 = education.InstitutionAddressLine2,
            City = education.InstitutionCity,
            State = education.InstitutionState,
            Pincode = education.InstitutionPincode
        };

        return View(viewModel);
    }

    /// <summary>
    /// Handles the submission of the edited education record.
    /// </summary>
    /// <param name="model">The updated education view model.</param>
    /// <returns>A redirect to the Index action on success, or the Edit view with errors on failure.</returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(EducationViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var userId = GetUserId();
        if (userId == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var existingEducation = await _educationService.GetEducationByIdAsync(model.Id, userId.Value);
        if (existingEducation == null)
        {
            return Forbid();
        }

        existingEducation.EducationType = model.EducationType;
        existingEducation.InstitutionName = model.InstitutionName;
        existingEducation.InstitutionAddressLine1 = model.AddressLine1;
        existingEducation.InstitutionAddressLine2 = model.AddressLine2;
        existingEducation.InstitutionCity = model.City;
        existingEducation.InstitutionState = model.State;
        existingEducation.InstitutionPincode = model.Pincode;

        await _educationService.UpdateEducationAsync(existingEducation);

        TempData["SuccessMessage"] = "Education history updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Handles the deletion of an education record.
    /// </summary>
    /// <param name="id">The ID of the education record to delete.</param>
    /// <returns>A redirect to the Index action.</returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var userId = GetUserId();
        if (userId == null)
        {
            return RedirectToAction("Login", "Account");
        }

        await _educationService.DeleteEducationAsync(id, userId.Value);

        TempData["SuccessMessage"] = "Education history deleted successfully.";
        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Gets the Person ID of the currently authenticated user from claims.
    /// </summary>
    /// <returns>The user's ID or null if not found.</returns>
    private int? GetUserId()
    {
        var claim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (claim != null && int.TryParse(claim.Value, out int id))
        {
            return id;
        }
        return null;
    }
}
