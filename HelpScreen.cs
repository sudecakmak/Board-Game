using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelab1
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
        }

        // Shows the about screen
        private void button1_Click(object sender, EventArgs e)
        {
            About form1 = new About();
            form1.ShowDialog();
        }
    }
}
