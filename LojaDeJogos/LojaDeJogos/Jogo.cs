using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeJogos
{
    class Jogo
    {
        private List<Jogo> Jogos;
        public string NomeJogo { get; set; }
        public int Id { get; set; }
        public string Genero { get; set; }
        public string AnoL { get; set; }
        private double _preço;
        public string Requesitos { get; set; }
        public double preço
        {
            get { return _preço; }
            set
            {
                if (value >= 0) // 0 = grátis para jogar
                    _preço = value;
            }
        }
        public Jogo()
        {
            this.Jogos = new List<Jogo>();
        }
        public void AdicionarJogo(Jogo jogo)
        {
            this.Jogos.Add(jogo);
        }

    }
}
