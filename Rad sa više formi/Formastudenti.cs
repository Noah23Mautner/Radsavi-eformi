using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rad_sa_više_formi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnunesinovogstudenta_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();
            if (rez == DialogResult.OK)
            {
                listBoxstudenti.Items.Add(frm.Student1.ToString());
            }
        }

        private void btnobrisisvestudente_Click(object sender, EventArgs e)
        {

            listBoxstudenti.Items.Clear();

        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (listBoxstudenti.SelectedIndex >= 0)
            {
                listBoxstudenti.Items.RemoveAt(listBoxstudenti.SelectedIndex);
            }
        }
    }
}
