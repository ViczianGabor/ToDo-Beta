﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDo_Beta
{
    public partial class frmLista : Form
    {
        public string selectedTodo { get; set; }

        public frmLista(List<string> todos)
        {
            
            InitializeComponent();
            lbTargyak.Items.Clear();
            foreach (var item in todos)
            {
                lbTargyak.Items.Add(item);
            }
        }

        private void lbTargyak_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            selectedTodo = lbTargyak.SelectedItem.ToString();
            this.Close();
            
        }

        private void frmLista_Shown(object sender, EventArgs e)
        {
            lbTargyak.SelectedIndex = 0;
            
        }


    }
}
