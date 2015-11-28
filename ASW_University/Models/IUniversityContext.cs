using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASW_University.Models
{
    public interface IUniversityContext : IDisposable
    {
        DbSet<Alunos> Alunos { get; }
        int SaveChanges();
        void MarkAsModified(Alunos item);
    }
}