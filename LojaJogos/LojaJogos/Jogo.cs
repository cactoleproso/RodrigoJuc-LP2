using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Jogo
    {
        
        public string NomeJogo { get; set; }
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Data { get; set; }
        private double _preço;
        public string Requesitos { get; set; }
        public string Desenvolvedor { get; set; }
        public double Preço
        {
            get { return _preço; }
            set
            {
                if (value >= 0) // 0 = grátis para jogar
                    _preço = value;
            }
        }       
    }
}
