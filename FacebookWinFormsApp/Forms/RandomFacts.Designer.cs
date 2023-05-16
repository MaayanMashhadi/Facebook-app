
namespace BasicFacebookFeatures.Forms
{
    partial class RandomFacts
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
            this.randomFactTB = new System.Windows.Forms.RichTextBox();
            this.getFactBT = new System.Windows.Forms.Button();
            this.shareInAppBT = new System.Windows.Forms.Button();
            this.GettingInfoLB = new System.Windows.Forms.Label();
            this.publishLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomFactTB
            // 
            this.randomFactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomFactTB.Location = new System.Drawing.Point(57, 52);
            this.randomFactTB.Name = "randomFactTB";
            this.randomFactTB.Size = new System.Drawing.Size(585, 260);
            this.randomFactTB.TabIndex = 0;
            this.randomFactTB.Text = "To get a random fact push the button :)";
            // 
            // getFactBT
            // 
            this.getFactBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFactBT.Location = new System.Drawing.Point(57, 409);
            this.getFactBT.Name = "getFactBT";
            this.getFactBT.Size = new System.Drawing.Size(192, 58);
            this.getFactBT.TabIndex = 1;
            this.getFactBT.Text = "Get a random fact";
            this.getFactBT.UseVisualStyleBackColor = true;
            this.getFactBT.Click += new System.EventHandler(this.getFactBT_Click);
            // 
            // shareInAppBT
            // 
            this.shareInAppBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareInAppBT.Location = new System.Drawing.Point(447, 410);
            this.shareInAppBT.Name = "shareInAppBT";
            this.shareInAppBT.Size = new System.Drawing.Size(195, 58);
            this.shareInAppBT.TabIndex = 2;
            this.shareInAppBT.Text = "Share in app posts";
            this.shareInAppBT.UseVisualStyleBackColor = true;
            this.shareInAppBT.Click += new System.EventHandler(this.shareInAppBT_Click);
            // 
            // GettingInfoLB
            // 
            this.GettingInfoLB.AutoSize = true;
            this.GettingInfoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GettingInfoLB.ForeColor = System.Drawing.Color.Black;
            this.GettingInfoLB.Location = new System.Drawing.Point(53, 350);
            this.GettingInfoLB.Name = "GettingInfoLB";
            this.GettingInfoLB.Size = new System.Drawing.Size(191, 20);
            this.GettingInfoLB.TabIndex = 9;
            this.GettingInfoLB.Text = "Getting random fact...";
            this.GettingInfoLB.Visible = false;
            // 
            // publishLB
            // 
            this.publishLB.AutoSize = true;
            this.publishLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishLB.Location = new System.Drawing.Point(53, 325);
            this.publishLB.Name = "publishLB";
            this.publishLB.Size = new System.Drawing.Size(422, 20);
            this.publishLB.TabIndex = 10;
            this.publishLB.Text = "The post was successfully published in the app...";
            this.publishLB.Visible = false;
            // 
            // RandomFacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.publishLB);
            this.Controls.Add(this.GettingInfoLB);
            this.Controls.Add(this.shareInAppBT);
            this.Controls.Add(this.getFactBT);
            this.Controls.Add(this.randomFactTB);
            this.Name = "RandomFacts";
            this.Text = "RandomFacts";
            this.Load += new System.EventHandler(this.randomFacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox randomFactTB;
        private System.Windows.Forms.Button getFactBT;
        private System.Windows.Forms.Button shareInAppBT;
        private System.Windows.Forms.Label GettingInfoLB;
        private System.Windows.Forms.Label publishLB;
    }
}