# HiveApps Coding Guidelines

## General Principles

- Keep code simple, explicit and intentional.
- Prefer readability over cleverness.
- Avoid premature abstractions.
- Avoid introducing frameworks without justification.
- Keep module boundaries clear.
- Prefer small vertical slices.

## Documentation

Every public class, interface, method and relevant public property must include XML documentation using `<summary>`.

Example:

```csharp
/// <summary>
/// Represents a tenant in the HiveApps platform.
/// </summary>
public sealed class Tenant
{
}
```

## Naming

Use clear domain-oriented names.

Examples:

- `Tenant`
- `Company`
- `MagicLink`
- `AuditLog`
- `TenantStatus`
- `CompanyStatus`

Avoid vague names such as:

- `Manager`
- `Helper`
- `Processor`
- `DataObject`

## Entity Design

Entities should protect their internal state where appropriate.

Prefer:

```csharp
public string Name { get; private set; }
```

over:

```csharp
public string Name { get; set; }
```

Use methods to express business operations.

## Time

Do not use `DateTimeOffset.UtcNow` directly in business logic once `IDateTimeProvider` is available.

Use:

```csharp
IDateTimeProvider.UtcNow
```

## Tenant Safety

TenantId must not be accepted from public request bodies for tenant-owned data.

TenantId must come from:

- authenticated session;
- tenant context;
- super admin operation.

## API Design

Use DTOs/contracts for API input and output.

Do not expose EF Core entities directly through API responses.

## Validation

Validation should be explicit.

Future preferred tool:

- FluentValidation.

## Error Handling

Errors should be consistent and safe.

Do not expose:

- stack traces;
- database errors;
- internal exception details;
- secrets;
- tokens;
- Magic Link validators.

## Build

After each meaningful change, run:

```powershell
dotnet build .\HiveApps.slnx
```

## Lint and Formatting

Use .NET formatting and analyzer checks before pushing changes:

```powershell
dotnet format .\HiveApps.slnx --verify-no-changes
```

If this command reports changes, format locally and commit the result.

## Commit Convention

Use Conventional Commits whenever possible:

- `feat:` new functionality.
- `fix:` bug fix.
- `docs:` documentation updates.
- `refactor:` internal code improvements without behavior changes.
- `test:` test-related changes.
- `chore:` maintenance tasks.

Examples:

- `feat(tenants): add tenant status transitions`
- `fix(identity): prevent magic link reuse`
- `docs(roadmap): add phase 0.5 governance`

## AI Agent Rules

When using Codex/Cline:

- Read `docs/current-state.md` before coding.
- Keep tasks small.
- Do not modify unrelated files.
- Summarize changed files.
- Explain design decisions.
- Run build after changes.
- Do not introduce microservices unless explicitly requested.
- Do not introduce CQRS unless explicitly requested.
- Do not create frontend unless explicitly requested.
