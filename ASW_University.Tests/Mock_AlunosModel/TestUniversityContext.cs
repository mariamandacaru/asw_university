using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ASW_University.Models;

namespace ASW_University.Tests
{
    public class TestUniversityContext : IUniversityContext
    {
        public TestUniversityContext()
        {
            this.Alunos = new TestAlunoDbSet();
        }

        public DbSet<Alunos> Alunos { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Alunos item) { }
        public void Dispose() { }
    }
}
