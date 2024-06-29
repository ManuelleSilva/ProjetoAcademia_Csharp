using System;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class FormMatricula : Form
    {
        private clMatricula matricula = new clMatricula();
        private clControleMatricula controle = new clControleMatricula();

        public FormMatricula()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBoxIdAluno.Clear();
            textBoxIdMatricula.Clear();
            textBoxIdTurma.Clear();
            maskedTextBoxData.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonBuscaAluno_Click(object sender, EventArgs e)
        {
            FormListaAlunos listaAlunos = new FormListaAlunos();
            listaAlunos.ShowDialog();
            textBoxIdAluno.Text = clGlobais.v2.ToString();
        }

        private void FormMatricula_Load(object sender, EventArgs e)
        {
            maskedTextBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void buttonBuscaTurma_Click(object sender, EventArgs e)
        {
            FormListaTurmas listaTurmas = new FormListaTurmas();
            listaTurmas.ShowDialog();
            textBoxIdTurma.Text = clGlobais.v3.ToString();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            FormListaMatricula listarMatriculas = new FormListaMatricula();
            listarMatriculas.ShowDialog();
            this.Hide();
        }

        // CADASTRAR
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxIdAluno.Text == "" || textBoxIdTurma.Text == "")
            {
                MessageBox.Show("Os campos Turma e Aluno não podem estar vazios!");
            }
            else
            {
                try
                {
                    matricula.DataMatricula = DateTime.ParseExact(maskedTextBoxData.Text, "dd/MM/yyyy", null);
                    matricula.IdTurma = int.Parse(textBoxIdTurma.Text);
                    matricula.IdAluno = int.Parse(textBoxIdAluno.Text);
                    matricula.StatusMatricula = comboBoxStatus.Text;

                    MessageBox.Show(controle.cadastrar(matricula));

                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar matrícula: " + ex.Message);
                }
            }
        }

        // ATUALIZAR
        private void btnAtua_Click(object sender, EventArgs e)
        {
            if (textBoxIdMatricula.Text == "")
            {
                MessageBox.Show("Informe o ID da matrícula para atualizar!");
                return;
            }

            try
            {
                matricula.IdMatricula = int.Parse(textBoxIdMatricula.Text);
                matricula.DataMatricula = DateTime.ParseExact(maskedTextBoxData.Text, "dd/MM/yyyy", null);
                matricula.IdTurma = int.Parse(textBoxIdTurma.Text);
                matricula.IdAluno = int.Parse(textBoxIdAluno.Text);
                matricula.StatusMatricula = comboBoxStatus.Text;

                MessageBox.Show(controle.alterar(matricula));

                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar matrícula: " + ex.Message);
            }
        }

        // CONSULTAR
        private void buttonCons_Click(object sender, EventArgs e)
        {
            if (textBoxIdMatricula.Text == "")
            {
                MessageBox.Show("Informe o ID da matrícula para consultar!");
                return;
            }

            try
            {
                matricula = controle.consultar(int.Parse(textBoxIdMatricula.Text));

                if (matricula == null)
                {
                    MessageBox.Show("Registro não encontrado!");
                    Limpar();
                }
                else
                {
                    textBoxIdMatricula.Text = matricula.IdMatricula.ToString();
                    textBoxIdTurma.Text = matricula.IdTurma.ToString();
                    textBoxIdAluno.Text = matricula.IdAluno.ToString();
                    maskedTextBoxData.Text = matricula.DataMatricula.ToString("dd/MM/yyyy");
                    comboBoxStatus.Text = matricula.StatusMatricula.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar matrícula: " + ex.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
