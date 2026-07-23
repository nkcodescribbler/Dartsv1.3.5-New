# Planner-Coder Todo — 112
**Requirement:** In the SpecToCode1.Model project, create the Person entity and DTOs. The Person entity must include the following fields: Id (int), Username (string, max 100), Password (string, max 100), FirstName (string, max 100), LastName (string, max 100), and LastLogin (DateTime?). Create UserDto, LoginDto, and RegisterDto for data transfer.

Acceptance Criteria:
- The Person entity includes: Id (int, PK), Username (nvarchar 100, unique), Password (nvarchar 100), FirstName (nvarchar 100), LastName (nvarchar 100), and LastLogin (DateTime, Nullable).
- DTOs UserDto, LoginDto, and RegisterDto are created with relevant fields.

Dependencies: Task Setup Solution and Project Structure

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- SpecToCode1.Data/ApplicationDbContext.cs: DbSet<Person> Persons { get; set; }

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- SpecToCode1.Data/Configurations/PersonConfiguration.cs: add EntityTypeConfiguration for Person (Max lengths, Unique Username)

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Create Person Entity and DTOs | SpecToCode1.Model/Person.cs, SpecToCode1.Model/UserDto.cs, SpecToCode1.Model/LoginDto.cs, SpecToCode1.Model/RegisterDto.cs | pending | — |
| T-002 | Configure Person Entity mapping | SpecToCode1.Data/Configurations/PersonConfiguration.cs | pending | T-001 |
