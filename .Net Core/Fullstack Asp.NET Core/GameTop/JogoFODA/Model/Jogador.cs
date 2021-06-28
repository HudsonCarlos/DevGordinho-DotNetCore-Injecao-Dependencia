using System;

namespace JogoFODA.Model
{
    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public string Correr()
        {
            return $"{_Nome} está corrento.";
        }

        public string Chutar()
        {
            return $"{_Nome} está chutando.";
        }

        public string Passar()
        {
            return $"{_Nome} está passando.";
        }
    }
}