﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudaIP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "admin";

            if(TxtUsuario.Text == user & TxtSenha.Text == password)
            {
                MessageBox.Show("Acesso Liberado!");
                FrmHome frmHome = new FrmHome();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
