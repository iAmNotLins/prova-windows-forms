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
    public partial class Cadastro : Form
    {

        public Cadastro()

        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
            this.Hide();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


       

            if (textBox1.Text != "" &&
            textBox2.Text != "" &&
            textBox3.Text != "" &&
             textBox4.Text != "" &&
             textBox5.Text != "" &&
             textBox6.Text != "" &&
             textBox7.Text != "" &&
            textBox8.Text != "" &&
            textBox9.Text != "")
            {
                MessageBox.Show(" Cadastro Feito com Sucesso");
                 textBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 textBox6.Text = "";
                 textBox7.Text = "";
                 textBox8.Text = "";
                 textBox9.Text = "";

            }
            else if (textBox1.Text == "" &&
         textBox2.Text == "" &&
         textBox3.Text == "" &&
          textBox4.Text == "" &&
          textBox5.Text == "" &&
          textBox6.Text == "" &&
          textBox7.Text == "" &&
         textBox8.Text == "" &&
         textBox9.Text == "")
            {
                MessageBox.Show("Os campos precisam ser preenchidos");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("O campo NOME precisa estar preenchido");
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("O campo CPF precisa estar preenchido");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("O campo RG precisa estar preenchido");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("O campo DATA DE NASCIMENTO precisa estar preenchido");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("O campo RUA precisa estar preenchido");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("O campo NÚMERO precisa estar preenchido");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("O campo BAIRRO precisa estar preenchido");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("O campo CIDADE precisa estar preenchido");
            } else if (textBox9.Text == "")
            {
                MessageBox.Show("O campo ESTADO precisa estar preenchido");
            }

        
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }

}