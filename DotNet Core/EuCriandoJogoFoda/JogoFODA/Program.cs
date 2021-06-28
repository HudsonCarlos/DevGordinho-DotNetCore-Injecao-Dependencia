using System;

namespace EuCriandoJogoFoda
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoFoda objJogo = new JogoFoda("Ronaldinho");
            objJogo.Jogar();
        }
    }

    class JogoFoda
    {
        public string jogador { get; set; }
        public JogoFoda(string value)
        {
            jogador = value;
            Console.WriteLine($"O Jogador {value} foi escalado para o time.");
        }

        public void Jogar(){
            Console.WriteLine($"{jogador} fez um gol.");
        }
    }
}
