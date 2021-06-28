using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private string nome = "Hudson da Silva Carlos";

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf = "123.123.123-12";

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string email = "hudsonscarlos@outlook.com";

        public string Email
        {
            get { return email; }
            set { email = value; }
        }



    }
}
