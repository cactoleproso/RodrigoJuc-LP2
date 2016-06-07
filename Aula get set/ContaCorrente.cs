using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ContaCorrente
    {
        public string NomeCliente { get; set; }
        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                    _saldo = value;
            }
        }
        public void Debitar( double valor)
        {
            if ( this.Saldo >= valor)
            {
                this.Saldo = valor;
            }
        }

    }
}
