using System;

namespace Uniciv.Api.Models
{
    public class FundoCapital
    {
        public FundoCapital()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; } //Identificador unico não sequencial.
        public string Nome { get; set; }
        public decimal ValorNecessario { get; set; }
        public decimal ValorAtual { get; set; } 
        public DateTime? DataResgate { get; set; }
    }
}