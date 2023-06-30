using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFracoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFra1Numerador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtFra1Denominador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFra2Numerador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFra2Denominador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                int numerador1 = int.Parse(txtFra1Numerador.Text);
                int denominador1 = int.Parse(txtFra1Denominador.Text);
                int numerador2 = int.Parse(txtFra2Numerador.Text);
                int denominador2 = int.Parse(txtFra2Denominador.Text);
                Fracao fr1 = new Fracao(numerador1, denominador1);
                Fracao fr2 = new Fracao(numerador2, denominador2);
                Calculadora calc = new Calculadora();
                Fracao result = calc.SomarFracao(fr1, fr2);
                txtResultadoNumerador.Text = result.Numerador.ToString();
                txtResultadoDenominador.Text = result.Denominador.ToString();
            }
            
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                int numerador1 = int.Parse(txtFra1Numerador.Text);
                int denominador1 = int.Parse(txtFra1Denominador.Text);
                int numerador2 = int.Parse(txtFra2Numerador.Text);
                int denominador2 = int.Parse(txtFra2Denominador.Text);
                Fracao fr1 = new Fracao(numerador1, denominador1);
                Fracao fr2 = new Fracao(numerador2, denominador2);
                Calculadora calc = new Calculadora();
                Fracao result = calc.SubtrairFracao(fr1, fr2);
                txtResultadoNumerador.Text = result.Numerador.ToString();
                txtResultadoDenominador.Text = result.Denominador.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                int numerador1 = int.Parse(txtFra1Numerador.Text);
                int denominador1 = int.Parse(txtFra1Denominador.Text);
                int numerador2 = int.Parse(txtFra2Numerador.Text);
                int denominador2 = int.Parse(txtFra2Denominador.Text);
                Fracao fr1 = new Fracao(numerador1, denominador1);
                Fracao fr2 = new Fracao(numerador2, denominador2);
                Calculadora calc = new Calculadora();
                Fracao result = calc.MultiplicarFracao(fr1, fr2);
                txtResultadoNumerador.Text = result.Numerador.ToString();
                txtResultadoDenominador.Text = result.Denominador.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                int numerador1 = int.Parse(txtFra1Numerador.Text);
                int denominador1 = int.Parse(txtFra1Denominador.Text);
                int numerador2 = int.Parse(txtFra2Numerador.Text);
                int denominador2 = int.Parse(txtFra2Denominador.Text);
                Fracao fr1 = new Fracao(numerador1, denominador1);
                Fracao fr2 = new Fracao(numerador2, denominador2);
                Calculadora calc = new Calculadora();
                Fracao result = calc.DividirFracao(fr1, fr2);
                txtResultadoNumerador.Text = result.Numerador.ToString();
                txtResultadoDenominador.Text = result.Denominador.ToString();
            }

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private bool CamposPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtFra1Numerador.Text) &&
                   !string.IsNullOrWhiteSpace(txtFra1Denominador.Text) &&
                   !string.IsNullOrWhiteSpace(txtFra2Numerador.Text) &&
                   !string.IsNullOrWhiteSpace(txtFra2Denominador.Text);
        }
    }
}
