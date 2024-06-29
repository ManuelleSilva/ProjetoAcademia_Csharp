using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoAcademia
{
    public partial class FormProfessor : Form
    {
        clProfessor professor = new clProfessor();
        ClControleProfessor controle = new ClControleProfessor();

        public FormProfessor()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBoxCodigoProf.Clear();
            textBoxNomeProf.Clear();
            maskedTextBoxTelefoneProf.Clear();
            maskedTextBoxCelularProf.Clear();
            textBoxEmail.Clear();
            txtBoxSenha.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeProf.Text == "" || maskedTextBoxTelefoneProf.Text == "" || maskedTextBoxCelularProf.Text == "" || textBoxEmail.Text == "" || txtBoxSenha.Text == "" || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                professor.Nome = textBoxNomeProf.Text;
                professor.Tel = maskedTextBoxTelefoneProf.Text;
                professor.Cel = maskedTextBoxCelularProf.Text;
                professor.Email = textBoxEmail.Text;
                professor.Senha = txtBoxSenha.Text;
                professor.StatusProfessor = comboBoxStatus.Text;

                string mensagem = controle.Cadastrar(professor);
                MessageBox.Show(mensagem);

                Limpar();
            }
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoProf.Text == "" || textBoxNomeProf.Text == "" || maskedTextBoxTelefoneProf.Text == "" || maskedTextBoxCelularProf.Text == "" || textBoxEmail.Text == "" || txtBoxSenha.Text == "" || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                professor.IdProfessor = int.Parse(textBoxCodigoProf.Text);
                professor.Nome = textBoxNomeProf.Text;
                professor.Tel = maskedTextBoxTelefoneProf.Text;
                professor.Cel = maskedTextBoxCelularProf.Text;
                professor.Email = textBoxEmail.Text;
                professor.Senha = txtBoxSenha.Text;
                professor.StatusProfessor = comboBoxStatus.Text;

                string mensagem = controle.Alterar(professor);
                MessageBox.Show(mensagem);

                Limpar();
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            FormListaProf ListarProfs = new FormListaProf();
            ListarProfs.ShowDialog();
        }

        private void buttonCons_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoProf.Text == "")
            {
                MessageBox.Show("Digite um código para consulta!");
                return;
            }

            try
            {
                professor = controle.Consultar(int.Parse(textBoxCodigoProf.Text));

                if (professor == null)
                {
                    MessageBox.Show("Registro não encontrado!");
                    Limpar();
                }
                else
                {
                    textBoxCodigoProf.Text = professor.IdProfessor.ToString();
                    textBoxNomeProf.Text = professor.Nome;
                    maskedTextBoxCelularProf.Text = professor.Cel;
                    maskedTextBoxTelefoneProf.Text = professor.Tel;
                    textBoxEmail.Text = professor.Email;
                    txtBoxSenha.Text = professor.Senha;
                    comboBoxStatus.Text = professor.StatusProfessor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Eventos desnecessários removidos
    }
}
