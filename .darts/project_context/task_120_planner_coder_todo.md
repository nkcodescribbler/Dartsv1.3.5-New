# Planner-Coder Todo — 120
**Requirement:** "Migration not applied for '"Profile Information" Module'". Address table is not created and added columns not reflected in 'Person' table. Fix the issue

An unhandled exception occurred while processing the request.
SqlException: Invalid column name 'ContactNumber'.
Invalid column name 'DOB'.

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Data\ApplicationDbContext.cs: Persons and Addresses DbSets registered, ApplyConfigurationsFromAssembly called.
- SpecToCode1.Presentation\Program.cs: Database migration applied automatically via context.Database.Migrate().

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Data\Configurations\PersonConfiguration.cs: add DOB and ContactNumber property configurations.
- SpecToCode1.Data\Configurations\AddressConfiguration.cs: ensure AddressLine2 and State are configured as optional.

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Update Models and Configurations | SpecToCode1.Model/Person.cs, SpecToCode1.Model/Address.cs, SpecToCode1.Data/Configurations/PersonConfiguration.cs, SpecToCode1.Data/Configurations/AddressConfiguration.cs | pending | — |
| T-002 | Manual Migration Script (Simulated) | SpecToCode1.Data/Migrations/20231027000001_AddProfileFields.cs, SpecToCode1.Data/Migrations/ApplicationDbContextModelSnapshot.cs | pending | T-001 |
| T-003 | Verify Service and Entry Point | SpecToCode1.Services/ProfileService.cs, SpecToCode1.Presentation/Program.cs | pending | T-002 |
