namespace AspNetVS2017.Capitulo01.Troco
{
    partial class TrocoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valortrocotextBox = new System.Windows.Forms.TextBox();
            this.valorpagotextBox = new System.Windows.Forms.TextBox();
            this.ValorCompratextBox = new System.Windows.Forms.TextBox();
            this.CalcularBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedaslistView = new System.Windows.Forms.ListView();
            this.moedasimageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.valortrocotextBox);
            this.groupBox1.Controls.Add(this.valorpagotextBox);
            this.groupBox1.Controls.Add(this.ValorCompratextBox);
            this.groupBox1.Controls.Add(this.CalcularBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // valortrocotextBox
            // 
            this.valortrocotextBox.BackColor = System.Drawing.SystemColors.Info;
            this.valortrocotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valortrocotextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.valortrocotextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.valortrocotextBox.Location = new System.Drawing.Point(166, 165);
            this.valortrocotextBox.Name = "valortrocotextBox";
            this.valortrocotextBox.Size = new System.Drawing.Size(100, 26);
            this.valortrocotextBox.TabIndex = 3;
            this.valortrocotextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // valorpagotextBox
            // 
            this.valorpagotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorpagotextBox.Location = new System.Drawing.Point(166, 103);
            this.valorpagotextBox.Name = "valorpagotextBox";
            this.valorpagotextBox.Size = new System.Drawing.Size(100, 20);
            this.valorpagotextBox.TabIndex = 2;
            this.valorpagotextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ValorCompratextBox
            // 
            this.ValorCompratextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValorCompratextBox.Location = new System.Drawing.Point(166, 46);
            this.ValorCompratextBox.Name = "ValorCompratextBox";
            this.ValorCompratextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorCompratextBox.TabIndex = 0;
            this.ValorCompratextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CalcularBtn
            // 
            this.CalcularBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalcularBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularBtn.Location = new System.Drawing.Point(36, 224);
            this.CalcularBtn.Name = "CalcularBtn";
            this.CalcularBtn.Size = new System.Drawing.Size(204, 40);
            this.CalcularBtn.TabIndex = 8;
            this.CalcularBtn.Text = "&Calcular";
            this.CalcularBtn.UseVisualStyleBackColor = true;
            this.CalcularBtn.Click += new System.EventHandler(this.CalcularBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Troco:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Valor Pago em Dinheiro:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Valor da Compra:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.moedaslistView);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(370, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 508);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // moedaslistView
            // 
            this.moedaslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedaslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.moedaslistView.LargeImageList = this.moedasimageList;
            this.moedaslistView.Location = new System.Drawing.Point(3, 16);
            this.moedaslistView.Name = "moedaslistView";
            this.moedaslistView.Size = new System.Drawing.Size(412, 489);
            this.moedaslistView.TabIndex = 0;
            this.moedaslistView.UseCompatibleStateImageBehavior = false;
            this.moedaslistView.SelectedIndexChanged += new System.EventHandler(this.moedaslistView_SelectedIndexChanged);
            // 
            // moedasimageList
            // 
            this.moedasimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasimageList.ImageStream")));
            this.moedasimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasimageList.Images.SetKeyName(0, "1.png");
            this.moedasimageList.Images.SetKeyName(1, "5.png");
            this.moedasimageList.Images.SetKeyName(2, "10.png");
            this.moedasimageList.Images.SetKeyName(3, "25.png");
            this.moedasimageList.Images.SetKeyName(4, "50.png");
            this.moedasimageList.Images.SetKeyName(5, "100.png");
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.CalcularBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.Text = "Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrocoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valortrocotextBox;
        private System.Windows.Forms.TextBox valorpagotextBox;
        private System.Windows.Forms.TextBox ValorCompratextBox;
        private System.Windows.Forms.Button CalcularBtn;
        private System.Windows.Forms.ImageList moedasimageList;
        private System.Windows.Forms.ListView moedaslistView;
    }
}

