♻️ EcoRecicla – Integrated Solid Waste Management System (C# / .NET)
Project Overview

This repository contains the development of the first milestone of the EcoRecicla project, implemented using C# and .NET (Windows Forms Application) and focused on the design and implementation of a SQL Server database for a comprehensive solid waste management system.
Developed for the course Fundamentals of Information Systems – UPC.

💻 Technology Stack
🟦 C# (.NET Framework / .NET 6+)
Primary programming language
Used to build the Windows Forms UI
Implements validation logic, CRUD operations, and system workflows
Connects to SQL Server through ADO.NET
🪟 Windows Forms (WinForms)

Graphical user interface for managing:

Users
Clients
Orders
Drivers
Vehicles
Assignments
Reports
🗄️ SQL Server
12-table relational schema
Stored procedures & optimized views
Audit logging
High referential integrity and constraints
📘 Summary

EcoRecicla is a solid waste management company based in Lima, Peru.
This system built with C#/.NET + SQL Server digitizes and automates:

Driver registration
Real-time waste collection tracking
Waste classification records
Automatic report generation

The architecture ensures traceability, high performance, and data integrity.

🎯 Project Objectives
Build a C#/.NET WinForms application for operational workflow automation
Design a secure, normalized SQL Server database
Ensure reliable CRUD operations using ADO.NET
Develop an intuitive interface aligned with real business processes
Provide a scalable foundation for future modules (APIs, dashboards, GPS integration)
🏢 About EcoRecicla

EcoRecicla provides:

Home & industrial waste collection
Sorting and classification
Documentation and reporting

The .NET system replaces manual processes with a centralized digital workflow.

🔧 Main Features (C# / .NET System)
🔐 Authentication Module
Secure login (WinForms)
Password hashing
SQL login audit log
Role-based access control
👥 Client Management
Full CRUD using ADO.NET
DataGridView display & filtering
Field validation implemented in C#
📦 Orders Module
Register, update, delete pickup orders
Status tracking (Pending, Scheduled, Completed)
Required-fields validation
🚚 Drivers & Vehicles
Registration and management
ComboBox selections (license type, vehicle type)
Search and filtering functions
📌 Assignments Module
Link driver + vehicle + order
Shift (turn) scheduling
Duplicate assignment prevention
📊 Reports Module
SQL Server views integrated with C#
Ready for export
📌 Functional Requirements (FR)

The system defines 40+ functional requirements, including:

User authentication
Client management
Order processing
Driver & vehicle management
Resource assignment
Report generation

All aligned with C#/.NET implementation.

⚙️ Non-Functional Requirements (NFR)

Includes requirements for:

Password encryption
Form loading < 3 seconds
Windows 10+ and .NET compatibility
Horizontal scalability
Fail-safe behavior
SQL audit logging
🗂️ Class & Database Diagram

Full Entity-Relationship model:
🔗 https://dbdiagram.io/d/6836e9c74dd3153d3d2027eb

Includes:

Clients
Users
Roles
Orders
Drivers
Vehicles
Assignments
Audit logs
And more
🗄️ Database Model (12 Tables)

Optimized for C#/.NET integration using:

Primary & foreign keys
Identity (auto-increment) fields
BIT flags
DECIMAL precision fields
NVARCHAR columns
Audit fields
Stored procedures & SQL views
🧪 System Architecture (C# + SQL Server)
C# WinForms UI
       │
ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
       │
SQL Server (Tables, Views, Stored Procedures)

Provides:

Secure parameterized queries
Clean separation between layers
High performance
Easy maintainability
🏁 Conclusions
The C#/.NET system digitizes and optimizes EcoRecicla’s operations.
SQL Server ensures data integrity, auditing, and scalability.
WinForms provides a simple and effective user interface.
Manual errors are reduced significantly through automation.
Architecture is ready for future expansion (APIs, cloud services).
✔️ Recommendations
Provide training to all system users
Implement SQL backup policies
Monitor performance and optimize queries
Integrate GPS, municipal APIs, SUNAT, etc.
Apply periodic software maintenance
📚 Glossary

Key concepts included:

Assignment
Pickup Order
Data Integrity
Stored Procedure
Traceability
SQL Server
C# WinForms
ADO.NET
