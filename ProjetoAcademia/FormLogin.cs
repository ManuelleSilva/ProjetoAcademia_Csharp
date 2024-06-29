using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class FormLogin : Form
    {
        cl_Login lgn = new cl_Login();


        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Digite Login e senha para acessar o sistema!!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool logar = lgn.Logar(textBox1.Text, textBox2.Text);

                    if (logar == true)
                    {
                        this.Hide();
                        Form1 principal = new Form1();
                        principal.Show();
                    }
                    else
                    {

                        MessageBox.Show("Login e/ou senha inválidos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
