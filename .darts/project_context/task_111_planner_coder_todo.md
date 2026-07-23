# Planner-Coder Todo — 111
**Requirement:** Create a new .NET 8.0 solution named 'SpecToCode1' with the specified four projects. Ensure correct project types (MVC for Presentation, Class Library for others) and establish the required references between them.

Acceptance Criteria:
- The solution contains 4 projects targeting .NET 8.0: SpecToCode1.Presentation, SpecToCode1.Services, SpecToCode1.Data, and SpecToCode1.Model.
- Project references are correctly set: Presentation -> Services, Services -> Data, Data -> Model, and Presentation -> Data.

Technical Hints: Use 'dotnet new sln', 'dotnet new mvc', and 'dotnet new classlib' commands. Establish references using 'dotnet add reference'.

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- None

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.sln: include all projects
- SpecToCode1.Presentation.csproj: add references to SpecToCode1.Services and SpecToCode1.Data
- SpecToCode1.Services.csproj: add reference to SpecToCode1.Data
- SpecToCode1.Data.csproj: add reference to SpecToCode1.Model

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Create Solution and Projects | SpecToCode1.sln, SpecToCode1.Model/SpecToCode1.Model.csproj, SpecToCode1.Data/SpecToCode1.Data.csproj, SpecToCode1.Services/SpecToCode1.Services.csproj, SpecToCode1.Presentation/SpecToCode1.Presentation.csproj | pending | — |
| T-002 | Establish Project References | SpecToCode1.Data/SpecToCode1.Data.csproj, SpecToCode1.Services/SpecToCode1.Services.csproj, SpecToCode1.Presentation/SpecToCode1.Presentation.csproj | pending | T-001 |
