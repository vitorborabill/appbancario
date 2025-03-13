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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.valor = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.limite = new System.Windows.Forms.Label();
            this.btdeposit = new System.Windows.Forms.Button();
            this.btsacar = new System.Windows.Forms.Button();
            this.valornum = new System.Windows.Forms.NumericUpDown();
            this.limitenum = new System.Windows.Forms.NumericUpDown();
            this.tmrJuros = new System.Windows.Forms.Timer(this.components);
            this.lblTaxa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valornum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitenum)).BeginInit();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.valor.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.valor.Location = new System.Drawing.Point(237, 99);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 46);
            this.valor.TabIndex = 0;
            this.valor.Text = "Valor :";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelX.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Location = new System.Drawing.Point(226, 365);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(111, 46);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "Saldo :";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblsaldo.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsaldo.Location = new System.Drawing.Point(445, 365);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(0, 46);
            this.lblsaldo.TabIndex = 2;
            this.lblsaldo.TextChanged += new System.EventHandler(this.lblsaldo_TextChanged);
            // 
            // limite
            // 
            this.limite.AutoSize = true;
            this.limite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.limite.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.limite.Location = new System.Drawing.Point(226, 529);
            this.limite.Name = "limite";
            this.limite.Size = new System.Drawing.Size(110, 46);
            this.limite.TabIndex = 3;
            this.limite.Text = "Limite :";
            // 
            // btdeposit
            // 
            this.btdeposit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btdeposit.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeposit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdeposit.Location = new System.Drawing.Point(162, 205);
            this.btdeposit.Name = "btdeposit";
            this.btdeposit.Size = new System.Drawing.Size(234, 62);
            this.btdeposit.TabIndex = 4;
            this.btdeposit.Text = "Depositar";
            this.btdeposit.UseVisualStyleBackColor = false;
            this.btdeposit.Click += new System.EventHandler(this.btdeposit_Click);
            // 
            // btsacar
            // 
            this.btsacar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btsacar.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsacar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsacar.Location = new System.Drawing.Point(554, 205);
            this.btsacar.Name = "btsacar";
            this.btsacar.Size = new System.Drawing.Size(234, 62);
            this.btsacar.TabIndex = 5;
            this.btsacar.Text = "Sacar";
            this.btsacar.UseVisualStyleBackColor = false;
            this.btsacar.Click += new System.EventHandler(this.btsacar_Click);
            // 
            // valornum
            // 
            this.valornum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.valornum.DecimalPlaces = 2;
            this.valornum.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valornum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.valornum.Location = new System.Drawing.Point(421, 92);
            this.valornum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.valornum.Name = "valornum";
            this.valornum.Size = new System.Drawing.Size(311, 53);
            this.valornum.TabIndex = 6;
            // 
            // limitenum
            // 
            this.limitenum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.limitenum.DecimalPlaces = 2;
            this.limitenum.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitenum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.limitenum.Location = new System.Drawing.Point(453, 527);
            this.limitenum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.limitenum.Name = "limitenum";
            this.limitenum.Size = new System.Drawing.Size(311, 53);
            this.limitenum.TabIndex = 7;
            // 
            // tmrJuros
            // 
            this.tmrJuros.Enabled = true;
            this.tmrJuros.Interval = 5000;
            this.tmrJuros.Tick += new System.EventHandler(this.tmrJuros_Tick);
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTaxa.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTaxa.Location = new System.Drawing.Point(413, 608);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(0, 46);
            this.lblTaxa.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 702);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.limitenum);
            this.Controls.Add(this.valornum);
            this.Controls.Add(this.btsacar);
            this.Controls.Add(this.btdeposit);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.valor);
            this.Name = "Form1";
            this.Text = "banco do cti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valornum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label limite;
        private System.Windows.Forms.Button btdeposit;
        private System.Windows.Forms.Button btsacar;
        private System.Windows.Forms.NumericUpDown valornum;
        private System.Windows.Forms.NumericUpDown limitenum;
        private System.Windows.Forms.Timer tmrJuros;
        private System.Windows.Forms.Label lblTaxa;
    }
}

