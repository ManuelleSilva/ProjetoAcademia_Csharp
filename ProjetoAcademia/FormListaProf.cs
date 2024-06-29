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
    public partial class FormListaProf : Form
    {

        FormProfessor formProfessor = new FormProfessor();

        ClControleProfessor controle = new ClControleProfessor();


        public FormListaProf()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string x = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clGlobais.v1 = int.Parse(x);
            this.Hide();
        }

        private void FormListaProf_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
