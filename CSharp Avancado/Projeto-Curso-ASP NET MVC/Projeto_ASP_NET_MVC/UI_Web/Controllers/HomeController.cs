using Aplicacao;
using System.Web.Mvc;

namespace UI_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
            var listaDeAlunos = appAluno.ListarTodos();

            return View(listaDeAlunos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}