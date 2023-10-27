
namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrimeiroNMmero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrimeiroNMmero
            // 
            this.lblPrimeiroNMmero.AutoSize = true;
            this.lblPrimeiroNMmero.Location = new System.Drawing.Point(300, 92);
            this.lblPrimeiroNMmero.Name = "lblPrimeiroNMmero";
            this.lblPrimeiroNMmero.Size = new System.Drawing.Size(84, 13);
            this.lblPrimeiroNMmero.TabIndex = 0;
            this.lblPrimeiroNMmero.Text = "Primeiro Número";
            this.lblPrimeiroNMmero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(558, 92);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNumero.TabIndex = 1;
            this.lblSegundoNumero.Text = "Segundo Número";
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnSoma.Location = new System.Drawing.Point(297, 134);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(87, 68);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Tag = "";
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnSubtração.Location = new System.Drawing.Point(390, 134);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(75, 68);
            this.btnSubtração.TabIndex = 3;
            this.btnSubtração.Text = "-";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnMultiplicação.Location = new System.Drawing.Point(471, 134);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(84, 68);
            this.btnMultiplicação.TabIndex = 4;
            this.btnMultiplicação.Text = "x";
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnDivisão.Location = new System.Drawing.Point(561, 134);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(87, 68);
            this.btnDivisão.TabIndex = 5;
            this.btnDivisão.Text = "/";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(548, 108);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 6;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(297, 108);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(297, 265);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblPrimeiroNMmero);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNMmero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
    }
}

