# PowerCred Application

PowerCred is a web application developed using **ASP.NET Core MVC** for managing tasks with features like user registration, login, task management, sorting tasks, and pagination.

## Features
- **User Registration & Authentication:** Users can register, log in, and log out of the application.
- **Task Management:** Users can view, sort, and paginate tasks.
- **Sorting Tasks:** Tasks can be sorted by priority and due date.
- **Pagination:** The task list is paginated to improve user experience.

## Technologies Used
- **ASP.NET Core MVC:** Framework for building the application.
- **Entity Framework Core:** ORM for database interactions.
- **Bootstrap:** Front-end framework for responsive design.
- **HTML5, CSS3, JavaScript:** Used for the web interface and client-side interactivity.

## Software Requirements
To run this project locally, you will need the following software installed:

1. **.NET SDK 6.0 or higher**  
   Download and install the .NET SDK from the official website.

2. **Visual Studio 2022 or Visual Studio Code**  
   - Visual Studio
   - Visual Studio Code
   
3. **SQL Server or any compatible relational database**  
   - SQL Server Express or any SQL server instance (optional, based on your setup). You can use the default `ApplicationDbContext` which is configured to use SQL Server.

4. **Node.js** (Optional for client-side dependencies, if required for further customizations).  
   Install Node.js if you're working with frontend dependencies.


## Project Structure

The project follows a standard MVC architecture and contains the following main folders and files:

### 1. **Controllers**
   - Contains the C# controller classes responsible for handling user requests and managing operations like registration, login, task management, etc.

### 2. **Models**
   - Contains data models representing the application’s entities, such as:
     - `User` - Model for user-related data.
     - `LoginViewModel` - ViewModel for handling user login data.
     - `TaskDetails` - Model for managing task-specific data.

### 3. **Views**
   - Contains Razor views for rendering dynamic HTML content, such as:
     - Registration page
     - Login page
     - Task list page
     - Other necessary user interfaces

### 4. **wwwroot**
   - Stores static files such as:
     - **CSS** - Stylesheets for frontend design.
     - **JavaScript** - Frontend functionality.
     - **Images** - Static images like logos and icons.

### 5. **appsettings.json**
   - Configuration file that stores settings like:
     - Database connection string
     - Application settings
     - Other necessary configuration data.

### 6. **Startup.cs**
   - Contains configuration for the application, including:
     - **Services** - Registering dependencies and services.
     - **Middleware** - Configuring middleware like authentication, authorization, and error handling.
     - **Routing** - Configuring the routing for controllers and views.
   
## Installation

1. Clone the repository.
2. Open the project in Visual Studio or your preferred IDE.
3. Run the application locally or configure it for deployment.

## Configuration

1. Update the `appsettings.json` file with your database connection string and any other settings needed.
2. Ensure you have the necessary dependencies installed for running the application.

