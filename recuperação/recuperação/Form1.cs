using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Usuário é obrigatório");
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Senha é obrigatória");
                }
                else
                {
                    if (txtUsuario.Text == "bill" && txtSenha.Text == "portao")
                    {
                        MessageBox.Show("Seja bem-vindo!");
                        TelaMenu Telamenu = new TelaMenu();
                        Telamenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha inválidos!");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            alterarSenha alterarSenha = new alterarSenha();
            alterarSenha.Show();
            this.Hide();
        }
    }
}