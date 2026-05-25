# HiveApps Architecture

## Architecture Style

HiveApps starts as a modular monolith.

The system is intentionally not implemented as microservices in the MVP. Module boundaries are kept explicit so selected modules can be extracted later if scale, team structure or operational requirements justify it.

## Backend

Backend stack:

- .NET 10.
- ASP.NET Core Web API.
- Entity Framework Core.
- PostgreSQL.
- Modular monolith.
- Tenant-scoped data access.
- Magic Link authentication.
- Audit logging.

## Frontend

Frontend stack planned:

- Angular.
- Public routes.
- Super admin routes.
- Tenant admin routes.
- Route guards.
- Typed API services.

The frontend is not part of the current implementation yet.

## Modules

Initial backend modules:

- CRM.
- Identity.
- Tenants.
- Audit.

Future modules:

- Helpdesk.
- Notifications.
- Marketplace.
- Integrations.

## Project Responsibilities

### HiveApps.Api

Responsible for:

- HTTP endpoints.
- Controllers.
- OpenAPI/Swagger.
- Authentication setup.
- Authorization setup.
- Dependency injection composition.
- CORS.
- Rate limiting.
- Health checks.

### HiveApps.SharedKernel

Responsible for:

- Base entities.
- Shared abstractions.
- Time abstractions.
- Shared contracts used across modules.

### HiveApps.Infrastructure

Responsible for:

- Persistence.
- Entity Framework Core.
- PostgreSQL configuration.
- External service implementations.
- Email provider integration.
- Tenant context implementation.
- Current user context implementation.
- Date/time provider implementation.

### HiveApps.Modules.Crm

Responsible for:

- CRM domain model.
- Companies.
- Contacts.
- Opportunities.
- Tasks.
- CRM-specific business rules.

### HiveApps.Modules.Identity

Responsible for:

- Magic Links.
- Demo sessions.
- Users.
- Roles.
- Authentication-related domain rules.

### HiveApps.Modules.Tenants

Responsible for:

- Tenant model.
- Tenant lifecycle.
- Tenant status.
- Tenant settings.

### HiveApps.Modules.Audit

Responsible for:

- Audit logs.
- Audit event types.
- Entity change tracking.
- Security-relevant events.

## Tenant Isolation

Tenant-owned records must include `TenantId`.

Tenant-scoped queries must never trust `TenantId` from the request body. TenantId must come from the authenticated session or tenant context.

## Entity Base Classes

Base entity structure:

```text
BaseEntity
  Id
  CreatedAt
  UpdatedAt

AuditableEntity : BaseEntity
  CreatedBy
  UpdatedBy

TenantEntity : AuditableEntity
  TenantId
```

## Deployment Target

Initial AWS deployment target:

- Angular frontend: AWS Amplify Hosting.
- .NET API and PostgreSQL: Amazon Lightsail with Docker Compose.
- DNS: Route 53.
- Email: Amazon SES.
- Backups: S3.
- Cost monitoring: AWS Budgets.

## Architecture Rules

- Do not start with microservices.
- Do not add CQRS until there is a clear use case.
- Do not add event sourcing.
- Do not add Kafka.
- Do not add Kubernetes.
- Prefer explicit module boundaries.
- Prefer a working vertical slice over broad incomplete scaffolding.
