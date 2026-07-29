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