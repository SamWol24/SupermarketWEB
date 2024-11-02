using System;
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
        }
    }
}
