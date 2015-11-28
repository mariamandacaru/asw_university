using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASW_University.Models;

namespace ASW_University.Tests
{
    class TestAlunoDbSet : TestDbSet<Alunos>
    {
        public override Alunos Find(params object[] keyValues)
        {
            return this.SingleOrDefault(aluno => aluno.ID == (int)keyValues.Single());
        }
    }
}
