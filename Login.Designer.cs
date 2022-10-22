
namespace prelab1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusertype = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.rbtnadmin = new System.Windows.Forms.RadioButton();
            this.rbtnuser = new System.Windows.Forms.RadioButton();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.chkboxshow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.ForeColor = System.Drawing.SystemColors.Window;
            this.lblusertype.Location = new System.Drawing.Point(149, 46);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(152, 32);
            this.lblusertype.TabIndex = 0;
            this.lblusertype.Text = "User Type";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Window;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(206, 258);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(96, 43);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnlogin_KeyPress);
            // 
            // rbtnadmin
            // 
            this.rbtnadmin.AutoSize = true;
            this.rbtnadmin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbtnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnadmin.ForeColor = System.Drawing.SystemColors.Window;
            this.rbtnadmin.Location = new System.Drawing.Point(136, 99);
            this.rbtnadmin.Name = "rbtnadmin";
            this.rbtnadmin.Size = new System.Drawing.Size(82, 24);
            this.rbtnadmin.TabIndex = 6;
            this.rbtnadmin.TabStop = true;
            this.rbtnadmin.Text = "Admin";
            this.rbtnadmin.UseMnemonic = false;
            this.rbtnadmin.UseVisualStyleBackColor = true;
            this.rbtnadmin.CheckedChanged += new System.EventHandler(this.rbtnadmin_CheckedChanged);
            // 
            // rbtnuser
            // 
            this.rbtnuser.AutoSize = true;
            this.rbtnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnuser.ForeColor = System.Drawing.SystemColors.Window;
            this.rbtnuser.Location = new System.Drawing.Point(232, 99);
            this.rbtnuser.Name = "rbtnuser";
            this.rbtnuser.Size = new System.Drawing.Size(70, 24);
            this.rbtnuser.TabIndex = 7;
            this.rbtnuser.TabStop = true;
            this.rbtnuser.Text = "User";
            this.rbtnuser.UseVisualStyleBackColor = true;
            this.rbtnuser.CheckedChanged += new System.EventHandler(this.rbtnuser_CheckedChanged_1);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(186, 153);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(116, 22);
            this.txtusername.TabIndex = 1;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(186, 197);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(116, 22);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(59, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(371, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sign Up 👉";
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.SystemColors.Window;
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Signup.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Signup.Location = new System.Drawing.Point(541, 81);
            this.Signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(87, 42);
            this.Signup.TabIndex = 5;
            this.Signup.Text = "Click";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // chkboxshow
            // 
            this.chkboxshow.AutoSize = true;
            this.chkboxshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxshow.Location = new System.Drawing.Point(321, 197);
            this.chkboxshow.Name = "chkboxshow";
            this.chkboxshow.Size = new System.Drawing.Size(139, 22);
            this.chkboxshow.TabIndex = 4;
            this.chkboxshow.Text = "Show Password";
            this.chkboxshow.UseVisualStyleBackColor = true;
            this.chkboxshow.CheckedChanged += new System.EventHandler(this.chkboxshow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(678, 370);
            this.Controls.Add(this.chkboxshow);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.rbtnuser);
            this.Controls.Add(this.rbtnadmin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblusertype);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusertype;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.RadioButton rbtnadmin;
        private System.Windows.Forms.RadioButton rbtnuser;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.CheckBox chkboxshow;
    }
}

