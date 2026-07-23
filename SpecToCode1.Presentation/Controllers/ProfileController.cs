using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpecToCode1.Model.ViewModels;
using SpecToCode1.Services;
using System.Security.Claims;

namespace SpecToCode1.Presentation.Controllers;

[Authorize]
public class ProfileController : Controller
{
    private readonly IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = GetUserId();
        if (userId == null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        var profile = await _profileService.GetProfileAsync(userId.Value);
        if (profile == null) return NotFound();

        return View(profile);
    }

    [HttpPost]
    public async Task<IActionResult> Index(ProfileViewModel model)
    {
        var userId = GetUserId();
        if (userId == null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = await _profileService.UpdateProfileAsync(model, userId.Value);
        if (result)
        {
            ViewBag.Message = "Profile updated successfully.";
        }
        else
        {
            ModelState.AddModelError("", "Error updating profile.");
        }

        return View(model);
    }

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