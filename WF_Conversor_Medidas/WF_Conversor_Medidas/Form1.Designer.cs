namespace WF_Conversor_Medidas
{
    partial class Form1
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbInstruct = new System.Windows.Forms.Label();
            this.lbValorConvertido = new System.Windows.Forms.Label();
            this.rbMetros = new System.Windows.Forms.RadioButton();
            this.rbCentim = new System.Windows.Forms.RadioButton();
            this.cbExibir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Transparent;
            this.btnConvert.Location = new System.Drawing.Point(338, 346);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(208, 49);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            this.btnConvert.MouseEnter += new System.EventHandler(this.btnConvert_MouseEnter);
            this.btnConvert.MouseLeave += new System.EventHandler(this.btnConvert_MouseLeave);
            // 
            // tbValor
            // 
            this.tbValor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbValor.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(124, 250);
            this.tbValor.MaxLength = 10;
            this.tbValor.Multiline = true;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(292, 47);
            this.tbValor.TabIndex = 1;
            // 
            // lbInstruct
            // 
            this.lbInstruct.AutoSize = true;
            this.lbInstruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInstruct.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruct.Location = new System.Drawing.Point(115, 156);
            this.lbInstruct.Name = "lbInstruct";
            this.lbInstruct.Size = new System.Drawing.Size(624, 50);
            this.lbInstruct.TabIndex = 2;
            this.lbInstruct.Text = "Digite o valor para conversão";
            // 
            // lbValorConvertido
            // 
            this.lbValorConvertido.AutoSize = true;
            this.lbValorConvertido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbValorConvertido.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorConvertido.Location = new System.Drawing.Point(638, 250);
            this.lbValorConvertido.Name = "lbValorConvertido";
            this.lbValorConvertido.Size = new System.Drawing.Size(48, 50);
            this.lbValorConvertido.TabIndex = 3;
            this.lbValorConvertido.Text = "0";
            // 
            // rbMetros
            // 
            this.rbMetros.AutoSize = true;
            this.rbMetros.Checked = true;
            this.rbMetros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMetros.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMetros.Location = new System.Drawing.Point(498, 250);
            this.rbMetros.Name = "rbMetros";
            this.rbMetros.Size = new System.Drawing.Size(78, 23);
            this.rbMetros.TabIndex = 4;
            this.rbMetros.Text = "Metros";
            this.rbMetros.UseVisualStyleBackColor = true;
            // 
            // rbCentim
            // 
            this.rbCentim.AutoSize = true;
            this.rbCentim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCentim.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCentim.Location = new System.Drawing.Point(498, 272);
            this.rbCentim.Name = "rbCentim";
            this.rbCentim.Size = new System.Drawing.Size(119, 23);
            this.rbCentim.TabIndex = 5;
            this.rbCentim.Text = "Centímetros";
            this.rbCentim.UseVisualStyleBackColor = true;
            // 
            // cbExibir
            // 
            this.cbExibir.AutoSize = true;
            this.cbExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExibir.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExibir.Location = new System.Drawing.Point(647, 327);
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.Size = new System.Drawing.Size(152, 27);
            this.cbExibir.TabIndex = 6;
            this.cbExibir.Text = "Exibir medida";
            this.cbExibir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(373, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.rbCentim);
            this.Controls.Add(this.rbMetros);
            this.Controls.Add(this.lbValorConvertido);
            this.Controls.Add(this.lbInstruct);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnConvert);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbInstruct;
        private System.Windows.Forms.Label lbValorConvertido;
        private System.Windows.Forms.RadioButton rbMetros;
        private System.Windows.Forms.RadioButton rbCentim;
        private System.Windows.Forms.CheckBox cbExibir;
        private System.Windows.Forms.Button button1;
    }
}

