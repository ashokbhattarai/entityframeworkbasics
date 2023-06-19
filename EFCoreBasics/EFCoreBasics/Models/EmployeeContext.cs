using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models;

public class EmployeeContext : DbContext
{
    public EmployeeContext()
    {
        
    }

    public EmployeeContext( DbContextOptions<DbContext> options ): base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ASHOKBHATTARAI\\SQLEXPRESS;Initial Catalog=EFCoreBasics_Test; Integrated Security= True ; Encrypt = True; TrustServerCertificate = True; User Instance = False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().ToTable("tblEmployees");
    }
    public DbSet<Employee> Employees { get; set;}

}
