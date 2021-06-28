using Dominio;
using Dominio.contrato;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioADO
{
    public class UsuarioRepositorioADO : IRepositorio<Usuario>
    {
        private Contexto contexto;

        public bool ValidarPorAtor(Usuario usuario)
        {
            var retorno = false;

            using (contexto = new Contexto())
            {
                var strQuerySelect = string.Format("SELECT count(*) FROM ControleEstoque.dbo.usuario WHERE login = '{0}' and senha = '{1}' ", usuario.Nome, usuario.Senha);
                retorno = ((int)contexto.ExecutaComandoExecuteScalar(strQuerySelect) > 0);
            }

            return retorno;
        }

        private void Insere(Usuario usuario)
        {
            //var strQueryInsert = "INSERT INTO aprendendoASP.dbo.aluno (Nome, Mae, DataNascimento) " + string.Format(" VALUES ('{0}','{1}','{2}')", usuario.Nome, usuario.Mae, usuario.DataNascimento);

            ////Boa pratica de programação é utilizar o using quando abro uma conexão
            //using (contexto = new Contexto())
            //{
            //    contexto.ExecutaComando(strQueryInsert);
            //}
        }

        private void Atualiza(Usuario usuario)
        {
            //string strQueryUpdate = "UPDATE aprendendoASP.dbo.aluno SET ";
            //strQueryUpdate += string.Format("Nome = '{0}', ", aluno.Nome);
            //strQueryUpdate += string.Format("Mae = '{0}', ", aluno.Mae);
            //strQueryUpdate += string.Format("DataNascimento = '{0}' ", aluno.DataNascimento);
            //strQueryUpdate += string.Format("WHERE Id = '{0}' ", aluno.Id);

            //using (contexto = new Contexto())
            //{
            //    contexto.ExecutaComando(strQueryUpdate);
            //}
        }

        public void Salvar(Usuario usuario)
        {
            //if (aluno.Id > 0)
            //    Atualiza(aluno);
            //else
            //    Insere(aluno);
        }

        public void Excluir(Usuario usuario)
        {
            //using (contexto = new Contexto())
            //{
            //    var strQueryDelete = string.Format("DELETE FROM aprendendoASP.dbo.aluno WHERE Id = '{0}' ", entidade.Id);
            //    contexto.ExecutaComando(strQueryDelete);
            //}
        }

        IEnumerable<Usuario> IRepositorio<Usuario>.ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuerySelect = string.Format("SELECT * FROM aprendendoASP.dbo.aluno");
                var retorno = contexto.ExecutaComandoComRetorno(strQuerySelect);
                return TransformaReaderEmListaDeObjeto(retorno);
            }
        }

        public Usuario ListarPorId(string id)
        {
            using (var contexto = new Contexto())
            {
                var strQuerySelect = string.Format("SELECT * FROM aprendendoASP.dbo.aluno WHERE Id = {0} ", id);
                var retorno = contexto.ExecutaComandoComRetorno(strQuerySelect);
                return TransformaReaderEmListaDeObjeto(retorno).FirstOrDefault();
            }
        }

        private List<Usuario> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var alunos = new List<Usuario>();

            while (reader.Read())
            {
                var temObjeto = new Usuario()
                {
                    //Id = int.Parse(reader["Id"].ToString()),
                    //Nome = reader["Nome"].ToString(),
                    //Mae = reader["Mae"].ToString(),
                    //DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                };
                alunos.Add(temObjeto);
            }
            reader.Close();
            return alunos;
        }
    }
}
