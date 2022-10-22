
namespace prelab1
{
    partial class Manager
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
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnallusers = new System.Windows.Forms.Button();
            this.btnupdateuser = new System.Windows.Forms.Button();
            this.btndeleteuser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToMainGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listviewusers = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadduser.Location = new System.Drawing.Point(31, 214);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(242, 105);
            this.btnadduser.TabIndex = 0;
            this.btnadduser.Text = "Add a user";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnallusers
            // 
            this.btnallusers.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnallusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnallusers.Location = new System.Drawing.Point(31, 91);
            this.btnallusers.Name = "btnallusers";
            this.btnallusers.Size = new System.Drawing.Size(242, 101);
            this.btnallusers.TabIndex = 1;
            this.btnallusers.Text = "List all users";
            this.btnallusers.UseVisualStyleBackColor = false;
            this.btnallusers.Click += new System.EventHandler(this.btnallusers_Click);
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnupdateuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdateuser.Location = new System.Drawing.Point(31, 346);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(242, 101);
            this.btnupdateuser.TabIndex = 2;
            this.btnupdateuser.Text = "Update a user";
            this.btnupdateuser.UseVisualStyleBackColor = false;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btndeleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeleteuser.Location = new System.Drawing.Point(31, 471);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(242, 101);
            this.btndeleteuser.TabIndex = 3;
            this.btndeleteuser.Text = "Delete a user";
            this.btndeleteuser.UseVisualStyleBackColor = false;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllUsersToolStripMenuItem,
            this.goBackToMainGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 73);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listAllUsersToolStripMenuItem
            // 
            this.listAllUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingScoresToolStripMenuItem,
            this.descendingScoresToolStripMenuItem});
            this.listAllUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAllUsersToolStripMenuItem.Name = "listAllUsersToolStripMenuItem";
            this.listAllUsersToolStripMenuItem.Size = new System.Drawing.Size(296, 69);
            this.listAllUsersToolStripMenuItem.Text = "List all users";
            // 
            // ascendingScoresToolStripMenuItem
            // 
            this.ascendingScoresToolStripMenuItem.Name = "ascendingScoresToolStripMenuItem";
            this.ascendingScoresToolStripMenuItem.Size = new System.Drawing.Size(529, 70);
            this.ascendingScoresToolStripMenuItem.Text = "Ascending Scores";
            this.ascendingScoresToolStripMenuItem.Click += new System.EventHandler(this.ascendingScoresToolStripMenuItem_Click);
            // 
            // descendingScoresToolStripMenuItem
            // 
            this.descendingScoresToolStripMenuItem.Name = "descendingScoresToolStripMenuItem";
            this.descendingScoresToolStripMenuItem.Size = new System.Drawing.Size(529, 70);
            this.descendingScoresToolStripMenuItem.Text = "Descending Scores";
            this.descendingScoresToolStripMenuItem.Click += new System.EventHandler(this.descendingScoresToolStripMenuItem_Click);
            // 
            // goBackToMainGameToolStripMenuItem
            // 
            this.goBackToMainGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goBackToMainGameToolStripMenuItem.Name = "goBackToMainGameToolStripMenuItem";
            this.goBackToMainGameToolStripMenuItem.Size = new System.Drawing.Size(526, 69);
            this.goBackToMainGameToolStripMenuItem.Text = "Go Back to Main Game";
            this.goBackToMainGameToolStripMenuItem.Click += new System.EventHandler(this.goBackToMainGameToolStripMenuItem_Click);
            // 
            // listviewusers
            // 
            this.listviewusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listviewusers.GridLines = true;
            this.listviewusers.HideSelection = false;
            this.listviewusers.Location = new System.Drawing.Point(338, 91);
            this.listviewusers.Name = "listviewusers";
            this.listviewusers.Size = new System.Drawing.Size(511, 498);
            this.listviewusers.TabIndex = 6;
            this.listviewusers.UseCompatibleStateImageBehavior = false;
            this.listviewusers.View = System.Windows.Forms.View.Details;
            this.listviewusers.Visible = false;
            this.listviewusers.SelectedIndexChanged += new System.EventHandler(this.listviewusers_SelectedIndexChanged);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(899, 637);
            this.Controls.Add(this.listviewusers);
            this.Controls.Add(this.btndeleteuser);
            this.Controls.Add(this.btnupdateuser);
            this.Controls.Add(this.btnallusers);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.Text = "Manager";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btnallusers;
        private System.Windows.Forms.Button btnupdateuser;
        private System.Windows.Forms.Button btndeleteuser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listAllUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingScoresToolStripMenuItem;
        private System.Windows.Forms.ListView listviewusers;
        private System.Windows.Forms.ToolStripMenuItem goBackToMainGameToolStripMenuItem;
    }
}