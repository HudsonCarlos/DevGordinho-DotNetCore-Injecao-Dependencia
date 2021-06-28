using PostGetModel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //Validação do lado do servidor
            //if (string.IsNullOrEmpty(pessoa.Nome)) { ModelState.AddModelError("Nome", "O campo nome é obrigatório"); }
            //if (pessoa.Senha != pessoa.ConfirmarSenha) { ModelState.AddModelError("", "As senha não conferem"); }
            

            //Condição necessário para que seja feita uma validação do lado do servidor, sem o ModelState a validação não é feita.
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        //Validação do lado do servidor
        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string> { "Hudson", "Isabela", "Sarah" };
            return Json(bancoDeNomesDeExemplo.All(x=>x.ToLower() != login.ToLower()),JsonRequestBehavior.AllowGet);
        }
    }
}