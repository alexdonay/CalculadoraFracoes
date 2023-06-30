using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFracoes
{
    public class Calculadora
    {
        private int CalcMDC(Fracao fracao)
        {
            int numerador = Math.Abs(fracao.Numerador);
            int denominador = Math.Abs(fracao.Denominador);

            while (denominador != 0)
            {
                int temp = denominador;
                denominador = numerador % denominador;
                numerador = temp;
            }

            return numerador;
        }

        private void SimplificarFracao(Fracao fracao)
        {
            int mdc = CalcMDC(fracao);
            fracao.Numerador /= mdc;
            fracao.Denominador /= mdc;
        }
        public Fracao SomarFracao(Fracao fracao1, Fracao fracao2)
        {
            Fracao resultado = new Fracao();
            resultado.Numerador = (fracao1.Numerador * fracao2.Denominador) + (fracao2.Numerador * fracao1.Denominador);
            resultado.Denominador = fracao1.Denominador * fracao2.Denominador;
            SimplificarFracao(resultado);
            return resultado;
        }

        public Fracao SubtrairFracao(Fracao fracao1, Fracao fracao2)
        {
            Fracao resultado = new Fracao();
            resultado.Numerador = (fracao1.Numerador * fracao2.Denominador) - (fracao2.Numerador * fracao1.Denominador);
            resultado.Denominador = fracao1.Denominador * fracao2.Denominador;
            SimplificarFracao(resultado);
            return resultado;
        }

        public Fracao MultiplicarFracao(Fracao fracao1, Fracao fracao2)
        {
            Fracao resultado = new Fracao();
            resultado.Numerador = fracao1.Numerador * fracao2.Numerador;
            resultado.Denominador = fracao1.Denominador * fracao2.Denominador;
            SimplificarFracao(resultado);
            return resultado;
        }

        public Fracao DividirFracao(Fracao fracao1, Fracao fracao2)
        {
            Fracao resultado = new Fracao();
            resultado.Numerador = fracao1.Numerador * fracao2.Denominador;
            resultado.Denominador = fracao1.Denominador * fracao2.Numerador;
            SimplificarFracao(resultado);
            return resultado;
        }
    }
}
