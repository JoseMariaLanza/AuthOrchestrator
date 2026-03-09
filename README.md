# AuthOrchestrator

Shared NuGet library providing JWT authentication, Redis session management, and auth contracts for the Fintech microservices ecosystem.

## Architecture

```
AuthOrchestrator/
├── AuthOrchestrator.csproj      # Multi-target: net6.0 + net8.0
├── JWT/
│   └── JwtConfiguration.cs      # JWT Bearer setup and token validation
├── Redis/
│   ├── RedisSettings.cs          # Redis connection config
│   ├── RedisHelper.cs            # Low-level Redis operations
│   ├── RedisService.cs           # Session management service
│   ├── IRedisHelper.cs           # Redis helper abstraction
│   └── IRedisService.cs          # Redis service abstraction
├── UserSession/
│   ├── UserSessionMiddleware.cs  # Middleware for session validation
│   └── UserSessionModel.cs       # Session data model
└── UserTypes/
    └── UserTypes.cs              # 28 user type constants
```

**This is a class library, not a runnable service.** It is consumed as a NuGet package by Tasker, CenterAuth, and OpsFlow.

## Technology stack

| Component | Version |
|---|---|
| .NET | 6.0 + 8.0 (multi-target) |
| JwtBearer | 6.0.21 (net6.0) / 8.0.12 (net8.0) |
| StackExchange.Redis | 2.8.16 |
| Extensions.Configuration | 8.0.x |
| Extensions.DependencyInjection | 8.0.1 |

## Current version

**1.1.0** — multi-target net6.0/net8.0, updated metadata and dependencies.

## What it provides

- **JWT configuration**: `ConfigureJwtAuthentication()` extension method for `IServiceCollection`
- **Redis services**: `AddRedisServices()` extension method for DI registration
- **User session middleware**: validates active session in Redis on every request
- **User type constants**: 28 named user types for role-based authorization

## Commands

```bash
# Build
dotnet build

# Pack NuGet
dotnet pack -c Release

# Output location
./NugetPackages/AuthOrchestrator.1.1.0.nupkg
```

## Consumers

| Repo | Version | Purpose |
|---|---|---|
| **Tasker** | 1.1.0 | JWT auth + Redis sessions for task management API |
| **CenterAuth** | 1.1.0 | JWT auth + Redis sessions for auth service |
| **OpsFlow** | 1.1.0 | JWT validation + user type mapping for operational tasks |
