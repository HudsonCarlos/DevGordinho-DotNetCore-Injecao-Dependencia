using System;
using JogoFODA.Model;
using JogoFODA.Interface;

namespace JogoFODA
{
    public class Jogo
    {
        public IJogador _IJogador;
        public Jogo(IJogador jogador)
        {
            _IJogador = jogador;
        }

        public void IniciarJogo()
        {
            _IJogador.Chutar();
            _IJogador.Correr();
            _IJogador.Passar();
        }
    }
}