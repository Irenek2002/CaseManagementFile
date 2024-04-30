using CaseManagementFile.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.PatientRepositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IPatientRepository, PatientService>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
await builder.Build().RunAsync();