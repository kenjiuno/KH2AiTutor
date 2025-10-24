using KH2AiTutor.Client.Helpers;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace KH2AiTutor.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddKH2AiTutorClient();

            await builder.Build().RunAsync();
        }
    }
}
