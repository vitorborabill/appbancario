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
            this.lblsaldo = new System.Windows.Forms.Label();
            this.limite = new System.Windows.Forms.Label();
            this.btdeposit = new System.Windows.Forms.Button();
            this.btsacar = new System.Windows.Forms.Button();
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
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(272, 238);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(0, 25);
            this.lblsaldo.TabIndex = 2;
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
            // btdeposit
            // 
            this.btdeposit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeposit.Location = new System.Drawing.Point(139, 123);
            this.btdeposit.Name = "btdeposit";
            this.btdeposit.Size = new System.Drawing.Size(106, 40);
            this.btdeposit.TabIndex = 4;
            this.btdeposit.Text = "Depositar";
            this.btdeposit.UseVisualStyleBackColor = true;
            this.btdeposit.Click += new System.EventHandler(this.btdeposit_Click);
            // 
            // btsacar
            // 
            this.btsacar.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsacar.Location = new System.Drawing.Point(277, 123);
            this.btsacar.Name = "btsacar";
            this.btsacar.Size = new System.Drawing.Size(106, 40);
            this.btsacar.TabIndex = 5;
            this.btsacar.Text = "Sacar";
            this.btsacar.UseVisualStyleBackColor = true;
            // 
            // valornum
            // 
            this.valornum.DecimalPlaces = 1;
            this.valornum.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valornum.Location = new System.Drawing.Point(232, 74);
            this.valornum.Name = "valornum";
            this.valornum.Size = new System.Drawing.Size(151, 33);
            this.valornum.TabIndex = 6;
            // 
            // limitenum
            // 
            this.limitenum.DecimalPlaces = 1;
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
            this.Controls.Add(this.btsacar);
            this.Controls.Add(this.btdeposit);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.lblsaldo);
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
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label limite;
        private System.Windows.Forms.Button btdeposit;
        private System.Windows.Forms.Button btsacar;
        private System.Windows.Forms.NumericUpDown valornum;
        private System.Windows.Forms.NumericUpDown limitenum;
    }
}

