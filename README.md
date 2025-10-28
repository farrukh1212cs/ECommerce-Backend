# E-Commerce API

A modern, scalable E-Commerce RESTful API built with .NET 8.0 following Clean Architecture principles.

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the Application](#running-the-application)
- [API Documentation](#api-documentation)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## 🎯 Overview

This E-Commerce API provides a robust backend solution for managing products, customers, orders, and order items. Built with industry best practices, it implements Clean Architecture to ensure maintainability, testability, and scalability.

## ✨ Features

- **Product Management**: Create, read, update, and delete products with stock tracking
- **Customer Management**: Handle customer information and profiles
- **Order Processing**: Complete order lifecycle management with status tracking
- **Order Items**: Detailed line-item management for orders
- **Business Logic**: Built-in domain logic for stock reduction and order calculations
- **API Documentation**: Interactive Swagger/OpenAPI documentation
- **Dependency Injection**: Leverages .NET's built-in DI container
- **Repository Pattern**: Clean separation of data access logic
- **Service Layer**: Business logic encapsulation

## 🏗️ Architecture

This project follows **Clean Architecture** principles with clear separation of concerns:

```
ECommerce/
├── ECommerce.Domain/          # Enterprise business rules
│   ├── Entities/              # Domain entities (Product, Order, Customer, OrderItem)
│   ├── Enums/                 # Domain enumerations (OrderStatus)
│   └── Repositories/          # Repository interfaces
│
├── ECommerce.Application/     # Application business rules
│   ├── DTOs/                  # Data Transfer Objects
│   └── Services/              # Business logic services
│       ├── Interfaces/        # Service contracts
│       └── Implementations/   # Service implementations
│
├── ECommerce.Infrastructure/  # External concerns
│   ├── Data/                  # Database context
│   └── Repositories/          # Repository implementations
│
└── ECommerce.API/            # Presentation layer
    ├── Controllers/          # API endpoints
    └── Program.cs            # Application entry point
```

### Architecture Layers

1. **Domain Layer**: Contains core business entities, enums, and repository interfaces. No dependencies on other layers.
2. **Application Layer**: Contains business logic, DTOs, and service interfaces. Depends only on Domain layer.
3. **Infrastructure Layer**: Handles data persistence and external dependencies. Implements repository interfaces.
4. **API Layer**: Presentation layer exposing RESTful endpoints. Depends on Application and Infrastructure layers.

## 🛠️ Technologies

- **.NET 8.0**: Latest .NET framework
- **ASP.NET Core**: Web API framework
- **Swagger/OpenAPI**: API documentation and testing
- **Dependency Injection**: Built-in DI container
- **Entity Framework Core**: (Ready for integration)
- **C# 12**: Latest language features

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Visual Studio 2022, VS Code, or Rider
- Git

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/ecommerce.git
   cd ecommerce
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

### Running the Application

1. **Run the API**
   ```bash
   cd ECommerce.API
   dotnet run
   ```

2. **Access Swagger UI**
   
   Open your browser and navigate to:
   - HTTPS: `https://localhost:5001/swagger`
   - HTTP: `http://localhost:5000/swagger`

## 📚 API Documentation

Once the application is running, access the interactive API documentation at `/swagger`.

### Available Endpoints

#### Products
- `GET /api/products` - Get all products
- `GET /api/products/{id}` - Get product by ID
- `POST /api/products` - Create new product
- `PUT /api/products/{id}` - Update product
- `DELETE /api/products/{id}` - Delete product

#### Customers
- `GET /api/customers` - Get all customers
- `GET /api/customers/{id}` - Get customer by ID
- `POST /api/customers` - Create new customer
- `PUT /api/customers/{id}` - Update customer
- `DELETE /api/customers/{id}` - Delete customer

#### Orders
- `GET /api/orders` - Get all orders
- `GET /api/orders/{id}` - Get order by ID
- `POST /api/orders` - Create new order
- `PUT /api/orders/{id}` - Update order
- `DELETE /api/orders/{id}` - Delete order

#### Order Items
- `GET /api/orderitems` - Get all order items
- `GET /api/orderitems/{id}` - Get order item by ID
- `POST /api/orderitems` - Create new order item
- `PUT /api/orderitems/{id}` - Update order item
- `DELETE /api/orderitems/{id}` - Delete order item

## 📁 Project Structure

```
ECommerce/
├── ECommerce.sln                          # Solution file
├── ECommerce.API/                         # Web API project
│   ├── Controllers/                       # API controllers
│   │   ├── ProductsController.cs
│   │   ├── CustomersController.cs
│   │   ├── OrdersController.cs
│   │   └── OrderItemsController.cs
│   ├── Program.cs                         # Application startup
│   ├── appsettings.json                   # Configuration
│   └── ECommerce.API.csproj
├── ECommerce.Application/                 # Application layer
│   ├── DTOs/                              # Data Transfer Objects
│   │   ├── ProductDto.cs
│   │   ├── CustomerDto.cs
│   │   ├── OrderDto.cs
│   │   └── OrderItemDto.cs
│   ├── Services/
│   │   ├── Interfaces/                    # Service contracts
│   │   └── Implementations/               # Service implementations
│   └── ECommerce.Application.csproj
├── ECommerce.Domain/                      # Domain layer
│   ├── Entities/                          # Domain entities
│   │   ├── Product.cs
│   │   ├── Customer.cs
│   │   ├── Order.cs
│   │   └── OrderItem.cs
│   ├── Enums/
│   │   └── OrderStatus.cs
│   ├── Repositories/                      # Repository interfaces
│   └── ECommerce.Domain.csproj
└── ECommerce.Infrastructure/              # Infrastructure layer
    ├── Data/
    │   └── AppDbContext.cs               # Database context
    ├── Repositories/                      # Repository implementations
    │   ├── ProductRepository.cs
    │   ├── CustomerRepository.cs
    │   ├── OrderRepository.cs
    │   └── OrderItemRepository.cs
    └── ECommerce.Infrastructure.csproj
```

## 🔧 Configuration

Configuration settings can be modified in `ECommerce.API/appsettings.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## 🧪 Testing

(To be implemented)

```bash
dotnet test
```

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Coding Standards

- Follow C# naming conventions
- Write clean, readable code
- Add XML documentation for public APIs
- Follow SOLID principles
- Write unit tests for new features

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Authors

- Your Name - Initial work

## 🙏 Acknowledgments

- Built with Clean Architecture principles
- Inspired by best practices in .NET development
- Thanks to the .NET community

## 📞 Contact

For questions or support, please open an issue in the GitHub repository.

---

**Happy Coding!** 🚀

