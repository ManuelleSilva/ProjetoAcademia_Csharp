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
    public partial class FormAluno : Form
    {

        clAluno aluno = new clAluno();
        clControleAluno controle = new clControleAluno();

        public FormAluno()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Limpar()
        {
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            maskedTextBoxCPF.Clear();
            textBoxEndereco.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
            maskedTextBoxCep.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCelular.Clear();
            textBoxEmail.Clear();
            textBoxPeso.Clear();
            textBoxAltura.Clear();
            textBoxImc.Clear();
            textBoxObs.Clear();
            comboBoxStatus.SelectedIndex = -1;
            txtBoxSenha.Clear();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Cadastre um nome!");
            }
            else
            {

                aluno.NomeAluno = textBoxNome.Text;
                aluno.Cpf = maskedTextBoxCPF.Text;
                aluno.Endereco = textBoxEndereco.Text;
                aluno.Bairro = textBoxBairro.Text;
                aluno.Cidade = textBoxCidade.Text;
                aluno.Estado = textBoxEstado.Text;
                aluno.Cep = maskedTextBoxCep.Text;
                aluno.Tel = maskedTextBoxTelefone.Text;
                aluno.Cel = maskedTextBoxCelular.Text;
                aluno.Email = textBoxEmail.Text;
                aluno.Peso = decimal.Parse(textBoxPeso.Text);
                aluno.Altura = decimal.Parse(textBoxAltura.Text);
                aluno.Imc = decimal.Parse(textBoxImc.Text);
                aluno.Obs = textBoxObs.Text;
                aluno.StatusAluno = comboBoxStatus.Text;
                aluno.Senha = txtBoxSenha.Text;


                MessageBox.Show(controle.cadastrar(aluno));

                Limpar();

            }
        }

        private void textBoxAltura_Leave(object sender, EventArgs e)
        {
            decimal peso, altura, imc;
            peso = decimal.Parse(textBoxPeso.Text);
            altura = Convert.ToDecimal(textBoxAltura.Text);
            imc =peso / (altura * altura);
            textBoxImc.Text = imc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxPeso.Text+ "\n"+ textBoxAltura.Text);
        }

        private void textBoxAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            FormListaAlunos ListarAlunos = new FormListaAlunos();
            ListarAlunos.ShowDialog();
            this.Hide();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text == "")
            {
                MessageBox.Show("Cadastre um código!");
            }
            else
            {
                aluno.IdAluno = int.Parse(textBoxCodigo.Text);
                MessageBox.Show(controle.excluir(aluno));
                Limpar();
            }
        }

        private void buttonCons_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    aluno = controle.consultar(int.Parse(textBoxCodigo.Text));

                    if (aluno is null)
                    {
                        MessageBox.Show("Registro não encontrado!");
                        Limpar();
                    }
                    else
                    {
                        textBoxCodigo.Text = aluno.IdAluno.ToString();
                        textBoxNome.Text = aluno.NomeAluno;
                        maskedTextBoxTelefone.Text = aluno.Tel;
                        maskedTextBoxCelular.Text = aluno.Cel;
                        textBoxEmail.Text = aluno.Email;
                        maskedTextBoxCPF.Text = aluno.Cpf;
                        textBoxEndereco.Text = aluno.Endereco;
                        textBoxBairro.Text = aluno.Bairro;
                        textBoxCidade.Text = aluno.Cidade;
                        textBoxEstado.Text = aluno.Estado;
                        maskedTextBoxCep.Text = aluno.Cep;
                        textBoxPeso.Text = aluno.Peso.ToString();
                        textBoxAltura.Text = aluno.Altura.ToString();
                        textBoxImc.Text = aluno.Imc.ToString();
                        textBoxObs.Text = aluno.Obs;
                        comboBoxStatus.Text = aluno.StatusAluno;
                        txtBoxSenha.Text = aluno.Senha;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text == "")
            {
                MessageBox.Show("Cadastre um código!");
            }
            else
            {
                aluno.NomeAluno = textBoxNome.Text;
                aluno.Cpf = maskedTextBoxCPF.Text;
                aluno.Endereco = textBoxEndereco.Text;
                aluno.Bairro = textBoxBairro.Text;
                aluno.Cidade = textBoxCidade.Text;
                aluno.Estado = textBoxEstado.Text;
                aluno.Cep = maskedTextBoxCep.Text;
                aluno.Tel = maskedTextBoxTelefone.Text;
                aluno.Cel = maskedTextBoxCelular.Text;
                aluno.Email = textBoxEmail.Text;
                aluno.Peso = decimal.Parse(textBoxPeso.Text);
                aluno.Altura = decimal.Parse(textBoxAltura.Text);
                aluno.Imc = decimal.Parse(textBoxImc.Text);
                aluno.Obs = textBoxObs.Text;
                aluno.StatusAluno = comboBoxStatus.Text;
                aluno.Senha = txtBoxSenha.Text;

                MessageBox.Show(controle.alterar(aluno));
                Limpar();
            }
        }


        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }
    }
}