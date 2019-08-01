﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2.Edicao
{
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridViewExample2.QuerysInnerJoinDataSet.MarcasRow marcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            textBox1.Text = marcasRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow.Nome = textBox1.Text;

            this.Close();
        }
    }
}
