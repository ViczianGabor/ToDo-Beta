using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDo_Beta
{
    public partial class frmKezdo : Form
    {
        private List<string> todos = new List<string>();

        public frmKezdo()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("ToDoItems.txt");
            while (!sr.EndOfStream)
            {
                todos.Add(sr.ReadLine());
            }
            sr.Close();
        }






        private void frmKezdo_Shown(object sender, EventArgs e)
        {
            tbBevitel.Text = " ";
            lbToDo.Items.Clear();
            tbBevitel.Focus();
            
            
        }

        private void btnListabol_Click(object sender, EventArgs e)
        {
            frmLista formLista = new frmLista(todos);
            
            var result = formLista.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbBevitel.Text = formLista.selectedTodo;
            }
            tbBevitel.Focus();
            tbBevitel.SelectionStart = tbBevitel.SelectionLength;
            tbBevitel.SelectionLength = 0;



        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            tbBevitel.Text = tbBevitel.Text.Trim(' ');
            if (tbBevitel.Text != "" && !lbToDo.Items.Contains(tbBevitel.Text))
            {
                lbToDo.Items.Add(tbBevitel.Text);
                tbBevitel.Clear();
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            lbToDo.Items.Clear();
            tbBevitel.Focus();

        }

        private void btnKivesz_Click(object sender, EventArgs e)
        {

        }

        private void mBeolvasas_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                lbToDo.Items.Clear();
                StreamReader sr = new StreamReader(ofdMegnyitas.FileName);
                while (!sr.EndOfStream)
                {
                    lbToDo.Items.Add(sr.ReadLine());
                }
               
                sr.Close();
                MessageBox.Show("Sikeres beolvasás", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private string FileName()
        {
            var datum = DateTime.Now;
            string ev = datum.Year.ToString();
            string honap = "";
            if (datum.Month < 10)
            {
                honap = 0 + datum.Month.ToString();
            }
            else
            {
                honap = datum.Month.ToString();
            }

            string nap = "";
            if (datum.Day <10)
            {
                nap = 0 + datum.Day.ToString();
            }
            else
            {
                nap = datum.Day.ToString();
            }

            return ev + honap + nap;
        }


        private void mMentes_Click(object sender, EventArgs e)
        {
            if (lbToDo.Items.Count !=0)
            {
                sfdMentes.FileName = FileName();
                if (sfdMentes.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdMentes.FileName);
                    foreach (var item in lbToDo.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                    MessageBox.Show("Sikeres mentés", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs mit menteni","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
