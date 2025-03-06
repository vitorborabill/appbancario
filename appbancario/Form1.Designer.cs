namespace appbancario
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
            this.valor = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.saldonum = new System.Windows.Forms.Label();
            this.limite = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.valornum = new System.Windows.Forms.NumericUpDown();
            this.limitenum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.valornum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitenum)).BeginInit();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(134, 81);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(56, 25);
            this.valor.TabIndex = 0;
            this.valor.Text = "Valor :";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.Location = new System.Drawing.Point(134, 238);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(63, 25);
            this.saldo.TabIndex = 1;
            this.saldo.Text = "Saldo :";
            // 
            // saldonum
            // 
            this.saldonum.AutoSize = true;
            this.saldonum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldonum.Location = new System.Drawing.Point(229, 238);
            this.saldonum.Name = "saldonum";
            this.saldonum.Size = new System.Drawing.Size(53, 25);
            this.saldonum.TabIndex = 2;
            this.saldonum.Text = "label3";
            // 
            // limite
            // 
            this.limite.AutoSize = true;
            this.limite.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limite.Location = new System.Drawing.Point(134, 329);
            this.limite.Name = "limite";
            this.limite.Size = new System.Drawing.Size(60, 25);
            this.limite.TabIndex = 3;
            this.limite.Text = "Limite :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(277, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // valornum
            // 
            this.valornum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valornum.Location = new System.Drawing.Point(232, 74);
            this.valornum.Name = "valornum";
            this.valornum.Size = new System.Drawing.Size(151, 33);
            this.valornum.TabIndex = 6;
            // 
            // limitenum
            // 
            this.limitenum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitenum.Location = new System.Drawing.Point(232, 327);
            this.limitenum.Name = "limitenum";
            this.limitenum.Size = new System.Drawing.Size(151, 33);
            this.limitenum.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 462);
            this.Controls.Add(this.limitenum);
            this.Controls.Add(this.valornum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.saldonum);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.valor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valornum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label saldonum;
        private System.Windows.Forms.Label limite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown valornum;
        private System.Windows.Forms.NumericUpDown limitenum;
    }
}

