using CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Editar()
        {
            Usuario usuario = new Usuario
            {
                Id = 1,
                Nome = "Rafael Cosetino",
                Email = "rafael@k19.com.br",
                Senha = "123",
                Descricao = "Sócio - fundador da K19 / Instrutor",
                DataCadastro = DateTime.Now
            };
            return View(usuario);
        }
    }
}