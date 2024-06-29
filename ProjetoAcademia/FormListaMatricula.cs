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
    public partial class FormListaMatricula : Form
    {

        FormMatricula formMatricula = new FormMatricula();

        clControleMatricula controle = new clControleMatricula();



        public FormListaMatricula()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string x = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
        }

        private void FormListaMatricula_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }
    }
}
