using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace prelab1
{
    public partial class Manager : Form
    {
        // provides sending data to the profile screen
        public static Manager instance;
        // shows if list with scores or not
        bool withscores = false;

        public Manager()
        {
            InitializeComponent();
            instance = this;
        }

        // data to be sent
        public string user;

        // Add users to listview
        public void ShowUsers()
        {
            withscores = false;
            listviewusers.Clear();
            listviewusers.Columns.Add("Users", 600);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                string Username = node.SelectSingleNode("Username").InnerText;
                ListViewItem item = new ListViewItem(Username);
                listviewusers.Items.Add(item);
            }

            listviewusers.Visible = true;
        }

        // list all users
        private void btnallusers_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        // adds a user
        private void btnadduser_Click(object sender, EventArgs e)
        {
            withscores = false;
            Signup form4 = new Signup();
            form4.ShowDialog();
            listviewusers.Clear();
            ShowUsers();
        }

        // updates a user
        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        // deletes a user
        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            ShowUsers();

            for (int i = 0; i < listviewusers.Items.Count; i++)
            {
                if (listviewusers.Items[i].Selected)
                {
                    listviewusers.Items[i].Remove();
                }
            }
        }

        // Show users by ascending scores
        private void ascendingScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withscores = true;
            listviewusers.Clear();
            listviewusers.Visible = true;
            listviewusers.Columns.Add("BestScore", 140);
            listviewusers.Columns.Add("User", 600);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");
            int Points;
            String Username = null;

            List<String> point = new List<String>();

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                Points = Convert.ToInt32(node.SelectSingleNode("BestScore").InnerText);
                point.Add(Points.ToString());
            }

            point.Sort();

            for (int i = point.Count() - 1; i > -1; i--)
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (point[i].ToString() == node.SelectSingleNode("BestScore").InnerText)
                    {
                        Username = node.SelectSingleNode("Username").InnerText;
                    }
                }

                ListViewItem item = new ListViewItem(point[i].ToString());
                item.SubItems.Add(Username);
                listviewusers.Items.Add(item);
            }
        }

        // Show users by descending scores
        private void descendingScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withscores = true;
            listviewusers.Clear();
            listviewusers.Visible = true;
            listviewusers.Columns.Add("BestScore", 140);
            listviewusers.Columns.Add("User", 600);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");
            int Points;
            String Username = null;

            List<String> point = new List<String>();

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                Points = Convert.ToInt32(node.SelectSingleNode("BestScore").InnerText);
                point.Add(Points.ToString());
            }

            point.Sort();

            for (int i = 0; i < point.Count(); i++)
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if(point[i].ToString() == node.SelectSingleNode("BestScore").InnerText)
                    {
                        Username = node.SelectSingleNode("Username").InnerText;
                    }
                }

               ListViewItem item = new ListViewItem(point[i].ToString());
               item.SubItems.Add(Username);
               listviewusers.Items.Add(item);
            }
        }

        // Select user in listbox 
        // redirects to profile screen
        private void listviewusers_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listviewusers.Items.Count; i++)
            {
                if (listviewusers.Items[i].Selected)
                {
                    if(withscores) user = listviewusers.Items[i].SubItems[1].Text;
                    else user = listviewusers.Items[i].Text;

                    ProfileScreen form6 = new ProfileScreen();
                    form6.ShowDialog();
                }
            }
        }

        // Close the manager screen shows the game screen
        private void goBackToMainGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MainGame form10 = new MainGame();
            form10.ShowDialog();
        }
    }
}
