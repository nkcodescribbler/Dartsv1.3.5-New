# Planner-Coder Todo — 117
**Requirement:** I am getting run time exception while running  SpecToCode1.Presentation project. "System.InvalidOperationException: 'The ConnectionString property has not been initialized.'" Fix the issue make it issue free.

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\Program.cs: builder.Configuration.GetConnectionString("DefaultConnection")

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\appsettings.json: add "ConnectionStrings": { "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SpecToCode1Db;Trusted_Connection=True;MultipleActiveResultSets=true" }

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Create appsettings.json with ConnectionString | C:\DARTS-development-environment\sandbox\kethare\Greenfield-With same refined prompt  v1.3.5\SpecToCode1.Presentation\appsettings.json | pending | — |
