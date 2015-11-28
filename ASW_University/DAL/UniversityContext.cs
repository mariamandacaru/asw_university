using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASW_University.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ASW_University.DAL
{
    public class UniversityContext : DbContext, IUniversityContext
    {
        public UniversityContext() : base("UniversityContext")
        {
        }

        public DbSet<Alunos> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public void MarkAsModified(Alunos item)
        {
            Entry(item).State = EntityState.Modified;
        }

    }
}