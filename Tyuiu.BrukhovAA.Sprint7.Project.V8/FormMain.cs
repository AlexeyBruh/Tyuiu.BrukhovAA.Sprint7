using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BrukhovAA.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelMainMenu_BAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuide_BAA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            FormBaseData formBD = new FormBaseData();
            formBD.ShowDialog();
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
