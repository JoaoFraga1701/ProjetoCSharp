using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmListarProdutos()
        {
            InitializeComponent();
            //executando o método para carregar a combobox
            carregaCombo();
        }

        //criando método para carregaCombo
        public void carregaCombo()
        {
            //inserindo valores no vetor
            Produtos[0] = "Banana";
            Produtos[1] = "Limão";
            Produtos[2] = "Laranja";
            Produtos[3] = "Pera";
            Produtos[4] = "Uva";
            Produtos[5] = "Maça";
            Produtos[6] = "Melancia";
            Produtos[7] = "jaboticaba";
            Produtos[8] = "Goiaba";
            Produtos[9] = "Tangerina";

            for (int i = 0; i < Produtos.Length; i++)
            {
                cbbProdutos.Items.Add(Produtos[i]);
            }
        }

        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }


        //criando um vetor
        string[] Produtos = new string[10];

        private void btnCarregar_Click(object sender, EventArgs e)
        {


            //inserindo valores no vetor
            Produtos[0] = "Banana";
            Produtos[1] = "Limão";
            Produtos[2] = "Laranja";
            Produtos[3] = "Pera";
            Produtos[4] = "Uva";
            Produtos[5] = "Maça";
            Produtos[6] = "Melancia";
            Produtos[7] = "jaboticaba";
            Produtos[8] = "Goiaba";
            Produtos[9] = "Tangerina";


            //Imprimindo os vetores
            //MessageBox.Show("Produto"+ Produtos[0]);
            //MessageBox.Show("Produto"+ Produtos[5]);

            //percorrendo o vetor criado
            ltbProdutos.Items.Clear();

            for (int i = 0; i < Produtos.Length; i++)
            {
                ltbProdutos.Items.Add(Produtos[i]);

            }


        }

        private void cbbListarItens_MouseClick(object sender, MouseEventArgs e)
        {
            //inserindo valores no vetor
            Produtos[0] = "Banana";
            Produtos[1] = "Limão";
            Produtos[2] = "Laranja";
            Produtos[3] = "Pera";
            Produtos[4] = "Uva";
            Produtos[5] = "Maça";
            Produtos[6] = "Melancia";
            Produtos[7] = "jaboticaba";
            Produtos[8] = "Goiaba";
            Produtos[9] = "Tangerina";

            cbbListarItens.Items.Clear();

            for (int i = 0; i < Produtos.Length; i++)
            {
                cbbListarItens.Items.Add(Produtos[i]);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();

        }

        private void btnTestarPessoa_Click(object sender, EventArgs e)
        {
            //instanciando o objeto pessoa
            Pessoa p = new Pessoa();
            p.Nome = "Senac";
            lblTestarPessoa.Text = p.Nome;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Bilhete bilhete = new Bilhete();

            bilhete.Documento = txtDocumento.Text;
            bilhete.NumeroCartao = mtbNumeroCartao.Text;

            lblMostrarDocumento.Text = bilhete.Documento;
            lblmostrarCartao.Text = bilhete.NumeroCartao;





        }

        private void btnTestaLogin_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin(txtTestaLogin.Text);
            abrir.Show();

          
            
        }
    }
}
