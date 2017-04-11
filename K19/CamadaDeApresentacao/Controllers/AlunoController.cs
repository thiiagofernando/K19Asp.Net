using CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Detalhes()
        {
            Aluno a = new Aluno
            {
                AlunoID = 1,
                Nome = "Jonas Hirata",
                Email = "jonas@k19.com.br"
            };
            return View(a);
        }

        public ActionResult Lista()
        {
            ICollection<Aluno> lista = new List<Aluno>();

            for (int i = 0; i < 5; i++)
            {
                Aluno a = new Aluno
                {
                    AlunoID = i,
                    Nome = "Aluno" + i,
                    Email = "Email" + i
                };
                lista.Add(a);
            }
            return View(lista);
        }

        public ActionResult Editar()
        {
            Aluno aluno = new Aluno
            {
                AlunoID = 2,
                Nome = "Jonas Hirata",
                Email = "jonas@k19.com.br"

            };
            return View(aluno);
        }
    }
}