# 🧱 Clean Architecture .NET 8 Web API

A clean and modular **.NET 8 Web API** example using **Clean Architecture principles** — designed for simplicity, testability, and maintainability.  
This project separates concerns across layers, uses **DTOs** for incoming data, **DAOs** for read operations, and avoids CQRS for simplicity.

---

## 🚀 Features

- ✅ .NET 8 Web API  
- ✅ Clean Architecture layering  
- ✅ DTOs for create/update requests  
- ✅ DAOs for read operations  
- ✅ Repository pattern for database access  
- ✅ EF Core for persistence  
- ✅ Swagger (enabled only in Development)  
- ✅ No `DependencyInjection.cs` files — registration is done in `Program.cs`

---

## 🧩 Architecture Overview

src/
├── CleanArch.Domain/
│   └── Entities/
│       └── Product.cs
│
├── CleanArch.Application/
│   ├── DTOs/
│   │   ├── ProductCreateDto.cs
│   │   └── ProductUpdateDto.cs
│   ├── Interfaces/
│   │   ├── IProductService.cs
│   │   └── IProductRepository.cs
│   └── Services/
│       └── ProductService.cs
│
├── CleanArch.Infrastructure/
│   ├── Persistence/
│   │   └── ApplicationDbContext.cs
│   ├── DAOs/
│   │   └── ProductDao.cs
│   └── Repositories/
│       └── ProductRepository.cs
│
└── CleanArch.WebAPI/
    ├── Controllers/
    │   └── ProductsController.cs
    ├── wwwroot/
    └── Program.cs
