using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASW_University;
using ASW_University.Controllers;
using ASW_University.Models;

namespace ASW_University.Tests.Controllers
{
    [TestClass]
    public class AlunosControllerTest
    {
        [TestMethod]
        public void CreateAluno_ShouldReturnSameAluno()
        {
            var controller = new AlunosController(new TestUniversityContext());

            var item = GetDemoAluno();

            var result = controller.Create(item);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EditAluno_ShouldReturnStatusCode()
        {
            var controller = new AlunosController(new TestUniversityContext());

            var item = GetDemoAluno();

            var result = controller.Edit(item.ID);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void GetAluno_ShouldReturnAlunoWithSameID()
        {
            var context = new TestUniversityContext();
            context.Alunos.Add(GetDemoAluno());

            var controller = new AlunosController(context);
            var result = controller.Edit(3) as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteAluno_ShouldReturnOK()
        {
            var context = new TestUniversityContext();
            var item = GetDemoAluno();
            context.Alunos.Add(item);

            var controller = new AlunosController(context);
            var result = controller.Delete(3);

            Assert.IsNotNull(result);
        }

        Alunos GetDemoAluno()
        {
            return new Alunos() { ID = 3, Nome = "Carson", Sobrenome = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") };
        }
    }


}
