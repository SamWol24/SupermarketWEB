<<<<<<< HEAD
﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SupermarketEF.Data;

namespace SupermarketEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<SupermarketContext>(options =>
                    options.UseSqlServer("Server=localhost;Database=SupermarketEF;Trusted_Connection=True;"))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<SupermarketContext>())
            {
                // Aquí puedes realizar operaciones con el contexto si lo deseas
                Console.WriteLine("DbContext creado exitosamente.");
            }
=======
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;

namespace SupermarketWEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Agregar servicios al contenedor.
            builder.Services.AddRazorPages();

            // Definir la cadena de conexi�n directamente en el c�digo
            var connectionString = "Data Source=(localdb)\\mssqllocalDB;Database=SupermarketEF;Trusted_Connection=True;";

            // Agregar el contexto SupermarketContext a la aplicaci�n
            builder.Services.AddDbContext<SupermarketContext>(options =>
                options.UseSqlServer(connectionString)
            );

            var app = builder.Build();

            // Configurar el pipeline de solicitudes HTTP.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
>>>>>>> 6182bfadce7588acb39cfb53303d29be2806ba20
        }
    }
}
