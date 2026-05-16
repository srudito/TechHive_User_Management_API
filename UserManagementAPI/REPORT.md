# User Management API Project Report

## 1. Introduction

This project involved developing a User Management API for TechHive Solutions. The goal was to implement CRUD operations while using Microsoft Copilot to assist with development, debugging, and optimization.

---

## 2. Project Setup

The API was built using ASP.NET Core Web API in GitHub Codespaces. Swagger was configured for API testing.

Microsoft Copilot assisted in generating boilerplate code and configuring services.

---

## 3. API Implementation

The API supports the following operations:

GET /api/users → Retrieve all users  
GET /api/users/{id} → Retrieve user by ID  
POST /api/users → Create user  
PUT /api/users/{id} → Update user  
DELETE /api/users/{id} → Delete user  

The User model includes the following fields:

- Id  
- Name  
- Email  
- Role  

---

## 4. Debugging and Improvements

### Issues Identified

- Missing validation for user input  
- Errors when retrieving non-existent users  
- Unhandled exceptions causing API crashes  

### Fixes Implemented

- Added validation for:
  - Required fields (Name, Role)
  - Email format validation
- Implemented try-catch blocks in all endpoints
- Improved error handling responses:
  - 400 Bad Request
  - 404 Not Found
  - 500 Internal Server Error  

---

## 5. Middleware Implementation

### Logging Middleware

Logs the HTTP method, request path, and response status code for each request.

### Error Handling Middleware

Catches unhandled exceptions and returns a consistent JSON response:

{ "error": "Internal server error." }

### Authentication Middleware

- Validates the token in request headers  
- Requires:

Authorization: my-secret-token  

- Returns 401 Unauthorized if the token is missing or invalid  

---

## 6. Middleware Pipeline Configuration

Middleware is configured in the following order:

1. Error Handling Middleware  
2. Authentication Middleware  
3. Logging Middleware  

This ensures proper handling, security, and logging of all requests.

---

## 7. Testing Results

Testing was performed using Swagger and a requests.http file.

### Successful Scenarios

POST → 201 Created  
GET → 200 OK  
PUT → 204 No Content  
DELETE → 204 No Content  

### Edge Case Testing

Invalid input → 400 Bad Request  
Non-existent user → 404 Not Found  
Missing or invalid token → 401 Unauthorized  

---

## 8. Role of Microsoft Copilot

Microsoft Copilot helped with:

- Generating CRUD controller code  
- Suggesting validation logic  
- Assisting in middleware creation  
- Improving debugging efficiency  
- Recommending best practices  

---

## 9. Conclusion

The final API is fully functional and includes:

- CRUD operations  
- Input validation  
- Authentication middleware  
- Logging middleware  
- Error handling middleware  

This project demonstrates strong backend development practices and effective use of AI-assisted tools.