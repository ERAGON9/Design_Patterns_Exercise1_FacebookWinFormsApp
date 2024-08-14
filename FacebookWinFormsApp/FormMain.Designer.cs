namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHomePage = new System.Windows.Forms.TabPage();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPageFindMatch = new System.Windows.Forms.TabPage();
            this.tabPageFeature2 = new System.Windows.Forms.TabPage();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Type here AppID to test it:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHomePage);
            this.tabControl1.Controls.Add(this.tabPageFindMatch);
            this.tabControl1.Controls.Add(this.tabPageFeature2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPageHomePage
            // 
            this.tabPageHomePage.Controls.Add(this.labelUserName);
            this.tabPageHomePage.Controls.Add(this.pictureBoxProfile);
            this.tabPageHomePage.Controls.Add(this.textBoxAppID);
            this.tabPageHomePage.Controls.Add(this.label1);
            this.tabPageHomePage.Controls.Add(this.buttonLogout);
            this.tabPageHomePage.Controls.Add(this.buttonLogin);
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 31);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1235, 662);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "Home Page";
            this.tabPageHomePage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(77, 145);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 28);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1320566432232601";
            // 
            // tabPageFindMatch
            // 
            this.tabPageFindMatch.Location = new System.Drawing.Point(4, 31);
            this.tabPageFindMatch.Name = "tabPageFindMatch";
            this.tabPageFindMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFindMatch.Size = new System.Drawing.Size(1235, 662);
            this.tabPageFindMatch.TabIndex = 1;
            this.tabPageFindMatch.Text = "Find Match";
            this.tabPageFindMatch.UseVisualStyleBackColor = true;
            // 
            // tabPageFeature2
            // 
            this.tabPageFeature2.Location = new System.Drawing.Point(4, 31);
            this.tabPageFeature2.Name = "tabPageFeature2";
            this.tabPageFeature2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeature2.Size = new System.Drawing.Size(1235, 662);
            this.tabPageFeature2.TabIndex = 2;
            this.tabPageFeature2.Text = "Feature2";
            this.tabPageFeature2.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(77, 104);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(190, 24);
            this.labelUserName.TabIndex = 56;
            this.labelUserName.Text = "No user logged in yet";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHomePage.ResumeLayout(false);
            this.tabPageHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageHomePage;
		private System.Windows.Forms.TabPage tabPageFindMatch;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabPage tabPageFeature2;
        private System.Windows.Forms.Label labelUserName;
    }
}

