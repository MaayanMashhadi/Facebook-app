
namespace BasicFacebookFeatures.Forms
{
    partial class FriendsForm
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
            this.profilePB = new System.Windows.Forms.PictureBox();
            this.friendsListB = new System.Windows.Forms.ListBox();
            this.profileNameLB = new System.Windows.Forms.Label();
            this.numberOfFriendsLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
            this.SuspendLayout();
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
            // friendsListB
            // 
            this.friendsListB.FormattingEnabled = true;
            this.friendsListB.ItemHeight = 20;
            this.friendsListB.Location = new System.Drawing.Point(262, 75);
            this.friendsListB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendsListB.Name = "friendsListB";
            this.friendsListB.Size = new System.Drawing.Size(293, 824);
            this.friendsListB.TabIndex = 5;
            // 
            // profileNameLB
            // 
            this.profileNameLB.AutoSize = true;
            this.profileNameLB.ForeColor = System.Drawing.Color.Black;
            this.profileNameLB.Location = new System.Drawing.Point(742, 289);
            this.profileNameLB.Name = "profileNameLB";
            this.profileNameLB.Size = new System.Drawing.Size(101, 20);
            this.profileNameLB.TabIndex = 6;
            this.profileNameLB.Text = "Profile name:";
            // 
            // numberOfFriendsLB
            // 
            this.numberOfFriendsLB.AutoSize = true;
            this.numberOfFriendsLB.ForeColor = System.Drawing.Color.Black;
            this.numberOfFriendsLB.Location = new System.Drawing.Point(742, 326);
            this.numberOfFriendsLB.Name = "numberOfFriendsLB";
            this.numberOfFriendsLB.Size = new System.Drawing.Size(139, 20);
            this.numberOfFriendsLB.TabIndex = 7;
            this.numberOfFriendsLB.Text = "Number of friends:";
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.numberOfFriendsLB);
            this.Controls.Add(this.profileNameLB);
            this.Controls.Add(this.friendsListB);
            this.Controls.Add(this.profilePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.ListBox friendsListB;
        private System.Windows.Forms.Label profileNameLB;
        private System.Windows.Forms.Label numberOfFriendsLB;
    }
}