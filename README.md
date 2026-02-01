# 🏨 Hotel Management System

## 📌 Description
Hotel Management System is a **desktop application** built using **C# WinForms** and **SQL Server**.  
The system is designed to manage hotel operations including **clients, rooms, reservations, and users** in a simple and organized way.

This project is intended for learning and portfolio purposes.

---

## ⚙️ Technologies Used
- C#
- WinForms
- SQL Server
- ADO.NET
- .NET Framework

---

## 🧩 System Modules & Features

### 👤 Client Management
- Add, update, delete, and search clients
- Store client personal information (name, phone, email, address)
- Prevent duplicate clients

---

### 🏠 Rooms Management
- Add, update, and delete rooms
- Manage room basic information (room number, type)
- Room status (Free / Not Free)

---

### 📅 Reservation Management
- Create and manage reservations
- Assign rooms to reservations
- Set check-in and check-out dates
- Prevent double booking

---

### 👥 User Management
- Add system users
- Track actions performed by users

---

## 🛠 Database Setup
1. Open **SQL Server Management Studio**
2. Create a new empty database (e.g. `HotelDB`)
3. Run the database schema script:

> ⚠️ The script contains **schema only** (no real data).

---

## ▶️ How to Run the Project
1. Clone the repository
2. Open the solution file:
3. Update the connection string in `App.config`
4. Run the project using Visual Studio

---

## 🔒 Security Notes
- Sensitive files are excluded using `.gitignore`
- No passwords or real client data are included
- Local configuration files are not tracked on GitHub