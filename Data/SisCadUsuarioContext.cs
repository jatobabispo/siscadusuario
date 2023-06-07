using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisCadUsuario.Models;

namespace SisCadUsuario.Data
{
    public class SisCadUsuarioContext : DbContext
    {
        public SisCadUsuarioContext (DbContextOptions<SisCadUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<SisCadUsuario.Models.User> User { get; set; } = default!;
    }
}
