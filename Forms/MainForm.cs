using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;



namespace CambiaNombres.Forms
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            OneForm of = new OneForm();
            of.Show();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            AllForm af = new AllForm();
            af.Show();
        }
    }
}
