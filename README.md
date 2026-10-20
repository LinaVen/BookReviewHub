# 📚 Book Review Hub

A full-stack web application developed using ASP.NET Core MVC,
ASP.NET Core Web API, Entity Framework Core, and Microsoft SQL Server.

This project was developed as part of my Computer Science studies
at Atlantic Technological University (ATU), Ireland.

## 🎯 Project Overview

Book Review Hub is a web application designed to allow users
to browse books, submit reviews, and manage book-related information.

The project demonstrates my understanding of full-stack web
development, database integration, and RESTful API communication.

## 🛠️ Technologies Used

- C#
- ASP.NET Core MVC
- ASP.NET Core Web API
- Entity Framework Core
- Microsoft SQL Server
- HTML5
- CSS3
- Bootstrap
- JavaScript
- Visual Studio
- Swagger / OpenAPI

## ✨ Main Features

- Browse book information
- Submit and view book reviews
- Database integration using Entity Framework Core
- RESTful API communication
- Responsive web interface using Bootstrap
- MVC architecture for organising application components

## 🏗️ Project Structure

- Controllers — Handle application requests
- Models — Define application data structures
- Views — Provide the user interface
- Data — Manage database operations
- Migrations — Track database schema changes
- wwwroot — Store CSS, JavaScript, and other static files
- Program.cs — Configure the application

## 🎓 Skills Demonstrated

- Object-Oriented Programming (OOP)
- Full-stack web development
- ASP.NET Core MVC architecture
- RESTful API development
- Database design and management
- Entity Framework Core
- C# programming
- REST API testing and debugging

## 👩‍💻 Developer

**Lina Venckus (Venckuviene)**

Computer Science Graduate  
Atlantic Technological University (ATU), Ireland

Interested in graduate and junior software development
opportunities, particularly in .NET, backend development,
and cloud technologies.

## 📸 Application Screenshot

The screenshot below shows the BookReviewHub application, including book details, submitted reviews, star ratings, and the review submission form.

![BookReviewHub Application Screenshot](bookreviewhub-screenshot.png)

## 🚀 How to Run the Project

### Prerequisites

Before running the application, make sure you have:

- Visual Studio 2022 or later
- .NET SDK compatible with the project
- SQL Server Express LocalDB (installed with Visual Studio)
- SQL Server Management Studio (SSMS) — optional

### Installation

1. Clone or download this GitHub repository.
2. Open the project solution (.sln) in Visual Studio.
3. Restore the NuGet packages.
4. Check the `DefaultConnection` connection string in `appsettings.json`. By default, the application uses SQL Server Express LocalDB and creates a database named `BookReviewHubDB`.
5. Open **Tools → NuGet Package Manager → Package Manager Console** in Visual Studio.

6. Run the following command to apply the existing database migrations:

   ```powershell
   Update-Database
   ```

7. Build the solution.

8. Run the application using Visual Studio.

### Application Features

Once the application is running, you can:

- Browse available books.
- View book details.
- Read existing reviews and ratings.
- Submit new book reviews.

## 🗄️ Sample Database

This project includes a sample SQL Server database with 25 books across five genres, along with sample reviews and star ratings.

📁 [Download the sample database and view setup instructions](database/README.md)

The database is provided as a `.bacpac` file and can be imported using SQL Server Management Studio (SSMS).
