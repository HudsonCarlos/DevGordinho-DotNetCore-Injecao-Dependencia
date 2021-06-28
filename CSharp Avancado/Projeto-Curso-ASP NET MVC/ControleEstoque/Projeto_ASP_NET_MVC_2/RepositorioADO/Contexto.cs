using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class Contexto : IDisposable //Para que a conexão seja fechada sempre que a classe for fechada
    {
        private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Config"].ConnectionString);

            //Abrindo a conexão como banco de dados
            minhaConexao.Open();
        }

        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
            {
                minhaConexao.Close();
            }
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };

            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);

            return cmdComando.ExecuteReader();
        }

        public object ExecutaComandoExecuteScalar(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);

            return cmdComando.ExecuteScalar();
        }
    }
}
