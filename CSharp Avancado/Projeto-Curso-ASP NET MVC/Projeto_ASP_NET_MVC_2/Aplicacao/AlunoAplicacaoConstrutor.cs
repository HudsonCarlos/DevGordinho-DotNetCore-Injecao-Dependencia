using RepositorioADO;
using RepositorioEF;

namespace Aplicacao
{
    public class AlunoAplicacaoConstrutor
    {

        public AlunoAplicacao AlunoAplicacaoADO()
        {
            return new AlunoAplicacao(new AlunoRepositorioADO());
        }

        public AlunoAplicacao AlunoAplicacaoEF()
        {
            return new AlunoAplicacao(new AlunoRepositorioEF());
        }
    }
}
