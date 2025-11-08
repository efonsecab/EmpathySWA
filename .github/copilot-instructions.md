# GitHub Copilot Instructions for EmpathySWA

## Project Overview

This is an **Empathy Assessment Application** built with Blazor WebAssembly and Azure Functions. The application helps users assess and develop empathy through structured questionnaires, daily practices, and self-reflection exercises. Content is primarily in Spanish.

## Technology Stack

- **Frontend**: Blazor WebAssembly (.NET 8)
- **Backend**: Azure Functions (.NET 8, Isolated Worker Model)
- **Shared Library**: .NET Standard 2.0
- **Hosting**: Azure Static Web Apps

## Project Structure

```
├── Client/          # Blazor WebAssembly application
├── Api/            # Azure Functions backend (HTTP triggers)
├── Shared/         # Shared models and data structures
└── .github/        # GitHub workflows and CI/CD
```

## Development Guidelines

### Building and Testing

1. **Build the entire solution:**
   ```bash
   dotnet build
   ```

2. **Run locally with Azure Static Web Apps CLI:**
   - Start the Blazor client: `cd Client && dotnet run`
   - Start the Functions API: `cd Api && func start`
   - Start the SWA proxy: `swa start http://localhost:5000 --api-location http://localhost:7071`
   - Access at `http://localhost:4280`

3. **No automated tests**: This project currently does not have a test suite. Manual testing is required.

### Code Style and Conventions

- **Namespace conventions:**
  - Client: `BlazorApp.Client`
  - API: `Api`
  - Shared: `BlazorApp.Shared` and `BlazorApp.Shared.EmpathyAssessment`

- **C# coding style:**
  - Use explicit initialization in constructors for non-nullable properties
  - Follow standard C# naming conventions (PascalCase for public members, camelCase for private fields)
  - Enable nullable reference types (`<Nullable>enable</Nullable>`)
  - Use implicit usings where enabled
  - TODOS LOS MODELOS Y CLASES, ASÍ COMO TODAS LAS PROPIEDADES Y MÉTODOS PÚBLICOS, DEBEN INCLUIR COMENTARIOS XML. Cada clase/modelo debe tener un `<summary>` que describa claramente su propósito (en español si es visible para el dominio). Cada método público debe incluir: `<summary>`, una etiqueta `<param>` por cada parámetro, `<returns>` cuando no sea `void`, y una etiqueta `<exception cref="TipoDeExcepcion">` por cada excepción que pueda lanzar de forma razonablemente previsible (por ejemplo validaciones, acceso a datos, argumentos nulos, etc.). Mantener la descripción consistente con el dominio de la empatía. Si el contenido es de cara al usuario final, la documentación debe estar en español.

- **Razor components:**
  - Component code should be in `@code` blocks
  - Use proper `@page` directives for routing
  - Include meaningful component descriptions in Spanish where content is in Spanish

### Domain-Specific Guidelines

- **Empathy Assessment Categories**: Defined in `Shared/EmpathyAssessment/`
  - Each category has questions, explanations, examples, and daily practices
  - Questions include emotional impact, concrete examples, and self-impact descriptions

- **Content Language**: Most user-facing content is in Spanish. Maintain consistency with existing Spanish terminology and phrasing.

- **Assessment Structure**:
  - Categories: Groups of related empathy dimensions
  - Questions: Specific behaviors or attitudes to assess
  - Daily Practices: Actionable, offline activities (no devices, money, or special conditions required)

### Azure Functions Best Practices

- Use the **Isolated Worker Model** (`Microsoft.Azure.Functions.Worker`)
- Functions use `HttpRequestData` and `HttpResponseData` (not `IActionResult`)
- Authorization level is typically `Anonymous` for public endpoints
- Use dependency injection via constructors for services like `ILogger`

### Common Patterns

1. **Model initialization**: All models initialize properties to prevent null reference warnings
2. **Razor component structure**: Page components typically include route, UI markup, and code block
3. **Data structures**: Lists are initialized in constructors to empty collections

### File Organization

- Place Razor pages in `Client/Pages/`
- Place shared models in `Shared/` or `Shared/EmpathyAssessment/`
- Azure Functions go in `Api/` with descriptive names ending in `Function.cs`
- Static assets go in `Client/wwwroot/`

## Important Notes

- **Build warnings**: There are existing nullable reference warnings in some Razor components. These are non-blocking and should be addressed when modifying those specific files.
- **Configuration**: The API requires a `local.settings.json` file (copy from `local.settings.example.json`)
- **Deployment**: Configured for Azure Static Web Apps via GitHub Actions workflow

## Making Changes

When contributing to this repository:

1. Maintain the existing code style and conventions
2. Keep Spanish content authentic and culturally appropriate
3. Test locally using the Azure Static Web Apps CLI workflow
4. Ensure nullable reference types are properly handled in new code
5. Add meaningful comments in Spanish for Spanish-language features
6. Consider the empathy assessment domain context when designing features
7. Documentar TODO miembro público con comentarios XML conforme a la sección de estilo (incluyendo excepciones lanzadas por los métodos).

## Dependencies Management

- Use only necessary NuGet packages
- Keep versions aligned across projects where shared
- Current key dependencies:
  - `Microsoft.AspNetCore.Components.WebAssembly` (Client)
  - `Microsoft.Azure.Functions.Worker.*` (API)
  - No test framework dependencies (no tests currently)
