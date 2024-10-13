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
    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1;

        public Student SelectedStudent
        {
            get { return student1; }
            set { student1 = value; }
        }
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }
       
      


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student();
            student1.Ime = txtime.Text;
            student1.Prezime = txtprezime.Text;
            student1.BrojIndeksa = txtindex.Text;
            student1.Smjer = combosmjer.SelectedItem.ToString();
            student1.DatumRodjenja = dateTimePickerdatumrođ.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnotkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
