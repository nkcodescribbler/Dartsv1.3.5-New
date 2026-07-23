# Planner-Coder Todo — 118
**Requirement:** Consolidated Prompt: Implement "Profile Information" Module (v2.0)
Objective: Extend the "chattocode1" ASP.NET Core 8.0 solution to include a secure "Profile Information" module. This task covers database schema updates, service implementation, and a responsive UI with strict validation and interactive features.

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Data\ApplicationDbContext.cs: Persons DbSet, ApplyConfigurationsFromAssembly
- SpecToCode1.Presentation\Program.cs: IAccountService, Authentication, DbContext, Migrate()
- SpecToCode1.Presentation\Views\Shared\_Layout.cshtml: Navbar links for Home, Logout, Register, Login

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Data\ApplicationDbContext.cs: add DbSet<Address> Addresses
- SpecToCode1.Presentation\Program.cs: add builder.Services.AddScoped<IProfileService, ProfileService>();
- SpecToCode1.Presentation\Views\Shared\_Layout.cshtml: add "Profile" link for authenticated users

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Backend Models, Data, and ViewModels | SpecToCode1.Model\AddressType.cs, SpecToCode1.Model\Address.cs, SpecToCode1.Model\Person.cs, SpecToCode1.Data\Configurations\AddressConfiguration.cs, SpecToCode1.Data\ApplicationDbContext.cs, SpecToCode1.Model\ViewModels\AddressViewModel.cs, SpecToCode1.Model\ViewModels\ProfileViewModel.cs | pending | — |
| T-002 | Business Logic and Services | SpecToCode1.Services\IProfileService.cs, SpecToCode1.Services\ProfileService.cs | pending | T-001 |
| T-003 | Account Controller Security & Identity | SpecToCode1.Presentation\Controllers\AccountController.cs | pending | T-001 |
| T-004 | UI, Presentation and Wiring | SpecToCode1.Presentation\Controllers\ProfileController.cs, SpecToCode1.Presentation\Views\Profile\Index.cshtml, SpecToCode1.Presentation\Program.cs, SpecToCode1.Presentation\Views\Shared\_Layout.cshtml | pending | T-002, T-003 |
