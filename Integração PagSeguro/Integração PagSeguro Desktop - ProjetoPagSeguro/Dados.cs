namespace PagSeguro
{
    public class Dados
    {
        // Seus dados de acesso ao PagSeguro
        public string MeuEmail { get; set; }
        public string MeuToken { get; set; }
        // Dados de Envvio para o PagSeguro
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DDD { get; set; }
        public string NumeroTelefone { get; set; }
        public string Valor { get; set; }
        public string CodigoAcesso { get; set; }
        public string Referencia { get; set; }
        public string TituloPagamento { get; set; }
        // Dados de Retorno do PagSeguro
        public string Status { get; set; }
        public string stringConexao { get; set; }
    }
}
