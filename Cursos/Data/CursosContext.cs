using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cursos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cursos.Data
{
    public class CursosContext : IdentityDbContext
    {
        public CursosContext (DbContextOptions<CursosContext> options)
            : base(options)
        {
        }

        public DbSet<Cursos.Models.Student> Student { get; set; }

        public DbSet<Cursos.Models.Enrollment> Enrollment { get; set; }

        public DbSet<Cursos.Models.Course> Course { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            base.OnModelCreating(modelBuilder);
        }
    }
}
