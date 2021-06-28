using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Aluno
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha nome do aluno")]
        public string Nome { get; set; }
        [DisplayName("Mãe")]
        [Required(ErrorMessage = "Preencha nome da Mãe")]
        public string Mae { get; set; }
        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Preencha a data de nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}
