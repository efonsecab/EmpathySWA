using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Punto de entrada de la aplicación de Azure Functions (modelo aislado) para la API.
/// Configura telemetría y servicios requeridos y arranca el host de funciones.
/// </summary>
public class Program
{
    /// <summary>
    /// Método principal que construye y ejecuta el host de Azure Functions.
    /// </summary>
    /// <remarks>
    /// Este método no recibe argumentos ni devuelve valor; inicializa Application Insights
    /// y usa la configuración por defecto del Worker aislado.
    /// </remarks>
    public static void Main()
    {
        var host = new HostBuilder()
            .ConfigureFunctionsWorkerDefaults()
            .ConfigureServices(services =>
            {
                services.AddApplicationInsightsTelemetryWorkerService();
                services.ConfigureFunctionsApplicationInsights();
            })
            .Build();

        host.Run();
    }
}
