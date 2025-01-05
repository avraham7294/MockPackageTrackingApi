# Mock Package Tracking API

## Overview
The **Mock Package Tracking API** is a simple web application designed to simulate package tracking services. It is built using .NET Core and provides endpoints to interact with mock package tracking data.

## Features
- RESTful API for package tracking.
- Mock data seeding for quick setup.
- Swagger integration for API exploration and testing.
- Uses Entity Framework Core for database interactions.

## Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Installation
1. **Clone the repository**:
   ```bash
   git clone https://github.com/avraham7294/mock-package-tracking-api.git
   cd mock-package-tracking-api
   ```

2. **Set up the database connection**:
   Update the `DefaultConnection` string in `appsettings.json` with your SQL Server instance details:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server_name;Database=MockPackageTracking;Trusted_Connection=True;"
   }
   ```

3. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

4. **Apply migrations and seed data**:
   If necessary, you can use EF Core tools to apply migrations:
   ```bash
   dotnet ef database update
   ```

5. **Run the application**:
   ```bash
   dotnet run
   ```
   The application will run on `http://localhost:5296` (HTTP) and `https://localhost:7289` (HTTPS).

## API Endpoints
### Base URL:
- HTTP: `http://localhost:5296`
- HTTPS: `https://localhost:7289`

### Endpoints
| Method | Endpoint                  | Description            |
|--------|---------------------------|------------------------|
| GET    | /api/packagetrackings     | Get all packages       |
| GET    | /api/packagetrackings/{id}| Get a package by ID    |

## Project Structure
```
├── Controllers
│   └── PackageTrackingController.cs  # API Controller
├── Data
│   ├── DbInitializer.cs              # Seeds mock data
│   └── MockPackageTrackingContext.cs # EF Core DbContext
├── Models
│   └── PackageTracking.cs            # Data model
├── Program.cs                        # Application entry point
├── appsettings.json                  # Configuration file
├── launchSettings.json               # Debugging configurations
```

## Development
- **Database Initialization**: The `DbInitializer` class ensures the database is created and seeded with mock data.
- **Swagger**: Explore and test the API at `https://localhost:7289/swagger` when running the app in development mode.

## Contributing
1. Fork the repository.
2. Create a new branch for your feature or bugfix:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Description of changes"
   ```
4. Push your branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request on GitHub.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For questions or suggestions, feel free to reach out to [avraham7294@gmail.com](mailto:avraham7294@gmail.com).

