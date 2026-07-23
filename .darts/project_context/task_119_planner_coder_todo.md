# Planner-Coder Todo — 119
**Requirement:** Facing compile time issue and output log is below, fix the issue, endue error free code.

Rebuild started at 13:11...
Restored C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Model\SpecToCode1.Model.csproj (in 1.35 sec).
1>------ Rebuild All started: Project: SpecToCode1.Model, Configuration: Debug Any CPU ------
Restored C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\SpecToCode1.Presentation.csproj (in 1.42 sec).
Restored C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Data\SpecToCode1.Data.csproj (in 1.42 sec).
Restored C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Services\SpecToCode1.Services.csproj (in 1.42 sec).
1>  SpecToCode1.Model -> C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Model\bin\Debug\net8.0\SpecToCode1.Model.dll
2>------ Rebuild All started: Project: SpecToCode1.Data, Configuration: Debug Any CPU ------
2>  SpecToCode1.Data -> C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Data\bin\Debug\net8.0\SpecToCode1.Data.dll
3>------ Rebuild All started: Project: SpecToCode1.Services, Configuration: Debug Any CPU ------
3>  SpecToCode1.Services -> C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Services\bin\Debug\net8.0\SpecToCode1.Services.dll
4>------ Rebuild All started: Project: SpecToCode1.Presentation, Configuration: Debug Any CPU ------
4>C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Controllers\AccountController.cs(40,30,40,34): error CS1503: Argument 1: cannot convert from 'SpecToCode1.Model.UserDto' to 'SpecToCode1.Model.Person'
4>C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Controllers\AccountController.cs(69,30,69,34): error CS1503: Argument 1: cannot convert from 'SpecToCode1.Model.UserDto' to 'SpecToCode1.Model.Person'
========== Rebuild All: 3 succeeded, 1 failed, 0 skipped ==========
========== Rebuild completed at 13:12 and took 07.716 seconds ==========

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Presentation\Controllers\AccountController.cs: Microsoft.AspNetCore.Authentication, Microsoft.AspNetCore.Authentication.Cookies, Microsoft.AspNetCore.Mvc, SpecToCode1.Model, SpecToCode1.Services, System.Security.Claims

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Presentation\Controllers\AccountController.cs: Update SignInUser signature to take UserDto instead of Person.

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Fix AccountController type mismatch | SpecToCode1.Presentation/Controllers/AccountController.cs | pending | — |
