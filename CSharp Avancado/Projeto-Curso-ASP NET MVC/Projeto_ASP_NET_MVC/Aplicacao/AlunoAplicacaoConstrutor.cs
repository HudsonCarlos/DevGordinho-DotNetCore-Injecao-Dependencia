using RepositorioADO;

namespace Aplicacao
{
    public class AlunoAplicacaoConstrutor
    {

        public AlunoAplicacao AlunoAplicacaoADO()
        {
            return new AlunoAplicacao(new AlunoRepositorioADO());
        }
    }
}
