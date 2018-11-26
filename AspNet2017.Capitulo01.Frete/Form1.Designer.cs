namespace AspNet2017.Capitulo01.Frete
{
    partial class freteForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.valortextBox = new System.Windows.Forms.TextBox();
            this.fretetextBox = new System.Windows.Forms.TextBox();
            this.LimparButton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.ufcomboBox = new System.Windows.Forms.ComboBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.fecharbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Uf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Frete:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // clientetextBox
            // 
            this.clientetextBox.Location = new System.Drawing.Point(101, 43);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.Size = new System.Drawing.Size(232, 20);
            this.clientetextBox.TabIndex = 2;
            // 
            // valortextBox
            // 
            this.valortextBox.Location = new System.Drawing.Point(101, 84);
            this.valortextBox.Name = "valortextBox";
            this.valortextBox.Size = new System.Drawing.Size(121, 20);
            this.valortextBox.TabIndex = 4;
            this.valortextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fretetextBox
            // 
            this.fretetextBox.Location = new System.Drawing.Point(101, 158);
            this.fretetextBox.Name = "fretetextBox";
            this.fretetextBox.ReadOnly = true;
            this.fretetextBox.Size = new System.Drawing.Size(121, 20);
            this.fretetextBox.TabIndex = 8;
            this.fretetextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(228, 369);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(96, 23);
            this.LimparButton.TabIndex = 0;
            this.LimparButton.Text = "&Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(228, 325);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(96, 23);
            this.Calcularbutton.TabIndex = 11;
            this.Calcularbutton.Text = "&Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ufcomboBox
            // 
            this.ufcomboBox.FormattingEnabled = true;
            this.ufcomboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "PR",
            "PA",
            "MG",
            "RS",
            "MS",
            "GO",
            "DF",
            "CE",
            "BA",
            "RN",
            "PI",
            "MA",
            "PB"});
            this.ufcomboBox.Location = new System.Drawing.Point(101, 119);
            this.ufcomboBox.Name = "ufcomboBox";
            this.ufcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ufcomboBox.TabIndex = 6;
            this.ufcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(101, 209);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.ReadOnly = true;
            this.totaltextBox.Size = new System.Drawing.Size(121, 20);
            this.totaltextBox.TabIndex = 10;
            // 
            // fecharbutton
            // 
            this.fecharbutton.Location = new System.Drawing.Point(361, 369);
            this.fecharbutton.Name = "fecharbutton";
            this.fecharbutton.Size = new System.Drawing.Size(96, 23);
            this.fecharbutton.TabIndex = 12;
            this.fecharbutton.Text = "&Fechar";
            this.fecharbutton.UseVisualStyleBackColor = true;
            this.fecharbutton.Click += new System.EventHandler(this.fecharbutton_Click);
            // 
            // freteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.fecharbutton);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.ufcomboBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.fretetextBox);
            this.Controls.Add(this.valortextBox);
            this.Controls.Add(this.clientetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "freteForm";
            this.Text = "Frete";
            this.Load += new System.EventHandler(this.freteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientetextBox;
        private System.Windows.Forms.TextBox valortextBox;
        private System.Windows.Forms.TextBox fretetextBox;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ComboBox ufcomboBox;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Button fecharbutton;
    }
}

