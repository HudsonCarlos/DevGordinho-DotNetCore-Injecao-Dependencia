using ProjetoLivroAspNetMvc01_2013.Contexts;
using ProjetoLivroAspNetMvc01_2013.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivroAspNetMvc01_2013.Controllers
{
    public class FabricanteController : Controller
    {
        private EFContext context = new EFContext();

        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderByDescending(x => x.Nome));
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Fabricante fab)
        {
            context.Fabricantes.Add(fab);
            context.SaveChanges();
            TempData["Mensagem"] = "Fabricante " + fab.Nome.ToUpper() + " foi criado.";
            return RedirectToAction("Index");
        }

        public ActionResult Editar(long? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Fabricante fab = context.Fabricantes.Find(id);
            if (fab == null) return HttpNotFound();

            return View(fab);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Fabricante fab)
        {
            if (ModelState.IsValid)
            {
                context.Entry(fab).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Mensagem"] = "Fabricante " + fab.Nome.ToUpper() + " foi alterado.";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(long? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Fabricante fab = context.Fabricantes.Find(id);
            if (fab == null) return HttpNotFound();

            return View(fab);
        }

        public ActionResult Deletar(long? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Fabricante fab = context.Fabricantes.Find(id);
            if (fab == null) return HttpNotFound();

            return View(fab);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(long id)
        {
            Fabricante fab = context.Fabricantes.Find(id);
            context.Fabricantes.Remove(fab);
            context.SaveChanges();
            TempData["Mensagem"] = "Fabricante " + fab.Nome.ToUpper() + " foi removido.";
            return RedirectToAction("Index");
        }
    }
}