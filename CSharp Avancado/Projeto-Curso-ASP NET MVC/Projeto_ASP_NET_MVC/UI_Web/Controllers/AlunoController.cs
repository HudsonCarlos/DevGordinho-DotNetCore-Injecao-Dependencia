using Aplicacao;
using Dominio;
using System;
using System.Web.Mvc;

namespace UI_Web.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Index()
        {
            var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
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
                var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Excluir(int id)
        {
            var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
            var aluno = appAluno.ListarPorId(id.ToString());

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(Aluno aluno)
        {
            var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
            appAluno.Excluir(aluno);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            if (id > 0)
            {
                var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
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
                var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Detalhes(int id)
        {
            var appAluno = new AlunoAplicacaoConstrutor().AlunoAplicacaoADO();
            var aluno = appAluno.ListarPorId(id.ToString());

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }
    }
}
