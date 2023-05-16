
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class PostsForm
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
            this.profileNameLb = new System.Windows.Forms.Label();
            this.numbersOfFriendsLB = new System.Windows.Forms.Label();
            this.timeLineListB = new System.Windows.Forms.ListBox();
            this.FetchingPostsLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePB
            // 
            this.profilePB.Location = new System.Drawing.Point(746, 61);
            this.profilePB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profilePB.Name = "profilePB";
            this.profilePB.Size = new System.Drawing.Size(192, 202);
            this.profilePB.TabIndex = 0;
            this.profilePB.TabStop = false;
            // 
            // profileNameLb
            // 
            this.profileNameLb.AutoSize = true;
            this.profileNameLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileNameLb.ForeColor = System.Drawing.Color.Black;
            this.profileNameLb.Location = new System.Drawing.Point(742, 289);
            this.profileNameLb.Name = "profileNameLb";
            this.profileNameLb.Size = new System.Drawing.Size(101, 20);
            this.profileNameLb.TabIndex = 1;
            this.profileNameLb.Text = "Profile name:";
            this.profileNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numbersOfFriendsLB
            // 
            this.numbersOfFriendsLB.AutoSize = true;
            this.numbersOfFriendsLB.ForeColor = System.Drawing.Color.Black;
            this.numbersOfFriendsLB.Location = new System.Drawing.Point(742, 326);
            this.numbersOfFriendsLB.Name = "numbersOfFriendsLB";
            this.numbersOfFriendsLB.Size = new System.Drawing.Size(139, 20);
            this.numbersOfFriendsLB.TabIndex = 2;
            this.numbersOfFriendsLB.Text = "Number of friends:";
            // 
            // timeLineListB
            // 
            this.timeLineListB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.timeLineListB.FormattingEnabled = true;
            this.timeLineListB.ItemHeight = 16;
            this.timeLineListB.Location = new System.Drawing.Point(106, 61);
            this.timeLineListB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeLineListB.Name = "timeLineListB";
            this.timeLineListB.Size = new System.Drawing.Size(583, 624);
            this.timeLineListB.TabIndex = 3;
            timeLineListB.DrawItem += timeLineListB_DrawItem;
            timeLineListB.MeasureItem += timeLineListB_MeasureItem;
            // 
            // FetchingPostsLB
            // 
            this.FetchingPostsLB.AutoSize = true;
            this.FetchingPostsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchingPostsLB.ForeColor = System.Drawing.Color.Black;
            this.FetchingPostsLB.Location = new System.Drawing.Point(742, 385);
            this.FetchingPostsLB.Name = "FetchingPostsLB";
            this.FetchingPostsLB.Size = new System.Drawing.Size(310, 29);
            this.FetchingPostsLB.TabIndex = 4;
            this.FetchingPostsLB.Text = "Loading posts please wait...";
            this.FetchingPostsLB.Visible = true;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 838);
            this.Controls.Add(this.FetchingPostsLB);
            this.Controls.Add(this.timeLineListB);
            this.Controls.Add(this.numbersOfFriendsLB);
            this.Controls.Add(this.profileNameLb);
            this.Controls.Add(this.profilePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TimeLineListB_DrawItem(object sender, DrawItemEventArgs e)
        {
            throw new System.NotImplementedException();
        }

      

        private void TimeLineListB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.Label profileNameLb;
        private System.Windows.Forms.Label numbersOfFriendsLB;
        private System.Windows.Forms.ListBox timeLineListB;
        private Label FetchingPostsLB;
    }
}