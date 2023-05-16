//using Logic;

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
            this.components = new System.ComponentModel.Container();
            this.groupsLB = new System.Windows.Forms.Label();
            this.timeLineLB = new System.Windows.Forms.Label();
            this.albumsIL = new System.Windows.Forms.ImageList(this.components);
            this.menuePanel = new System.Windows.Forms.Panel();
            this.rememberMeCB = new System.Windows.Forms.CheckBox();
            this.LogoutBT = new System.Windows.Forms.Button();
            this.LoginBT = new System.Windows.Forms.Button();
            this.factBT = new System.Windows.Forms.Button();
            this.gamesBT = new System.Windows.Forms.Button();
            this.albumsBT = new System.Windows.Forms.Button();
            this.friendsBT = new System.Windows.Forms.Button();
            this.postBT = new System.Windows.Forms.Button();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.iconLB = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.titlePanle = new System.Windows.Forms.Panel();
            this.titleLB = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.welcomeLb = new System.Windows.Forms.Label();
            this.menuePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.titlePanle.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsLB
            // 
            this.groupsLB.AutoSize = true;
            this.groupsLB.Location = new System.Drawing.Point(741, 71);
            this.groupsLB.Name = "groupsLB";
            this.groupsLB.Size = new System.Drawing.Size(59, 17);
            this.groupsLB.TabIndex = 62;
            this.groupsLB.Text = "Groups:";
            // 
            // timeLineLB
            // 
            this.timeLineLB.AutoSize = true;
            this.timeLineLB.Location = new System.Drawing.Point(810, 26);
            this.timeLineLB.Name = "timeLineLB";
            this.timeLineLB.Size = new System.Drawing.Size(69, 17);
            this.timeLineLB.TabIndex = 64;
            this.timeLineLB.Text = "Time line:";
            // 
            // albumsIL
            // 
            this.albumsIL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.albumsIL.ImageSize = new System.Drawing.Size(16, 16);
            this.albumsIL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuePanel
            // 
            this.menuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuePanel.Controls.Add(this.rememberMeCB);
            this.menuePanel.Controls.Add(this.LogoutBT);
            this.menuePanel.Controls.Add(this.LoginBT);
            this.menuePanel.Controls.Add(this.factBT);
            this.menuePanel.Controls.Add(this.gamesBT);
            this.menuePanel.Controls.Add(this.albumsBT);
            this.menuePanel.Controls.Add(this.friendsBT);
            this.menuePanel.Controls.Add(this.postBT);
            this.menuePanel.Controls.Add(this.iconPanel);
            this.menuePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuePanel.Location = new System.Drawing.Point(0, 0);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(220, 807);
            this.menuePanel.TabIndex = 71;
            // 
            // rememberMeCB
            // 
            this.rememberMeCB.AutoSize = true;
            this.rememberMeCB.Location = new System.Drawing.Point(22, 605);
            this.rememberMeCB.Name = "rememberMeCB";
            this.rememberMeCB.Size = new System.Drawing.Size(190, 26);
            this.rememberMeCB.TabIndex = 1;
            this.rememberMeCB.Text = "Remember settings";
            this.rememberMeCB.UseVisualStyleBackColor = true;
            this.rememberMeCB.Visible = false;
            // 
            // LogoutBT
            // 
            this.LogoutBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutBT.FlatAppearance.BorderSize = 0;
            this.LogoutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBT.ForeColor = System.Drawing.Color.White;
            this.LogoutBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBT.Location = new System.Drawing.Point(0, 440);
            this.LogoutBT.Name = "LogoutBT";
            this.LogoutBT.Size = new System.Drawing.Size(220, 60);
            this.LogoutBT.TabIndex = 78;
            this.LogoutBT.Text = "Logout";
            this.LogoutBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBT.UseVisualStyleBackColor = true;
            this.LogoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // LoginBT
            // 
            this.LoginBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginBT.FlatAppearance.BorderSize = 0;
            this.LoginBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.ForeColor = System.Drawing.Color.White;
            this.LoginBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBT.Location = new System.Drawing.Point(0, 380);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(220, 60);
            this.LoginBT.TabIndex = 77;
            this.LoginBT.Text = "Login";
            this.LoginBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // factBT
            // 
            this.factBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.factBT.FlatAppearance.BorderSize = 0;
            this.factBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factBT.ForeColor = System.Drawing.Color.White;
            this.factBT.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_questions_48;
            this.factBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.factBT.Location = new System.Drawing.Point(0, 320);
            this.factBT.Name = "factBT";
            this.factBT.Size = new System.Drawing.Size(220, 60);
            this.factBT.TabIndex = 76;
            this.factBT.Text = "Get random fact";
            this.factBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.factBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.factBT.UseVisualStyleBackColor = true;
            //this.factBT.Click += new System.EventHandler(this.factBT_Click);
            this.factBT.Click += penalBT_Click;
            // 
            // gamesBT
            // 
            this.gamesBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamesBT.FlatAppearance.BorderSize = 0;
            this.gamesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesBT.ForeColor = System.Drawing.Color.White;
            this.gamesBT.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_visual_game_boy_48;
            this.gamesBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gamesBT.Location = new System.Drawing.Point(0, 260);
            this.gamesBT.Name = "gamesBT";
            this.gamesBT.Size = new System.Drawing.Size(220, 60);
            this.gamesBT.TabIndex = 75;
            this.gamesBT.Text = "Games";
            this.gamesBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gamesBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gamesBT.UseVisualStyleBackColor = true;
            //this.gamesBT.Click += new System.EventHandler(this.gamesBT_Click);
            this.gamesBT.Click += penalBT_Click;
            // 
            // albumsBT
            // 
            this.albumsBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumsBT.FlatAppearance.BorderSize = 0;
            this.albumsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsBT.ForeColor = System.Drawing.Color.White;
            this.albumsBT.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_image_gallery_48;
            this.albumsBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumsBT.Location = new System.Drawing.Point(0, 200);
            this.albumsBT.Name = "albumsBT";
            this.albumsBT.Size = new System.Drawing.Size(220, 60);
            this.albumsBT.TabIndex = 74;
            this.albumsBT.Text = "Albums";
            this.albumsBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.albumsBT.UseVisualStyleBackColor = true;
            //this.albumsBT.Click += new System.EventHandler(this.albumsBT_Click);
            this.albumsBT.Click += penalBT_Click;
            // 
            // friendsBT
            // 
            this.friendsBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendsBT.FlatAppearance.BorderSize = 0;
            this.friendsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsBT.ForeColor = System.Drawing.Color.White;
            this.friendsBT.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_team_48;
            this.friendsBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsBT.Location = new System.Drawing.Point(0, 140);
            this.friendsBT.Name = "friendsBT";
            this.friendsBT.Size = new System.Drawing.Size(220, 60);
            this.friendsBT.TabIndex = 73;
            this.friendsBT.Text = "Friends";
            this.friendsBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.friendsBT.UseVisualStyleBackColor = true;
            //this.friendsBT.Click += new System.EventHandler(this.friendsBT_Click);
            this.friendsBT.Click += penalBT_Click;
            // 
            // postBT
            // 
            this.postBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.postBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.postBT.FlatAppearance.BorderSize = 0;
            this.postBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBT.ForeColor = System.Drawing.Color.White;
            this.postBT.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_page_48;
            this.postBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postBT.Location = new System.Drawing.Point(0, 80);
            this.postBT.Name = "postBT";
            this.postBT.Size = new System.Drawing.Size(220, 60);
            this.postBT.TabIndex = 72;
            this.postBT.Text = "Posts";
            this.postBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.postBT.UseVisualStyleBackColor = false;
            //this.postBT.Click += new System.EventHandler(this.postBT_Click);
            this.postBT.Click += penalBT_Click;
            // 
            // iconPanel
            // 
            this.iconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.iconPanel.Controls.Add(this.iconLB);
            this.iconPanel.Controls.Add(this.pictureBoxIcon);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(220, 80);
            this.iconPanel.TabIndex = 72;
            // 
            // iconLB
            // 
            this.iconLB.AutoSize = true;
            this.iconLB.BackColor = System.Drawing.Color.Transparent;
            this.iconLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLB.ForeColor = System.Drawing.Color.White;
            this.iconLB.Location = new System.Drawing.Point(63, 26);
            this.iconLB.Name = "iconLB";
            this.iconLB.Size = new System.Drawing.Size(151, 29);
            this.iconLB.TabIndex = 73;
            this.iconLB.Text = "OurFacbook";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_facebook_f_50;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIcon.TabIndex = 73;
            this.pictureBoxIcon.TabStop = false;
            // 
            // titlePanle
            // 
            this.titlePanle.BackColor = System.Drawing.Color.MediumPurple;
            this.titlePanle.Controls.Add(this.titleLB);
            this.titlePanle.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanle.Location = new System.Drawing.Point(220, 0);
            this.titlePanle.Name = "titlePanle";
            this.titlePanle.Size = new System.Drawing.Size(952, 80);
            this.titlePanle.TabIndex = 72;
            // 
            // titleLB
            // 
            this.titleLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.ForeColor = System.Drawing.Color.White;
            this.titleLB.Location = new System.Drawing.Point(404, 26);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(174, 33);
            this.titleLB.TabIndex = 73;
            this.titleLB.Text = "Login profile";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.welcomeLb);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(220, 80);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(952, 727);
            this.MainPanel.TabIndex = 73;
            // 
            // welcomeLb
            // 
            this.welcomeLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.welcomeLb.AutoSize = true;
            this.welcomeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLb.ForeColor = System.Drawing.Color.Black;
            this.welcomeLb.Location = new System.Drawing.Point(214, 286);
            this.welcomeLb.Name = "welcomeLb";
            this.welcomeLb.Size = new System.Drawing.Size(552, 48);
            this.welcomeLb.TabIndex = 0;
            this.welcomeLb.Text = "Welcome to ourFacbook app";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 807);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.titlePanle);
            this.Controls.Add(this.menuePanel);
            this.Controls.Add(this.timeLineLB);
            this.Controls.Add(this.groupsLB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurFacebook";
            this.menuePanel.ResumeLayout(false);
            this.menuePanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.titlePanle.ResumeLayout(false);
            this.titlePanle.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.Label groupsLB;
        private System.Windows.Forms.Label timeLineLB;
        private System.Windows.Forms.ImageList albumsIL;
        private System.Windows.Forms.Panel menuePanel;
        private System.Windows.Forms.Button postBT;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Button gamesBT;
        private System.Windows.Forms.Button albumsBT;
        private System.Windows.Forms.Button friendsBT;
        private System.Windows.Forms.Panel titlePanle;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label iconLB;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.Button factBT;
        private System.Windows.Forms.Label welcomeLb;
        private System.Windows.Forms.Button LogoutBT;
        private System.Windows.Forms.CheckBox rememberMeCB;
    }
}

