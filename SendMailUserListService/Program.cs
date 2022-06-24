
using Hafta._5.Application.Interfaces.Services;
using Hafta._5.Infrastructure.Services.UserExportService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SendMailUserListService;

var host = CreateDefaultBuilder().Build();

// Invoke Worker
using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;
var workerInstance = provider.GetRequiredService<Worker>();
//workerInstance.DoWork();

host.Run();
static IHostBuilder CreateDefaultBuilder()
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddSingleton<Worker>();
            services.AddScoped<IUserExportExcel, UserExportExcel>();
        });
}