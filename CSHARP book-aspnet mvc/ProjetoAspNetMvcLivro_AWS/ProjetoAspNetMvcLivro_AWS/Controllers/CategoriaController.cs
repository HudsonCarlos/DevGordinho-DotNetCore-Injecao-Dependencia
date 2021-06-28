using ProjetoLivroAspNetMvc01_2013.Contexts;
using ProjetoLivroAspNetMvc01_2013.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivroAspNetMvc01_2013.Controllers
{
    public class CategoriaController : Controller
    {
        private EFContext context = new EFContext();

        //public static IList<Categoria> listaCategorias = new List<Categoria>()
        //{
        //    new Categoria(){ CategoriaId = 1, Nome = "Computador"},
        //    new Categoria(){ CategoriaId = 2, Nome = "NoteBook"},
        //    new Categoria(){ CategoriaId = 3, Nome = "Tablet"},
        //    new Categoria(){ CategoriaId = 4, Nome = "Celular"},
        //    new Categoria(){ CategoriaId = 5, Nome = "Impressora"},
        //};

        public ActionResult Index()
        {
            return View(context.Categorias.OrderBy(x => x.CategoriaId));
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Categoria cat)
        {
            context.Categorias.Add(cat);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(long id)
        {
            return View("Detalhes", context.Categorias.Find(id));
        }

        public ActionResult Editar(long id)
        {
            return View("Editar", context.Categorias.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Categoria cat)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cat).State = EntityState.Modified;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Deletar(long id)
        {
            return View("Deletar", context.Categorias.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(Categoria cat)
        {
            context.Categorias.Remove(context.Categorias.Find(cat.CategoriaId));
            context.SaveChanges();
            TempData["Mensagem"] = "Categoria " + cat.Nome.ToUpper() + " foi removido";
            return RedirectToAction("Index");
        }
    }
}