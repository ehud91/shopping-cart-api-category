# Category Service API

This project is a RESTful API built using **ASP.NET 8** and **MongoDB** for managing categories in a shopping cart application. The API allows you to perform basic CRUD operations on category data (Create, Read). This document will guide you through setting up, running, and using the API.

# ![C# Logo](https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png)


![ASP.NET Badge](https://img.shields.io/badge/ASP.NET-8.0-blue.svg?style=flat-square) ![MongoDB Badge](https://img.shields.io/badge/MongoDB-Database-green?style=flat-square) ![Swagger Badge](https://img.shields.io/badge/Swagger-API%20Docs-brightgreen?style=flat-square)

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Setup](#setup)
- [Configuration](#configuration)
- [Endpoints](#endpoints)
- [Usage](#usage)
- [License](#license)

---

## Features

- **Create** new categories.
- **Retrieve** categories (individual or all).
- Integrated with **MongoDB** for data storage.
- Follows clean architecture principles with separate **Controllers**, **Services**, and **Models**.
- **Dependency Injection** for easy extensibility.
- Follows RESTful conventions for API development.

## Technologies

- **ASP.NET 8**: Backend framework for building scalable web APIs.
- **MongoDB**: NoSQL database for storing categories.
- **C#**: Primary programming language.
- **MongoDB Driver for C#**: To interact with MongoDB.
- **Swagger**: API documentation and testing.

---

## Setup

### Prerequisites

- **.NET SDK 8.0** or later installed. [Download .NET](https://dotnet.microsoft.com/download)
- **MongoDB** running locally or on MongoDB Atlas.
- **Visual Studio 2022** or **VS Code** for development.
- **MongoDB NuGet package / Driver - [MongoDB NuGet](https://www.mongodb.com/blog/post/quick-start-c-sharp-and-mongodb-starting-and-setup) install via Visual Studio 2022 and use it in the code
  ```bash
  using MongoDB.Driver;
  ```
  
### Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-repo/shopping-cart-api.git
   cd shopping-cart-api
