
namespace prelab1
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Board = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.lbltimecount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1737, 70);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.managerToolStripMenuItem,
            this.profileScreenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpScreenToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 28.2F);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(162, 66);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(467, 66);
            this.toolStripMenuItem2.Text = "Settings";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(467, 66);
            this.managerToolStripMenuItem.Text = "Manager Screen";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // profileScreenToolStripMenuItem
            // 
            this.profileScreenToolStripMenuItem.Name = "profileScreenToolStripMenuItem";
            this.profileScreenToolStripMenuItem.Size = new System.Drawing.Size(467, 66);
            this.profileScreenToolStripMenuItem.Text = "Profile Screen";
            this.profileScreenToolStripMenuItem.Click += new System.EventHandler(this.profileScreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(467, 66);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpScreenToolStripMenuItem
            // 
            this.helpScreenToolStripMenuItem.Name = "helpScreenToolStripMenuItem";
            this.helpScreenToolStripMenuItem.Size = new System.Drawing.Size(467, 66);
            this.helpScreenToolStripMenuItem.Text = "Help Screen";
            this.helpScreenToolStripMenuItem.Click += new System.EventHandler(this.helpScreenToolStripMenuItem_Click);
            // 
            // Board
            // 
            this.Board.AutoScroll = true;
            this.Board.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.Board.Location = new System.Drawing.Point(41, 95);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(1807, 2000);
            this.Board.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Points: ";
            // 
            // lblpoint
            // 
            this.lblpoint.AutoSize = true;
            this.lblpoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpoint.Location = new System.Drawing.Point(391, 22);
            this.lblpoint.Name = "lblpoint";
            this.lblpoint.Size = new System.Drawing.Size(35, 38);
            this.lblpoint.TabIndex = 3;
            this.lblpoint.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 400;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 400;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.Location = new System.Drawing.Point(527, 24);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 36);
            this.lbltime.TabIndex = 4;
            // 
            // lbltimecount
            // 
            this.lbltimecount.AutoSize = true;
            this.lbltimecount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltimecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimecount.Location = new System.Drawing.Point(620, 24);
            this.lbltimecount.Name = "lbltimecount";
            this.lbltimecount.Size = new System.Drawing.Size(0, 36);
            this.lbltimecount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(619, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Best Score:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblscore.Location = new System.Drawing.Point(817, 21);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(35, 38);
            this.lblscore.TabIndex = 7;
            this.lblscore.Text = "0";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1737, 862);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltimecount);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainGame_MouseMove);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileScreenToolStripMenuItem;
        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbltimecount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpScreenToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblscore;
    }
}