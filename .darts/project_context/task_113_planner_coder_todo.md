# Planner-Coder Todo — 113
**Requirement:** In the SpecToCode1.Data project, implement the ApplicationDbContext. Use IEntityTypeConfiguration<Person> to map the Person entity to the database, ensuring the Username field is unique. Generate the 'InitialCreate' migration.

Acceptance Criteria:
- DbContext is implemented with Person entity configuration.
- Fluent API is used in IEntityTypeConfiguration<Person> to enforce schema constraints (e.g., unique Username).
- The project contains an 'InitialCreate' migration file.

Technical Hints: Ensure Microsoft.EntityFrameworkCore.SqlServer and Microsoft.EntityFrameworkCore.Design are installed. Use 'dotnet ef migrations add InitialCreate' from the Data project directory.

Dependencies: Task Define Domain Model and DTOs

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Presentation/Program.cs: ApplicationDbContext registered with SQL Server, migrations applied on startup.
- SpecToCode1.Data/ApplicationDbContext.cs: Persons DbSet defined, configurations applied from assembly.
- SpecToCode1.Data/Configurations/PersonConfiguration.cs: Person mapping with unique Username index.

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Data/Migrations/20231027000000_InitialCreate.cs: add migration logic for Person table.
- SpecToCode1.Data/Migrations/ApplicationDbContextModelSnapshot.cs: add model snapshot.

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Create Initial Migration | SpecToCode1.Data/Migrations/20231027000000_InitialCreate.cs, SpecToCode1.Data/Migrations/20231027000000_InitialCreate.Designer.cs, SpecToCode1.Data/Migrations/ApplicationDbContextModelSnapshot.cs | pending | — |
