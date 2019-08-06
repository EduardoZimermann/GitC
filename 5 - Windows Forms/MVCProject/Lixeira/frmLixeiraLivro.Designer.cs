namespace MVCProject.Lixeira
{
    partial class frmLixeiraLivro
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.recoverCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoverr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recoverrecover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorasNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recoverrecover,
            this.idDataGridViewTextBoxColumn3,
            this.registroDataGridViewTextBoxColumn3,
            this.tituloDataGridViewTextBoxColumn3,
            this.isbnDataGridViewTextBoxColumn3,
            this.generosTipoDataGridViewTextBoxColumn,
            this.editorasNomeDataGridViewTextBoxColumn,
            this.sinopseDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.userIncDataGridViewTextBoxColumn,
            this.userAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livrosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 454);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 80);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lixeira de Livros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1024, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // recoverCommand
            // 
            this.recoverCommand.HeaderText = "Restaurar";
            this.recoverCommand.MinimumWidth = 6;
            this.recoverCommand.Name = "recoverCommand";
            this.recoverCommand.Text = "Restaurar";
            this.recoverCommand.UseColumnTextForButtonValue = true;
            this.recoverCommand.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // recover
            // 
            this.recover.DataPropertyName = "User Alt";
            this.recover.HeaderText = "Restaurar";
            this.recover.MinimumWidth = 6;
            this.recover.Name = "recover";
            this.recover.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn1
            // 
            this.registroDataGridViewTextBoxColumn1.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn1.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn1.Name = "registroDataGridViewTextBoxColumn1";
            this.registroDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn1
            // 
            this.isbnDataGridViewTextBoxColumn1.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn1.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn1.Name = "isbnDataGridViewTextBoxColumn1";
            this.isbnDataGridViewTextBoxColumn1.Width = 125;
            // 
            // recoverr
            // 
            this.recoverr.HeaderText = "Restaurar";
            this.recoverr.MinimumWidth = 6;
            this.recoverr.Name = "recoverr";
            this.recoverr.Text = "Restaurar";
            this.recoverr.UseColumnTextForButtonValue = true;
            this.recoverr.Width = 125;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn2
            // 
            this.registroDataGridViewTextBoxColumn2.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn2.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn2.Name = "registroDataGridViewTextBoxColumn2";
            this.registroDataGridViewTextBoxColumn2.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn2
            // 
            this.tituloDataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn2.Name = "tituloDataGridViewTextBoxColumn2";
            this.tituloDataGridViewTextBoxColumn2.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn2
            // 
            this.isbnDataGridViewTextBoxColumn2.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn2.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn2.Name = "isbnDataGridViewTextBoxColumn2";
            this.isbnDataGridViewTextBoxColumn2.Width = 125;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // recoverrecover
            // 
            this.recoverrecover.HeaderText = "Restaurar";
            this.recoverrecover.MinimumWidth = 6;
            this.recoverrecover.Name = "recoverrecover";
            this.recoverrecover.ReadOnly = true;
            this.recoverrecover.Text = "Restaurar";
            this.recoverrecover.UseColumnTextForButtonValue = true;
            this.recoverrecover.Width = 125;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn3
            // 
            this.registroDataGridViewTextBoxColumn3.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn3.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn3.Name = "registroDataGridViewTextBoxColumn3";
            this.registroDataGridViewTextBoxColumn3.ReadOnly = true;
            this.registroDataGridViewTextBoxColumn3.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn3
            // 
            this.tituloDataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn3.Name = "tituloDataGridViewTextBoxColumn3";
            this.tituloDataGridViewTextBoxColumn3.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn3.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn3
            // 
            this.isbnDataGridViewTextBoxColumn3.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn3.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn3.Name = "isbnDataGridViewTextBoxColumn3";
            this.isbnDataGridViewTextBoxColumn3.ReadOnly = true;
            this.isbnDataGridViewTextBoxColumn3.Width = 125;
            // 
            // generosTipoDataGridViewTextBoxColumn
            // 
            this.generosTipoDataGridViewTextBoxColumn.DataPropertyName = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.HeaderText = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generosTipoDataGridViewTextBoxColumn.Name = "generosTipoDataGridViewTextBoxColumn";
            this.generosTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generosTipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorasNomeDataGridViewTextBoxColumn
            // 
            this.editorasNomeDataGridViewTextBoxColumn.DataPropertyName = "Editoras.Nome";
            this.editorasNomeDataGridViewTextBoxColumn.HeaderText = "Editoras.Nome";
            this.editorasNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorasNomeDataGridViewTextBoxColumn.Name = "editorasNomeDataGridViewTextBoxColumn";
            this.editorasNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorasNomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinopseDataGridViewTextBoxColumn
            // 
            this.sinopseDataGridViewTextBoxColumn.DataPropertyName = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopseDataGridViewTextBoxColumn.Name = "sinopseDataGridViewTextBoxColumn";
            this.sinopseDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinopseDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // userIncDataGridViewTextBoxColumn
            // 
            this.userIncDataGridViewTextBoxColumn.DataPropertyName = "User Inc";
            this.userIncDataGridViewTextBoxColumn.HeaderText = "User Inc";
            this.userIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIncDataGridViewTextBoxColumn.Name = "userIncDataGridViewTextBoxColumn";
            this.userIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // userAltDataGridViewTextBoxColumn
            // 
            this.userAltDataGridViewTextBoxColumn.DataPropertyName = "User Alt";
            this.userAltDataGridViewTextBoxColumn.HeaderText = "User Alt";
            this.userAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userAltDataGridViewTextBoxColumn.Name = "userAltDataGridViewTextBoxColumn";
            this.userAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.userAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmLixeiraLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLixeiraLivro";
            this.Text = "frmLixeiraLivro";
            this.Load += new System.EventHandler(this.FrmLixeiraLivro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLixeiraLivro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLixeiraLivro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn recoverCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn recover;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn recoverr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn recoverrecover;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn generosTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorasNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livrosBindingSource;
    }
}