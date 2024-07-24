using Ejercicio5.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
