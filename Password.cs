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
    public partial class Password : Form
    {
        public static Password instance;
        public string passwordcontrol;
        public Password()
        {
            InitializeComponent();
            instance = this;
            ActiveControl = textBoxpassword;
        }

        // The password check is needed to update or delete own information
        private void btnenter_Click(object sender, EventArgs e)
        {
            passwordcontrol = textBoxpassword.Text;

            if (Login.instance.password == passwordcontrol)
            {
                Close();
            }
            else
            {
                MessageBox.Show("False password!\nTry Again!");
            }
        }

        // Pressing the “Enter” key has the same functionality as clicking on the login button
        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnenter.PerformClick();
            }
        }
    }
}
