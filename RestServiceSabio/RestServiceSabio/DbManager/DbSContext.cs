using EntityFrameworkCore.FirebirdSql.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestServiceSabio.DbManager
{
    public class DbSContext : DbContext
    {
        public DbSet<UserDto> user { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "User ID=SYSDBA;Password=masterkey;" +
                       "Database=localhost:C:\\GOLDEN_CL.FDB; " +
                       "DataSource=localhost;Charset=NONE;";
            optionsBuilder.UseFirebird(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelo)
        {
            //Fluent Api
            modelo.Entity<UserDto>(entity =>
            {
                entity.HasIndex(e => e.NUMERO)
                    .HasName("NUMERO")
                    .IsUnique();
            });
        }
    }
    public class UserDto
    {
        public int NUMERO { get; set; }
        public String LOGIN { get; set; }
        public String NOMBRE { get; set; }
        public String CLAVE { get; set; }
        public int AREA { get; set; }
        public int HABILI { get; set; }
        public int UNINEG { get; set; }
        public int ESROOT { get; set; }
        public String PATH { get; set; }
        public String URL { get; set; }
        public int DEPOSI { get; set; }
        public String EMAIL { get; set; }
        public int PTOVTA { get; set; }

    }
}
