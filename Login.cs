using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace prelab1
{
    public partial class Login : Form
    {
        public static Login instance;
        public Login()
        {
            InitializeComponent();
            instance = this;
        }

        // allows it to be used in other forms
        public string user;
        public string password; 
        public bool admin;  // Indicates whether the admin is logged in.

        // Default username and passwords
        private void rbtnadmin_CheckedChanged(object sender, EventArgs e)
        {
            admin = true;
            txtpassword.Text = "admin";
            txtusername.Text = "Admin";
        }

        // Default username and passwords
        private void rbtnuser_CheckedChanged_1(object sender, EventArgs e)
        {
            admin = false;
            txtpassword.Text = "user";
            txtusername.Text = "User";
        }

        //Hashed the password
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
               
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
               
                return builder.ToString();
            }
        }
        
        // Login button checks the entered information if info true shows main game window else show warning message
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Save last username
            Properties.Settings.Default.username = txtusername.Text;
            Properties.Settings.Default.Save();

            user = txtusername.Text;
            password = txtpassword.Text;

            bool cont = false;
            XmlDocument doc=new XmlDocument();
            doc.Load(@"../../Information.xml");

            foreach (XmlNode node in doc.SelectNodes("//Admin"))
            {
                string Username = node.SelectSingleNode("Username").InnerText;
                string Password = node.SelectSingleNode("Password").InnerText.ToString();

                if(Username== txtusername.Text && Password == ComputeSha256Hash(txtpassword.Text))
                {
                    Hide();
                    MainGame form2 = new MainGame();
                    //Keeps the user name in memory to save the settings at the end and sends it to the settings section
                    form2.Username = txtusername.Text;
                    form2.Password = ComputeSha256Hash(txtpassword.Text);
                    form2.ShowDialog();
                  
                    cont = true;
                    break;
                }
            }

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                string Username = node.SelectSingleNode("Username").InnerText;
                string Password = node.SelectSingleNode("Password").InnerText.ToString();

                if (Username == txtusername.Text && Password == ComputeSha256Hash(txtpassword.Text))
                {
                    MessageBox.Show("Successfully logged in!");
                    Hide();
                    MainGame form2 = new MainGame();
                    //Keeps the user name in memory to save the settings at the end and sends it to the settings section
                    form2.Username = txtusername.Text;
                    form2.Password = ComputeSha256Hash(txtpassword.Text);
                    form2.ShowDialog();

                    cont = true;
                    break;
                }
            }

            if (cont == false)
            {
                MessageBox.Show("Can't login!");
            }
        }

        // Pressing the “Enter” key has the same functionality as clicking on the login button
        // Pressing the “Tab” key focuses login button
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.PerformClick();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                btnlogin.Focus();
            }
        }

        // At the first run, the username field focused
        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txtusername;

            // Remembers the last username
            txtusername.Text = Properties.Settings.Default.username;

        }

        // Pressing the “Tab” key focuses password field
        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only letters are allowed in username
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            if (e.KeyChar == (char)Keys.Tab)
            {
                txtpassword.Focus();
            }
        }

        // Pressing the “Tab” key focuses username field
        private void btnlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                ActiveControl = txtusername;
            }
        }

        // Opens the sing up screen
        private void Signup_Click(object sender, EventArgs e)
        {
            Signup form4 = new Signup();
            form4.ShowDialog();
        }

        // Pressing the “Enter” key has the same functionality as clicking on the login button
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        // Show-Hide password when checkbox changed
        private void chkboxshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxshow.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        // Password field show the characters as ‘******’
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
      
    }
}
