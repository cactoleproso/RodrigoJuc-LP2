using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo
    {
        private double _perimetro;
        public double Perimetro 
        {
            get {return _perimetro;}
            set
            {
                if (value > 0)
                    _perimetro = value;
            }
        }
        public int Id { get; set; }
        private int _cor;
        public int Cor
        {
            get { return _cor; }
            set
            {
                if (_cor >= 0 && _cor < 16777216)
                    _cor = value;
            }

        }
        public int PosX { get; set; }
        public int PosY { get; set; }
        private double _ladoA;
        public double LadoA
        {
            get { return _ladoA; }
            set
            {
                if (value > 0)
                    _ladoA = value;
            }
        }
        private double _ladoB;
        public double LadoB
        {
            get { return _ladoB; }
            set 
            {
                if (value > 0)
                    _ladoB = value;
            }
        }
        private double _ladoC;
        public double LadoC
        {
            get { return _ladoC; }
            set
            {
                if (value > 0)
                    _ladoC = value;
            }
        }
        public Triangulo ( double LadoA , double LadoB , double LadoC)
        {
            Perimetro = LadoA + LadoB + LadoC;
        }
    }
}
