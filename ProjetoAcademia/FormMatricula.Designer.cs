
namespace ProjetoAcademia
{
    partial class FormMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatricula));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdTurma = new System.Windows.Forms.TextBox();
            this.buttonBuscaAluno = new System.Windows.Forms.Button();
            this.buttonBuscaTurma = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonCons = new System.Windows.Forms.Button();
            this.btnAtua = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Matrícula:";
            // 
            // textBoxIdMatricula
            // 
            this.textBoxIdMatricula.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxIdMatricula.Location = new System.Drawing.Point(40, 58);
            this.textBoxIdMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdMatricula.Name = "textBoxIdMatricula";
            this.textBoxIdMatricula.Size = new System.Drawing.Size(193, 29);
            this.textBoxIdMatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da Matrícula:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.maskedTextBoxData.Location = new System.Drawing.Point(40, 146);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(99, 29);
            this.maskedTextBoxData.TabIndex = 3;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aluno:";
            // 
            // textBoxIdAluno
            // 
            this.textBoxIdAluno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxIdAluno.Location = new System.Drawing.Point(40, 218);
            this.textBoxIdAluno.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdAluno.Name = "textBoxIdAluno";
            this.textBoxIdAluno.Size = new System.Drawing.Size(193, 29);
            this.textBoxIdAluno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma:";
            // 
            // textBoxIdTurma
            // 
            this.textBoxIdTurma.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxIdTurma.Location = new System.Drawing.Point(40, 294);
            this.textBoxIdTurma.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdTurma.Name = "textBoxIdTurma";
            this.textBoxIdTurma.Size = new System.Drawing.Size(193, 29);
            this.textBoxIdTurma.TabIndex = 7;
            // 
            // buttonBuscaAluno
            // 
            this.buttonBuscaAluno.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBuscaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaAluno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonBuscaAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonBuscaAluno.Location = new System.Drawing.Point(277, 218);
            this.buttonBuscaAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscaAluno.Name = "buttonBuscaAluno";
            this.buttonBuscaAluno.Size = new System.Drawing.Size(100, 31);
            this.buttonBuscaAluno.TabIndex = 8;
            this.buttonBuscaAluno.Text = "Buscar";
            this.buttonBuscaAluno.UseVisualStyleBackColor = true;
            this.buttonBuscaAluno.Click += new System.EventHandler(this.buttonBuscaAluno_Click);
            // 
            // buttonBuscaTurma
            // 
            this.buttonBuscaTurma.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBuscaTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaTurma.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonBuscaTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonBuscaTurma.Location = new System.Drawing.Point(277, 294);
            this.buttonBuscaTurma.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscaTurma.Name = "buttonBuscaTurma";
            this.buttonBuscaTurma.Size = new System.Drawing.Size(100, 31);
            this.buttonBuscaTurma.TabIndex = 8;
            this.buttonBuscaTurma.Text = "Buscar";
            this.buttonBuscaTurma.UseVisualStyleBackColor = true;
            this.buttonBuscaTurma.Click += new System.EventHandler(this.buttonBuscaTurma_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonListar.Location = new System.Drawing.Point(25, 139);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(111, 33);
            this.buttonListar.TabIndex = 9;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = false;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonCadastrar.Location = new System.Drawing.Point(25, 15);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(111, 33);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxIdAluno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIdMatricula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBoxData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonBuscaTurma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonBuscaAluno);
            this.groupBox1.Controls.Add(this.textBoxIdTurma);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(161, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 462);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matricula";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Bloqueado"});
            this.comboBoxStatus.Location = new System.Drawing.Point(40, 374);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(160, 30);
            this.comboBoxStatus.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(36, 353);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 22);
            this.label15.TabIndex = 22;
            this.label15.Text = "Status:";
            // 
            // buttonCons
            // 
            this.buttonCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCons.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonCons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonCons.Location = new System.Drawing.Point(25, 97);
            this.buttonCons.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCons.Name = "buttonCons";
            this.buttonCons.Size = new System.Drawing.Size(111, 33);
            this.buttonCons.TabIndex = 16;
            this.buttonCons.Text = "Consultar";
            this.buttonCons.UseVisualStyleBackColor = false;
            this.buttonCons.Click += new System.EventHandler(this.buttonCons_Click);
            // 
            // btnAtua
            // 
            this.btnAtua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAtua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtua.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAtua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.btnAtua.Location = new System.Drawing.Point(25, 56);
            this.btnAtua.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtua.Name = "btnAtua";
            this.btnAtua.Size = new System.Drawing.Size(111, 33);
            this.btnAtua.TabIndex = 15;
            this.btnAtua.Text = "Atualizar";
            this.btnAtua.UseVisualStyleBackColor = false;
            this.btnAtua.Click += new System.EventHandler(this.btnAtua_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.buttonLimpar.Location = new System.Drawing.Point(25, 444);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(111, 33);
            this.buttonLimpar.TabIndex = 17;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // FormMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCons);
            this.Controls.Add(this.btnAtua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula";
            this.Load += new System.EventHandler(this.FormMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdTurma;
        private System.Windows.Forms.Button buttonBuscaAluno;
        private System.Windows.Forms.Button buttonBuscaTurma;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCons;
        private System.Windows.Forms.Button btnAtua;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label15;
    }
}