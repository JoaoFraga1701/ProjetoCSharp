
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListarProdutos = new System.Windows.Forms.Label();
            this.lblListarItens = new System.Windows.Forms.Label();
            this.cbbListarItens = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.lblTestarPessoa = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblnumeroCartao = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblMostrarDocumento = new System.Windows.Forms.Label();
            this.lblmostrarCartao = new System.Windows.Forms.Label();
            this.mtbNumeroCartao = new System.Windows.Forms.MaskedTextBox();
            this.btnTestaLogin = new System.Windows.Forms.Button();
            this.txtTestaLogin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(235, 91);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(97, 35);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "&Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.ItemHeight = 20;
            this.ltbProdutos.Location = new System.Drawing.Point(444, 59);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(178, 204);
            this.ltbProdutos.TabIndex = 3;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(56, 59);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(161, 28);
            this.cbbProdutos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produtos";
            // 
            // lblListarProdutos
            // 
            this.lblListarProdutos.AutoSize = true;
            this.lblListarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarProdutos.Location = new System.Drawing.Point(451, 25);
            this.lblListarProdutos.Name = "lblListarProdutos";
            this.lblListarProdutos.Size = new System.Drawing.Size(133, 20);
            this.lblListarProdutos.TabIndex = 6;
            this.lblListarProdutos.Text = "Lista de Produtos";
            // 
            // lblListarItens
            // 
            this.lblListarItens.AutoSize = true;
            this.lblListarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarItens.Location = new System.Drawing.Point(53, 102);
            this.lblListarItens.Name = "lblListarItens";
            this.lblListarItens.Size = new System.Drawing.Size(88, 20);
            this.lblListarItens.TabIndex = 8;
            this.lblListarItens.Text = "Listar Itens";
            // 
            // cbbListarItens
            // 
            this.cbbListarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListarItens.FormattingEnabled = true;
            this.cbbListarItens.Items.AddRange(new object[] {
            "abobora",
            "manga",
            "peixe"});
            this.cbbListarItens.Location = new System.Drawing.Point(56, 127);
            this.cbbListarItens.Name = "cbbListarItens";
            this.cbbListarItens.Size = new System.Drawing.Size(161, 28);
            this.cbbListarItens.TabIndex = 7;
            this.cbbListarItens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbListarItens_MouseClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(57, 302);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(134, 33);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTestarPessoa
            // 
            this.btnTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarPessoa.Location = new System.Drawing.Point(56, 251);
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.Size = new System.Drawing.Size(135, 35);
            this.btnTestarPessoa.TabIndex = 10;
            this.btnTestarPessoa.Text = "&Testar pessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.btnTestarPessoa_Click);
            // 
            // lblTestarPessoa
            // 
            this.lblTestarPessoa.AutoSize = true;
            this.lblTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestarPessoa.Location = new System.Drawing.Point(52, 189);
            this.lblTestarPessoa.Name = "lblTestarPessoa";
            this.lblTestarPessoa.Size = new System.Drawing.Size(114, 20);
            this.lblTestarPessoa.TabIndex = 11;
            this.lblTestarPessoa.Text = "Mostra pessoa";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(269, 403);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(135, 35);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "&Reserva";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(272, 289);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(132, 26);
            this.txtDocumento.TabIndex = 15;
            // 
            // lblnumeroCartao
            // 
            this.lblnumeroCartao.AutoSize = true;
            this.lblnumeroCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroCartao.Location = new System.Drawing.Point(268, 336);
            this.lblnumeroCartao.Name = "lblnumeroCartao";
            this.lblnumeroCartao.Size = new System.Drawing.Size(136, 20);
            this.lblnumeroCartao.TabIndex = 17;
            this.lblnumeroCartao.Text = "Número do cartão";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(268, 266);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(92, 20);
            this.lblDocumento.TabIndex = 18;
            this.lblDocumento.Text = "Documento";
            // 
            // lblMostrarDocumento
            // 
            this.lblMostrarDocumento.AutoSize = true;
            this.lblMostrarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDocumento.Location = new System.Drawing.Point(428, 292);
            this.lblMostrarDocumento.Name = "lblMostrarDocumento";
            this.lblMostrarDocumento.Size = new System.Drawing.Size(150, 20);
            this.lblMostrarDocumento.TabIndex = 19;
            this.lblMostrarDocumento.Text = "Mostrar Documento";
            // 
            // lblmostrarCartao
            // 
            this.lblmostrarCartao.AutoSize = true;
            this.lblmostrarCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrarCartao.Location = new System.Drawing.Point(428, 365);
            this.lblmostrarCartao.Name = "lblmostrarCartao";
            this.lblmostrarCartao.Size = new System.Drawing.Size(194, 20);
            this.lblmostrarCartao.TabIndex = 20;
            this.lblmostrarCartao.Text = "Mostrar Número do cartão";
            // 
            // mtbNumeroCartao
            // 
            this.mtbNumeroCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroCartao.Location = new System.Drawing.Point(272, 359);
            this.mtbNumeroCartao.Mask = "000,000,000-00";
            this.mtbNumeroCartao.Name = "mtbNumeroCartao";
            this.mtbNumeroCartao.Size = new System.Drawing.Size(132, 26);
            this.mtbNumeroCartao.TabIndex = 21;
            // 
            // btnTestaLogin
            // 
            this.btnTestaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestaLogin.Location = new System.Drawing.Point(269, 189);
            this.btnTestaLogin.Name = "btnTestaLogin";
            this.btnTestaLogin.Size = new System.Drawing.Size(135, 35);
            this.btnTestaLogin.TabIndex = 22;
            this.btnTestaLogin.Text = "&Testar Login";
            this.btnTestaLogin.UseVisualStyleBackColor = true;
            this.btnTestaLogin.Click += new System.EventHandler(this.btnTestaLogin_Click);
            // 
            // txtTestaLogin
            // 
            this.txtTestaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestaLogin.FormattingEnabled = true;
            this.txtTestaLogin.Items.AddRange(new object[] {
            "abobora",
            "manga",
            "peixe"});
            this.txtTestaLogin.Location = new System.Drawing.Point(260, 155);
            this.txtTestaLogin.Name = "txtTestaLogin";
            this.txtTestaLogin.Size = new System.Drawing.Size(161, 28);
            this.txtTestaLogin.TabIndex = 23;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestaLogin);
            this.Controls.Add(this.btnTestaLogin);
            this.Controls.Add(this.mtbNumeroCartao);
            this.Controls.Add(this.lblmostrarCartao);
            this.Controls.Add(this.lblMostrarDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblnumeroCartao);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblTestarPessoa);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblListarItens);
            this.Controls.Add(this.cbbListarItens);
            this.Controls.Add(this.lblListarProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ltbProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ABC - ListarProdutos";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListarProdutos;
        private System.Windows.Forms.Label lblListarItens;
        private System.Windows.Forms.ComboBox cbbListarItens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Label lblTestarPessoa;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblnumeroCartao;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblMostrarDocumento;
        private System.Windows.Forms.Label lblmostrarCartao;
        private System.Windows.Forms.MaskedTextBox mtbNumeroCartao;
        private System.Windows.Forms.Button btnTestaLogin;
        private System.Windows.Forms.ComboBox txtTestaLogin;
    }
}