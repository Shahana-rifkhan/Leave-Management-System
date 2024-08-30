# Leave-Management-System
The Leave Management System is a desktop application designed to manage employee leave requests and approvals within an organization. The Leave Management System is a desktop application designed to manage employee leave requests and approvals within an organization. The system has two distinct user roles: **Employee** and **Admin**, each with its own application interface. The system uses a centralized database to store and manage data, which can be set up as a local database for development purposes using Visual Studio IDE with C#.NET.

## Features

### Employee Application
- **Login:** Employees can log in using their employee number and password.
- **Apply for Leave:** Employees can apply for different types of leaves:
  - **Annual Leaves:** 14 days per year, must be applied 7 days in advance.
  - **Casual Leaves:** 7 days per year, can be applied for before the start of the defined roster.
  - **Short Leaves:** 2 per month, each with a duration of 1 hour and 30 minutes, applicable for upcoming time slots.
- **Leave Status:** Employees can view the status of their applied leaves (approved or not).
- **Delete Leaves:** Employees have the option to delete their applied leaves.
- **Leave History:** Employees can view their remaining leaves and the history of all applied leaves.

### Admin Application
- **Login:** Admins can securely log in to the system.
- **Employee Management:** Admins can register new employees and define the number of leaves each employee is entitled to based on their employment status.
- **Roster Management:** Admins can set the start and end times for employee rosters.
- **Leave Approval:** Admins can approve or reject leave requests submitted by employees.
- **Leave Reports:** Admins can generate and view leave reports for:
  - Individual employee leave history within a specified date range.
  - All employees' leave history within a specified date range.

## Installation 

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

- **Visual Studio 2019 or later** (with .NET desktop development workload)
- **SQL Server Express** or any version of SQL Server
- **.NET Framework 4.x**

### Steps

1. **Clone the Repository**:
  - First, clone the project repository to your local machine:

    ```bash
    git clone git@github.com:YourUsername/Leave-Management-System.git

2. **Open the Solution in Visual Studio**:
  - Open Visual Studio.
  - Go to `File -> Open -> Project/Solution`.
  - Navigate to the cloned repository folder and select       `EmployeeLeaveManagementSystemCSharp.sln`.

3. **Restore NuGet Packages**
Once the solution is open, restore the NuGet packages:

  - Right-click on the solution in the Solution Explorer.
  - Select `Restore NuGet Packages`.

4. **Configure the Database**:

  - Use the Included Database Files: The project includes a local database (leave.mdf and leave_log.ldf):
  - Attach these files to your SQL Server instance using SQL Server Management Studio (SSMS).
  - Update the connection string in the `App.config` file to point to your local SQL Server instance.

5. **Build the Solution**:

  - In Visual Studio, go to `Build -> Build Solution` or press `Ctrl + Shift + B`.

6. **Run the Application**:

  - Set the desired project (Employee or Admin) as the startup project:
    - Right-click the project in the `Solution Explorer`.
    - Select `Set as Startup Project`.
  - Press `F5` to start debugging and run the application.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
```bash
This README provides a comprehensive guide to installing and running your Leave Management System. You can adapt it to your specific project needs.
