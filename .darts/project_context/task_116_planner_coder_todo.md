# Planner-Coder Todo — 116
**Requirement:** Build the MVC components in SpecToCode1.Presentation. Create the AccountController with associated ViewModels and Razor views for user registration and login. Protect the Home page using [Authorize]. Update the shared layout to reflect the user's authentication state.

Acceptance Criteria:
- AccountController exists with Login and Register actions.
- HomeController or the default landing page is protected by the [Authorize] attribute.
- Login and Register views use Bootstrap 5 styling and jQuery Unobtrusive Validation.
- _Layout.cshtml shows 'Home' and 'Logout' for logged-in users, and 'Login/Register' for guests.

Technical Hints: Use ASP.NET Core Identity-like flows with manual cookie signing if not using full Identity, or use Claims-based identity as required by the 'fully functional cookie-based authentication' spec.

Dependencies: Task Configure Web Infrastructure and Auth

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Program.cs: CookieAuth, AccountService registration, UseAuthentication, UseAuthorization.
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Controllers\AccountController.cs: Login/Register actions.
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Controllers\HomeController.cs: Authorize attribute.

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- None (already registered in Program.cs and controllers).

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Create MVC Views and Layout | SpecToCode1.Presentation/Views/Account/Login.cshtml, SpecToCode1.Presentation/Views/Account/Register.cshtml, SpecToCode1.Presentation/Views/Home/Index.cshtml, SpecToCode1.Presentation/Views/Shared/_Layout.cshtml, SpecToCode1.Presentation/Views/_ViewImports.cshtml, SpecToCode1.Presentation/Views/_ViewStart.cshtml | pending | — |
