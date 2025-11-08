using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;

/// <summary>
/// Punto de entrada del cliente Blazor WebAssembly. Configura componentes raíz,
/// servicios DI y arranca la aplicación en el navegador.
/// </summary>
public static class Program
{
    /// <summary>
    /// Construye y ejecuta el host WebAssembly inicializando los servicios necesarios.
    /// </summary>
    /// <param name="args">Argumentos de línea de comandos (no utilizados normalmente en WASM).</param>
    /// <exception cref="System.UriFormatException">Se lanza si la configuración de <c>API_Prefix</c> contiene una URI inválida.</exception>
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

        await builder.Build().RunAsync();
    }
}
