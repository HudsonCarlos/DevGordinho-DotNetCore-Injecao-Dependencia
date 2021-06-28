using Aplicacao;
using Dominio;
using System;
using System.Web.Mvc;

namespace UI_Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoAplicacao appAluno;

        public AlunoController()
        {
            appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoEF();
        }

        public ActionResult Index()
        {
            var listaDeAlunos = appAluno.ListarTodos();

            return View(listaDeAlunos);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Excluir(int id)
        { 
            var aluno = appAluno.ListarPorId(id.ToString());

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(Aluno aluno)
        {
            appAluno.Excluir(aluno);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            if (id > 0)
            {
                var aluno = appAluno.ListarPorId(id.ToString());

                if (aluno == null)
                    return HttpNotFound();

                return View(aluno);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Detalhes(int id)
        {
            var aluno = appAluno.ListarPorId(id.ToString());

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

    }
}
