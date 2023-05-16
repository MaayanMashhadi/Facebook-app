
namespace BasicFacebookFeatures.Forms
{
    partial class AlbumForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label countLabel;
            this.profilePB = new System.Windows.Forms.PictureBox();
            this.profileNameLB = new System.Windows.Forms.Label();
            this.numberOfFriendsLB = new System.Windows.Forms.Label();
            this.albumsLB = new System.Windows.Forms.ListBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fetchingInfoLB = new System.Windows.Forms.Label();
            this.ViewCoverLB = new System.Windows.Forms.Label();
            this.AlbumDetailsP = new System.Windows.Forms.Panel();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SortUp = new System.Windows.Forms.Button();
            this.SortDown = new System.Windows.Forms.Button();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.AlbumDetailsP.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(22, 49);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(22, 81);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 152);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(22, 212);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(99, 20);
            imageNormalLabel.TabIndex = 8;
            imageNormalLabel.Text = "Cover photo:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(22, 11);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(56, 20);
            countLabel.TabIndex = 9;
            countLabel.Text = "Count:";
            // 
            // profilePB
            // 
            this.profilePB.Location = new System.Drawing.Point(746, 61);
            this.profilePB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profilePB.Name = "profilePB";
            this.profilePB.Size = new System.Drawing.Size(192, 202);
            this.profilePB.TabIndex = 4;
            this.profilePB.TabStop = false;
            // 
            // profileNameLB
            // 
            this.profileNameLB.AutoSize = true;
            this.profileNameLB.ForeColor = System.Drawing.Color.Black;
            this.profileNameLB.Location = new System.Drawing.Point(742, 289);
            this.profileNameLB.Name = "profileNameLB";
            this.profileNameLB.Size = new System.Drawing.Size(101, 20);
            this.profileNameLB.TabIndex = 9;
            this.profileNameLB.Text = "Profile name:";
            // 
            // numberOfFriendsLB
            // 
            this.numberOfFriendsLB.AutoSize = true;
            this.numberOfFriendsLB.ForeColor = System.Drawing.Color.Black;
            this.numberOfFriendsLB.Location = new System.Drawing.Point(742, 326);
            this.numberOfFriendsLB.Name = "numberOfFriendsLB";
            this.numberOfFriendsLB.Size = new System.Drawing.Size(139, 20);
            this.numberOfFriendsLB.TabIndex = 10;
            this.numberOfFriendsLB.Text = "Number of friends:";
            // 
            // albumsLB
            // 
            this.albumsLB.DataSource = this.albumsBindingSource;
            this.albumsLB.FormattingEnabled = true;
            this.albumsLB.ItemHeight = 20;
            this.albumsLB.Location = new System.Drawing.Point(64, 74);
            this.albumsLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.albumsLB.Name = "albumsLB";
            this.albumsLB.Size = new System.Drawing.Size(614, 684);
            this.albumsLB.TabIndex = 11;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // fetchingInfoLB
            // 
            this.fetchingInfoLB.AutoSize = true;
            this.fetchingInfoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchingInfoLB.Location = new System.Drawing.Point(737, 379);
            this.fetchingInfoLB.Name = "fetchingInfoLB";
            this.fetchingInfoLB.Size = new System.Drawing.Size(125, 25);
            this.fetchingInfoLB.TabIndex = 12;
            this.fetchingInfoLB.Text = "Getting info...";
            this.fetchingInfoLB.Visible = false;
            // 
            // ViewCoverLB
            // 
            this.ViewCoverLB.AutoSize = true;
            this.ViewCoverLB.ForeColor = System.Drawing.Color.Black;
            this.ViewCoverLB.Location = new System.Drawing.Point(717, 430);
            this.ViewCoverLB.Name = "ViewCoverLB";
            this.ViewCoverLB.Size = new System.Drawing.Size(144, 20);
            this.ViewCoverLB.TabIndex = 14;
            this.ViewCoverLB.Text = "View album details:";
            // 
            // AlbumDetailsP
            // 
            this.AlbumDetailsP.Controls.Add(countLabel);
            this.AlbumDetailsP.Controls.Add(this.countLabel1);
            this.AlbumDetailsP.Controls.Add(imageNormalLabel);
            this.AlbumDetailsP.Controls.Add(createdTimeLabel);
            this.AlbumDetailsP.Controls.Add(this.createdTimeDateTimePicker);
            this.AlbumDetailsP.Controls.Add(descriptionLabel);
            this.AlbumDetailsP.Controls.Add(this.descriptionTextBox);
            this.AlbumDetailsP.Controls.Add(nameLabel);
            this.AlbumDetailsP.Controls.Add(this.nameTextBox);
            this.AlbumDetailsP.Location = new System.Drawing.Point(713, 455);
            this.AlbumDetailsP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlbumDetailsP.Name = "AlbumDetailsP";
            this.AlbumDetailsP.Size = new System.Drawing.Size(386, 311);
            this.AlbumDetailsP.TabIndex = 15;
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Count", true));
            this.countLabel1.Location = new System.Drawing.Point(135, 11);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(112, 29);
            this.countLabel1.TabIndex = 10;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumsBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(138, 44);
            this.createdTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "no description..."));
            this.descriptionTextBox.Location = new System.Drawing.Point(138, 81);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(224, 54);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(138, 149);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 26);
            this.nameTextBox.TabIndex = 7;
            // 
            // SortUp
            // 
            this.SortUp.Location = new System.Drawing.Point(64, 28);
            this.SortUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortUp.Name = "SortUp";
            this.SortUp.Size = new System.Drawing.Size(255, 39);
            this.SortUp.TabIndex = 16;
            this.SortUp.Text = "Sort by number of pictures Up";
            this.SortUp.UseVisualStyleBackColor = true;
            this.SortUp.Click += new System.EventHandler(this.sortUp_Click);
            // 
            // SortDown
            // 
            this.SortDown.Location = new System.Drawing.Point(326, 28);
            this.SortDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortDown.Name = "SortDown";
            this.SortDown.Size = new System.Drawing.Size(251, 39);
            this.SortDown.TabIndex = 17;
            this.SortDown.Text = "Sort by number of picturs Down";
            this.SortDown.UseVisualStyleBackColor = true;
            this.SortDown.Click += new System.EventHandler(this.sortDown_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 850);
            this.Controls.Add(this.SortDown);
            this.Controls.Add(this.SortUp);
            this.Controls.Add(this.AlbumDetailsP);
            this.Controls.Add(this.ViewCoverLB);
            this.Controls.Add(this.fetchingInfoLB);
            this.Controls.Add(this.albumsLB);
            this.Controls.Add(this.numberOfFriendsLB);
            this.Controls.Add(this.profileNameLB);
            this.Controls.Add(this.profilePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlbumForm";
            this.Text = "AlbumForm";
            this.Load += new System.EventHandler(this.albumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.AlbumDetailsP.ResumeLayout(false);
            this.AlbumDetailsP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.Label profileNameLB;
        private System.Windows.Forms.Label numberOfFriendsLB;
        private System.Windows.Forms.ListBox albumsLB;
        private System.Windows.Forms.Label fetchingInfoLB;
        private System.Windows.Forms.Label ViewCoverLB;
        private System.Windows.Forms.Panel AlbumDetailsP;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.Button SortUp;
        private System.Windows.Forms.Button SortDown;
    }
}