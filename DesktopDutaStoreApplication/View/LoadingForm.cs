using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDutaStoreApplication.View
{
    public partial class LoadingForm : Form
    {
        private int currentImageIndex = 0;
        private readonly string[] imageNames = { "Loading1", "Loading2", "Loading3", "Loading4", "Loading5" };

        public LoadingForm()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            // Set initial image
            UpdateImage();

            // Set up a Timer to handle animation
            Timer timer = new Timer();
            timer.Interval = 1500; // Set the interval between image changes (in milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async Task SimulateLoadingProcess()
        {
            try
            {
                // Simulate a time-consuming process (replace this with your actual loading logic)
                await Task.Delay(5000); // Simulating a 5-second loading process
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during loading process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update to the next image
            currentImageIndex = (currentImageIndex + 1) % imageNames.Length;
            UpdateImage();

            // Check if loading is complete
            if (currentImageIndex == imageNames.Length - 1)
            {
                // Stop the timer
                ((Timer)sender).Stop();

                // Open the login form
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => ((Timer)sender).Start(); // Restart the timer when login form is closed
                loginForm.Show();

                // Close the current form
                this.Hide();
            }
        }

        private void UpdateImage()
        {
            // Get the image from Resources based on the current index
            string imageName = imageNames[currentImageIndex];
            Image image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

            // Update PictureBox with the new image
            pictureBoxLoadingBar.Image = image;
        }
    }
}
