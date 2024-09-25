using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DuckAgency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "HomeLight.png"));
        }
        
        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Home.png"));
        }
        
        private void messageButton_MouseEnter(object sender, EventArgs e)
        {
            messageButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "MessageLight.png"));
        }
        
        private void messageButton_MouseLeave(object sender, EventArgs e)
        {
            messageButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Message.png"));
        }
        
        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "ProfileLight.png"));
        }
        
        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Profile.png"));
        }
        
        private void homeButton_MouseDown(object sender, MouseEventArgs e)
        {
            homeButton.Size = new Size(homeButton.Width - 4, homeButton.Height - 4);
            homeButton.Location = new Point(homeButton.Location.X + 2, homeButton.Location.Y + 2);
        }

        private void homeButton_MouseUp(object sender, MouseEventArgs e)
        {
            homeButton.Size = new Size(homeButton.Width + 4, homeButton.Height + 4);
            homeButton.Location = new Point(homeButton.Location.X - 2, homeButton.Location.Y - 2);
        }
        
        private void messageButton_MouseDown(object sender, MouseEventArgs e)
        {
            messageButton.Size = new Size(messageButton.Width - 4, messageButton.Height - 4);
            messageButton.Location = new Point(messageButton.Location.X + 2, messageButton.Location.Y + 2);
        }

        private void messageButton_MouseUp(object sender, MouseEventArgs e)
        {
            messageButton.Size = new Size(messageButton.Width + 4, messageButton.Height + 4);
            messageButton.Location = new Point(messageButton.Location.X - 2, messageButton.Location.Y - 2);
        }
        
        private void profileButton_MouseDown(object sender, MouseEventArgs e)
        {
            profileButton.Size = new Size(profileButton.Width - 4, profileButton.Height - 4);
            profileButton.Location = new Point(profileButton.Location.X + 2, profileButton.Location.Y + 2);
        }

        private void profileButton_MouseUp(object sender, MouseEventArgs e)
        {
            profileButton.Size = new Size(profileButton.Width + 4, profileButton.Height + 4);
            profileButton.Location = new Point(profileButton.Location.X - 2, profileButton.Location.Y - 2);
        }
        
        private void homeButton_Click(object sender, EventArgs e)
        {
            //
        }
        
        private void messageButton_Click(object sender, EventArgs e)
        {
            Hide();
            MatchmakerForm matchmakerForm = new MatchmakerForm();
            matchmakerForm.Show();
        }
        
        private void profileButton_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }
    }
}