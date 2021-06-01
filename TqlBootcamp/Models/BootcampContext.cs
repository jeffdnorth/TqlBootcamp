using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TqlBootcamp.Models
{

    public class BootcampContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentScore> AssessmentScores { get; set; }

        //sets up sql server w our connection string
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress01;database=BootcampDB;trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { }

    }

}
