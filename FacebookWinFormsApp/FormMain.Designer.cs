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
            this.labelMatchesEmail = new System.Windows.Forms.Label();
            this.labelMatchesLocation = new System.Windows.Forms.Label();
            this.labelMatchesBirthday = new System.Windows.Forms.Label();
            this.labelMatchesName = new System.Windows.Forms.Label();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.pictureBoxMatches = new System.Windows.Forms.PictureBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
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
            this.tabPageFriendOverView = new System.Windows.Forms.TabPage();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxMutualFriends = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxSports = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonShowSimilarities = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.LabelCommentsNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelLikesNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonShowInteractionStats = new System.Windows.Forms.Button();
            this.comboBoxFriends = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPageFindMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchLeft)).BeginInit();
            this.tabPageFriendOverView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPageFriendOverView);
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
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 31);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1235, 662);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "Home Page";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(23, 106);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(269, 31);
            this.labelUserName.TabIndex = 56;
            this.labelUserName.Text = "No user logged in yet";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Gainsboro;
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
            this.textBoxAppID.Size = new System.Drawing.Size(237, 28);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1320566432232601";
            // 
            // tabPageFindMatch
            // 
            this.tabPageFindMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageFindMatch.Controls.Add(this.labelMatchesEmail);
            this.tabPageFindMatch.Controls.Add(this.labelMatchesLocation);
            this.tabPageFindMatch.Controls.Add(this.labelMatchesBirthday);
            this.tabPageFindMatch.Controls.Add(this.labelMatchesName);
            this.tabPageFindMatch.Controls.Add(this.buttonFindMatch);
            this.tabPageFindMatch.Controls.Add(this.pictureBoxMatches);
            this.tabPageFindMatch.Controls.Add(this.listBoxMatches);
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
            this.tabPageFindMatch.Location = new System.Drawing.Point(4, 31);
            this.tabPageFindMatch.Name = "tabPageFindMatch";
            this.tabPageFindMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFindMatch.Size = new System.Drawing.Size(1235, 662);
            this.tabPageFindMatch.TabIndex = 1;
            this.tabPageFindMatch.Text = "Find Match";
            // 
            // labelMatchesEmail
            // 
            this.labelMatchesEmail.AutoSize = true;
            this.labelMatchesEmail.Location = new System.Drawing.Point(913, 624);
            this.labelMatchesEmail.Name = "labelMatchesEmail";
            this.labelMatchesEmail.Size = new System.Drawing.Size(62, 24);
            this.labelMatchesEmail.TabIndex = 20;
            this.labelMatchesEmail.Text = "Email:";
            // 
            // labelMatchesLocation
            // 
            this.labelMatchesLocation.AutoSize = true;
            this.labelMatchesLocation.Location = new System.Drawing.Point(913, 582);
            this.labelMatchesLocation.Name = "labelMatchesLocation";
            this.labelMatchesLocation.Size = new System.Drawing.Size(86, 24);
            this.labelMatchesLocation.TabIndex = 19;
            this.labelMatchesLocation.Text = "Location:";
            // 
            // labelMatchesBirthday
            // 
            this.labelMatchesBirthday.AutoSize = true;
            this.labelMatchesBirthday.Location = new System.Drawing.Point(913, 537);
            this.labelMatchesBirthday.Name = "labelMatchesBirthday";
            this.labelMatchesBirthday.Size = new System.Drawing.Size(82, 24);
            this.labelMatchesBirthday.TabIndex = 18;
            this.labelMatchesBirthday.Text = "Birthday:";
            // 
            // labelMatchesName
            // 
            this.labelMatchesName.AutoSize = true;
            this.labelMatchesName.Location = new System.Drawing.Point(913, 494);
            this.labelMatchesName.Name = "labelMatchesName";
            this.labelMatchesName.Size = new System.Drawing.Size(66, 24);
            this.labelMatchesName.TabIndex = 17;
            this.labelMatchesName.Text = "Name:";
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
            // pictureBoxMatches
            // 
            this.pictureBoxMatches.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxMatches.Location = new System.Drawing.Point(757, 494);
            this.pictureBoxMatches.Name = "pictureBoxMatches";
            this.pictureBoxMatches.Size = new System.Drawing.Size(132, 154);
            this.pictureBoxMatches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatches.TabIndex = 15;
            this.pictureBoxMatches.TabStop = false;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 25;
            this.listBoxMatches.Location = new System.Drawing.Point(421, 494);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(316, 154);
            this.listBoxMatches.TabIndex = 14;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max:";
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(662, 304);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(68, 28);
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
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Min:";
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(524, 304);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(68, 28);
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
            this.radioButtonFemale.Location = new System.Drawing.Point(621, 201);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(95, 28);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(522, 201);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(72, 28);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFindMatchRight
            // 
            this.pictureBoxFindMatchRight.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFindMatchRight.Image = global::BasicFacebookFeatures.Properties.Resources.tryImage;
            this.pictureBoxFindMatchRight.Location = new System.Drawing.Point(913, 8);
            this.pictureBoxFindMatchRight.Name = "pictureBoxFindMatchRight";
            this.pictureBoxFindMatchRight.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFindMatchRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFindMatchRight.TabIndex = 7;
            this.pictureBoxFindMatchRight.TabStop = false;
            // 
            // pictureBoxFindMatchLeft
            // 
            this.pictureBoxFindMatchLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFindMatchLeft.Image = global::BasicFacebookFeatures.Properties.Resources.tryImage;
            this.pictureBoxFindMatchLeft.Location = new System.Drawing.Point(250, 8);
            this.pictureBoxFindMatchLeft.Name = "pictureBoxFindMatchLeft";
            this.pictureBoxFindMatchLeft.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFindMatchLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFindMatchLeft.TabIndex = 6;
            this.pictureBoxFindMatchLeft.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Sorted by the number of shared like pages in descending order)";
            // 
            // labelFriendList
            // 
            this.labelFriendList.AutoSize = true;
            this.labelFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendList.Location = new System.Drawing.Point(517, 434);
            this.labelFriendList.Name = "labelFriendList";
            this.labelFriendList.Size = new System.Drawing.Size(139, 26);
            this.labelFriendList.TabIndex = 4;
            this.labelFriendList.Text = "Matches list";
            // 
            // labelAgePreference
            // 
            this.labelAgePreference.AutoSize = true;
            this.labelAgePreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgePreference.Location = new System.Drawing.Point(513, 254);
            this.labelAgePreference.Name = "labelAgePreference";
            this.labelAgePreference.Size = new System.Drawing.Size(174, 26);
            this.labelAgePreference.TabIndex = 3;
            this.labelAgePreference.Text = "Age preference";
            // 
            // labelGenderPreference
            // 
            this.labelGenderPreference.AutoSize = true;
            this.labelGenderPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderPreference.Location = new System.Drawing.Point(513, 157);
            this.labelGenderPreference.Name = "labelGenderPreference";
            this.labelGenderPreference.Size = new System.Drawing.Size(210, 26);
            this.labelGenderPreference.TabIndex = 2;
            this.labelGenderPreference.Text = "Gender preference";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Location = new System.Drawing.Point(246, 120);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(854, 24);
            this.labelTitle2.TabIndex = 1;
            this.labelTitle2.Text = "Lets try find out your best next dates from your friend list based on preferences" +
    " and common hobbies!\r\n";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(374, 32);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(515, 52);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "Welcome to Find Match!";
            // 
            // tabPageFriendOverView
            // 
            this.tabPageFriendOverView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageFriendOverView.Controls.Add(this.listBoxLikedPages);
            this.tabPageFriendOverView.Controls.Add(this.label13);
            this.tabPageFriendOverView.Controls.Add(this.listBoxMutualFriends);
            this.tabPageFriendOverView.Controls.Add(this.label12);
            this.tabPageFriendOverView.Controls.Add(this.listBoxSports);
            this.tabPageFriendOverView.Controls.Add(this.label11);
            this.tabPageFriendOverView.Controls.Add(this.listBoxLanguages);
            this.tabPageFriendOverView.Controls.Add(this.label10);
            this.tabPageFriendOverView.Controls.Add(this.buttonShowSimilarities);
            this.tabPageFriendOverView.Controls.Add(this.pictureBoxFriend);
            this.tabPageFriendOverView.Controls.Add(this.LabelCommentsNum);
            this.tabPageFriendOverView.Controls.Add(this.label8);
            this.tabPageFriendOverView.Controls.Add(this.LabelLikesNum);
            this.tabPageFriendOverView.Controls.Add(this.label6);
            this.tabPageFriendOverView.Controls.Add(this.buttonShowInteractionStats);
            this.tabPageFriendOverView.Controls.Add(this.comboBoxFriends);
            this.tabPageFriendOverView.Controls.Add(this.label2);
            this.tabPageFriendOverView.Location = new System.Drawing.Point(4, 31);
            this.tabPageFriendOverView.Name = "tabPageFriendOverView";
            this.tabPageFriendOverView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriendOverView.Size = new System.Drawing.Size(1235, 662);
            this.tabPageFriendOverView.TabIndex = 2;
            this.tabPageFriendOverView.Text = "Friend OverView";
            this.tabPageFriendOverView.Click += new System.EventHandler(this.buttonShowInteractionStats_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 22;
            this.listBoxLikedPages.Location = new System.Drawing.Point(770, 484);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(248, 114);
            this.listBoxLikedPages.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(601, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Liked pages:";
            // 
            // listBoxMutualFriends
            // 
            this.listBoxMutualFriends.FormattingEnabled = true;
            this.listBoxMutualFriends.ItemHeight = 22;
            this.listBoxMutualFriends.Location = new System.Drawing.Point(770, 323);
            this.listBoxMutualFriends.Name = "listBoxMutualFriends";
            this.listBoxMutualFriends.Size = new System.Drawing.Size(248, 114);
            this.listBoxMutualFriends.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mutual friends:";
            // 
            // listBoxSports
            // 
            this.listBoxSports.FormattingEnabled = true;
            this.listBoxSports.ItemHeight = 22;
            this.listBoxSports.Location = new System.Drawing.Point(213, 484);
            this.listBoxSports.Name = "listBoxSports";
            this.listBoxSports.Size = new System.Drawing.Size(248, 114);
            this.listBoxSports.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sports:";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 22;
            this.listBoxLanguages.Location = new System.Drawing.Point(213, 323);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(248, 114);
            this.listBoxLanguages.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Languages:";
            // 
            // buttonShowSimilarities
            // 
            this.buttonShowSimilarities.Location = new System.Drawing.Point(447, 205);
            this.buttonShowSimilarities.Name = "buttonShowSimilarities";
            this.buttonShowSimilarities.Size = new System.Drawing.Size(320, 30);
            this.buttonShowSimilarities.TabIndex = 8;
            this.buttonShowSimilarities.Text = "Show Similarities!";
            this.buttonShowSimilarities.UseVisualStyleBackColor = true;
            this.buttonShowSimilarities.Click += new System.EventHandler(this.buttonShowSimilarities_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFriend.Location = new System.Drawing.Point(55, 93);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(224, 142);
            this.pictureBoxFriend.TabIndex = 7;
            this.pictureBoxFriend.TabStop = false;
            // 
            // LabelCommentsNum
            // 
            this.LabelCommentsNum.AutoSize = true;
            this.LabelCommentsNum.Location = new System.Drawing.Point(675, 141);
            this.LabelCommentsNum.Name = "LabelCommentsNum";
            this.LabelCommentsNum.Size = new System.Drawing.Size(117, 24);
            this.LabelCommentsNum.TabIndex = 6;
            this.LabelCommentsNum.Text = "Not available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Number of comments: ";
            // 
            // LabelLikesNum
            // 
            this.LabelLikesNum.AutoSize = true;
            this.LabelLikesNum.Location = new System.Drawing.Point(675, 93);
            this.LabelLikesNum.Name = "LabelLikesNum";
            this.LabelLikesNum.Size = new System.Drawing.Size(117, 24);
            this.LabelLikesNum.TabIndex = 4;
            this.LabelLikesNum.Text = "Not available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of likes: ";
            // 
            // buttonShowInteractionStats
            // 
            this.buttonShowInteractionStats.Location = new System.Drawing.Point(447, 29);
            this.buttonShowInteractionStats.Name = "buttonShowInteractionStats";
            this.buttonShowInteractionStats.Size = new System.Drawing.Size(320, 30);
            this.buttonShowInteractionStats.TabIndex = 2;
            this.buttonShowInteractionStats.Text = "Show interaction stats!";
            this.buttonShowInteractionStats.UseVisualStyleBackColor = true;
            this.buttonShowInteractionStats.Click += new System.EventHandler(this.buttonShowInteractionStats_Click);
            // 
            // comboBoxFriends
            // 
            this.comboBoxFriends.FormattingEnabled = true;
            this.comboBoxFriends.Location = new System.Drawing.Point(222, 29);
            this.comboBoxFriends.Name = "comboBoxFriends";
            this.comboBoxFriends.Size = new System.Drawing.Size(147, 30);
            this.comboBoxFriends.TabIndex = 1;
            this.comboBoxFriends.SelectedIndexChanged += new System.EventHandler(this.comboBoxFriends_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a friend:";
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
            this.tabPageFindMatch.ResumeLayout(false);
            this.tabPageFindMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMatchLeft)).EndInit();
            this.tabPageFriendOverView.ResumeLayout(false);
            this.tabPageFriendOverView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageFriendOverView;
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
        private System.Windows.Forms.PictureBox pictureBoxMatches;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.Button buttonFindMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelLikesNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShowInteractionStats;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxMutualFriends;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxSports;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonShowSimilarities;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label LabelCommentsNum;
        private System.Windows.Forms.Label labelMatchesName;
        private System.Windows.Forms.Label labelMatchesEmail;
        private System.Windows.Forms.Label labelMatchesLocation;
        private System.Windows.Forms.Label labelMatchesBirthday;
    }
}