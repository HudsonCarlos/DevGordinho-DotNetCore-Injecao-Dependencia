using PostGetModel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEnumerable<Noticia> todasAsNoticias;

        public HomeController()
        {
            //Existe um método dentro da classe Noticia simulando um banco de dados, abaixo uma instancian dessa classe é feita ordenando decedente por data
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var pessoa = new Pessoa()
                            {
                                PessoaId = 1,
                                Nome = "Hudson S. Carlos",
                                Twitter = "@DuduTisuvax"
                            };

            //Passando informação para a View via ViewData
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Twitter"] = pessoa.Twitter;

            //Passando informação para a View via ViewBag
            ViewBag.BPessoaId = pessoa.PessoaId;
            ViewBag.BNome = pessoa.Nome;
            ViewBag.BTwitter = pessoa.Twitter;

            //Passando informação para a View via View Tipada
            return View(pessoa);
        }

        //EX 01 - Eu recebo os dados do formulario por parametros
        //[HttpPost]
        //public ActionResult Lista(int pessoaId, string nome, string twitter)
        //{
        //    ViewData["pessoaId"] = pessoaId;
        //    ViewData["nome"] = nome;
        //    ViewData["twitter"] = twitter;

        //    return View();
        //}

        //EX 02 - Eu recebo os dados do formulario por FormCollection
        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["pessoaId"] = form["pessoaId"];
        //    ViewData["nome"] = form["nome"];
        //    ViewData["twitter"] = form["twitter"];

        //    return View();
        //}

        //EX 03 - Eu recebo os dados do formulario por ViewTipada
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["pessoaId"] = pessoa.PessoaId;
            ViewData["nome"] = pessoa.Nome;
            ViewData["twitter"] = pessoa.Twitter;

            return View(pessoa);
        }

        public ActionResult ListaGET(int pessoaId, string nome, string twitter)
        {
            ViewData["pessoaId"] = pessoaId;
            ViewData["nome"] = nome;
            ViewData["twitter"] = twitter;

            return View();
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

        public ActionResult Noticias()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);

            var todasAsCategoriasCategorias = todasAsNoticias.OrderBy(x => x.Categoria).Select(x => x.Categoria).Distinct().ToList();

            //Enviando parametros de cateria via ViewBag
            ViewBag.Categorias = todasAsCategoriasCategorias;

            return View(ultimasNoticias); 
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x=> x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}