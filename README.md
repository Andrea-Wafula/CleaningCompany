City Cleaning Company MVC App

An ASP.NET Core MVC web application for managing employees, departments, and clients for a city-based cleaning company.

📋 Table of Contents

About the Project

Features

Tech Stack

Getting Started

Prerequisites

Installation

Database Setup


Project Structure

Usage

Future Improvements

Contributing

License

Contact



---

📖 About the Project

This web app allows the management of:

Employees and their assigned departments

Departments within the company

Clients and their contact details


It’s designed to streamline scheduling and organization for a cleaning company while demonstrating CRUD operations using ASP.NET Core MVC and Entity Framework Core.


---

✨ Features

Employee management (Create, Read, Update, Delete)

Department management (Create, Read, Update, Delete)

Client management (Create, Read, Update, Delete)

SQLite database integration using Entity Framework Core

Responsive Razor views



---

🛠 Tech Stack

.NET Core / ASP.NET Core MVC

C#

Entity Framework Core

SQLite for database management

Razor Pages for UI rendering

Bootstrap (default styling)



---

🚀 Getting Started

Prerequisites

.NET 6 SDK

Visual Studio 2022/2023 or Visual Studio Code

Git


Installation

1. Clone the repository:

git clone https://github.com/yourusername/CityCleaningCompanyMVC.git
cd CityCleaningCompanyMVC


2. Restore dependencies:

dotnet restore


3. Update the database connection string in appsettings.json if needed:

"ConnectionStrings": {
  "DefaultConnection": "Data Source=cleaningcompany.db"
}



Database Setup

1. Add migrations and create the database:

dotnet ef migrations add InitialCreate
dotnet ef database update


2. Run the application:

dotnet run


3. Navigate to:

https://localhost:{PORT}




---

📁 Project Structure

CityCleaningCompanyMVC/
│
├── Controllers/
│   ├── ClientController.cs
│   ├── DepartmentController.cs
│   └── EmployeeController.cs
│
├── Models/
│   ├── Client.cs
│   ├── Department.cs
│   └── Employee.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Views/
│   ├── Client/
│   ├── Department/
│   ├── Employee/
│   └── Shared/
│
├── wwwroot/
│   ├── css/
│   └── js/
│
├── appsettings.json
├── Program.cs
└── README.md


---

📌 Usage

Manage employees, departments, and clients through the UI.

Add, edit, or delete records as needed.

Easily track which employees belong to which departments.



---

🔧 Future Improvements

Job scheduling functionality for client appointments

Authentication/Authorization for admin vs employee access

Enhanced UI styling with custom CSS/Bootstrap

Improved reporting and dashboard analytics



---

🤝 Contributing

Contributions are welcome!

1. Fork the repository


2. Create your feature branch (git checkout -b feature/YourFeature)


3. Commit your changes (git commit -m 'Add some feature')


4. Push to the branch (git push origin feature/YourFeature)


5. Open a Pull Request




---

📄 License

This project is licensed under the MIT License.


---

📧 Contact

Created by Andrea Ongoma Wafula
GitHub: andreawafula
Email: wafulaandrea@gmail.com


---

Happy Cleaning! 🧹


---

# CleaningCompany
