using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ititans_App1
{

    public class StudentContext : DbContext
    {

        
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.ApplyConfiguration(new StudentConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FURQAN-PC;Database=iTitansSampleDB;Trusted_Connection=True; User ID=sa; Password=123; TrustServerCertificate=True; MultipleActiveResultSets=true;");
        }

    }


}
