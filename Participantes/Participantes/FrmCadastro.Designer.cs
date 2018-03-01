namespace Participantes
{
    partial class FrmCadastro
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.txbCNPJ = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lbIE = new System.Windows.Forms.Label();
            this.txbIE = new System.Windows.Forms.TextBox();
            this.lbMun = new System.Windows.Forms.Label();
            this.cbMun = new System.Windows.Forms.ComboBox();
            this.lbSuframa = new System.Windows.Forms.Label();
            this.txbSuframa = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.txbEnd = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbCompl = new System.Windows.Forms.TextBox();
            this.lbCompl = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 29);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(347, 20);
            this.tbName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(286, 151);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastro";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(15, 180);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.Size = new System.Drawing.Size(721, 172);
            this.dgvParticipantes.TabIndex = 3;
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(375, 25);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 21);
            this.cbPais.TabIndex = 4;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(372, 9);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(29, 13);
            this.lbPais.TabIndex = 5;
            this.lbPais.Text = "País";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(13, 102);
            this.txbCPF.MaxLength = 11;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 9;
            // 
            // cbDocumento
            // 
            this.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(14, 75);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(101, 21);
            this.cbDocumento.TabIndex = 10;
            this.cbDocumento.SelectedIndexChanged += new System.EventHandler(this.cbDocumento_SelectedIndexChanged);
            // 
            // txbCNPJ
            // 
            this.txbCNPJ.Location = new System.Drawing.Point(14, 102);
            this.txbCNPJ.MaxLength = 14;
            this.txbCNPJ.Name = "txbCNPJ";
            this.txbCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txbCNPJ.TabIndex = 11;
            this.txbCNPJ.TextChanged += new System.EventHandler(this.txbCNPJ_TextChanged);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(10, 59);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(62, 13);
            this.lbDocumento.TabIndex = 12;
            this.lbDocumento.Text = "Documento";
            this.lbDocumento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbIE
            // 
            this.lbIE.AutoSize = true;
            this.lbIE.Location = new System.Drawing.Point(131, 59);
            this.lbIE.Name = "lbIE";
            this.lbIE.Size = new System.Drawing.Size(94, 13);
            this.lbIE.TabIndex = 13;
            this.lbIE.Text = "Inscrição Estadual";
            // 
            // txbIE
            // 
            this.txbIE.Location = new System.Drawing.Point(133, 76);
            this.txbIE.MaxLength = 14;
            this.txbIE.Name = "txbIE";
            this.txbIE.Size = new System.Drawing.Size(100, 20);
            this.txbIE.TabIndex = 14;
            // 
            // lbMun
            // 
            this.lbMun.AutoSize = true;
            this.lbMun.Location = new System.Drawing.Point(602, 9);
            this.lbMun.Name = "lbMun";
            this.lbMun.Size = new System.Drawing.Size(54, 13);
            this.lbMun.TabIndex = 15;
            this.lbMun.Text = "Município";
            // 
            // cbMun
            // 
            this.cbMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMun.FormattingEnabled = true;
            this.cbMun.Location = new System.Drawing.Point(605, 25);
            this.cbMun.Name = "cbMun";
            this.cbMun.Size = new System.Drawing.Size(117, 21);
            this.cbMun.TabIndex = 16;
            // 
            // lbSuframa
            // 
            this.lbSuframa.AutoSize = true;
            this.lbSuframa.Location = new System.Drawing.Point(257, 59);
            this.lbSuframa.Name = "lbSuframa";
            this.lbSuframa.Size = new System.Drawing.Size(46, 13);
            this.lbSuframa.TabIndex = 17;
            this.lbSuframa.Text = "Suframa";
            // 
            // txbSuframa
            // 
            this.txbSuframa.Location = new System.Drawing.Point(260, 76);
            this.txbSuframa.MaxLength = 9;
            this.txbSuframa.Name = "txbSuframa";
            this.txbSuframa.Size = new System.Drawing.Size(101, 20);
            this.txbSuframa.TabIndex = 18;
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(372, 61);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(53, 13);
            this.lbEnd.TabIndex = 19;
            this.lbEnd.Text = "Endereço";
            // 
            // txbEnd
            // 
            this.txbEnd.Location = new System.Drawing.Point(375, 77);
            this.txbEnd.MaxLength = 60;
            this.txbEnd.Name = "txbEnd";
            this.txbEnd.Size = new System.Drawing.Size(203, 20);
            this.txbEnd.TabIndex = 20;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(590, 61);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(44, 13);
            this.lbNum.TabIndex = 21;
            this.lbNum.Text = "Número";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(593, 77);
            this.txbNum.MaxLength = 10;
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(41, 20);
            this.txbNum.TabIndex = 22;
            this.txbNum.TextChanged += new System.EventHandler(this.txbNum_TextChanged);
            // 
            // txbCompl
            // 
            this.txbCompl.Location = new System.Drawing.Point(640, 77);
            this.txbCompl.MaxLength = 60;
            this.txbCompl.Name = "txbCompl";
            this.txbCompl.Size = new System.Drawing.Size(82, 20);
            this.txbCompl.TabIndex = 24;
            // 
            // lbCompl
            // 
            this.lbCompl.AutoSize = true;
            this.lbCompl.Location = new System.Drawing.Point(637, 61);
            this.lbCompl.Name = "lbCompl";
            this.lbCompl.Size = new System.Drawing.Size(71, 13);
            this.lbCompl.TabIndex = 23;
            this.lbCompl.Text = "Complemento";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(375, 119);
            this.txbBairro.MaxLength = 60;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(97, 20);
            this.txbBairro.TabIndex = 26;
            this.txbBairro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(373, 103);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 25;
            this.lbBairro.Text = "Bairro";
            this.lbBairro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(513, 25);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(73, 21);
            this.cbUF.TabIndex = 27;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.Location = new System.Drawing.Point(510, 9);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(21, 13);
            this.lbUF.TabIndex = 28;
            this.lbUF.Text = "UF";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(375, 151);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 29;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 371);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbUF);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txbCompl);
            this.Controls.Add(this.lbCompl);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.txbEnd);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.txbSuframa);
            this.Controls.Add(this.lbSuframa);
            this.Controls.Add(this.cbMun);
            this.Controls.Add(this.lbMun);
            this.Controls.Add(this.txbIE);
            this.Controls.Add(this.lbIE);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.txbCNPJ);
            this.Controls.Add(this.cbDocumento);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.dgvParticipantes);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbName);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro Participantes";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.TextBox txbCNPJ;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lbIE;
        private System.Windows.Forms.TextBox txbIE;
        private System.Windows.Forms.Label lbMun;
        private System.Windows.Forms.ComboBox cbMun;
        private System.Windows.Forms.Label lbSuframa;
        private System.Windows.Forms.TextBox txbSuframa;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.TextBox txbEnd;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.TextBox txbCompl;
        private System.Windows.Forms.Label lbCompl;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label lbUF;
        private System.Windows.Forms.Button btExcluir;
    }
}

