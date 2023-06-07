using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NuGet.Packaging.Signing;
using SisCadUsuario.Data;
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
// using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisCadUsuario.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SisCadUsuarioContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<SisCadUsuarioContext>>()))
        {
            // Look for any users.
            if (context.User.Any())
            {
                return; // DB has been seeded
            }
            context.User.AddRange(
            new User
            {
                Name = "JATOBA BISPO",
                Email = "jatoba@gmail.com",
                Password = "123",
                CPF = 02027148555,
                Created_at = DateTime.Now,
                // Updated_at = DateTime.Now,
                DataNascimento = DateTime.Parse("1989-2-12"),
                Phone = 71988776655,
                Perfil = "Admin",
                Complemento = "Fundos",
                Number = 10,
                City = "Salvador",
                Logradouro = "Travessa",
                State = "Bahia",
                Country = "Brasil",
                CEP = 40100000,
            },
            new User
            {
                Name = "Harry",
                Email = "harry@gmail.com",
                Password = "123",
                CPF = 02027148555,
                Created_at = DateTime.Now,
                // Updated_at = DateTime.Now,
                DataNascimento = DateTime.Parse("1989-2-12"),
                Phone = 71988776655,
                Perfil = "Supervisor",
                Complemento = "Fundos",
                Number = 10,
                City = "Salvador",
                Logradouro = "Travessa",
                State = "Bahia",
                Country = "Brasil",
                CEP = 40100000,
            },
            new User
            {
                Name = "Sally",
                Email = "sally@gmail.com",
                Password = "123",
                CPF = 1234567901,
                Created_at = DateTime.Now,
                // Updated_at = DateTime.Now,
                DataNascimento = DateTime.Parse("1989-2-12"),
                Phone = 987654321,
                Perfil = "Operador",
                Complemento = "Fundos",
                Number = 10,
                City = "Salvador",
                Logradouro = "Travessa",
                State = "Bahia",
                Country = "Brasil",
                CEP = 40100000,
            }
            );
            context.SaveChanges();
        }
    }
}

