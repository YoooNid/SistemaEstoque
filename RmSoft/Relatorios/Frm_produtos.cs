﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RmSoft.Relatorios
{
    public partial class Frm_produtos : Form
    {
        public Frm_produtos()
        {
            InitializeComponent();
        }

        private void Frm_produtos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
