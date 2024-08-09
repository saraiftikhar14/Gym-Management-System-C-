# Gym Management System (C#)

## Introduction
The Gym Management System is designed to streamline and enhance the operations of a gym by providing a comprehensive solution for managing members, staff, and equipment. Developed using C# with a Graphical User Interface (GUI), this project aims to offer an intuitive and efficient platform for gym administration.

## Login Page
When you run the Gym Management System, the first screen you will see is the Login Page. This page ensures only authorized users can access the system.

### Features
- **Username**: Admin
- **Password**: 12345

### Login Process
1. **Enter Credentials**: Default Username: Admin, Password: 12345.
2. **Click Login**: Credentials are verified.
3. **Access Granted**: Correct credentials lead to the Dashboard.
4. **Access Denied**: Incorrect credentials show an error message.

## Dashboard
After logging in, you will be directed to the Dashboard, which provides an overview of gym operations and statistics.

## New Member Page
From the Dashboard, navigate to the New Member Page:
- **Enter Member Data**: User fills in the new member's information.
- **Save Data**: When the data is saved, it is stored in the SQL Server database.

## New Staff Page
From the Dashboard, click on the New Staff Page:
- **Enter Staff Data**: User fills in the new staff member's information.
- **Reset Data**: If data needs to be changed, click reset and re-enter the information.
- **Save Data**: When the data is saved, it is stored in the SQL Server database.

## Equipment Page
From the Dashboard, navigate to the Equipment Page:
- **Enter Equipment Data**: User fills in the equipment information.
- **Save Data**: When the data is saved, it is stored in the SQL Server database.
- **Reset Data**: If data needs to be changed, click reset and re-enter the information.
- **View Equipment**: View the entered equipment data.

## Search Member
From the Dashboard, use the Search Member feature:
- **Enter Member ID**: User inputs the member's ID to search for their details.
- **View Details**: If the ID is entered correctly, the member's details are displayed.
- **Error Handling**: If no ID is entered or the ID is incorrect, an error message is displayed.

## Delete Member
From the Dashboard, navigate to the Delete Member Page:
- **Enter Member ID**: User inputs the ID of the member to be deleted.
- **Click Delete**: The member with the entered ID is deleted from the system.

## Logout
To log out of the system:
- **Click Logout**: User logs out of the system.
- **Re-login**: User can log in again by entering their credentials on the Login Page.

## Technologies Used
- **C#**: The primary programming language used for development.
- **SQL Server**: For database management.



