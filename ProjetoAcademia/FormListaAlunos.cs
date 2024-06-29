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
    public partial class FormListaAlunos : Form
    {



        FormAluno formAluno = new FormAluno() ;

        clControleAluno controle = new clControleAluno();

        
        public FormListaAlunos()
        {
            InitializeComponent();
           
        }
        
        private void FormListaAlunos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string x = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clGlobais.v2= int.Parse(x);
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
