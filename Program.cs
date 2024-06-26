using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Components;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CompanyServices>();
builder.Services.AddScoped<ContractServices>();
builder.Services.AddScoped<DrugServices>();
builder.Services.AddScoped<PatientServices>();
builder.Services.AddScoped<PrescriptionServices>();
builder.Services.AddScoped<PharmacyServices>();
builder.Services.AddScoped<DoctorServices>();



builder.Services.AddBlazorBootstrap();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Connection Configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if(string.IsNullOrEmpty(connectionString))
{
    throw new Exception("Connection String is Invalid");
}

builder.Services.AddDbContext<ApplicationDataBaseContext> (options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();