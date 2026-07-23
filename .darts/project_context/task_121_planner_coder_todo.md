# Planner-Coder Todo — 121
**Requirement:** Fix the migration issue I am facing runtime exception while navigate to "Profile" menu.

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Presentation/Program.cs: builder.Services.AddScoped<IProfileService, ProfileService>(), context.Database.Migrate()
- SpecToCode1.Data/ApplicationDbContext.cs: DbSet<Person>, DbSet<Address>

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Model/ViewModels/ProfileViewModel.cs: Change properties to { get; set; } to allow model binding and mapping.
- SpecToCode1.Presentation/Views/Profile/Index.cshtml: Ensure correct model properties and hidden fields for address types if needed.

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Fix ProfileViewModel property accessibility | SpecToCode1.Model/ViewModels/ProfileViewModel.cs | pending | — |
| T-002 | Fix Profile View binding and fields | SpecToCode1.Presentation/Views/Profile/Index.cshtml | pending | T-001 |
