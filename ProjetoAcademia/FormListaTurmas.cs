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
    public partial class FormListaTurmas : Form
    {

        FormTurma formTurma = new FormTurma();

        clControleTurma controle = new clControleTurma();

        public FormListaTurmas()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string x = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clGlobais.v3 = int.Parse(x);
            this.Hide();
        }

        private void FormListaTurmas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }
    }
}
