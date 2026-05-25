# HiveApps Demo Limits

## Purpose

HiveApps will be publicly accessible as a portfolio and demo application.

The demo must be safe against abuse, excessive resource usage and cost spikes.

## Public Area

The public area should be mostly static and low-cost.

Public pages:

- Landing page.
- Portfolio.
- Public CV.
- Project description.
- Request demo access.

## Protected Area

The protected area is accessible through Magic Link or authenticated session.

Protected areas:

- Tenant admin workspace.
- CRM module.
- Future modules.

## Suggested Limits

### Magic Links

- Magic Link expires after 15 minutes before redemption.
- Redeemed sessions expire after 60 minutes.
- Magic Link is single-use.
- Magic Link can be revoked.
- Failed validation attempts are limited.

### Demo Sessions

- Maximum session lifetime: 60 minutes.
- Maximum companies per tenant demo: 20.
- Maximum contacts per tenant demo: 50.
- Maximum opportunities per tenant demo: 20.
- Maximum tasks per tenant demo: 50.

### Global Daily Limits

Suggested initial limits:

- Maximum demo tenants created per day: 20.
- Maximum Magic Links generated per day: 50.
- Maximum email sends per day: 10.
- Maximum CRM records created per day: 500.

### Email

Real email must not be sent freely.

Allowed modes:

- Screen-only mode.
- SES sandbox mode.
- Allowlist mode.

### Cleanup

Old demo data should be cleaned automatically.

Suggested cleanup:

- Delete expired Magic Links older than 24 hours.
- Delete demo sessions older than 24 hours.
- Delete demo tenants older than 7 days, unless marked as persistent.

## Read-Only Mode

The system should support a read-only mode through configuration.

When read-only mode is enabled:

- Public pages remain available.
- Existing data can be viewed.
- New data cannot be created.
- Magic Link generation is disabled.
- Email sending is disabled.

## Abuse Events

The system should audit:

- Rate limit exceeded.
- Demo quota exceeded.
- Invalid Magic Link attempts.
- Revoked Magic Link usage attempt.
- Expired Magic Link usage attempt.
- Suspicious repeated actions.
