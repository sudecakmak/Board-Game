
namespace prelab1
{
    partial class Password
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
            this.btnenter = new System.Windows.Forms.Button();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnenter
            // 
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenter.Location = new System.Drawing.Point(157, 147);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(83, 35);
            this.btnenter.TabIndex = 0;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxpassword.Location = new System.Drawing.Point(112, 113);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(186, 28);
            this.textBoxpassword.TabIndex = 1;
            this.textBoxpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your password to update or delete ";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(413, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.btnenter);
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label1;
    }
}