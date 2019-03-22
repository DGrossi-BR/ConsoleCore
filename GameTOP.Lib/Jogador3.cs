using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        string iJogador.Chutar()
        {
            return "teste chuta";
        }

        string iJogador.Correr()
        {
            return "teste corre";
        }

        string iJogador.Passe()
        {
            return "teste passe";
        }
    }
}