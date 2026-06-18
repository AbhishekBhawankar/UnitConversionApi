# Unit Conversion API

A RESTful ASP.NET Core Web API for converting values between different units of measurement.

## Features

- Length Conversion
  - Meter ↔ Feet
  - Meter ↔ Kilometer
  - Feet ↔ Kilometer

- Temperature Conversion
  - Celsius ↔ Fahrenheit

- Weight Conversion
  - Kilogram ↔ Pound

- Swagger Documentation
- Dependency Injection
- Exception Handling Middleware
- Clean and Extensible Architecture
- Unit Test Support

## Technology Stack

- .NET 8
- ASP.NET Core Web API
- Swagger / OpenAPI
- xUnit (for unit testing)

## Project Structure

```text
UnitConversionApi
│
├── Controllers
├── Services
├── Converters
├── Models
├── Middleware
└── Program.cs
```

## API Endpoint

### Convert Units

```http
POST /api/conversion/convert
```

### Request

```json
{
  "category": "Length",
  "fromUnit": "Meter",
  "toUnit": "Feet",
  "value": 10
}
```

### Response

```json
{
  "originalValue": 10,
  "fromUnit": "Meter",
  "toUnit": "Feet",
  "convertedValue": 32.8084
}
```

## Supported Categories

### Length

- Meter
- Feet
- Kilometer

### Temperature

- Celsius
- Fahrenheit

### Weight

- Kilogram
- Pound

## Running the Application

### Clone Repository

```bash
git clone <repository-url>
```

### Navigate to Project

```bash
cd UnitConversionApi
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Application

```bash
dotnet run
```

The API will start locally.

## Swagger UI

After running the application, open:

```text
https://localhost:xxxx/swagger
```

Replace `xxxx` with the port displayed in the console.

## Design Decisions

- Implemented the Strategy Pattern using the `IConverter` interface.
- Each conversion category has its own converter implementation.
- Dependency Injection is used for loose coupling and maintainability.
- Exception Middleware provides centralized error handling.
- The solution is designed to be easily extended with additional conversion categories and units in the future.

## Future Improvements

- Store units and conversion factors in a database.
- Add FluentValidation for request validation.
- Add authentication and authorization.
- Add support for more conversion categories.
- Add caching and monitoring.

## Author

Abhishek Bhawankar