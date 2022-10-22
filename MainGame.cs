using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace prelab1
{
    public partial class MainGame : Form
    {
        public static MainGame instance;
        public MainGame()
        {
            InitializeComponent();
            instance = this;
        }

        //Pulls the username from the login screen
        public string user;
        public string password;

        //Pulls the username from the login screen
        public string Username
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }

        }

        public int n = 9;
        PictureBox[,] P = new PictureBox[20, 20];
        PictureBox selectedpicture, newloc = null;
        bool select = false;
        Point selectpoint;
        int k, l, old_k, old_l;
        Image selectimage = null;
        int point = 3, left, top;
        bool deleted, Firstj, onlyj = false;

        // If the user selects a different level, the game board needs to be recreated with new dimensions.
        public bool settings()
        {
            if(settingClick)
            {
                if (Settings.instance.hard.Checked)
                {
                    n = 6;
                    point = 5;
                    Settings.instance.hard.Checked = false;
                }
                if (Settings.instance.normal.Checked)
                {
                    n = 9;
                    point = 3;
                    Settings.instance.normal.Checked = false;
                }
                if (Settings.instance.easy.Checked)
                {
                    n = 15;
                    point = 1;
                    Settings.instance.easy.Checked = false;
                }
                else if (Settings.instance.custom.Checked)
                {
                    n = Settings.instance.size;
                    point = 2;
                    Settings.instance.custom.Checked = false;
                }

                settingClick = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete the board
        public void DeleteBoard()
        {
            Board.Controls.Clear();
        }

        // Build the board
        public void BuildBoard()
        {
            top = 15;

            for (int i = 0; i < n; i++)
            { 
                left = 5;

                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    left += 60;
                    P[i, j].BackColor = Color.White;
                    P[i, j].BorderStyle = BorderStyle.Fixed3D;
                    P[i, j].Size = new Size(60, 60);
                    P[i, j].Location = new Point(left, top);
                    P[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    P[i, j].Image = null;
                    Board.Controls.Add(P[i, j]);

                    P[i, j].Cursor = Cursors.Hand;

                    //The user select a shape placed on the game board and move it to the desired point/ empty box.
                    P[i, j].MouseClick += (sender2, e2) =>
                    {
                        selectedpicture = sender2 as PictureBox;
                        selectpoint = selectedpicture.Location;
                        k = (selectpoint.X - 65) / 60;
                        l = (selectpoint.Y - 15) / 60;

                        if (selectedpicture.Image != null)
                        {
                            newloc = selectedpicture;
                            selectedpicture.BorderStyle = BorderStyle.FixedSingle;
                            selectimage = selectedpicture.Image;
                            select = true;
                            old_k = k; old_l = l;
                        }
                        else if (selectedpicture.Image == null && select)
                        {
                            if (First_j_WayOfTheShapeEmpty(old_k, old_l, k, l) || First_i_WayOfTheShapeEmpty(old_k, old_l, k, l))
                            {
                                select = false;
                                newloc.Image = null;
                                newloc.BorderStyle = BorderStyle.Fixed3D;
                                StepByStep(old_k, old_l, k, l);
                            }
                            else
                            {
                                newloc.BorderStyle = BorderStyle.Fixed3D;
                            }
                        }
                    };
                }

                top += 60;
            }

            PutRandomShapes();
        }

        XDocument xDoc = XDocument.Load(@"../../Information.xml");
        bool settingClick, colorClick;

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            settingClick = true; colorClick = true;
            Settings form3 = new Settings();

            //It pulls the username from the log in screen and saves it for the settings screen
            form3.Username = user;
            form3.ShowDialog();
        }

        // Redirects to manager screen
        // only for admins
        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.instance.admin)
            {
                Hide();
                Manager form5 = new Manager();
                form5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only admin can access!");
            }

            this.TopMost = true;
        }

        // Redirects to profile screen
        // only for users
        private void profileScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.instance.admin)
            {
                MessageBox.Show("Admins have no profile!");
            }
            else
            {
                ProfileScreen form6 = new ProfileScreen();
                form6.ShowDialog();
            }

            this.TopMost = true;
        }

        // Settings are checked
        private void MainGame_Load(object sender, EventArgs e)
        {
            n = 9;
            settingClick = false; colorClick = false;
            BuildBoard();
            BestScore();
            //ShowScoreSQL();
            
        }

        // Plays the sound when the user make a move
        public void playStepSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"../../Step.wav");
            simpleSound.Play();
        }

        // Plays a sound when user make a score point
        public void playDeleteSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"../../Delete.wav");
            simpleSound.Play();
        }

        // Timers for step by step function
        public void timer1_Tick(object sender, EventArgs e)
        {
            Board.Enabled = false;
            onlyj = false;

            if(!Firstj)
            {
                if (old_k == k)
                {
                    if (old_l == l)
                    {
                        onlyj = true;
                    }
                    else
                    {
                        P[old_l, old_k].Image = null;
                        old_l--;
                        P[old_l, old_k].Image = selectimage;
                    }
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_k--;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_l == l && onlyj)
                {
                    timer1.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
            else
            {
                if (old_l == l)
                {
                    P[old_l, old_k].Image = null;
                    old_k--;
                    P[old_l, old_k].Image = selectimage;
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_l--;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_k == k)
                {
                    timer1.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            Board.Enabled = false;
            onlyj = false;

            if(!Firstj)
            {
                if (old_k == k)
                {
                    if (old_l == l)
                    {
                        onlyj = true;
                    }
                    else
                    {
                        P[old_l, old_k].Image = null;
                        old_l--;
                        P[old_l, old_k].Image = selectimage;
                    }
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_k++;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_l == l && onlyj)
                {
                    timer2.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
            else
            {
                if (old_l == l)
                {
                    P[old_l, old_k].Image = null;
                    old_k++;
                    P[old_l, old_k].Image = selectimage;
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_l--;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_k == k)
                {
                    timer2.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
        }

        public void timer3_Tick(object sender, EventArgs e)
        {
            onlyj = false;
            Board.Enabled = false;

            if (!Firstj)
            {
                if (old_k == k)
                {
                    if (old_l == l)
                    {
                        onlyj = true;
                    }
                    else
                    {
                        P[old_l, old_k].Image = null;
                        old_l++;
                        P[old_l, old_k].Image = selectimage;
                    }
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_k--;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_l == l && onlyj)
                {
                    timer3.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
            else
            {
                if (old_l == l)
                {
                    P[old_l, old_k].Image = null;
                    old_k--;
                    P[old_l, old_k].Image = selectimage;
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_l++;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_k == k)
                {
                    timer3.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    PutRandomShapes();
                    Board.Enabled = true;
                }
            }
                
        }

        public void timer4_Tick(object sender, EventArgs e)
        {
            Board.Enabled = false;
            onlyj = false;

            if(!Firstj)
            {
                if (old_k == k)
                {
                    if (old_l == l)
                    {
                        onlyj = true;
                    }
                    else
                    {
                        P[old_l, old_k].Image = null;
                        old_l++;
                        P[old_l, old_k].Image = selectimage;
                    }
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_k++;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_l == l && onlyj)
                {
                    timer4.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    Board.Enabled = true;
                    PutRandomShapes();
                }
            }
            else
            {
                if (old_l == l)
                {
                    P[old_l, old_k].Image = null;
                    old_k++;
                    P[old_l, old_k].Image = selectimage;
                }
                else
                {
                    P[old_l, old_k].Image = null;
                    old_l++;
                    P[old_l, old_k].Image = selectimage;
                }

                if (old_k == k)
                {
                    timer4.Stop();
                    DeleteShapes();
                    if (!deleted) playStepSound();
                    Board.Enabled = true;
                    PutRandomShapes();
                }
            }
            
        }

       // Writes the best score in best score place
        public void BestScore()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                if (user == node.SelectSingleNode("Username").InnerText)
                {
                    lblscore.Text = node.SelectSingleNode("BestScore").InnerText;
                }
            }
        }

        // Saves the best score in xml
        public void SaveBestScore()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            if (Convert.ToInt32(lblpoint.Text) >= Convert.ToInt32(lblscore.Text))
            {
                foreach (XmlNode node in doc.SelectNodes("//User"))
                {
                    if (user == node.SelectSingleNode("Username").InnerText)
                    {
                        node.SelectSingleNode("BestScore").InnerText = lblpoint.Text;
                    }
                }
            }

            doc.Save(@"../../Information.xml");
        }

        public void SaveScore()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Information.xml");

            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                if (user == node.SelectSingleNode("Username").InnerText && Convert.ToInt32(lblpoint.Text) != 0)
                {
                    node.SelectSingleNode("Score").InnerText += "\n\t   Score - " + lblpoint.Text;
                }
            }

            doc.Save(@"../../Information.xml");
        }

        public void SaveScoreSQL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OOP;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update OOP set score=@score,password=@password where username=@username", con);

            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@score", lblpoint.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void ShowScoreSQL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OOP;Integrated Security=True");
            SqlCommand cmdzs = new SqlCommand("SELECT MAX (score) as max_score FROM OOP ", con);
            cmdzs.CommandType = CommandType.Text;
            con.Open();
            lblscore.Text = cmdzs.ExecuteScalar().ToString();
            con.Close();
        }

        public void StepByStep(int old_k, int old_l, int k, int l)
        {
            // First i are incremented or decremented
            if (First_i_WayOfTheShapeEmpty(old_k, old_l, k, l))
            {
                Firstj = false;

                if (old_k > k && old_l > l)
                {
                   timer1.Start();
                   timer1_Tick(null, null);
                }
                else if (old_l > l)
                {
                    timer2.Start();
                    timer2_Tick(null, null);
                }
                else if (old_k > k)
                {
                    timer3.Start();
                    timer3_Tick(null, null);
                }
                else
                {
                    timer4.Start();
                    timer4_Tick(null, null);
                }
            }
            else // First j are incremented or decremented
            {
                Firstj = true;

                if (old_k > k && old_l > l)
                {
                    timer1.Start();
                    timer1_Tick(null, null);
                }
                else if (old_l > l)
                {
                    timer2.Start();
                    timer2_Tick(null, null);
                }
                else if (old_k > k)
                {
                    timer3.Start();
                    timer3_Tick(null, null);
                }
                else
                {
                    timer4.Start();
                    timer4_Tick(null, null);
                }
            }
        }

        // Opens the About Screen
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About form7 = new About();
            form7.ShowDialog();
        }

        // regulates the game according to the settings
        private void MainGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (settings())
            {
                DeleteBoard();
                BuildBoard();
            }
        }

        // The path of the shape determine
        public bool First_i_WayOfTheShapeEmpty(int old_k,int old_l,int k,int l)
        {
            bool dec_a = false, dec_b = false;
            int a, b, old_a, old_b;
            a = l; b = k; old_a = old_l; old_b = old_k;

            if (old_b > b)
            {
                dec_b = true;
            }
            if (old_a > a)
            {
                dec_a = true;
            }

            while (old_b != b)
            {
                if(dec_b) old_b--;
                else old_b++;

                if (P[old_a, old_b].Image != null)
                    return false;
            }
            while (old_a != a)
            {
                if (dec_a) old_a--;
                else old_a++;

                if (P[old_a, old_b].Image != null)
                    return false; 
            }

            return true;
        }

        // The path of the shape determine
        public bool First_j_WayOfTheShapeEmpty(int old_k, int old_l, int k, int l)
        {
            bool dec_a = false, dec_b = false;
            int a, b, old_a, old_b;
            a = l; b = k; old_a = old_l; old_b = old_k;

            if (old_b > b)
            {
                dec_b = true;
            }
            if (old_a > a)
            {
                dec_a = true;
            }

            while (old_a != a)
            {
                if (dec_a) old_a--;
                else old_a++;

                if (P[old_a, old_b].Image != null)
                    return false;
            }
            while (old_b != b)
            {
                if (dec_b) old_b--;
                else old_b++;

                if (P[old_a, old_b].Image != null)
                    return false;
            }

            return true;
        }

        // Opens the Help Screen
        private void helpScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen form8 = new HelpScreen();
            form8.ShowDialog();

            this.TopMost = true;
        }


        int q, SameShapeCount;

        // If five same coloured and shaped boxes are side by side (vertically or
        // horizontally), these boxes(same shaped and coloured five boxes) are emptied.
        public void DeleteShapes()
        {
            deleted = false;
            q = 5;
            SameShapeCount = 5;

            for (int i = 0; i < n; i++)
            {
                if (deleted) break;

                for (int j = 0; j < n; j++)
                {
                    if ((i + 4 < n) && (P[i, j].Image != null) && (P[i + 1, j].Image != null) && (P[i + 2, j].Image != null) && (P[i + 3, j].Image != null) && (P[i + 4, j].Image != null))
                    {
                        if ((P[i, j].Image.Size == P[i + 1, j].Image.Size) && (P[i, j].Image.Size == P[i + 2, j].Image.Size) && (P[i, j].Image.Size == P[i + 3, j].Image.Size) && (P[i, j].Image.Size == P[i + 4, j].Image.Size))
                        {
                            while (q + i < n)
                            {
                                if (P[i + q, j].Image != null)
                                {
                                    if (P[i, j].Image.Size == P[i + q, j].Image.Size) { P[i + q, j].Image = null; SameShapeCount++; }
                                    else break;
                                }

                                q++;
                            }

                            P[i, j].Image = null;
                            P[i + 1, j].Image = null;
                            P[i + 2, j].Image = null;
                            P[i + 3, j].Image = null;
                            P[i + 4, j].Image = null;
                            

                            playDeleteSound();
                            MessageBox.Show("Shapes are deleted!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblpoint.Text = (Convert.ToInt32(lblpoint.Text) + (point * SameShapeCount)).ToString();
                            if (Convert.ToInt32(lblpoint.Text) > Convert.ToInt32(lblscore.Text)) lblscore.Text = lblpoint.Text;
                            //SaveScoreSQL();
                            deleted = true;
                            q = 5;
                            break;
                        }
                    }
                    else deleted = false;

                    if ((j + 4 < n) && (P[i, j].Image!=null) && (P[i, j + 1].Image != null) && (P[i, j + 2].Image != null) && (P[i, j + 3].Image != null) && (P[i, j + 4].Image != null)) 
                    {
                        if ((P[i, j].Image.Size == P[i, j + 1].Image.Size) && (P[i, j].Image.Size == P[i, j + 2].Image.Size) && (P[i, j].Image.Size == P[i, j + 3].Image.Size) && (P[i, j].Image.Size == P[i, j + 4].Image.Size))
                        {
                            while (q + j < n)
                            {
                                if (P[i, j + q].Image != null)
                                {
                                    if (P[i, j].Image.Size == P[i, j + q].Image.Size) { P[i, j + q].Image = null; SameShapeCount++; }
                                    else break;
                                }

                                q++;
                            }

                            P[i, j].Image = null;
                            P[i, j + 1].Image = null;
                            P[i, j + 2].Image = null;
                            P[i, j + 3].Image = null;
                            P[i, j + 4].Image = null;
                           

                            playDeleteSound();
                            MessageBox.Show("Shapes are deleted!", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblpoint.Text = (Convert.ToInt32(lblpoint.Text) + (point * SameShapeCount)).ToString();
                            if (Convert.ToInt32(lblpoint.Text) > Convert.ToInt32(lblscore.Text)) lblscore.Text = lblpoint.Text;
                            //SaveScoreSQL();
                            deleted = true;
                            q = 5;
                            break;
                        }
                    }
                    else deleted = false;
                }
            }
        }


        // Return the number of empty places in the matrix
        public int lessThan3Place()
        {
            int empty = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (P[i, j].Image == null) 
                        empty++;
                }
            }

            return empty;
        }


        // 3 shapes randomly assigned
        public void PutRandomShapes()
        {
            Random r = new Random();
            int c = 0;
            int rnumber1, rnumber2, rnumber3;

            Bitmap br = Properties.Resources.blueround;
            Bitmap rr = Properties.Resources.redround;
            Bitmap gr = Properties.Resources.greenround;
            Bitmap bt = Properties.Resources.bluetriangle;
            Bitmap rt = Properties.Resources.redtriangle;
            Bitmap gt = Properties.Resources.greentriangle;
            Bitmap bs = Properties.Resources.bluesquare;
            Bitmap rs = Properties.Resources.redsquare;
            Bitmap gs = Properties.Resources.greensquare;

            Bitmap[] bitmaparray = null;

            // regulates the shapes in the game according to the settings
            if (colorClick)
            {
                if (Settings.instance.square.Checked)
                {
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { bs, rs };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rs, gs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gs, bs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gs, bs, rs };
                }
                if (Settings.instance.triangle.Checked)
                {
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { bt, rt };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rt, gt };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gt, bt };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gt, bt, rt };
                }
                if (Settings.instance.round.Checked)
                {
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { br, rr };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rr, gr };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gr, br };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gr, br, rr };
                }
                if (Settings.instance.square.Checked && Settings.instance.triangle.Checked)
                {
                    if (Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { bt, bs };
                    if (Settings.instance.red.Checked) bitmaparray = new Bitmap[] { rt, rs };
                    if (Settings.instance.green.Checked) bitmaparray = new Bitmap[] { gt, gs };
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { bt, rt, bs, rs };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rt, gt, rs, gs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gt, bt, gs, bs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gt, bt, rt, gs, bs, rs };
                }
                if (Settings.instance.square.Checked && Settings.instance.round.Checked)
                {
                    if (Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { br, bs };
                    if (Settings.instance.red.Checked) bitmaparray = new Bitmap[] { rr, rs };
                    if (Settings.instance.green.Checked) bitmaparray = new Bitmap[] { gr, gs };
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { br, rr, bs, rs };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rr, gr, rs, gs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gr, br, gs, bs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gr, br, rr, gs, bs, rs };
                }
                if (Settings.instance.round.Checked && Settings.instance.triangle.Checked)
                {
                    if (Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { bt, br };
                    if (Settings.instance.red.Checked) bitmaparray = new Bitmap[] { rt, rr };
                    if (Settings.instance.green.Checked) bitmaparray = new Bitmap[] { gt, gr };
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { br, rr, bt, rt };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rr, gr, rt, gt };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gr, br, gt, bt };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gr, br, rr, gt, bt, rt };
                }
                if (Settings.instance.round.Checked && Settings.instance.triangle.Checked && Settings.instance.square.Checked)
                {
                    if (Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { bt, bs, br };
                    if (Settings.instance.red.Checked) bitmaparray = new Bitmap[] { rt, rs, rr };
                    if (Settings.instance.green.Checked) bitmaparray = new Bitmap[] { gt, gs, gr };
                    if (Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { br, rr, bt, rt, bs, rs };
                    if (Settings.instance.red.Checked && Settings.instance.green.Checked) bitmaparray = new Bitmap[] { rr, gr, gt, rt, rs, gs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked) bitmaparray = new Bitmap[] { gr, br, gt, bt, gs, bs };
                    if (Settings.instance.green.Checked && Settings.instance.blue.Checked && Settings.instance.red.Checked) bitmaparray = new Bitmap[] { gr, br, rr, gs, bs, rs, bt, rt, gt };
                }
            }
            else
            {
                bitmaparray = new Bitmap[] { gr, br, rr, gs, bs, rs, bt, rt, gt };
            }

            // If there are less than 3 empty spaces left in the game, the game board is filled and the game is finished
            if (lessThan3Place() <= 3)
            {
                rnumber3 = r.Next(0, bitmaparray.Length);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (P[i, j].Image == null)
                            P[i, j].Image = bitmaparray[rnumber3];
                    }
                }

                MessageBox.Show("Game finished!\nYour Point: " + lblpoint.Text);
                DeleteShapes();
                SaveBestScore();
                SaveScore();
               
                Close();
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                while (c != 3)
                {
                    rnumber1 = r.Next(0, n);
                    rnumber2 = r.Next(0, n);

                    rnumber3 = r.Next(0, bitmaparray.Length);

                    while (P[rnumber1, rnumber2].Image != null)
                    {
                        rnumber1 = r.Next(0, n);
                        rnumber2 = r.Next(0, n);
                    }

                    P[rnumber1, rnumber2].Image = bitmaparray[rnumber3];

                    c++;
                }
            }

            DeleteShapes();
        }
    }
}

