using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Carro
    {
        private int _velocidade;
        public int Velocidade
        {
            get { return _velocidade;  }
            set
            {
                if (value > 0)
                    _velocidade = value;
            }
        }
        
        public string Modelo { get; set; }
        public Carro()
        {
            this.Velocidade = Velocidade;
            this.Modelo = Modelo;
        }
    }
}
