﻿using System;
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
    public partial class frmMenuPrincipal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        public frmMenuPrincipal(string nome)
        {
            InitializeComponent();
            lblPegarUsuario.Text = nome;
        }
        


        private void btnVoltar_Click_2(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos(lblPegarUsuario.Text);
            abrir.Show();
            this.Hide();

            
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmListarProdutos abrir = new frmListarProdutos();
            abrir.Show();
            this.Hide();
        }
    }
}
