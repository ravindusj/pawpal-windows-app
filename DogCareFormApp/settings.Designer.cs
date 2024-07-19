namespace DogCareFormApp
{
    partial class settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.savechanges = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.CurrentPassword = new System.Windows.Forms.TextBox();
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.CurrentUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 108);
            this.label5.TabIndex = 23;
            this.label5.Text = "Settings\r\n\r\n\r\n\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Current Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // savechanges
            // 
            this.savechanges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savechanges.Location = new System.Drawing.Point(308, 410);
            this.savechanges.Name = "savechanges";
            this.savechanges.Size = new System.Drawing.Size(110, 41);
            this.savechanges.TabIndex = 21;
            this.savechanges.Text = "Save Changes";
            this.savechanges.UseVisualStyleBackColor = false;
            this.savechanges.Click += new System.EventHandler(this.savechanges_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(223, 338);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(195, 20);
            this.NewPassword.TabIndex = 20;
            this.NewPassword.TextChanged += new System.EventHandler(this.NewPassword_TextChanged);
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.Location = new System.Drawing.Point(223, 243);
            this.CurrentPassword.Name = "CurrentPassword";
            this.CurrentPassword.Size = new System.Drawing.Size(195, 20);
            this.CurrentPassword.TabIndex = 19;
            this.CurrentPassword.TextChanged += new System.EventHandler(this.CurrentPassword_TextChanged);
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(223, 290);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(195, 20);
            this.NewUsername.TabIndex = 18;
            this.NewUsername.TextChanged += new System.EventHandler(this.NewUsername_TextChanged);
            // 
            // CurrentUsername
            // 
            this.CurrentUsername.Location = new System.Drawing.Point(223, 197);
            this.CurrentUsername.Name = "CurrentUsername";
            this.CurrentUsername.Size = new System.Drawing.Size(195, 20);
            this.CurrentUsername.TabIndex = 17;
            this.CurrentUsername.TextChanged += new System.EventHandler(this.CurrentUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "New Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savechanges);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.CurrentPassword);
            this.Controls.Add(this.NewUsername);
            this.Controls.Add(this.CurrentUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(467, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button savechanges;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox CurrentPassword;
        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.TextBox CurrentUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
