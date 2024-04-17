using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcProyectoweb.Models;
using System.Security.Cryptography.X509Certificates;

namespace MvcProyecto1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
       
        }
        public DbSet<Almacen> Almacen { get;set;}
    }
}
