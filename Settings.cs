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

namespace prelab1
{
    public partial class Settings : Form
    {
        public static Settings instance;

        public bool formclosed = false;
        public RadioButton easy, hard, custom, normal;
        public CheckBox blue, red, green, round, square, triangle;
        public int size;

        //Pulls the username from the login screen
        public string user;

        public Settings()
        {
            InitializeComponent();
            instance = this;
        }

        // Examinates if user select one than more shape and colour
        public bool EnoughShapeOrColour()
        {
            if (triangle.Checked && !square.Checked && !round.Checked)
            {
                if (blue.Checked && !green.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (red.Checked && !green.Checked && !blue.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (green.Checked && !blue.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
            }
            if (square.Checked && !triangle.Checked && !round.Checked)
            {
                if (blue.Checked && !green.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (red.Checked && !green.Checked && !blue.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (green.Checked && !blue.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
            }
            if (round.Checked && !square.Checked && !triangle.Checked)
            {
                if (blue.Checked && !green.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (red.Checked && !green.Checked && !blue.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
                if (green.Checked && !blue.Checked && !red.Checked) { MessageBox.Show("You must select one than more shape and colour!"); return true; }
            }

            return false;
        }

        // if user cannot select one than more shape and color cancel the form closing event
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnoughShapeOrColour() || MatrixSize())
            {
                e.Cancel = true;
            }
        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(txtsize.Text);
        }

        public bool MatrixSize()
        {
            if (rbtncustom.Checked)
            {
                if (size > 20) { MessageBox.Show("You must select smaller size than 20!"); return false; }
                else if (size < 6) { MessageBox.Show("You must select bigger size than 6!"); return false; }
                else return true;
            }

            return false;
        }

        //Pulls the username from the login screen
        public string Username
        {
            get { return user; }
            set { user = value; }
        }
       
        private void rbtncustom_CheckedChanged(object sender, EventArgs e)
        {
            txtsize.Visible = true;
            lbenterintformtrx.Visible = true;
        }

        XDocument xDoc = XDocument.Load(@"../../Information.xml");

        private void Settings_Load(object sender, EventArgs e)
        {
            easy = rbtneasy;
            hard = rbtnhard;
            normal = rbtnnormal;
            custom = rbtncustom;

            blue = Blue;
            green = Green;
            red = Red;

            square = chkboxsquare;
            round = chkboxround;
            triangle = chkboxtri;

            //Collect data from xml file for settings screen
            XElement rootElement = xDoc.Root;
            foreach (XElement Admin in rootElement.Elements())
            {
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Red")
                {
                    Red.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Green")
                {
                    Green.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Blue")
                {
                    Blue.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Green,Blue")
                {
                    Blue.Checked = true;
                    Green.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Red,Blue")
                {
                    Blue.Checked = true;
                    Red.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Red,Green")
                {
                    Red.Checked = true;
                    Green.Checked = true;
                }
                if (Admin.Element("Username").Value == user && Admin.Element("Color").Value == "Green,Blue,Red")
                {
                    Red.Checked = true;
                    Green.Checked = true;
                    Blue.Checked = true;
                }

                if (Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value == "2x2")
                {
                    rbtneasy.Checked = true;
                }
                else if (Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value == "3x3")
                {
                    rbtnnormal.Checked = true;
                }
                else if (Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value == "4x4")
                {
                    rbtnhard.Checked = true;
                }
                else if (Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value != "2x2" && Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value != "3x3" && Admin.Element("Username").Value == user && Admin.Element("Difficulty").Value != "4x4")
                {
                    rbtncustom.Checked = true;
                }

                if (Admin.Element("Username").Value == user && Admin.Element("Shape").Value == "Square")
                {
                    chkboxsquare.Checked = true;
                }
                else if (Admin.Element("Username").Value == user && Admin.Element("Shape").Value == "Round")
                {
                    chkboxround.Checked = true;

                }
                else if (Admin.Element("Username").Value == user && Admin.Element("Shape").Value == "Triangle")
                {
                    chkboxtri.Checked = true;
                }

            }


            foreach (XElement User in rootElement.Elements())
            {

                if (User.Element("Username").Value == user && User.Element("Color").Value == "Red")
                {
                    Red.Checked = true;
                }
                if (User.Element("Username").Value == user && User.Element("Color").Value == "Green")
                {
                    Green.Checked = true;
                }
                if (User.Element("Username").Value == user && User.Element("Color").Value == "Blue")
                {
                    Blue.Checked = true;
                }


                if (User.Element("Username").Value == user && User.Element("Difficulty").Value == "2x2")
                {
                    rbtneasy.Checked = true;
                }
                else if (User.Element("Username").Value == user && User.Element("Difficulty").Value == "3x3")
                {
                    rbtnnormal.Checked = true;

                }
                else if (User.Element("Username").Value == user && User.Element("Difficulty").Value == "4x4")
                {
                    rbtnhard.Checked = true;
                }
                else if (User.Element("Username").Value == user && User.Element("Difficulty").Value != "2x2" && User.Element("Username").Value == user && User.Element("Difficulty").Value != "3x3" && User.Element("Username").Value == user && User.Element("Difficulty").Value != "4x4")
                {
                    rbtncustom.Checked = true;
                }

                if (User.Element("Username").Value == user && User.Element("Shape").Value == "Square")
                {
                    chkboxsquare.Checked = true;
                }
                else if (User.Element("Username").Value == user && User.Element("Shape").Value == "Round")
                {
                    chkboxround.Checked = true;

                }
                else if (User.Element("Username").Value == user && User.Element("Shape").Value == "Triangle")
                {
                    chkboxtri.Checked = true;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            XElement rootElement = xDoc.Root;

            foreach (XElement data in rootElement.Elements())
            {
                //Commands to save the color settings of the logged in user
                if (data.Element("Username").Value == user && Red.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", Red.Name);
                    data.Add(color);
                }

                if (data.Element("Username").Value == user && Green.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", Green.Name);
                    data.Add(color);
                }
                if (data.Element("Username").Value == user && Blue.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", Blue.Name);
                    data.Add(color);
                }
                if (data.Element("Username").Value == user && Red.Checked && Green.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", "Red,Green");
                    data.Add(color);
                }
                if (data.Element("Username").Value == user && Red.Checked && Blue.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", "Red,Blue");
                    data.Add(color);
                }
                if (data.Element("Username").Value == user && Green.Checked && Blue.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", "Green,Blue");
                    data.Add(color);
                }
                if (data.Element("Username").Value == user && Green.Checked && Blue.Checked && Red.Checked)
                {
                    data.Element("Color").Remove();
                    XElement color = new XElement("Color", "Green,Blue,Red");
                    data.Add(color);
                }

                //Color save codes end
                //Commands to save login user's difficulty settings
                if (data.Element("Username").Value == user && rbtneasy.Checked)
                {
                    data.Element("Difficulty").Remove();
                    string easy = "2x2";
                    XElement difficulty = new XElement("Difficulty", easy);
                    data.Add(difficulty);
                }
                else if (data.Element("Username").Value == user && rbtnnormal.Checked)
                {
                    data.Element("Difficulty").Remove();
                    string normal = "3x3";
                    XElement difficulty = new XElement("Difficulty", normal);
                    data.Add(difficulty);
                }
                else if (data.Element("Username").Value == user && rbtnhard.Checked)
                {
                    data.Element("Difficulty").Remove();
                    string hard = "4x4";
                    XElement difficulty = new XElement("Difficulty", hard);
                    data.Add(difficulty);
                }
                else if (data.Element("Username").Value == user && rbtncustom.Checked)
                {
                    data.Element("Difficulty").Remove();
                    string col = txtsize.Text;
                    string mat = col + "x" + col;

                    XElement difficulty = new XElement("Difficulty", mat);
                    data.Add(difficulty);
                }
                //End of difficulty save codes
                //Commands to save shape settings of logged in user
                if (data.Element("Username").Value == user && chkboxsquare.Checked)
                {
                    data.Element("Shape").Remove();

                    XElement difficulty = new XElement("Shape", chkboxsquare.Text);
                    data.Add(difficulty);
                }
                else if (data.Element("Username").Value == user && chkboxround.Checked)
                {
                    data.Element("Shape").Remove();
                    XElement difficulty = new XElement("Shape", chkboxround.Text);
                    data.Add(difficulty);
                }
                else if (data.Element("Username").Value == user && chkboxtri.Checked)
                {
                    data.Element("Shape").Remove();
                    XElement difficulty = new XElement("Shape", chkboxtri.Text);
                    data.Add(difficulty);
                }
                //End of shape save codes
            }

            MessageBox.Show("Saved!");
            xDoc.Save(@"../../Information.xml");
            this.TopMost = true;
        }

    }
}

