using ProjetoLivro01Vs2013.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivro01Vs2013.Controllers
{
    public class CategoriasController : Controller
    {
        public static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria(){ IdCategoria = 1, Nome = "Computador" },
            new Categoria(){ IdCategoria = 2, Nome = "Teclado" },
            new Categoria(){ IdCategoria = 3, Nome = "Mouse" },
            new Categoria(){ IdCategoria = 4, Nome = "Impressora" },
            new Categoria(){ IdCategoria = 5, Nome = "Monitor" }
        };
        
        // GET: /Categorias/
        public ActionResult Index()
        {
            return View(categorias);
        }

        // GET: /Create/
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(Categoria cat)
        {
            categorias.Add(cat);
            cat.IdCategoria = categorias.Select(m => m.IdCategoria).Max() + 1;
            return RedirectToAction("Index");
        }

        // GET: /Edit/
        public ActionResult Editar(long id)
        {
            return View("Editar", categorias.Where(x => x.IdCategoria == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Categoria cat)
        {
            foreach (var item in categorias.Where(x => x.IdCategoria == cat.IdCategoria))
            {
                item.IdCategoria = cat.IdCategoria;
                item.Nome = cat.Nome;
            }
            return RedirectToAction("Index");
        }

        // GET: /Details/
        public ActionResult Detalhes(long id)
        {
            return View("Detalhes", categorias.Where(x => x.IdCategoria == id).FirstOrDefault());
        }

        // GET: /Delete/
        public ActionResult Delete(long id)
        {
            return View("Delete", categorias.Where(x => x.IdCategoria == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria cat)
        {
            //categorias.Remove(categorias.Where(x => x.IdCategoria == id).FirstOrDefault());
            categorias.RemoveAt(categorias.IndexOf(categorias.Where(x => x.IdCategoria == cat.IdCategoria).First()));
            return RedirectToAction("Index");
        }
    }
}