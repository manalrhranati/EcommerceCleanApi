# EcommerceCleanApi

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor)
![Architecture](https://img.shields.io/badge/Architecture-Clean Architecture-blue)

A modern, scalable E-Commerce application built using **.NET 8**, **Clean Architecture**, and **Blazor WebAssembly**. The project demonstrates best practices including CQRS with **MediatR**, Fluent validation via pipeline behaviors, and standard REST API integration.

---

## 📐 Architecture Overview

The system follows **Clean Architecture** principles, separating concerns across distinct layers to ensure high testability and maintainability:

```
EcommerceCleanApi/
├── src/
│   ├── Domain/           # Domain entities, value objects, domain logic
│   ├── Application/      # Business logic, MediatR Queries/Commands, FluentValidation
│   ├── Infrastructure/   # Data persistence, Entity Framework Core, external services
│   ├── WebApi/           # ASP.NET Core REST API, Controllers, Middleware
│   └── BlazorApp/        # Blazor WebAssembly frontend UI components & pages
└── EcommerceCleanApi.sln
```

---

## 🛠️ Tech Stack & Key Libraries

- **Framework:** .NET 8.0 SDK
- **Frontend:** Blazor WebAssembly (Interactive Client-Side UI)
- **Backend:** ASP.NET Core Web API
- **Design Pattern:** CQRS (Command Query Responsibility Segregation) via **MediatR**
- **Validation:** **FluentValidation** integrated with custom MediatR `ValidationBehaviour`
- **ORM:** Entity Framework Core
- **API Documentation:** Swagger / OpenAPI

---

## ✨ Features & Functionality

- **Product Catalog Management:**
  - View all available products (`GetProductsQuery`).
  - View detailed product views via GUID routes (`GetProductByIdQuery`).
  - Create new products with strict data validation (`CreateProductCommand`).
  - Delete products cleanly via API (`DeleteProductCommand`).
- **Data Validation Rules:**
  - `Name`: Non-empty, maximum length of 200 characters.
  - `Price`: Must be greater than `0`.
- **UI & Routing:**
  - Dedicated product detail routes (`/product/{id:guid}`).
  - Dynamic loading and responsive views.

---

## 🔌 API Endpoints

| Method | Endpoint | Description | Request Body / Params |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/Products` | Fetch all products | None |
| **GET** | `/api/Products/{id}` | Fetch single product by `Guid` | `id: Guid` |
| **POST** | `/api/Products` | Create a new product | `CreateProductCommand` |
| **DELETE** | `/api/Products/{id}` | Delete product by `Guid` | `id: Guid` |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- An IDE such as **Visual Studio 2022**, **JetBrains Rider**, or **Visual Studio Code**.

### Installation & Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Manalrhranati/EcommerceCleanApi.git
   cd EcommerceCleanApi
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Run the application (Blazor WebAssembly + API):**
   ```bash
   dotnet run --project src/BlazorApp/BlazorApp.csproj
   ```

4. **Access the Application:**
   - **Blazor App:** Navigate to `https://localhost:7000` (or configured local port).
   - **Swagger API Docs:** Navigate to `https://localhost:7000/swagger` to inspect and test API endpoints.

---

## 📝 License

Distributed under the MIT License. See `LICENSE` for more information.
