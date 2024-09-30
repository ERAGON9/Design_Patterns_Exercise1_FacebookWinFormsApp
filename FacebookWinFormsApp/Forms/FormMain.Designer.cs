namespace BasicFacebookFeatures.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableSelcetFriend = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserFirstName = new System.Windows.Forms.Label();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.labelUserDetails = new System.Windows.Forms.Label();
            this.labelUserBirthdate = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.labelUserGender = new System.Windows.Forms.Label();
            this.labelUserHometown = new System.Windows.Forms.Label();
            this.labelUserLocation = new System.Windows.Forms.Label();
            this.labelPostNewStatus = new System.Windows.Forms.Label();
            this.textBoxPostNewStatus = new System.Windows.Forms.TextBox();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelPostsInfo = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelFriendsInfo = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelAlbumsInfo = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.labelLikePages = new System.Windows.Forms.Label();
            this.labelLikePagesInfo = new System.Windows.Forms.Label();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.pictureBoxLikePages = new System.Windows.Forms.PictureBox();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            this.labelFavoriteTeamsInfo = new System.Windows.Forms.Label();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.pictureBoxFavoriteTeams = new System.Windows.Forms.PictureBox();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.buttonFriendOverView = new System.Windows.Forms.Button();
            this.tabPageHomePage = new System.Windows.Forms.TabPage();
            this.userFriendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likePagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteTeamsPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikePages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeams)).BeginInit();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFriendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteTeamsPageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHomePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 703);
            this.tabControl1.TabIndex = 54;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // lableSelcetFriend
            // 
            this.lableSelcetFriend.AutoSize = true;
            this.lableSelcetFriend.Location = new System.Drawing.Point(51, 29);
            this.lableSelcetFriend.Name = "lableSelcetFriend";
            this.lableSelcetFriend.Size = new System.Drawing.Size(134, 24);
            this.lableSelcetFriend.TabIndex = 0;
            this.lableSelcetFriend.Text = "Select a friend:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxProfile.Location = new System.Drawing.Point(29, 143);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelUserFirstName
            // 
            this.labelUserFirstName.AutoSize = true;
            this.labelUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUserFirstName.Location = new System.Drawing.Point(23, 106);
            this.labelUserFirstName.Name = "labelUserFirstName";
            this.labelUserFirstName.Size = new System.Drawing.Size(263, 29);
            this.labelUserFirstName.TabIndex = 56;
            this.labelUserFirstName.Text = "No user logged in yet";
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullName.Location = new System.Drawing.Point(289, 146);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(118, 26);
            this.labelUserFullName.TabIndex = 57;
            this.labelUserFullName.Text = "Full Name:";
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserDetails.Location = new System.Drawing.Point(346, 109);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(137, 26);
            this.labelUserDetails.TabIndex = 58;
            this.labelUserDetails.Text = "User Details:";
            // 
            // labelUserBirthdate
            // 
            this.labelUserBirthdate.AutoSize = true;
            this.labelUserBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserBirthdate.Location = new System.Drawing.Point(289, 220);
            this.labelUserBirthdate.Name = "labelUserBirthdate";
            this.labelUserBirthdate.Size = new System.Drawing.Size(105, 26);
            this.labelUserBirthdate.TabIndex = 59;
            this.labelUserBirthdate.Text = "Birthdate:";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmail.Location = new System.Drawing.Point(289, 333);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(74, 26);
            this.labelUserEmail.TabIndex = 60;
            this.labelUserEmail.Text = "Email:";
            // 
            // labelUserGender
            // 
            this.labelUserGender.AutoSize = true;
            this.labelUserGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGender.Location = new System.Drawing.Point(289, 182);
            this.labelUserGender.Name = "labelUserGender";
            this.labelUserGender.Size = new System.Drawing.Size(90, 26);
            this.labelUserGender.TabIndex = 61;
            this.labelUserGender.Text = "Gender:";
            // 
            // labelUserHometown
            // 
            this.labelUserHometown.AutoSize = true;
            this.labelUserHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserHometown.Location = new System.Drawing.Point(289, 257);
            this.labelUserHometown.Name = "labelUserHometown";
            this.labelUserHometown.Size = new System.Drawing.Size(123, 26);
            this.labelUserHometown.TabIndex = 62;
            this.labelUserHometown.Text = "Hometown:";
            // 
            // labelUserLocation
            // 
            this.labelUserLocation.AutoSize = true;
            this.labelUserLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLocation.Location = new System.Drawing.Point(289, 295);
            this.labelUserLocation.Name = "labelUserLocation";
            this.labelUserLocation.Size = new System.Drawing.Size(100, 26);
            this.labelUserLocation.TabIndex = 63;
            this.labelUserLocation.Text = "Location:";
            // 
            // labelPostNewStatus
            // 
            this.labelPostNewStatus.AutoSize = true;
            this.labelPostNewStatus.Location = new System.Drawing.Point(640, 24);
            this.labelPostNewStatus.Name = "labelPostNewStatus";
            this.labelPostNewStatus.Size = new System.Drawing.Size(150, 24);
            this.labelPostNewStatus.TabIndex = 64;
            this.labelPostNewStatus.Text = "Post New Status:";
            // 
            // textBoxPostNewStatus
            // 
            this.textBoxPostNewStatus.Location = new System.Drawing.Point(800, 21);
            this.textBoxPostNewStatus.Name = "textBoxPostNewStatus";
            this.textBoxPostNewStatus.Size = new System.Drawing.Size(310, 28);
            this.textBoxPostNewStatus.TabIndex = 65;
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Location = new System.Drawing.Point(1119, 19);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(80, 33);
            this.buttonPostNewStatus.TabIndex = 66;
            this.buttonPostNewStatus.Text = "Post";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonPostNewStatus_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(632, 109);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(105, 24);
            this.labelPosts.TabIndex = 67;
            this.labelPosts.Text = "Your Posts:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 22;
            this.listBoxPosts.Location = new System.Drawing.Point(636, 160);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(620, 180);
            this.listBoxPosts.TabIndex = 68;
            // 
            // labelPostsInfo
            // 
            this.labelPostsInfo.AutoSize = true;
            this.labelPostsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsInfo.Location = new System.Drawing.Point(633, 135);
            this.labelPostsInfo.Name = "labelPostsInfo";
            this.labelPostsInfo.Size = new System.Drawing.Size(266, 18);
            this.labelPostsInfo.TabIndex = 69;
            this.labelPostsInfo.Text = "(Click on a post to view the comments)";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(25, 399);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(124, 24);
            this.labelFriends.TabIndex = 71;
            this.labelFriends.Text = "Your Friends:";
            // 
            // labelFriendsInfo
            // 
            this.labelFriendsInfo.AutoSize = true;
            this.labelFriendsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsInfo.Location = new System.Drawing.Point(26, 427);
            this.labelFriendsInfo.Name = "labelFriendsInfo";
            this.labelFriendsInfo.Size = new System.Drawing.Size(245, 18);
            this.labelFriendsInfo.TabIndex = 72;
            this.labelFriendsInfo.Text = "(Click on a friend to view his picture)";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userFriendsBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 22;
            this.listBoxFriends.Location = new System.Drawing.Point(28, 457);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(243, 158);
            this.listBoxFriends.TabIndex = 73;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxFriends.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userFriendsBindingSource, "ImageNormal", true));
            this.pictureBoxFriends.Location = new System.Drawing.Point(223, 529);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 74;
            this.pictureBoxFriends.TabStop = false;
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Location = new System.Drawing.Point(335, 399);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(124, 24);
            this.labelAlbums.TabIndex = 75;
            this.labelAlbums.Text = "Your Albums:";
            // 
            // labelAlbumsInfo
            // 
            this.labelAlbumsInfo.AutoSize = true;
            this.labelAlbumsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsInfo.Location = new System.Drawing.Point(336, 427);
            this.labelAlbumsInfo.Name = "labelAlbumsInfo";
            this.labelAlbumsInfo.Size = new System.Drawing.Size(297, 18);
            this.labelAlbumsInfo.TabIndex = 76;
            this.labelAlbumsInfo.Text = "(Click on an album to view it\'s cover picture)";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(338, 457);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(243, 158);
            this.listBoxAlbums.TabIndex = 77;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxAlbums.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.pictureBoxAlbums.Location = new System.Drawing.Point(533, 529);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 78;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // labelLikePages
            // 
            this.labelLikePages.AutoSize = true;
            this.labelLikePages.Location = new System.Drawing.Point(647, 399);
            this.labelLikePages.Name = "labelLikePages";
            this.labelLikePages.Size = new System.Drawing.Size(152, 24);
            this.labelLikePages.TabIndex = 79;
            this.labelLikePages.Text = "Your Like Pages:";
            // 
            // labelLikePagesInfo
            // 
            this.labelLikePagesInfo.AutoSize = true;
            this.labelLikePagesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikePagesInfo.Location = new System.Drawing.Point(648, 427);
            this.labelLikePagesInfo.Name = "labelLikePagesInfo";
            this.labelLikePagesInfo.Size = new System.Drawing.Size(240, 18);
            this.labelLikePagesInfo.TabIndex = 80;
            this.labelLikePagesInfo.Text = "(Click on a page to view it\'s picture)";
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.DataSource = this.likePagesBindingSource;
            this.listBoxLikePages.DisplayMember = "Name";
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 22;
            this.listBoxLikePages.Location = new System.Drawing.Point(650, 457);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(243, 158);
            this.listBoxLikePages.TabIndex = 81;
            // 
            // pictureBoxLikePages
            // 
            this.pictureBoxLikePages.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxLikePages.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.likePagesBindingSource, "ImageNormal", true));
            this.pictureBoxLikePages.Location = new System.Drawing.Point(845, 529);
            this.pictureBoxLikePages.Name = "pictureBoxLikePages";
            this.pictureBoxLikePages.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLikePages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikePages.TabIndex = 82;
            this.pictureBoxLikePages.TabStop = false;
            // 
            // labelFavoriteTeams
            // 
            this.labelFavoriteTeams.AutoSize = true;
            this.labelFavoriteTeams.Location = new System.Drawing.Point(958, 399);
            this.labelFavoriteTeams.Name = "labelFavoriteTeams";
            this.labelFavoriteTeams.Size = new System.Drawing.Size(190, 24);
            this.labelFavoriteTeams.TabIndex = 83;
            this.labelFavoriteTeams.Text = "Your Favorite Teams:";
            // 
            // labelFavoriteTeamsInfo
            // 
            this.labelFavoriteTeamsInfo.AutoSize = true;
            this.labelFavoriteTeamsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavoriteTeamsInfo.Location = new System.Drawing.Point(959, 427);
            this.labelFavoriteTeamsInfo.Name = "labelFavoriteTeamsInfo";
            this.labelFavoriteTeamsInfo.Size = new System.Drawing.Size(241, 18);
            this.labelFavoriteTeamsInfo.TabIndex = 84;
            this.labelFavoriteTeamsInfo.Text = "(Click on a team to view it\'s picture)";
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.DataSource = this.favoriteTeamsPageBindingSource;
            this.listBoxFavoriteTeams.DisplayMember = "Name";
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 22;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(951, 457);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(243, 158);
            this.listBoxFavoriteTeams.TabIndex = 85;
            // 
            // pictureBoxFavoriteTeams
            // 
            this.pictureBoxFavoriteTeams.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxFavoriteTeams.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.favoriteTeamsPageBindingSource, "ImageNormal", true));
            this.pictureBoxFavoriteTeams.Location = new System.Drawing.Point(1156, 529);
            this.pictureBoxFavoriteTeams.Name = "pictureBoxFavoriteTeams";
            this.pictureBoxFavoriteTeams.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFavoriteTeams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFavoriteTeams.TabIndex = 86;
            this.pictureBoxFavoriteTeams.TabStop = false;
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Enabled = false;
            this.buttonFindMatch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonFindMatch.Location = new System.Drawing.Point(338, 16);
            this.buttonFindMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(268, 32);
            this.buttonFindMatch.TabIndex = 87;
            this.buttonFindMatch.Text = "Find Match";
            this.buttonFindMatch.UseVisualStyleBackColor = true;
            this.buttonFindMatch.Click += new System.EventHandler(this.buttonFindMatch_Click);
            // 
            // buttonFriendOverView
            // 
            this.buttonFriendOverView.Enabled = false;
            this.buttonFriendOverView.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonFriendOverView.Location = new System.Drawing.Point(338, 56);
            this.buttonFriendOverView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFriendOverView.Name = "buttonFriendOverView";
            this.buttonFriendOverView.Size = new System.Drawing.Size(268, 32);
            this.buttonFriendOverView.TabIndex = 88;
            this.buttonFriendOverView.Text = "Friend OverView";
            this.buttonFriendOverView.UseVisualStyleBackColor = true;
            this.buttonFriendOverView.Click += new System.EventHandler(this.buttonFriendOverView_Click);
            // 
            // tabPageHomePage
            // 
            this.tabPageHomePage.AutoScroll = true;
            this.tabPageHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.tabPageHomePage.Controls.Add(this.buttonFriendOverView);
            this.tabPageHomePage.Controls.Add(this.buttonFindMatch);
            this.tabPageHomePage.Controls.Add(this.pictureBoxFavoriteTeams);
            this.tabPageHomePage.Controls.Add(this.listBoxFavoriteTeams);
            this.tabPageHomePage.Controls.Add(this.labelFavoriteTeamsInfo);
            this.tabPageHomePage.Controls.Add(this.labelFavoriteTeams);
            this.tabPageHomePage.Controls.Add(this.pictureBoxLikePages);
            this.tabPageHomePage.Controls.Add(this.listBoxLikePages);
            this.tabPageHomePage.Controls.Add(this.labelLikePagesInfo);
            this.tabPageHomePage.Controls.Add(this.labelLikePages);
            this.tabPageHomePage.Controls.Add(this.pictureBoxAlbums);
            this.tabPageHomePage.Controls.Add(this.listBoxAlbums);
            this.tabPageHomePage.Controls.Add(this.labelAlbumsInfo);
            this.tabPageHomePage.Controls.Add(this.labelAlbums);
            this.tabPageHomePage.Controls.Add(this.pictureBoxFriends);
            this.tabPageHomePage.Controls.Add(this.listBoxFriends);
            this.tabPageHomePage.Controls.Add(this.labelFriendsInfo);
            this.tabPageHomePage.Controls.Add(this.labelFriends);
            this.tabPageHomePage.Controls.Add(this.labelPostsInfo);
            this.tabPageHomePage.Controls.Add(this.listBoxPosts);
            this.tabPageHomePage.Controls.Add(this.labelPosts);
            this.tabPageHomePage.Controls.Add(this.buttonPostNewStatus);
            this.tabPageHomePage.Controls.Add(this.textBoxPostNewStatus);
            this.tabPageHomePage.Controls.Add(this.labelPostNewStatus);
            this.tabPageHomePage.Controls.Add(this.labelUserLocation);
            this.tabPageHomePage.Controls.Add(this.labelUserHometown);
            this.tabPageHomePage.Controls.Add(this.labelUserGender);
            this.tabPageHomePage.Controls.Add(this.labelUserEmail);
            this.tabPageHomePage.Controls.Add(this.labelUserBirthdate);
            this.tabPageHomePage.Controls.Add(this.labelUserDetails);
            this.tabPageHomePage.Controls.Add(this.labelUserFullName);
            this.tabPageHomePage.Controls.Add(this.labelUserFirstName);
            this.tabPageHomePage.Controls.Add(this.pictureBoxProfile);
            this.tabPageHomePage.Controls.Add(this.buttonLogout);
            this.tabPageHomePage.Controls.Add(this.buttonLogin);
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 31);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1274, 668);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "Home Page";
            // 
            // userFriendsBindingSource
            // 
            this.userFriendsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // likePagesBindingSource
            // 
            this.likePagesBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // favoriteTeamsPageBindingSource
            // 
            this.favoriteTeamsPageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikePages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeams)).EndInit();
            this.tabPageHomePage.ResumeLayout(false);
            this.tabPageHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFriendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likePagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteTeamsPageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lableSelcetFriend;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.TabPage tabPageHomePage;
        private System.Windows.Forms.Button buttonFriendOverView;
        private System.Windows.Forms.Button buttonFindMatch;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.Label labelFavoriteTeamsInfo;
        private System.Windows.Forms.Label labelFavoriteTeams;
        private System.Windows.Forms.PictureBox pictureBoxLikePages;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.Label labelLikePagesInfo;
        private System.Windows.Forms.Label labelLikePages;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbumsInfo;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriendsInfo;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelPostsInfo;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.TextBox textBoxPostNewStatus;
        private System.Windows.Forms.Label labelPostNewStatus;
        private System.Windows.Forms.Label labelUserLocation;
        private System.Windows.Forms.Label labelUserHometown;
        private System.Windows.Forms.Label labelUserGender;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.Label labelUserBirthdate;
        private System.Windows.Forms.Label labelUserDetails;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Label labelUserFirstName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.BindingSource userFriendsBindingSource;
        private System.Windows.Forms.BindingSource likePagesBindingSource;
        private System.Windows.Forms.BindingSource favoriteTeamsPageBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}