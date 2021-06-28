using Aplicacao;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControleEstoque.Web.Controllers
{
    public class ContaController : Controller
    {
        private readonly UsuarioAplicacao appUsuario;

        public ContaController()
        {
            appUsuario = new AplicacaoConstrutor().UsuarioAplicacaoADO();
        }

        [AllowAnonymous] 
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Usuario login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = appUsuario.ValidarPorAtor(login);

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.Nome, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                    RedirectToAction("Index", "Home");
            }
            else
                ModelState.AddModelError("","Usuário ou senha inválido!");

            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}