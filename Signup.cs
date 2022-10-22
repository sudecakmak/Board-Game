using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace prelab1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
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

        //List<String> passwordList = new List<String>();

        private void save_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"../../Information.xml");
            x.Element("logininfo").Add(
                    new XElement("User",
                                 new XElement("Username", username.Text),
                                 new XElement("Password", ComputeSha256Hash(password.Text)),
                                 new XElement("Name-Surname", namesurname.Text),
                                 new XElement("PhoneNumber", phonenumber.Text.ToString()),
                                 new XElement("Address", address.Text.ToString()),
                                 new XElement("City", city.Text),
                                 new XElement("Country", country.Text),
                                 new XElement("E-mail", email.Text),
                                 new XElement("Color", "-999"),
                                 new XElement("Difficulty", "-999"),
                                 new XElement("Shape", "-999"),
                                 new XElement("Score", "-999"),
                                 new XElement("BestScore", "-999")));

            x.Save(@"../../Information.xml");
            SqlSave();

            if (Login.instance.admin)
                MessageBox.Show("New user added!");
            else
                MessageBox.Show("Signed Up!");

            //passwordList.Add(password.Text);
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            ActiveControl = username;
        }

        public void SqlSave()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OOP;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into OOP values (@username,@score,@password)", con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@score", "0");
            cmd.Parameters.AddWithValue("@password", ComputeSha256Hash(password.Text));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                password.Focus();
            }
        }
    }
}
