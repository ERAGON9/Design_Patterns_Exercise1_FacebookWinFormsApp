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
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPageFindMatch = new System.Windows.Forms.TabPage();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.pictureBoxFriendList = new System.Windows.Forms.PictureBox();
            this.listBoxMatchesList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.pictureBoxFindMatchRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxFindMatchLeft = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFriendList = new System.Windows.Forms.Label();
            this.labelAgePreference = new System.Windows.Forms.Label();
            this.labelGenderPreference = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.tabPageFeature2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPageFindMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchLeft)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(176, 18);
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
            this.tabPageHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageHomePage.Controls.Add(this.labelUserName);
            this.tabPageHomePage.Controls.Add(this.pictureBoxProfile);
            this.tabPageHomePage.Controls.Add(this.textBoxAppID);
            this.tabPageHomePage.Controls.Add(this.label1);
            this.tabPageHomePage.Controls.Add(this.buttonLogout);
            this.tabPageHomePage.Controls.Add(this.buttonLogin);
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 27);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1235, 666);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "Home Page";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(23, 106);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(217, 26);
            this.labelUserName.TabIndex = 56;
            this.labelUserName.Text = "No user logged in yet";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(29, 140);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1320566432232601";
            // 
            // tabPageFindMatch
            // 
            this.tabPageFindMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageFindMatch.Controls.Add(this.buttonFindMatch);
            this.tabPageFindMatch.Controls.Add(this.pictureBoxFriendList);
            this.tabPageFindMatch.Controls.Add(this.listBoxMatchesList);
            this.tabPageFindMatch.Controls.Add(this.label5);
            this.tabPageFindMatch.Controls.Add(this.numericUpDownMaxAge);
            this.tabPageFindMatch.Controls.Add(this.label4);
            this.tabPageFindMatch.Controls.Add(this.numericUpDownMinAge);
            this.tabPageFindMatch.Controls.Add(this.radioButtonFemale);
            this.tabPageFindMatch.Controls.Add(this.radioButtonMale);
            this.tabPageFindMatch.Controls.Add(this.pictureBoxFindMatchRight);
            this.tabPageFindMatch.Controls.Add(this.pictureBoxFindMatchLeft);
            this.tabPageFindMatch.Controls.Add(this.label3);
            this.tabPageFindMatch.Controls.Add(this.labelFriendList);
            this.tabPageFindMatch.Controls.Add(this.labelAgePreference);
            this.tabPageFindMatch.Controls.Add(this.labelGenderPreference);
            this.tabPageFindMatch.Controls.Add(this.labelTitle2);
            this.tabPageFindMatch.Controls.Add(this.labelTitle1);
            this.tabPageFindMatch.Location = new System.Drawing.Point(4, 27);
            this.tabPageFindMatch.Name = "tabPageFindMatch";
            this.tabPageFindMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFindMatch.Size = new System.Drawing.Size(1235, 666);
            this.tabPageFindMatch.TabIndex = 1;
            this.tabPageFindMatch.Text = "Find Match";
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Location = new System.Drawing.Point(518, 368);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(198, 40);
            this.buttonFindMatch.TabIndex = 16;
            this.buttonFindMatch.Text = "Lets Find Match!";
            this.buttonFindMatch.UseVisualStyleBackColor = true;
            this.buttonFindMatch.Click += new System.EventHandler(this.buttonFindMatch_Click);
            // 
            // pictureBoxFriendList
            // 
            this.pictureBoxFriendList.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFriendList.Location = new System.Drawing.Point(751, 520);
            this.pictureBoxFriendList.Name = "pictureBoxFriendList";
            this.pictureBoxFriendList.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFriendList.TabIndex = 15;
            this.pictureBoxFriendList.TabStop = false;
            // 
            // listBoxMatchesList
            // 
            this.listBoxMatchesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMatchesList.FormattingEnabled = true;
            this.listBoxMatchesList.ItemHeight = 20;
            this.listBoxMatchesList.Location = new System.Drawing.Point(421, 494);
            this.listBoxMatchesList.Name = "listBoxMatchesList";
            this.listBoxMatchesList.Size = new System.Drawing.Size(316, 144);
            this.listBoxMatchesList.TabIndex = 14;
            this.listBoxMatchesList.SelectedIndexChanged += new System.EventHandler(this.listBoxMatchesList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max:";
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(662, 304);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(68, 24);
            this.numericUpDownMaxAge.TabIndex = 12;
            this.numericUpDownMaxAge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Min:";
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(524, 304);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(68, 24);
            this.numericUpDownMinAge.TabIndex = 10;
            this.numericUpDownMinAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(621, 188);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 22);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(522, 188);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 22);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFindMatchRight
            // 
            this.pictureBoxFindMatchRight.Location = new System.Drawing.Point(913, 8);
            this.pictureBoxFindMatchRight.Name = "pictureBoxFindMatchRight";
            this.pictureBoxFindMatchRight.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFindMatchRight.TabIndex = 7;
            this.pictureBoxFindMatchRight.TabStop = false;
            // 
            // pictureBoxFindMatchLeft
            // 
            this.pictureBoxFindMatchLeft.Location = new System.Drawing.Point(250, 8);
            this.pictureBoxFindMatchLeft.Name = "pictureBoxFindMatchLeft";
            this.pictureBoxFindMatchLeft.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFindMatchLeft.TabIndex = 6;
            this.pictureBoxFindMatchLeft.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Sorted by number of shared like pages in descending order)";
            // 
            // labelFriendList
            // 
            this.labelFriendList.AutoSize = true;
            this.labelFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendList.Location = new System.Drawing.Point(517, 434);
            this.labelFriendList.Name = "labelFriendList";
            this.labelFriendList.Size = new System.Drawing.Size(99, 22);
            this.labelFriendList.TabIndex = 4;
            this.labelFriendList.Text = "Friend list";
            // 
            // labelAgePreference
            // 
            this.labelAgePreference.AutoSize = true;
            this.labelAgePreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgePreference.Location = new System.Drawing.Point(513, 254);
            this.labelAgePreference.Name = "labelAgePreference";
            this.labelAgePreference.Size = new System.Drawing.Size(147, 22);
            this.labelAgePreference.TabIndex = 3;
            this.labelAgePreference.Text = "Age preference";
            // 
            // labelGenderPreference
            // 
            this.labelGenderPreference.AutoSize = true;
            this.labelGenderPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderPreference.Location = new System.Drawing.Point(513, 144);
            this.labelGenderPreference.Name = "labelGenderPreference";
            this.labelGenderPreference.Size = new System.Drawing.Size(178, 22);
            this.labelGenderPreference.TabIndex = 2;
            this.labelGenderPreference.Text = "Gender preference";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Location = new System.Drawing.Point(358, 101);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(432, 18);
            this.labelTitle2.TabIndex = 1;
            this.labelTitle2.Text = "Lets try find out your best next dates based on common hobbies!\r\n";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(374, 32);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(413, 39);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "Welcome to Find Match!";
            // 
            // tabPageFeature2
            // 
            this.tabPageFeature2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageFeature2.Location = new System.Drawing.Point(4, 27);
            this.tabPageFeature2.Name = "tabPageFeature2";
            this.tabPageFeature2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeature2.Size = new System.Drawing.Size(1235, 666);
            this.tabPageFeature2.TabIndex = 2;
            this.tabPageFeature2.Text = "Feature2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
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
            this.tabPageFindMatch.ResumeLayout(false);
            this.tabPageFindMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchLeft)).EndInit();
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
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelGenderPreference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFriendList;
        private System.Windows.Forms.Label labelAgePreference;
        private System.Windows.Forms.PictureBox pictureBoxFindMatchRight;
        private System.Windows.Forms.PictureBox pictureBoxFindMatchLeft;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.PictureBox pictureBoxFriendList;
        private System.Windows.Forms.ListBox listBoxMatchesList;
        private System.Windows.Forms.Button buttonFindMatch;
    }
}

