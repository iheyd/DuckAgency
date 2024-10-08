using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DuckAgency
{
    public partial class MatchmakerForm : Form
    {
        public MatchmakerForm()
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
            homeButton.Location = new Point(homeButton.Location.X + 2, homeButton.Location.Y + 2);
        }

        private void homeButton_MouseUp(object sender, MouseEventArgs e)
        {
            homeButton.Location = new Point(homeButton.Location.X - 2, homeButton.Location.Y - 2);
        }
        
        private void messageButton_MouseDown(object sender, MouseEventArgs e)
        {
            messageButton.Location = new Point(messageButton.Location.X + 2, messageButton.Location.Y + 2);
        }

        private void messageButton_MouseUp(object sender, MouseEventArgs e)
        {
            messageButton.Location = new Point(messageButton.Location.X - 2, messageButton.Location.Y - 2);
        }
        
        private void profileButton_MouseDown(object sender, MouseEventArgs e)
        {
            profileButton.Location = new Point(profileButton.Location.X + 2, profileButton.Location.Y + 2);
        }

        private void profileButton_MouseUp(object sender, MouseEventArgs e)
        {
            profileButton.Location = new Point(profileButton.Location.X - 2, profileButton.Location.Y - 2);
        }
        
        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        
        private void messageButton_Click(object sender, EventArgs e)
        {
            //
        }
        
        private void profileButton_Click(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }
    }
}