using Microsoft.AspNetCore;
using Boblioteca.UI.Data;
//agregamos estas directivas using
using Biblioteca.Repositorios;
using Biblioteca.Aplicacion.UseCases;
using Biblioteca.Aplicacion.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//agregamos estos servicios al contenedor DI
builder.Services.AddTransient<ObtenerDocenteUseCase>();
builder.Services.AddTransient<AgregarDocenteUseCase>();
builder.Services.AddTransient<ListarDocenteUseCase>();
builder.Services.AddTransient<EliminarDocenteUseCase>();
builder.Services.AddTransient<ModificarDocenteUseCase>();
builder.Services.AddScoped<IRepositorioDocente, RepositorioDocente>();


builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudianteUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();

builder.Services.AddTransient<ObtenerLibroUseCase>();
builder.Services.AddTransient<AgregarLibroUseCase>();
builder.Services.AddTransient<ListarLibroUseCase>();
builder.Services.AddTransient<EliminarLibroUseCase>();
builder.Services.AddTransient<ModificarLibroUseCase>();
builder.Services.AddScoped<IRepositorioLibro, RepositorioLibro>();


builder.Services.AddTransient<ObtenerPrestamoUseCase>();
builder.Services.AddTransient<DevolverLibroUseCase>();
builder.Services.AddTransient<RealizarPrestamoUseCase>();
builder.Services.AddTransient<ListarPrestamoUseCase>();
builder.Services.AddScoped<IRepositorioPrestamo, RepositorioPrestamo>();

var app = builder.Build();



new BibliotecaCreadorDB().AsegurarCreacionDB();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
