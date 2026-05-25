# HiveApps Product Vision

## Overview

HiveApps is a modular business applications suite and developer portfolio project.

The first version demonstrates the ability to design, build, document and deploy an enterprise-style SaaS application using .NET, Angular, PostgreSQL and AWS.

This project is for the developer purpose of showcasing his development skills with a lightweight and simple, but minimally functional application to be hosted on a cloud environment.

## Product Identity

HiveApps represents a modular suite of business applications. The name is inspired by the concept of a hive: multiple parts working together in a structured and collaborative system.

## MVP Scope

The MVP includes:

- A public portfolio area: recruiters should check information about the developer as a public CV.
- A super admin area: where we can create and invite new users/tenants.
- Tenant management: tenants are invited to use the system for a limited amount of time.
- Magic Link access: magic link invitations are used toinvite new tenants to test the system.
- A tenant-scoped CRM module: a MVP CRM for managing simple customer journeys from oportunities to convertion.
- Audit logging: for simulating real enterprise auditting of operations.
- Demo safety limits: tenants are going to use a limited amount of resources for a limited time.
- Future AWS deployment: the application will soon be deployed to AWS.

## Public Area

The public area presents:

- A landing page.
- Professional profile.
- Public CV/resume.
- Technical portfolio.
- Description of HiveApps.
- Request access to the demo playground.

## Super Admin Area

The super admin area is restricted to the system owner (the developer himself).

It allows:

- Creating tenants.
- Managing tenants (CRUD).
- Creating Magic Links.
- Revoking Magic Links.
- Viewing demo sessions.
- Reviewing audit logs.
- Managing demo limits.

## Tenant Admin Area

Tenant admins access the application through Magic Links.

They can manage only their own tenant data.

## First Business Module

The first business module is CRM.

CRM v1 includes:

- Companies.
- Contacts.
- Opportunities.
- Tasks.
- Basic dashboard.
- Audit history.

## Future Modules

Future modules may include:

- Helpdesk.
- Notifications.
- AI-assisted workflows (RAG, LLMs, etc).

These are out of scope for the first MVP.

## Primary Technical Goal

HiveApps should demonstrate:

- Modular monolith architecture.
- Tenant isolation.
- Magic Link authentication.
- Enterprise-style CRUD.
- Auditability.
- Cloud deployment readiness.
- Clean documentation.
- Professional software engineering practices.
