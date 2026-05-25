# HiveApps Current State

## Project Goal

HiveApps is a modular business applications suite and developer portfolio project.

The MVP starts with:

- Public portfolio area.
- Super admin area.
- Tenant management.
- Magic Link access.
- Tenant-scoped CRM module.
- Audit logging.
- Future AWS deployment.

Future modules may include Helpdesk and a SaaS marketplace, but they are out of scope for the MVP.

## Current Repository Structure

Root directory:

```text
D:\Studies\Repos\HiveApps
```

Solution file:

```text
HiveApps.slnx
```

Backend projects:

```text
backend/src/HiveApps.Api
backend/src/HiveApps.Infrastructure
backend/src/HiveApps.SharedKernel
backend/src/Modules/HiveApps.Modules.Crm
backend/src/Modules/HiveApps.Modules.Identity
backend/src/Modules/HiveApps.Modules.Tenants
backend/src/Modules/HiveApps.Modules.Audit
```

## Current Implementation

The solution compiles successfully.

The SharedKernel project contains documented base abstractions:

```text
Entities/BaseEntity.cs
Entities/AuditableEntity.cs
Entities/TenantEntity.cs
Abstractions/ICurrentUserContext.cs
Abstractions/ITenantContext.cs
Time/IDateTimeProvider.cs
```

All public classes, interfaces, methods and relevant public properties must include XML documentation using `<summary>`.

## Target Architecture

HiveApps starts as a modular monolith.

The system must not start as microservices. Module boundaries should remain explicit so selected modules can be extracted later if justified.

## Current Technology

- .NET 10
- ASP.NET Core Web API
- PostgreSQL planned
- Entity Framework Core planned
- Angular planned
- AWS planned

## Current Rules

- Do not add microservices yet.
- Do not add CQRS yet unless explicitly requested.
- Do not add event sourcing.
- Do not add Kafka, Kubernetes or unnecessary infrastructure.
- Do not create frontend yet unless explicitly requested.
- Do not implement Helpdesk yet.
- Do not implement marketplace yet.
- Prefer small vertical slices.
- Every generated class/interface/method/property should include XML documentation.
- Run `dotnet build .\HiveApps.slnx` after changes.
