using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public string Chutar()
        {
            return $"{_Nome} está chutando \n";
        }
        //Corre
        public string Correr()
        {
            return $"{_Nome} está correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}