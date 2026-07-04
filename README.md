# eCommerceSolution.ProductsService

A RESTful product catalog and inventory management microservice built with **ASP.NET Core (C#)**. It utilizes **PostgreSQL** and **Entity Framework Core** to securely and efficiently handle product data, schemas, and lifecycle management.

## 🛠️ Tech Stack & Infrastructure

* **Framework:** .NET Core API
* **Database & ORM:** PostgreSQL accessed via Entity Framework Core (`DbContext`)
* **Containerization:** Docker (configured via the included `Dockerfile`)
* **Migrations:** Code-first database schema management using EF Core Migrations.

## 🏗️ Architecture Role & Data Flow

This service acts as the central source of truth for all product-related data within the eCommerce platform. 

* **Structured Storage:** PostgreSQL was selected to provide robust relational integrity for product details, pricing, and catalog categorizations.
* **Separation of Concerns:** The architecture adheres to a clean, N-tier structure. Incoming requests hit the `Controllers`, business logic is handled in `Services` (defined by `ServiceContracts`), and data access is strictly abstracted to `Repositories` (defined by `RepositoryContracts`).
* **Error Handling:** Centralized exception handling is implemented via custom middleware in the `Middlewares` folder to ensure consistent API responses.

## 📂 System Architecture Overview

This repository is part of a larger, decentralized eCommerce microservice ecosystem:

1. **[eCommerceSolution.ProductsService](https://github.com/sonai21/eCommerceSolution.ProductsService)** (PostgreSQL) - *You are here*
2. [eCommerceSolution.UsersService](https://github.com/sonai21/eCommerceSolution.UsersService) (Users Microservice)
3. [eCommerceSolution.OrdersService](https://github.com/sonai21/eCommerceSolution.OrdersService) (Orders Microservice)

## 🚀 How to Run

### Local Development
1.  Clone the repository and navigate to the project directory:
    ```bash
    git clone [https://github.com/sonai21/eCommerceSolution.ProductsService.git](https://github.com/sonai21/eCommerceSolution.ProductsService.git)
    cd eCommerceSolution.ProductsService
    ```
2.  Restore dependencies: 
    ```bash
    dotnet restore
    ```
3.  Update your PostgreSQL connection string in `appsettings.json` or `appsettings.Development.json`.
4.  Apply pending database migrations:
    ```bash
    dotnet ef database update
    ```
5.  Run the application: 
    ```bash
    dotnet run
    ```

### Docker (Containerized)
To run this service in an isolated container:
```bash
docker build -t ecommercesolution-productsservice .
docker run -d -p 8080:80 ecommercesolution-productsservice
