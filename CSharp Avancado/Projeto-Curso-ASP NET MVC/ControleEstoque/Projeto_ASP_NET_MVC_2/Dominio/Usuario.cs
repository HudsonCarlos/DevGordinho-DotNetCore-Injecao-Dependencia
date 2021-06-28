using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name="Usuário:")]
        [Required(ErrorMessage = "Digite o nome.")]
        public string Nome { get; set; }

        [Display(Name ="Senha:")]
        [Required(ErrorMessage = "Digite a Senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}
