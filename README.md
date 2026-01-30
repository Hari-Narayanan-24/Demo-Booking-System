# 📘 Booking System API — ASP.NET Core + EF Core

## 📌 Project Overview

This project is a **minimal booking system backend API** built using **ASP.NET Core Web API** and **Entity Framework Core**.

The goal of this project was to demonstrate:

* Backend system design fundamentals
* Database integration using ORM
* Migration-based schema management
* Clean REST API structure
* AI-assisted development workflow

This project was built as part of learning and demonstrating hands-on capability in the .NET ecosystem while coming from a Python backend background.

---

## 🧠 Why This Project Was Built

To simulate a real-world booking backend similar to systems used by:

* Sports clubs
* Training centres
* Membership organisations

The system supports:

* Club creation
* Member management
* Session booking
* Booking retrieval per club

---

## 🛠 Tech Stack

### Backend

* ASP.NET Core Web API
* C#

### Database

* Entity Framework Core (ORM)
* SQLite (used for fast local setup and demo simplicity)

### Development Tools

* Swagger (API testing and documentation)
* EF Core Migrations (Database schema management)

---

## 📂 Project Structure

```
Controllers/   → API endpoints  
Models/        → Database entity models  
DTOs/          → Request input models  
Data/          → Database context  
Migrations/    → Database schema history  
Program.cs     → Application startup configuration  
```

---

## 🚀 Features Implemented

### Core Booking Workflow

* Create Clubs
* Create Members
* Create Bookings
* Retrieve Bookings by Club

### Engineering Practices

* DTO-based request validation
* Entity relationship validation
* Migration-based database schema evolution
* Clean API routing structure

---

## 🔗 API Endpoints

### Create Club

```
POST /clubs
```

### Create Member

```
POST /members
```

### Create Booking

```
POST /bookings
```

### Get Bookings By Club

```
GET /clubs/{clubId}/bookings
```

---

## 🧪 Testing

API tested using:

* Swagger UI

### Test Flow

1. Create Club
2. Create Member
3. Create Booking
4. Retrieve Bookings by Club

---

## 🤖 AI-Assisted Development

AI tools were used to:

* Accelerate project scaffolding
* Generate boilerplate code
* Help understand .NET ecosystem concepts
* Debug build and dependency issues

All generated code was manually reviewed, simplified, and tested before integration.

Full development log available in:

```
AI-LOG.md
```

---

## 🧭 Key Learning Outcomes

* ASP.NET Core request pipeline
* Dependency Injection fundamentals
* EF Core ORM workflow
* Database migrations lifecycle
* Cross-stack development (Python → C# transition)

---

## 📈 If This Project Were Extended

Future improvements would include:

* PostgreSQL database integration
* Authentication and authorization
* Multi-tenant access control
* Frontend integration (React or Razor pages)
* Deployment pipeline (Cloud hosting + CI/CD)

---

## ▶️ How To Run Locally

### 1️⃣ Clone Repository

```
git clone <repo-url>
```

### 2️⃣ Restore Packages

```
dotnet restore
```

### 3️⃣ Apply Database Migration

```
dotnet ef database update
```

### 4️⃣ Run API

```
dotnet run --launch-profile http
```

---

## 📬 Developer Note

This project was built to demonstrate strong backend fundamentals, fast learning capability across stacks, and modern AI-assisted development workflows while maintaining engineering correctness and code clarity.