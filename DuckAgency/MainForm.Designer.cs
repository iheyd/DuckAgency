using System.ComponentModel;

namespace DuckAgency
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.homeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.dislikeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(7, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(64, 64);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeButton_MouseDown);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            this.homeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.homeButton_MouseUp);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileButton.BackgroundImage")));
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.profileButton.Location = new System.Drawing.Point(553, 4);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(64, 64);
            this.profileButton.TabIndex = 2;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            this.profileButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.profileButton_MouseDown);
            this.profileButton.MouseEnter += new System.EventHandler(this.profileButton_MouseEnter);
            this.profileButton.MouseLeave += new System.EventHandler(this.profileButton_MouseLeave);
            this.profileButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.profileButton_MouseUp);
            // 
            // messageButton
            // 
            this.messageButton.BackColor = System.Drawing.Color.Transparent;
            this.messageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("messageButton.BackgroundImage")));
            this.messageButton.FlatAppearance.BorderSize = 0;
            this.messageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.messageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.messageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.messageButton.Location = new System.Drawing.Point(481, 4);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(64, 64);
            this.messageButton.TabIndex = 1;
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            this.messageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.messageButton_MouseDown);
            this.messageButton.MouseEnter += new System.EventHandler(this.messageButton_MouseEnter);
            this.messageButton.MouseLeave += new System.EventHandler(this.messageButton_MouseLeave);
            this.messageButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.messageButton_MouseUp);
            // 
            // dislikeButton
            // 
            this.dislikeButton.BackColor = System.Drawing.Color.Transparent;
            this.dislikeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dislikeButton.BackgroundImage")));
            this.dislikeButton.FlatAppearance.BorderSize = 0;
            this.dislikeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dislikeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dislikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dislikeButton.Location = new System.Drawing.Point(30, 348);
            this.dislikeButton.Name = "dislikeButton";
            this.dislikeButton.Size = new System.Drawing.Size(64, 64);
            this.dislikeButton.TabIndex = 3;
            this.dislikeButton.UseVisualStyleBackColor = false;
            this.dislikeButton.Click += new System.EventHandler(this.dislikeButton_Click);
            this.dislikeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dislikeButton_MouseDown);
            this.dislikeButton.MouseEnter += new System.EventHandler(this.dislikeButton_MouseEnter);
            this.dislikeButton.MouseLeave += new System.EventHandler(this.dislikeButton_MouseLeave);
            this.dislikeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dislikeButton_MouseUp);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(124, 348);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 64);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseDown);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseUp);
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.Transparent;
            this.likeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("likeButton.BackgroundImage")));
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Location = new System.Drawing.Point(218, 348);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(64, 64);
            this.likeButton.TabIndex = 5;
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            this.likeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.likeButton_MouseDown);
            this.likeButton.MouseEnter += new System.EventHandler(this.likeButton_MouseEnter);
            this.likeButton.MouseLeave += new System.EventHandler(this.likeButton_MouseLeave);
            this.likeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.likeButton_MouseUp);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.Transparent;
            this.subButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subButton.BackgroundImage")));
            this.subButton.FlatAppearance.BorderSize = 0;
            this.subButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.subButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subButton.Location = new System.Drawing.Point(308, 348);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(288, 64);
            this.subButton.TabIndex = 6;
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            this.subButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subButton_MouseDown);
            this.subButton.MouseEnter += new System.EventHandler(this.subButton_MouseEnter);
            this.subButton.MouseLeave += new System.EventHandler(this.subButton_MouseLeave);
            this.subButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.subButton_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dislikeButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.homeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckAgency | Главная";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button subButton;

        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button dislikeButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;

        #endregion
    }
}