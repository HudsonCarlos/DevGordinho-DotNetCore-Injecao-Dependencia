using Aplicacao;
using Dominio;
using System;

namespace UI_DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            ////String de conexão
            //SqlConnection minhaConexao = new SqlConnection(@"data source=NOTEDELL64-PC\SQL2014_01;Integrated Security=SSPI;Initial Catalog=aprendendoASP");

            ////Abrindo a conexão como banco de dados
            //minhaConexao.Open();

            ////-
            //string strQueryUpdate = "UPDATE ALUNO SET Nome = 'Hudson da Silva Carlos' WHERE AlunoId = 1";
            ////-
            //SqlCommand CmdComandoUpdate = new SqlCommand(strQueryUpdate, minhaConexao);
            ////-
            //CmdComandoUpdate.ExecuteNonQuery();

            ////-
            //string strQueryDelete = "DELETE FROM ALUNO WHERE AlunoId = 3";
            ////-
            //SqlCommand CmdComandoDelete = new SqlCommand(strQueryDelete, minhaConexao);
            ////-
            //CmdComandoDelete.ExecuteNonQuery();

            //Console.WriteLine("Digite o nome do aluno");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o nome da mae do aluno");
            //string mae = Console.ReadLine();
            //Console.WriteLine("Digite o nome de nascimento do aluno");
            //string nascimento = Console.ReadLine();

            ////-
            //string strQueryInsert = string.Format("INSERT INTO ALUNO VALUES ('{0}','{1}','{2}')", nome, mae, nascimento);
            ////-
            //SqlCommand CmdComandoInsert = new SqlCommand(strQueryInsert, minhaConexao);
            ////-
            //CmdComandoInsert.ExecuteNonQuery();

            ////Criando o  comando SQL para manipular os dados do banco
            //string strQuerySelect = "SELECT * FROM ALUNO";
            ////O SQLCommand é que vai fazer a busca desses dados, ele precisa do comando sql e da string de conexao.
            //SqlCommand CmdComandoSelect = new SqlCommand(strQuerySelect, minhaConexao);
            ////Após executar a busca será retornado os dados do banco em um objeto do tipo DataReader
            //SqlDataReader dados = CmdComandoSelect.ExecuteReader();

            //while (dados.Read())
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, Nascimento:{3}", dados["AlunoId"].ToString(), dados["Nome"].ToString(), dados["Mae"].ToString(), dados["DataNascimento"].ToString());
            //}

            //REFATORANDO TODO O CODIGO ACIMA

            //var contexto = new Contexto();
            Aluno objAluno;

            objAluno = new Aluno() { Id = 1, Nome = "HUDSON DA SILVA CARLOS asasasasa", Mae = "VERA LUCIA", DataNascimento = DateTime.Parse("27/07/1988") };
            //new AlunoAplicacao().Salvar(objAluno);

            //new AlunoAplicacao().Excluir(6);

            //Console.WriteLine("Digite o nome do aluno");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o nome da mae do aluno");
            //string mae = Console.ReadLine();
            //Console.WriteLine("Digite o nome de nascimento do aluno");
            //string nascimento = Console.ReadLine();

            //objAluno = new Aluno() { Nome = nome, Mae = mae, DataNascimento = DateTime.Parse(nascimento) };
            //new AlunoAplicacao().Salvar(objAluno);

            //var todosAlunos = new AlunoAplicacao().ListarTodos();
            //var todosAlunos = new AlunoAplicacao().RetornaAluno(2); 

            //foreach (var item in todosAlunos)
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, Nascimento:{3}", item.Id, item.Nome, item.Mae, item.DataNascimento);
            //}

            Console.ReadKey();
            
        }
    }
}
