namespace MVCProject.View
{
    partial class frmLivros
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
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.autorCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.livroAutorTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCollum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCollum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.autorCollum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorasNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Autor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosTipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorasNomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.edit,
            this.Autor,
            this.idDataGridViewTextBoxColumn3,
            this.registroDataGridViewTextBoxColumn3,
            this.tituloDataGridViewTextBoxColumn3,
            this.isbnDataGridViewTextBoxColumn3,
            this.generosTipoDataGridViewTextBoxColumn1,
            this.editorasNomeDataGridViewTextBoxColumn1,
            this.sinopseDataGridViewTextBoxColumn1,
            this.observacoesDataGridViewTextBoxColumn1,
            this.ativoDataGridViewCheckBoxColumn1,
            this.userIncDataGridViewTextBoxColumn,
            this.userAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livrosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(729, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(871, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lixeira";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 80);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Livros";
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
            // deleteCommand
            // 
            this.deleteCommand.HeaderText = "Deletar";
            this.deleteCommand.MinimumWidth = 6;
            this.deleteCommand.Name = "deleteCommand";
            this.deleteCommand.Text = "Deletar";
            this.deleteCommand.UseColumnTextForButtonValue = true;
            this.deleteCommand.Width = 125;
            // 
            // editCommand
            // 
            this.editCommand.HeaderText = "Editar";
            this.editCommand.MinimumWidth = 6;
            this.editCommand.Name = "editCommand";
            this.editCommand.Text = "Editar";
            this.editCommand.UseColumnTextForButtonValue = true;
            this.editCommand.Width = 125;
            // 
            // autorCommand
            // 
            this.autorCommand.HeaderText = "Autores";
            this.autorCommand.MinimumWidth = 6;
            this.autorCommand.Name = "autorCommand";
            this.autorCommand.Text = "Autor(es)";
            this.autorCommand.UseColumnTextForButtonValue = true;
            this.autorCommand.Width = 125;
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
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // livroAutorTableAdapter
            // 
            this.livroAutorTableAdapter.ClearBeforeFill = true;
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
            this.registroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.registroDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn1
            // 
            this.isbnDataGridViewTextBoxColumn1.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn1.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn1.Name = "isbnDataGridViewTextBoxColumn1";
            this.isbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.isbnDataGridViewTextBoxColumn1.Width = 125;
            // 
            // deleteCollum
            // 
            this.deleteCollum.HeaderText = "Deletar";
            this.deleteCollum.MinimumWidth = 6;
            this.deleteCollum.Name = "deleteCollum";
            this.deleteCollum.Text = "Deletar";
            this.deleteCollum.UseColumnTextForButtonValue = true;
            this.deleteCollum.Width = 125;
            // 
            // editCollum
            // 
            this.editCollum.HeaderText = "Editar";
            this.editCollum.MinimumWidth = 6;
            this.editCollum.Name = "editCollum";
            this.editCollum.Text = "Editar";
            this.editCollum.UseColumnTextForButtonValue = true;
            this.editCollum.Width = 125;
            // 
            // autorCollum
            // 
            this.autorCollum.HeaderText = "Autor(es)";
            this.autorCollum.MinimumWidth = 6;
            this.autorCollum.Name = "autorCollum";
            this.autorCollum.Text = "Autor(es)";
            this.autorCollum.UseColumnTextForButtonValue = true;
            this.autorCollum.Width = 125;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
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
            // generosTipoDataGridViewTextBoxColumn
            // 
            this.generosTipoDataGridViewTextBoxColumn.DataPropertyName = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generosTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generosTipoDataGridViewTextBoxColumn.Name = "generosTipoDataGridViewTextBoxColumn";
            this.generosTipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorasNomeDataGridViewTextBoxColumn
            // 
            this.editorasNomeDataGridViewTextBoxColumn.DataPropertyName = "Editoras.Nome";
            this.editorasNomeDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editorasNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorasNomeDataGridViewTextBoxColumn.Name = "editorasNomeDataGridViewTextBoxColumn";
            this.editorasNomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinopseDataGridViewTextBoxColumn
            // 
            this.sinopseDataGridViewTextBoxColumn.DataPropertyName = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopseDataGridViewTextBoxColumn.Name = "sinopseDataGridViewTextBoxColumn";
            this.sinopseDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Deletar";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Deletar";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editar";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Editar";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor(es)";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Text = "Autor(es)";
            this.Autor.UseColumnTextForButtonValue = true;
            this.Autor.Width = 125;
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
            // generosTipoDataGridViewTextBoxColumn1
            // 
            this.generosTipoDataGridViewTextBoxColumn1.DataPropertyName = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn1.HeaderText = "Genero";
            this.generosTipoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.generosTipoDataGridViewTextBoxColumn1.Name = "generosTipoDataGridViewTextBoxColumn1";
            this.generosTipoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.generosTipoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // editorasNomeDataGridViewTextBoxColumn1
            // 
            this.editorasNomeDataGridViewTextBoxColumn1.DataPropertyName = "Editoras.Nome";
            this.editorasNomeDataGridViewTextBoxColumn1.HeaderText = "Editora";
            this.editorasNomeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.editorasNomeDataGridViewTextBoxColumn1.Name = "editorasNomeDataGridViewTextBoxColumn1";
            this.editorasNomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.editorasNomeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sinopseDataGridViewTextBoxColumn1
            // 
            this.sinopseDataGridViewTextBoxColumn1.DataPropertyName = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn1.HeaderText = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sinopseDataGridViewTextBoxColumn1.Name = "sinopseDataGridViewTextBoxColumn1";
            this.sinopseDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sinopseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn1
            // 
            this.observacoesDataGridViewTextBoxColumn1.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn1.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn1.Name = "observacoesDataGridViewTextBoxColumn1";
            this.observacoesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn1
            // 
            this.ativoDataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn1.Name = "ativoDataGridViewCheckBoxColumn1";
            this.ativoDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn1.Width = 125;
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
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLivros";
            this.Text = "frmLivros";
            this.Load += new System.EventHandler(this.FrmLivros_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLivros_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLivros_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCommand;
        private System.Windows.Forms.DataGridViewButtonColumn editCommand;
        private System.Windows.Forms.DataGridViewButtonColumn autorCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCollum;
        private System.Windows.Forms.DataGridViewButtonColumn editCollum;
        private System.Windows.Forms.DataGridViewButtonColumn autorCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn generosTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorasNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn generosTipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorasNomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
    }
}