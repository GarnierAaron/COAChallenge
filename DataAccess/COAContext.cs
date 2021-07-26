using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class COAContext : DbContext
    {
        public COAContext(DbContextOptions<COAContext> options) : base(options) { }
        
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
