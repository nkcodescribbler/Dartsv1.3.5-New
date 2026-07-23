# Planner-Coder Todo — 122
**Requirement:** Implement UserEducationHistory entity with EF Core Code-First, including Fluent API configuration, migration, and automatic migration on startup.

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Data\ApplicationDbContext.cs: DbSet<Person>, DbSet<Address>, ApplyConfigurationsFromAssembly
- SpecToCode1.Model\Person.cs: Addresses collection
- SpecToCode1.Presentation\Program.cs: Authentication, Services, Database.Migrate()

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Data\ApplicationDbContext.cs: add DbSet<UserEducationHistory>
- SpecToCode1.Model\Person.cs: add public virtual ICollection<UserEducationHistory> EducationHistories { get; set; } = new List<UserEducationHistory>();

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Backend — Data Models & DbContext | SpecToCode1.Model\UserEducationHistory.cs, SpecToCode1.Model\Person.cs, SpecToCode1.Data\Configurations\UserEducationHistoryConfiguration.cs, SpecToCode1.Data\ApplicationDbContext.cs | pending | — |
| T-002 | Migration — Generate EF Migration | SpecToCode1.Data\Migrations\20231027000002_AddUserEducationHistory.cs | pending | T-001 |
| T-003 | Entry points — Automatic Migration | SpecToCode1.Presentation\Program.cs | pending | T-002 |
