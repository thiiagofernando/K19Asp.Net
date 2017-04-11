using CamadaDeControle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeControle.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Lista()
        {
            K19Context ctx = new K19Context();
            return View(ctx.Produtos);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastra(string nome, string descricao, double preco)
        {
            Produto p = new Produto
            {
                Nome = nome,
                Descricao = descricao,
                Preco = preco
            };

            K19Context ctx = new K19Context();
            ctx.Produtos.Add(p);
            ctx.SaveChanges();

            return RedirectToAction("Lista");
        }
    }
}