
namespace prelab1
{
    partial class Settings
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
            this.grpboxdif = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbenterintformtrx = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.rbtnhard = new System.Windows.Forms.RadioButton();
            this.rbtneasy = new System.Windows.Forms.RadioButton();
            this.rbtnnormal = new System.Windows.Forms.RadioButton();
            this.rbtncustom = new System.Windows.Forms.RadioButton();
            this.grpboxshape = new System.Windows.Forms.GroupBox();
            this.chkboxround = new System.Windows.Forms.CheckBox();
            this.chkboxtri = new System.Windows.Forms.CheckBox();
            this.chkboxsquare = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.CheckBox();
            this.Blue = new System.Windows.Forms.CheckBox();
            this.Green = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpboxdif.SuspendLayout();
            this.grpboxshape.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxdif
            // 
            this.grpboxdif.Controls.Add(this.label1);
            this.grpboxdif.Controls.Add(this.lbenterintformtrx);
            this.grpboxdif.Controls.Add(this.txtsize);
            this.grpboxdif.Controls.Add(this.rbtnhard);
            this.grpboxdif.Controls.Add(this.rbtneasy);
            this.grpboxdif.Controls.Add(this.rbtnnormal);
            this.grpboxdif.Controls.Add(this.rbtncustom);
            this.grpboxdif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxdif.Location = new System.Drawing.Point(52, 30);
            this.grpboxdif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxdif.Name = "grpboxdif";
            this.grpboxdif.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxdif.Size = new System.Drawing.Size(211, 307);
            this.grpboxdif.TabIndex = 4;
            this.grpboxdif.TabStop = false;
            this.grpboxdif.Text = "Difficulty levels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 13;
            this.label1.Visible = false;
            // 
            // lbenterintformtrx
            // 
            this.lbenterintformtrx.AutoSize = true;
            this.lbenterintformtrx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbenterintformtrx.Location = new System.Drawing.Point(32, 216);
            this.lbenterintformtrx.Name = "lbenterintformtrx";
            this.lbenterintformtrx.Size = new System.Drawing.Size(133, 40);
            this.lbenterintformtrx.TabIndex = 12;
            this.lbenterintformtrx.Text = "Enter integer value\r\n       6x6-20x20";
            this.lbenterintformtrx.Visible = false;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(79, 259);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(31, 34);
            this.txtsize.TabIndex = 11;
            this.txtsize.Visible = false;
            this.txtsize.TextChanged += new System.EventHandler(this.txtsize_TextChanged);
            // 
            // rbtnhard
            // 
            this.rbtnhard.AutoSize = true;
            this.rbtnhard.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.rbtnhard.Location = new System.Drawing.Point(18, 121);
            this.rbtnhard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnhard.Name = "rbtnhard";
            this.rbtnhard.Size = new System.Drawing.Size(98, 42);
            this.rbtnhard.TabIndex = 9;
            this.rbtnhard.TabStop = true;
            this.rbtnhard.Text = "Hard";
            this.rbtnhard.UseVisualStyleBackColor = true;
            // 
            // rbtneasy
            // 
            this.rbtneasy.AutoSize = true;
            this.rbtneasy.BackColor = System.Drawing.Color.Transparent;
            this.rbtneasy.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.rbtneasy.Location = new System.Drawing.Point(18, 44);
            this.rbtneasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtneasy.Name = "rbtneasy";
            this.rbtneasy.Size = new System.Drawing.Size(92, 42);
            this.rbtneasy.TabIndex = 8;
            this.rbtneasy.Text = "Easy";
            this.rbtneasy.UseVisualStyleBackColor = false;
            // 
            // rbtnnormal
            // 
            this.rbtnnormal.AutoSize = true;
            this.rbtnnormal.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.rbtnnormal.Location = new System.Drawing.Point(18, 82);
            this.rbtnnormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnnormal.Name = "rbtnnormal";
            this.rbtnnormal.Size = new System.Drawing.Size(130, 42);
            this.rbtnnormal.TabIndex = 6;
            this.rbtnnormal.TabStop = true;
            this.rbtnnormal.Text = "Normal";
            this.rbtnnormal.UseVisualStyleBackColor = true;
            // 
            // rbtncustom
            // 
            this.rbtncustom.AutoSize = true;
            this.rbtncustom.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.rbtncustom.Location = new System.Drawing.Point(18, 159);
            this.rbtncustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtncustom.Name = "rbtncustom";
            this.rbtncustom.Size = new System.Drawing.Size(132, 42);
            this.rbtncustom.TabIndex = 7;
            this.rbtncustom.TabStop = true;
            this.rbtncustom.Text = "Custom";
            this.rbtncustom.UseVisualStyleBackColor = true;
            this.rbtncustom.CheckedChanged += new System.EventHandler(this.rbtncustom_CheckedChanged);
            // 
            // grpboxshape
            // 
            this.grpboxshape.Controls.Add(this.chkboxround);
            this.grpboxshape.Controls.Add(this.chkboxtri);
            this.grpboxshape.Controls.Add(this.chkboxsquare);
            this.grpboxshape.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxshape.Location = new System.Drawing.Point(313, 30);
            this.grpboxshape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxshape.Name = "grpboxshape";
            this.grpboxshape.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxshape.Size = new System.Drawing.Size(211, 307);
            this.grpboxshape.TabIndex = 5;
            this.grpboxshape.TabStop = false;
            this.grpboxshape.Text = "Shape options";
            // 
            // chkboxround
            // 
            this.chkboxround.AutoSize = true;
            this.chkboxround.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.chkboxround.Location = new System.Drawing.Point(21, 141);
            this.chkboxround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxround.Name = "chkboxround";
            this.chkboxround.Size = new System.Drawing.Size(119, 42);
            this.chkboxround.TabIndex = 5;
            this.chkboxround.Text = "Round";
            this.chkboxround.UseVisualStyleBackColor = true;
            // 
            // chkboxtri
            // 
            this.chkboxtri.AutoSize = true;
            this.chkboxtri.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.chkboxtri.Location = new System.Drawing.Point(21, 102);
            this.chkboxtri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxtri.Name = "chkboxtri";
            this.chkboxtri.Size = new System.Drawing.Size(137, 42);
            this.chkboxtri.TabIndex = 4;
            this.chkboxtri.Text = "Triangle";
            this.chkboxtri.UseVisualStyleBackColor = true;
            // 
            // chkboxsquare
            // 
            this.chkboxsquare.AutoSize = true;
            this.chkboxsquare.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.chkboxsquare.Location = new System.Drawing.Point(21, 64);
            this.chkboxsquare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxsquare.Name = "chkboxsquare";
            this.chkboxsquare.Size = new System.Drawing.Size(125, 42);
            this.chkboxsquare.TabIndex = 3;
            this.chkboxsquare.Text = "Square";
            this.chkboxsquare.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(361, 361);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 51);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Red.Location = new System.Drawing.Point(18, 64);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(86, 42);
            this.Red.TabIndex = 7;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Blue.Location = new System.Drawing.Point(18, 140);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(93, 42);
            this.Blue.TabIndex = 8;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Green.Location = new System.Drawing.Point(18, 101);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(114, 42);
            this.Green.TabIndex = 9;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(576, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 307);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color options";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(836, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grpboxshape);
            this.Controls.Add(this.grpboxdif);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.grpboxdif.ResumeLayout(false);
            this.grpboxdif.PerformLayout();
            this.grpboxshape.ResumeLayout(false);
            this.grpboxshape.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxdif;
        private System.Windows.Forms.GroupBox grpboxshape;
        private System.Windows.Forms.CheckBox chkboxround;
        private System.Windows.Forms.CheckBox chkboxtri;
        private System.Windows.Forms.CheckBox chkboxsquare;
        private System.Windows.Forms.RadioButton rbtnhard;
        private System.Windows.Forms.RadioButton rbtneasy;
        private System.Windows.Forms.RadioButton rbtncustom;
        private System.Windows.Forms.RadioButton rbtnnormal;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label lbenterintformtrx;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.CheckBox Blue;
        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}