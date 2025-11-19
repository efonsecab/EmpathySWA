// Punto de entrada para Azure Functions (modelo aislado) — actualizado al patrón de plantilla de .NET 10.
// Este archivo usa la nueva API `FunctionsApplication.CreateBuilder` y
// `ConfigureFunctionsWebApplication()` para asegurar que el generador
// de metadatos de funciones (`functions.metadata`) se ejecute correctamente.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Inicializa y ejecuta la aplicación de Azure Functions usando el patrón
/// recomendado para .NET 10 (FunctionsApplication).
/// </summary>
var builder = FunctionsApplication.CreateBuilder(args);

// Configura el entorno web de funciones (registra extensiones y targets necesarios).
builder.ConfigureFunctionsWebApplication();

// Configuraciones de servicios (Application Insights, DI, etc.)
builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

// Construye y ejecuta el host de funciones.
builder.Build().Run();
