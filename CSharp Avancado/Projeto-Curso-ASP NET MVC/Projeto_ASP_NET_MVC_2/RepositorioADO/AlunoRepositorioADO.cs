using Dominio;
using Dominio.contrato;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace RepositorioADO
{
    public class AlunoRepositorioADO : IRepositorio<Aluno>
    {
        private Contexto contexto;

        private void Insere(Aluno aluno)
        {
            var strQueryInsert = "INSERT INTO aprendendoASP.dbo.aluno (Nome, Mae, DataNascimento) " + string.Format(" VALUES ('{0}','{1}','{2}')", aluno.Nome, aluno.Mae, aluno.DataNascimento);

            //Boa pratica de programação é utilizar o using quando abro uma conexão
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQueryInsert);
            }
        }

        private void Atualiza(Aluno aluno)
        {
            string strQueryUpdate = "UPDATE aprendendoASP.dbo.aluno SET ";
            strQueryUpdate += string.Format("Nome = '{0}', ", aluno.Nome);
            strQueryUpdate += string.Format("Mae = '{0}', ", aluno.Mae);
            strQueryUpdate += string.Format("DataNascimento = '{0}' ", aluno.DataNascimento);
            strQueryUpdate += string.Format("WHERE Id = '{0}' ", aluno.Id);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQueryUpdate);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.Id > 0)
                Atualiza(aluno);
            else
                Insere(aluno);
        }

        public void Excluir(Aluno entidade)
        {
            using (contexto = new Contexto())
            {
                var strQueryDelete = string.Format("DELETE FROM aprendendoASP.dbo.aluno WHERE Id = '{0}' ", entidade.Id);
                contexto.ExecutaComando(strQueryDelete);
            }
        }

        IEnumerable<Aluno> IRepositorio<Aluno>.ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuerySelect = string.Format("SELECT * FROM aprendendoASP.dbo.aluno");
                var retorno = contexto.ExecutaComandoComRetorno(strQuerySelect);
                return TransformaReaderEmListaDeObjeto(retorno);
            }
        }

        public Aluno ListarPorId(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuerySelect = string.Format("SELECT * FROM aprendendoASP.dbo.aluno WHERE Id = {0} ", id);
                var retorno = contexto.ExecutaComandoComRetorno(strQuerySelect);
                return TransformaReaderEmListaDeObjeto(retorno).FirstOrDefault();
            }
        }

        private List<Aluno> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();

            while (reader.Read())
            {
                var temObjeto = new Aluno()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    Mae = reader["Mae"].ToString(),
                    DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                };
                alunos.Add(temObjeto);
            }
            reader.Close();
            return alunos;
        }

    }
}
