# User Management API

A simple ASP.NET Core Web API for managing users, built using GitHub Codespaces and enhanced with Microsoft Copilot.

---

## 🚀 Features

- CRUD operations (Create, Read, Update, Delete)
- Input validation (Name, Email, Role)
- Authentication middleware (token-based)
- Logging middleware (request & response logging)
- Global error handling middleware
- Swagger UI for testing
- HTTP request testing via requests.http

---

## 🛠 Tech Stack

- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
- GitHub Codespaces
- REST Client

---

## 📂 Project Structure

UserManagementAPI/

├── Controllers/  
├── Models/  
├── Middleware/  
├── Program.cs  
├── requests.http  
├── README.md  
└── REPORT.md  

---

## ▶️ How to Run

Run the application using:

dotnet run

Then open Swagger in your browser:

https://\<your-codespace-url\>/swagger

---

## 🔐 Authentication

All API endpoints require the following header:

Authorization: my-secret-token

---

## 📌 API Endpoints

GET /api/users → Get all users  
GET /api/users/{id} → Get user by ID  
POST /api/users → Create user  
PUT /api/users/{id} → Update user  
DELETE /api/users/{id} → Delete user  

---

## 🧪 Testing

Example request using REST Client:

GET {{baseUrl}}/api/users  
Authorization: my-secret-token  

### Test Scenarios

✅ Valid input → Success (200/201)  
❌ Invalid input → 400 Bad Request  
❌ Missing user → 404 Not Found  
❌ Missing token → 401 Unauthorized  

---

## 📊 Example Response

{
  "id": 1,
  "name": "John Doe",
  "email": "john@example.com",
  "role": "Admin"
}

---

## 🤖 Copilot Contribution

Microsoft Copilot helped with:

- Generating CRUD endpoints
- Adding validation logic
- Creating middleware components
- Improving error handling
- Speeding up development

---

## ✅ Project Status

✔ Completed  
✔ Fully tested  
✔ Ready for submission  