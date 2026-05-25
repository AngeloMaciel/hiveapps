# HiveApps Security Notes

## Security Goals

HiveApps should demonstrate secure-by-design thinking for a public demo application.

Primary concerns:

- Tenant isolation.
- Magic Link safety.
- Abuse prevention.
- Cost protection.
- Safe logging.
- Secure deployment.

## Tenant Isolation

Tenant-scoped data must include `TenantId`.

Tenant-owned records must always be queried through the current tenant context.

Never trust `TenantId` from request bodies for tenant-owned operations.

## Magic Link Safety

Magic Links must be:

- Time-limited.
- Single-use.
- Revocable.
- Stored safely.
- Validated without exposing secrets.

The system should not store raw secret validators.

Preferred model:

- Public selector in URL.
- Secret validator in URL.
- Store only hash of validator or composite token.
- Apply expiration.
- Apply attempt limits.
- Revoke after successful use.

## Logging

Logs must not include:

- Magic Link secret values.
- Raw tokens.
- Passwords.
- Full sensitive payloads.
- Secrets.
- Connection strings.

Avoid logging personally identifiable information unless explicitly required and sanitized.

## Public Demo Abuse Prevention

The public demo must include:

- Rate limiting.
- Global daily quotas.
- Per-session quotas.
- Short-lived demo sessions.
- Optional read-only mode.
- Automatic cleanup of old demo data.

## Email Safety

Real email sending must be restricted.

Preferred modes:

- Screen-only demo mode.
- SES sandbox.
- Allowlist mode.
- Daily email quota.

No public unrestricted email sending.

## Cloud Cost Safety

AWS deployment must include:

- AWS Budgets.
- Low billing alerts.
- No unnecessary NAT Gateway.
- No unnecessary Load Balancer.
- No oversized RDS instance.
- No unbounded logs.
- No public PostgreSQL exposure.

## Deployment Safety

Only required ports should be exposed:

- 80
- 443
- restricted SSH, if needed

PostgreSQL must not be publicly exposed.

## API Error Safety

Do not expose:

- stack traces;
- database exception details;
- internal service names;
- infrastructure details;
- secrets.
