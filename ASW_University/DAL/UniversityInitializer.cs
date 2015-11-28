using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASW_University.Models;

namespace ASW_University.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var alunos = new List<Alunos>
            {
            new Alunos{Nome="Carson",Sobrenome="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Alunos{Nome="Meredith",Sobrenome="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alunos{Nome="Arturo",Sobrenome="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Alunos{Nome="Gytis",Sobrenome="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alunos{Nome="Yan",Sobrenome="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Alunos{Nome="Peggy",Sobrenome="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Alunos{Nome="Laura",Sobrenome="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Alunos{Nome="Nino",Sobrenome="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();
  
        }
    }
}