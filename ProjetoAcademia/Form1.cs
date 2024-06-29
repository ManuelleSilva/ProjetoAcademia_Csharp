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

   
    public partial class Form1 : Form
    {

        cl_Conexao c = new cl_Conexao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(c.conectar());
        }


        private void buttonAluno_Click(object sender, EventArgs e)
        {
            FormAluno Aluno = new FormAluno();
            Aluno.ShowDialog();
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            FormProfessor Professor = new FormProfessor();
            Professor.ShowDialog();
        }

        private void buttonTurma_Click(object sender, EventArgs e)
        {
            FormTurma Turma = new FormTurma();
            Turma.ShowDialog();
        }

        private void buttonMatricula_Click(object sender, EventArgs e)
        {
            FormMatricula Matricula = new FormMatricula();
            Matricula.ShowDialog();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
