using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Maradona estas pateando";
        }

        public string Correr()
        {
            return "Maradona estas corriendo";
        }

        public string Passe()
        {
            return "Maradona estas passando";
        }
    }
}