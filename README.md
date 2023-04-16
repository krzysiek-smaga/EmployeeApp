# EmployeeApp
Employee Application - ASP.NET Web Api + SPA Angular UI

# Getting Started
## Requirements
- Sql Server instance
- Node version 18.15.0
- Angular CLI version 15.2.5
## Clone Repository
Clone the Repository by running the command
```
git clone https://github.com/krzysiek-smaga/EmployeeApp.git
```
# Build and Run
## Backend
### Step 1 - Open solution from Visual Studio
Open solution file `./EmployeeApp.API/EmployeeApp.API.sln` from Visual Studio
### Step 2 - Clean solution
To clean sulution go to
```
Build -> Clean Solution
```
### Step 3 - Create Database
Open `Package manager console` and run command
```
dotnet ef database update
```
### Step 4 - Run solution
Run solution from Visual Studio locally. The Swagger page opens up showing the current available API.
You can test endpoints here or proceed with next steps to run UI application

## Frontend
### Step 1 - Install packages
Open PowerShell in root folder of UI application `./EmployeeApp.UI/` and run command
```
npm install
```
### Step 2 - Run UI application
Start UI application by running the command
```
ng serve --open
```
An Application page opens up and Employee App is ready to use

# Notes
Employees prepared as dummy data have positions names instead of full names to better show hierarchy while filtering data. I was considering to introduce additional property to show position of employees, but I wanted the app to comply with the requirements without additional features