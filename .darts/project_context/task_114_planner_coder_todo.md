# Planner-Coder Todo — 114
**Requirement:** Implement the business logic for user management in the SpecToCode1.Services project. Create IAccountService and its implementation to handle registration (with unique username check) and login (with credential verification and LastLogin timestamp updates).

Acceptance Criteria:
- IAccountService and AccountService are implemented in the Services project.
- RegisterUserAsync validates that usernames are unique.
- LoginUserAsync verifies credentials and updates the LastLogin field in the database.
- Service methods return DTOs rather than raw entities.

Dependencies: Task Implement Data Layer and Migrations

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Program.cs: builder.Services.AddScoped<IAccountService, AccountService>();
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Data\ApplicationDbContext.cs: public DbSet<Person> Persons { get; set; }

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- None (already wired)

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Verify and/or Implement Account Service | SpecToCode1.Services/IAccountService.cs, SpecToCode1.Services/AccountService.cs | pending | — |
