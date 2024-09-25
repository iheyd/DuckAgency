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
        
        private void dislikeButton_MouseEnter(object sender, EventArgs e)
        {
            dislikeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "DislikeLight.png"));
        }
        
        private void dislikeButton_MouseLeave(object sender, EventArgs e)
        {
            dislikeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Dislike.png"));
        }
        
        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "BackLight.png"));
        }
        
        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Back.png"));
        }
        
        private void likeButton_MouseEnter(object sender, EventArgs e)
        {
            likeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "LikeLight.png"));
        }
        
        private void likeButton_MouseLeave(object sender, EventArgs e)
        {
            likeButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Like.png"));
        }
        
        private void subButton_MouseEnter(object sender, EventArgs e)
        {
            subButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "SubLight.png"));
        }
        
        private void subButton_MouseLeave(object sender, EventArgs e)
        {
            subButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "Sub.png"));
        }
        
        private void dislikeButton_MouseDown(object sender, MouseEventArgs e)
        {
            dislikeButton.Location = new Point(dislikeButton.Location.X + 2, dislikeButton.Location.Y + 2);
        }

        private void dislikeButton_MouseUp(object sender, MouseEventArgs e)
        {
            dislikeButton.Location = new Point(dislikeButton.Location.X - 2, dislikeButton.Location.Y - 2);
        }
        
        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            backButton.Location = new Point(backButton.Location.X + 2, backButton.Location.Y + 2);
        }

        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            backButton.Location = new Point(backButton.Location.X - 2, backButton.Location.Y - 2);
        }
        
        private void likeButton_MouseDown(object sender, MouseEventArgs e)
        {
            likeButton.Location = new Point(likeButton.Location.X + 2, likeButton.Location.Y + 2);
        }

        private void likeButton_MouseUp(object sender, MouseEventArgs e)
        {
            likeButton.Location = new Point(likeButton.Location.X - 2, likeButton.Location.Y - 2);
        }
        
        private void subButton_MouseDown(object sender, MouseEventArgs e)
        {
            subButton.Location = new Point(subButton.Location.X + 2, subButton.Location.Y + 2);
        }

        private void subButton_MouseUp(object sender, MouseEventArgs e)
        {
            subButton.Location = new Point(subButton.Location.X - 2, subButton.Location.Y - 2);
        }
        
        private void dislikeButton_Click(object sender, EventArgs e)
        {
            //
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            //
        }
        
        private void likeButton_Click(object sender, EventArgs e)
        {
            //
        }
        
        private void subButton_Click(object sender, EventArgs e)
        {
            //
        }
    }
}