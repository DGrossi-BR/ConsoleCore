using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_Jogador1.Correr());
            System.Console.Write(_Jogador1.Chutar());
            System.Console.Write(_Jogador1.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_Jogador2.Correr());
            System.Console.Write(_Jogador2.Chutar());
            System.Console.Write(_Jogador2.Passe());
        }
    }
}