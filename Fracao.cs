using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFracoes
{
    public class Fracao
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Fracao()
        {
            this.Numerador = 1;
            this.Denominador = 1;

        }
        public Fracao(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }

        
        public override string ToString()
        {
            return "Numerador : " + Numerador + "Denominador: " + Denominador;
        }
    }
}
