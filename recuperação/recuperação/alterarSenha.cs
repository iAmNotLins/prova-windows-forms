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
    public partial class alterarSenha : Form
    {
        public alterarSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (txtAtual.Text == "")
            {
                MessageBox.Show("Todos campos devem ser preenchidos!");
            }
            else if (txtAtual.Text == txtNova.Text)
            {
                MessageBox.Show("A nova senha não pode ser igual a atual");
            }
            else
            {
                if (txtNova.Text != txtConfirme.Text)
                {
                    MessageBox.Show("As senhas não conferem!");
                }
                else if (txtAtual.Text == "portao")
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                    Form1 telaLogin = new Form1();
                    telaLogin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Senha atual incorreta!");
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }
    }
}

