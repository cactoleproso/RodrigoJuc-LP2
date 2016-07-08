using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Corrida
    {
        private string vencedor;
        private double menortempo = 1024*1024;
        private double velconvertida;
        private double tempototal;
        private List<Carro> Carros;
        public void AddCarro(Carro carro)
        {
            this.Carros.Add(carro);
        }
        public Corrida()
        {
            this.Carros = new List<Carro>();
        }
        public string Vencedor()
        {
            
            string s = string.Format(" ");
            foreach (Carro a in Carros)
            {
                velconvertida = a.Velocidade / 3.6;
                tempototal = 1500 / velconvertida;
                if ( tempototal < menortempo)
                {
                    menortempo = tempototal;
                    vencedor = a.Modelo;
                }
                s += string.Format(" Tempo do {0}: {1}", a.Modelo, tempototal);
            }
            s += string.Format(" O carro vencedor é: {0}" , vencedor);
            return s;
        }
    }
}
