# My MVC App

This is a simple web application built using the ASP.NET Core MVC framework. The application provides user authentication functionality, allowing users to register and log in.

## Project Structure

- **Controllers**: Contains the controllers that handle user requests.
  - `AccountController.cs`: Manages user authentication (login and registration).
  - `HomeController.cs`: Manages the home page of the application.

- **Models**: Contains the data models used in the application.
  - `AccountViewModel.cs`: Represents the data for user login and registration.
  - `ApplicationUser.cs`: Represents the user entity, extending IdentityUser.

- **Views**: Contains the Razor views for the application.
  - **Account**: Contains views related to user account management.
    - `Login.cshtml`: The login page.
    - `Register.cshtml`: The registration page.
  - **Home**: Contains views related to the home page.
    - `Index.cshtml`: The main landing page.
  - **Shared**: Contains shared views and layout.
    - `_Layout.cshtml`: The layout for the application.
    - `_LoginPartial.cshtml`: A partial view for displaying login information.

- **wwwroot**: Contains static files such as CSS and JavaScript.
  - `css`: Directory for CSS files.
  - `js`: Directory for JavaScript files.

- **Configuration Files**:
  - `appsettings.json`: Configuration settings for the application.
  - `Program.cs`: Entry point of the application.
  - `Startup.cs`: Configures services and the request pipeline.

## Features

- User registration and login functionality.
- Home page as the landing page of the application.
- Responsive design with CSS for styling.
- Modular structure following the MVC pattern.

## Getting Started

1. Clone the repository.
2. Navigate to the project directory.
3. Run the application using the command:
   ```
   dotnet run
   ```
4. Open your browser and go to `http://localhost:5000` to view the application.

## Contributing

Feel free to submit issues or pull requests for improvements or bug fixes.