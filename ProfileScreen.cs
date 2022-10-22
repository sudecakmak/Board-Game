using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace prelab1
{
    public partial class ProfileScreen : Form
    {
        // allows to retrieve data
        public static ProfileScreen instance;
        public ProfileScreen()
        {
            InitializeComponent();
            instance = this;
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

        // Update ( saves changes )
        private void btnsave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            if (Login.instance.admin)  // for admin
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (Manager.instance.user == node.SelectSingleNode("Username").InnerText)
                    {
                        node.SelectSingleNode("Username").InnerText = textusername.Text;
                        node.SelectSingleNode("Password").InnerText = ComputeSha256Hash(textpassword.Text);
                        node.SelectSingleNode("Name-Surname").InnerText = textnamesurname.Text;
                        node.SelectSingleNode("PhoneNumber").InnerText = textphonenumber.Text;
                        node.SelectSingleNode("Address").InnerText = textaddress.Text;
                        node.SelectSingleNode("City").InnerText = textcity.Text;
                        node.SelectSingleNode("Country").InnerText = textcountry.Text;
                        node.SelectSingleNode("E-mail").InnerText = textemail.Text;
                        node.SelectSingleNode("E-mail").InnerText = textemail.Text;
                        node.SelectSingleNode("BestScore").InnerText = txtboxbestscore.Text;

                        MessageBox.Show("User informations are updated!");
                    }
                }
            }
            else // for user
            {
                Password form7 = new Password();
                form7.ShowDialog();

                // The password check is needed to update own information
                if (Login.instance.password == Password.instance.passwordcontrol)
                {
                    foreach (XmlNode node in doc.SelectNodes("//User"))
                    {
                        if (Login.instance.user == node.SelectSingleNode("Username").InnerText)
                        {
                            node.SelectSingleNode("Username").InnerText = textusername.Text;
                            node.SelectSingleNode("Password").InnerText = textpassword.Text;
                            node.SelectSingleNode("Name-Surname").InnerText = textnamesurname.Text;
                            node.SelectSingleNode("PhoneNumber").InnerText = textphonenumber.Text;
                            node.SelectSingleNode("Address").InnerText = textaddress.Text;
                            node.SelectSingleNode("City").InnerText = textcity.Text;
                            node.SelectSingleNode("Country").InnerText = textcountry.Text;
                            node.SelectSingleNode("E-mail").InnerText = textemail.Text;
                            node.SelectSingleNode("BestScore").InnerText = txtboxbestscore.Text;

                            MessageBox.Show("Your informations are updated!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must enter your password for update!");
                }
            }

            Close();

            doc.Save(@"../../Information.xml");
        }

        // Upload the users information (Profile screen)
        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            ActiveControl = textpassword;
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            if (Login.instance.admin)  // for admin
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (Manager.instance.user == node.SelectSingleNode("Username").InnerText)
                    {
                        textusername.Text = node.SelectSingleNode("Username").InnerText;
                        textpassword.Text = node.SelectSingleNode("Password").InnerText;
                        textnamesurname.Text = node.SelectSingleNode("Name-Surname").InnerText;
                        textphonenumber.Text = node.SelectSingleNode("PhoneNumber").InnerText;
                        textaddress.Text = node.SelectSingleNode("Address").InnerText;
                        textcity.Text = node.SelectSingleNode("City").InnerText;
                        textcountry.Text = node.SelectSingleNode("Country").InnerText;
                        textemail.Text = node.SelectSingleNode("E-mail").InnerText;
                        txtboxbestscore.Text = node.SelectSingleNode("BestScore").InnerText;
                    }

                }
            }
            else   // for user
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (Login.instance.user == node.SelectSingleNode("Username").InnerText)
                    {
                        textusername.Text = node.SelectSingleNode("Username").InnerText;
                        textpassword.Text = node.SelectSingleNode("Password").InnerText;
                        textnamesurname.Text = node.SelectSingleNode("Name-Surname").InnerText;
                        textphonenumber.Text = node.SelectSingleNode("PhoneNumber").InnerText;
                        textaddress.Text = node.SelectSingleNode("Address").InnerText;
                        textcity.Text = node.SelectSingleNode("City").InnerText;
                        textcountry.Text = node.SelectSingleNode("Country").InnerText;
                        textemail.Text = node.SelectSingleNode("E-mail").InnerText;
                        txtboxbestscore.Text = node.SelectSingleNode("BestScore").InnerText;
                    }
                }

            }
        }

        public void SqlDelete()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OOP;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete OOP where username=@username", con);

            cmd.Parameters.AddWithValue("@username", textusername.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Deletes the user
        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlDelete();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            if (Login.instance.admin)  // for admin
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (Manager.instance.user == node.SelectSingleNode("Username").InnerText)
                    {
                        node.ParentNode.RemoveChild(node);
                        doc.Save(@"../../Information.xml");
                    }
                }
                MessageBox.Show("User has been deleted!");
            }
            else  // for user
            {
                Password form7 = new Password();
                form7.ShowDialog();

                // The password check is needed to update or delete own information
                if (Login.instance.password == Password.instance.passwordcontrol)
                {
                    foreach (XmlNode node in doc.SelectNodes("//User"))
                    {
                        if (Login.instance.user == node.SelectSingleNode("Username").InnerText)
                        {
                            node.ParentNode.RemoveChild(node);
                            MessageBox.Show("Your account has been deleted!");
                            doc.Save(@"../../Information.xml");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must enter your password for delete your profile!");
                }
            }

            Close();
        }

        // cannot change username
        private void textusername_TextChanged(object sender, EventArgs e)
        {
            textusername.ReadOnly = true;
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            //textpassword.UseSystemPasswordChar = false;
            //textpassword.PasswordChar = '\0';
        }
    }
}
