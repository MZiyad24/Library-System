# Library Management System
The Library Management System is designed to facilitate the management of a library's resources by providing a convenient interface for librarians and library users. The system allows admins to handle book catalogs, track lending and returns, and manage customer accounts. Users can explore available books, reserve and borrow books, and manage their profiles.

Installation and Setup
Requirements:
.NET Framework (for C# desktop application)
Microsoft Visual Studio (for C# development)
SQL Server (or any other relational database system)
SQL Server Management Studio (SSMS) (for managing the database)
Steps to Setup:


Database Design
The SQL database for the Library Management System consists of the following tables:

Books Table:

BookID: Primary Key
Title: Title of the book
Author: Author of the book
Category: Category or genre
ISBN: International Standard Book Number
CopiesAvailable: Number of copies available
Users Table:

UserID: Primary Key
FirstName: First name of the user
LastName: Last name of the user
Email: Email address
PhoneNumber: Contact number
Role: Either "admin" or "customer"
Password: Encrypted password for login
Transactions Table:

TransactionID: Primary Key
BookID: Foreign Key to Books Table
UserID: Foreign Key to Users Table
IssueDate: Date when the book was issued
ReturnDate: Date when the book was returned
DueDate: Due date for returning the book
FineAmount: Calculated fine for overdue books
Reservations Table:

ReservationID: Primary Key
BookID: Foreign Key to Books Table
UserID: Foreign Key to Users Table
ReservationDate: Date when the book was reserved
Features
Admin Features:
Book Management: Add, update, and remove books from the library database.
User Management: Manage customer profiles, view borrowing history.
Transactions: Track book borrowing, returns, and reservations.
Fine Calculation: Calculate fines for late returns.
Customer Features:
Book Search: Search books by title, author, or category.
Borrow Books: Borrow available books.
Reserve Books: Reserve books if not available.
Profile Management: Edit personal profile details.
Usage
Admin:
Login: Use the default admin credentials to log in.
Manage Books: Navigate to the book management screen to add, edit, or delete books.
View Transactions: View all book transactions, including current borrowings and overdue books.
Track Fines: Manage and calculate fines for overdue books.
Customer:
Login: Use your credentials to log in as a customer.
Search Books: Search for books by title, author, or genre.
Reserve Books: Reserve unavailable books.
Borrow Books: Borrow books if available and track your borrowing history.
Manage Profile: Update personal information, such as name, email, and phone number.
Screenshots
Login Screen:

Admin Dashboard:

Book Management:

User Profile:

Contributors
Developer 1: Database Design and Backend Logic.
Developer 2: C# GUI Development.
Developer 3: Testing and Documentation.
