using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CesdeU.DAL
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext() : base("UniversidadContext")
        {
        }

        public DbSet<Models.Estudiante> Estudiantes { get; set; }

        public DbSet<Models.Enrollment> Enrollments { get; set; }

        public DbSet<Models.Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}