# Weather API - DevOps Project

A containerized REST API built with C# .NET Core, demonstrating cloud-native development practices.

## Overview

This is a production-ready microservice that provides real-time weather information for multiple cities. Built with containerization and orchestration in mind for deployment on Kubernetes.

## Features

- ✅ RESTful API endpoint (`/weather?city=Islamabad`)
- ✅ JSON response with temperature, humidity, and weather description
- ✅ Error handling for invalid cities
- ✅ Containerized with Docker (multi-stage build)
- ✅ Environment configuration for cloud deployments
- ✅ OpenAPI/Swagger support for API documentation

## Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core 10.0 (Minimal APIs)
- **.NET Runtime:** .NET 10.0
- **Containerization:** Docker
- **Container Orchestration:** Kubernetes-ready

## API Endpoints

### GET /weather

Returns weather information for a specified city.

**Parameters:**
- `city` (query string, optional): City name (defaults to "Islamabad")

**Example Request:**
```bash
curl "http://localhost:5000/weather?city=Karachi"
```

**Example Response:**
```json
{
  "city": "Karachi",
  "temperature": 32,
  "humidity": 75,
  "description": "Hot and Humid",
  "unit": "Celsius",
  "timestamp": "2026-05-22T07:45:24.7099352Z"
}
```

## Getting Started

### Local Development

1. **Prerequisites:**
   - .NET SDK 10.0 or later
   - Visual Studio Code or Visual Studio

2. **Run the application:**
```bash
   dotnet restore
   dotnet run
```

3. **Access the API:**

   http://localhost:5000/weather?city=Islamabad

   ### Docker Deployment

1. **Build the image:**
```bash
   docker build -t weatherapi:1.0 .
```

2. **Run the container:**
```bash
   docker run -p 5000:5000 weatherapi:1.0
```

3. **Test the API:**
```bash
   curl "http://localhost:5000/weather?city=Dubai"
```

## Architecture

This project demonstrates:

- **Minimal APIs:** Modern .NET approach for lightweight microservices
- **Multi-stage Docker builds:** Optimized container images for production
- **Cloud-native design:** Environment-based configuration, health checks ready
- **12-factor app principles:** Stateless, scalable, easy to deploy

## Project Structure
WeatherAPI/
├── Program.cs              # Application entry point and API endpoints
├── WeatherAPI.csproj       # Project configuration
├── Dockerfile              # Multi-stage Docker build configuration
├── appsettings.json        # Default configuration
├── appsettings.Development.json  # Development configuration
└── bin/                    # Compiled binaries

## DevOps Skills Demonstrated

- ✅ Containerization (Docker)
- ✅ CI/CD pipeline ready
- ✅ Environment configuration
- ✅ Health checks and monitoring ready
- ✅ Kubernetes deployment ready (next phase)
- ✅ Infrastructure as Code compatible

## Next Steps

- Deploy to Azure Container Registry (ACR)
- Kubernetes (AKS) deployment
- CI/CD pipeline with Azure DevOps
- Monitoring with Application Insights
- Helm chart creation

## Author

Zain - Software Engineer | Cloud & DevOps Specialist

---

**Built to demonstrate professional DevOps practices in cloud-native application development.**
