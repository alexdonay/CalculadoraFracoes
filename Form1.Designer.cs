namespace CalculadoraFracoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFra1Numerador;
        private System.Windows.Forms.TextBox txtFra1Denominador;
        private System.Windows.Forms.TextBox txtFra2Numerador;
        private System.Windows.Forms.TextBox txtFra2Denominador;
        private System.Windows.Forms.Label lblFra1;
        private System.Windows.Forms.Label lblFra2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtResultadoNumerador;
        private System.Windows.Forms.TextBox txtResultadoDenominador;
        private System.Windows.Forms.Label lblResultado;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFra1Numerador = new System.Windows.Forms.TextBox();
            this.txtFra1Denominador = new System.Windows.Forms.TextBox();
            this.txtFra2Numerador = new System.Windows.Forms.TextBox();
            this.txtFra2Denominador = new System.Windows.Forms.TextBox();
            this.lblFra1 = new System.Windows.Forms.Label();
            this.lblFra2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtResultadoNumerador = new System.Windows.Forms.TextBox();
            this.txtResultadoDenominador = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFra1Numerador
            // 
            this.txtFra1Numerador.Location = new System.Drawing.Point(50, 50);
            this.txtFra1Numerador.Name = "txtFra1Numerador";
            this.txtFra1Numerador.Size = new System.Drawing.Size(50, 20);
            this.txtFra1Numerador.TabIndex = 0;
            this.txtFra1Numerador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFra1Numerador_KeyPress);
            // 
            // txtFra1Denominador
            // 
            this.txtFra1Denominador.Location = new System.Drawing.Point(50, 80);
            this.txtFra1Denominador.Name = "txtFra1Denominador";
            this.txtFra1Denominador.Size = new System.Drawing.Size(50, 20);
            this.txtFra1Denominador.TabIndex = 1;
            this.txtFra1Denominador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFra1Denominador_KeyPress);
            // 
            // txtFra2Numerador
            // 
            this.txtFra2Numerador.Location = new System.Drawing.Point(200, 50);
            this.txtFra2Numerador.Name = "txtFra2Numerador";
            this.txtFra2Numerador.Size = new System.Drawing.Size(50, 20);
            this.txtFra2Numerador.TabIndex = 2;
            this.txtFra2Numerador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFra2Numerador_KeyPress);
            // 
            // txtFra2Denominador
            // 
            this.txtFra2Denominador.Location = new System.Drawing.Point(200, 80);
            this.txtFra2Denominador.Name = "txtFra2Denominador";
            this.txtFra2Denominador.Size = new System.Drawing.Size(50, 20);
            this.txtFra2Denominador.TabIndex = 3;
            this.txtFra2Denominador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFra2Denominador_KeyPress);
            // 
            // lblFra1
            // 
            this.lblFra1.Location = new System.Drawing.Point(50, 30);
            this.lblFra1.Name = "lblFra1";
            this.lblFra1.Size = new System.Drawing.Size(100, 23);
            this.lblFra1.TabIndex = 4;
            this.lblFra1.Text = "Fração 1:";
            // 
            // lblFra2
            // 
            this.lblFra2.Location = new System.Drawing.Point(200, 30);
            this.lblFra2.Name = "lblFra2";
            this.lblFra2.Size = new System.Drawing.Size(100, 23);
            this.lblFra2.TabIndex = 5;
            this.lblFra2.Text = "Fração 2:";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(350, 50);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(50, 50);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "+";
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(410, 50);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(50, 50);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(470, 50);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(530, 50);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(50, 50);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "/";
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // txtResultadoNumerador
            // 
            this.txtResultadoNumerador.Location = new System.Drawing.Point(350, 120);
            this.txtResultadoNumerador.Name = "txtResultadoNumerador";
            this.txtResultadoNumerador.ReadOnly = true;
            this.txtResultadoNumerador.Size = new System.Drawing.Size(50, 20);
            this.txtResultadoNumerador.TabIndex = 10;
            // 
            // txtResultadoDenominador
            // 
            this.txtResultadoDenominador.Location = new System.Drawing.Point(350, 150);
            this.txtResultadoDenominador.Name = "txtResultadoDenominador";
            this.txtResultadoDenominador.ReadOnly = true;
            this.txtResultadoDenominador.Size = new System.Drawing.Size(50, 20);
            this.txtResultadoDenominador.TabIndex = 11;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(350, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFra1Numerador);
            this.Controls.Add(this.txtFra1Denominador);
            this.Controls.Add(this.txtFra2Numerador);
            this.Controls.Add(this.txtFra2Denominador);
            this.Controls.Add(this.lblFra1);
            this.Controls.Add(this.lblFra2);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtResultadoNumerador);
            this.Controls.Add(this.txtResultadoDenominador);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Calculadora de Frações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

