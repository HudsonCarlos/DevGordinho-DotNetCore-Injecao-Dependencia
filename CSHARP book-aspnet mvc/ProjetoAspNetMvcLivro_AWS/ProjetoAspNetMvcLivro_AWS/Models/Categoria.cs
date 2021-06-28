using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLivroAspNetMvc01_2013.Models
{
    public class Categoria
    {

        public long CategoriaId { get; set; }
        public string Nome { get; set; }
    }
}