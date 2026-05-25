# HiveApps Roadmap

## Phase 0 — Project Foundation

Status: In progress.

Goals:

- Create repository structure.
- Create backend solution.
- Create module projects.
- Add project references.
- Add SharedKernel base abstractions.
- Add documentation files.

Completed:

- Solution created as `HiveApps.slnx`.
- Backend projects created.
- Module projects created.
- Project references added.
- SharedKernel base abstractions created.
- Solution compiles.

## Phase 0.5 — Engineering Governance

Status: In progress.

Goals:

- Create GitHub repository integration and first push flow.
- Add CI pipeline with restore/build/lint/test checks.
- Add pull request template.
- Define commit message convention.
- Keep quality gates lightweight and portfolio-friendly.

Completed:

- GitHub repository created.
- Initial CI workflow added in `.github/workflows/ci.yml`.
- PR template added in `.github/pull_request_template.md`.
- Commit convention and lint guidance documented in `docs/coding-guidelines.md`.

Definition of Done:

- Every push/PR to tracked branches runs CI automatically.
- Solution builds successfully in CI.
- Formatting check (`dotnet format --verify-no-changes`) is enforced.
- Team conventions are documented and visible in the repository.

## Phase 1 — Tenants Foundation

Goals:

- Add `Tenant` entity.
- Add `TenantStatus` enum.
- Add tenant contracts.
- Add basic tenant domain behavior.

## Phase 2 — CRM Foundation

Goals:

- Add `Company` entity.
- Add `CompanyStatus` enum.
- Add company contracts.
- Add basic company behavior.
- Ensure company is tenant-scoped.

## Phase 3 — Infrastructure Foundation

Goals:

- Add EF Core packages.
- Add PostgreSQL provider.
- Add `HiveAppsDbContext`.
- Add entity configurations.
- Add first migration.
- Add local PostgreSQL through Docker Compose.

## Phase 4 — First API Slice

Goal:

Super admin or development context can create a tenant and create a company associated with that tenant.

Includes:

- Tenant endpoint.
- Company endpoint.
- Tenant context placeholder.
- Basic validation.
- Swagger visibility.
- Build success.

## Phase 5 — Magic Link Foundation

Goals:

- Add Magic Link entity.
- Add Magic Link status.
- Add token hashing model.
- Add Magic Link generation.
- Add Magic Link redemption.
- Add demo session model.

## Phase 6 — First Full Vertical Slice

Goal:

Super admin creates a tenant, generates a Magic Link, user redeems it, enters tenant workspace and creates a CRM company.

Includes:

- Tenant creation.
- Magic Link creation.
- Magic Link redemption.
- Tenant-scoped session.
- Company CRUD.
- Audit log.

## Phase 7 — CRM Expansion

Goals:

- Contacts.
- Opportunities.
- Tasks.
- Basic dashboard.
- Search.
- Pagination.
- Archive/restore.

## Phase 8 — Public Portfolio

Goals:

- Public portfolio route.
- CV summary.
- Technical project description.
- Demo request page.

## Phase 9 — AWS Deployment

Goals:

- Route 53 DNS.
- Amplify frontend hosting.
- Lightsail backend deployment.
- PostgreSQL deployment.
- SES controlled email.
- S3 backups.
- AWS Budgets.
