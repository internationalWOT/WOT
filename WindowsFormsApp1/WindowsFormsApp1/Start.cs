using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            PodCasts pc = new PodCasts();
            pc.Show();
        }

        private void kategorierButton_Click(object sender, EventArgs e)
        {

        }

        private void feedsButton_Click(object sender, EventArgs e)
        {
            Feeds f = new Feeds();
            f.Show();
        }
    }
}
