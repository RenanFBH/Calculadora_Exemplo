﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Exemplo_WF
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void calculadora1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objeto
            frmCalculos objCalculos = new frmCalculos();
            //
            objCalculos.MdiParent = this;
            //Mostrando o objeto
            objCalculos.Show();
        }
    }
}
