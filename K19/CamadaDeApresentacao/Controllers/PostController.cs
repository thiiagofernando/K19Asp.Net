﻿using CamadaDeApresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            ICollection<Post> posts = new List<Post>();

            for (int i = 0; i < 10; i++)
            {
                posts.Add(new Post
                {
                    Autor = "Autor do post " + i,
                    Categoria = "Categoria " + i ,
                    Data = DateTime.Now.Subtract(TimeSpan.FromDays(i)),
                    Texto = i + " - Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Titulo = "Titulo do post" + i
                });
            }
            return View(posts);
        }
    }
}