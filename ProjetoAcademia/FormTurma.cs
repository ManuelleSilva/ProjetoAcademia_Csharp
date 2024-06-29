using System;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class FormTurma : Form
    {
        public FormTurma()
        {
            InitializeComponent();
        }

        clTurma Turma = new clTurma();
        clControleTurma controle = new clControleTurma();

        private void Limpar()
        {
            textBoxdesc.Clear();
            textBoxIdProfessor.Clear();
            textBoxIdTurma.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }

        private void buttonBuscaProfessor_Click(object sender, EventArgs e)
        {
            FormListaProf listaProf = new FormListaProf();
            listaProf.ShowDialog();
            textBoxIdProfessor.Text = clGlobais.v1.ToString();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            FormListaTurmas ListarTurmas = new FormListaTurmas();
            ListarTurmas.ShowDialog();
            this.Hide();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdProfessor.Text))
            {
                MessageBox.Show("O campo professor não pode estar vazio!");
            }
            else
            {
                Turma.Descricao = textBoxdesc.Text;
                Turma.Horarioinicio = TimeSpan.Parse(maskedTextBox1.Text);
                Turma.Horariotermino = TimeSpan.Parse(maskedTextBox2.Text);
                Turma.IdProfessor = int.Parse(textBoxIdProfessor.Text);
                Turma.StatusTurma = comboBoxStatus.Text;

                MessageBox.Show(controle.cadastrar(Turma));
                Limpar();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            Turma.IdProfessor = int.Parse(textBoxIdProfessor.Text);
            Turma.Horarioinicio = TimeSpan.Parse(maskedTextBox1.Text);
            Turma.Horariotermino = TimeSpan.Parse(maskedTextBox2.Text);
            Turma.IdTurma = int.Parse(textBoxIdTurma.Text);
            Turma.Descricao = textBoxdesc.Text;
            Turma.StatusTurma = comboBoxStatus.Text;
            MessageBox.Show(controle.alterar(Turma));
            Limpar();
        }

        private void buttonCons_Click(object sender, EventArgs e)
        {
            try
            {
                Turma = controle.consultar(int.Parse(textBoxIdTurma.Text));

                if (Turma == null)
                {
                    MessageBox.Show("Registro não encontrado!");
                    Limpar();
                }
                else
                {
                    textBoxIdTurma.Text = Turma.IdTurma.ToString();
                    textBoxIdProfessor.Text = Turma.IdProfessor.ToString();
                    textBoxdesc.Text = Turma.Descricao;
                    maskedTextBox1.Text = Turma.Horarioinicio.ToString();
                    maskedTextBox2.Text = Turma.Horariotermino.ToString();
                    comboBoxStatus.Text = Turma.StatusTurma.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
