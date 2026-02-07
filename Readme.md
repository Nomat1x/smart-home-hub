#  Smart Home Hub

Modern IoT automation platform built with .NET 9, deployed on Raspberry Pi 5 with full CI/CD pipeline.

##  Project Goals

- Learn modern .NET 9 development
- Practice CI/CD with GitHub Actions
- Deploy to real hardware (Raspberry Pi 5)
- Build production-ready IoT system

##  Tech Stack

| Category | Technology |
|----------|-----------|
| **Backend** | .NET 9, Minimal APIs |
| **API Docs** | OpenAPI, Scalar |
| **Database** | PostgreSQL, EF Core |
| **Messaging** | MQTT (Mosquitto) |
| **Real-time** | SignalR |
| **Containers** | Docker, Docker Compose |
| **CI/CD** | GitHub Actions |
| **Deployment** | Raspberry Pi 5 (ARM64) |

##  Build Status

![CI/CD](https://github.com/Nomat1x/smart-home-hub/workflows/CI/badge.svg)
[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4)](https://dotnet.microsoft.com/)

## 🏃 Quick Start

### Prerequisites
- .NET 9 SDK
- Docker (optional)

### Run locally
```bash
dotnet run --project src/SmartHomeHub.Api
```

### Build
```bash
dotnet build
```

### Test
```bash
dotnet test
```

##  API Documentation

When running in development:
- **Scalar UI**: https://localhost:7xxx/scalar/v1
- **OpenAPI JSON**: https://localhost:7xxx/openapi/v1.json

##  Project Structure
```
smart-home-hub/
├── .github/
│   └── workflows/        # CI/CD pipelines
├── src/
│   └── SmartHomeHub.Api/ # Main API project
├── tests/                # Unit & integration tests
├── SmartHomeHub.sln      # Solution file
└── README.md
```

##  Roadmap

### Phase 1: Foundation 
- [x] .NET 9 project setup
- [x] OpenAPI + Scalar integration
- [ ] CI/CD pipeline
- [ ] Unit tests

### Phase 2: Core Features
- [ ] PostgreSQL + EF Core
- [ ] Device management API
- [ ] MQTT integration
- [ ] Background services

### Phase 3: Real-time & Automation
- [ ] SignalR integration
- [ ] Automation rules engine
- [ ] Telegram bot

### Phase 4: Deployment
- [ ] Docker containerization
- [ ] Raspberry Pi deployment
- [ ] Real hardware integration (ESP32)

##  Docker
```bash
docker-compose up -d
```

##  Contributing

Personal learning project, but feedback welcome!

##  License

MIT