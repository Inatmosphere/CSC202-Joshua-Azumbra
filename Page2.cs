using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project_App
{
    public partial class Page2 : Form
    {
        // The five variables
        private test homeForm;
        private PictureBox[] pictureBoxes;  // Array for all 10 picture boxes
        private System.Windows.Forms.Timer animationTimer;
        private int currentImageIndex = 0;  // Tracks animation progress
        private int[] yearMapping = new int[] { 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026 };  // NEW: Year array
        public Page2(test home = null)
        {
            InitializeComponent();
            homeForm = home;
            InitializePictureBoxArray();
            SetupAnimationTimer();
        }

        // throwing picture boxes into array
        private void InitializePictureBoxArray()
        {
            pictureBoxes = new PictureBox[10];
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;
        }


        private void SetupAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer();  
            animationTimer.Interval = 250; // setting interval for image pop up
            animationTimer.Tick += AnimationTimer_Tick;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Start/Reset animation sequence
            currentImageIndex = 0;
            HideAllPictures();
            hScrollBar1.Value = 0;  // Reset scrollbar
            button2.Text = "Animating...";
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < pictureBoxes.Length)
            {
                // Show next image with pop effect
                pictureBoxes[currentImageIndex].Visible = true;

                // brief scale-up effect (pop)
                Size originalSize = pictureBoxes[currentImageIndex].Size;
                pictureBoxes[currentImageIndex].Size = new Size(160, 150);

                currentImageIndex++;
            }
            else
            {
                // Animation complete
                animationTimer.Stop();
                button2.Text = "Reset Gallery";
            }
        }


        // back to home page
        private void button1_Click(object sender, EventArgs e)
        {
            if (homeForm != null)
            {
                homeForm.Show();
            }
            else
            {
                test home = new test();
                home.Show();
            }
            this.Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Stop animation if scrolling
            if (animationTimer != null) animationTimer.Stop();
            button2.Text = "Show Gallery";

            int scrollValue = hScrollBar1.Value;
            HideAllPictures();

            // Array-based reveal loop
            int imagesToShow = Math.Min(scrollValue / 26, 10);
            for (int i = 0; i < imagesToShow; i++)
            {
                pictureBoxes[i].Visible = true;
            }
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            button1.Text = "Back to Home";
            button2.Text = "Show Gallery";
            button3.Text = "Show Year →";  
            textBox1.Text = "2017-2026";   // Time range we had with Prince
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 260;
            hScrollBar1.Value = 0;
            HideAllPictures();
        }

        // loop used to hide the pictures
        private void HideAllPictures()
        {
            // array-based hiding
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if textbox is empty
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "Textbox cannot be empty";
                    return;
                }

                // Parse year input safely
                if (int.TryParse(textBox1.Text, out int inputYear))
                {
                    // Validate year range (business logic check)
                    if (inputYear < 2017 || inputYear > 2026)
                    {
                        textBox1.Text = "Year must be 2017-2026";
                        return;
                    }

                    // Stop animation and reset button state
                    if (animationTimer != null && animationTimer.Enabled)
                    {
                        animationTimer.Stop();
                    }
                    button2.Text = "Show Gallery";

                    // Safe array operations with null check
                    if (pictureBoxes != null && yearMapping != null)
                    {
                        int yearIndex = Array.IndexOf(yearMapping, inputYear);

                        if (yearIndex >= 0)
                        {
                            HideAllPictures();
                            // Show images up to selected year
                            for (int i = 0; i <= yearIndex; i++)
                            {
                                pictureBoxes[i].Visible = true;
                            }
                            textBox1.Text = $"Showed 2017-{yearMapping[yearIndex]} ({yearIndex + 1} images)";
                        }
                        else
                        {
                            textBox1.Text = "Year not found in range";
                        }
                    }
                    else
                    {
                        textBox1.Text = "Gallery not initialized";
                    }
                }
                else
                {
                    textBox1.Text = "Enter valid number (2017-2026)";
                }
            }
            //Exeption handling
            catch (Exception ex)
            {
                // Catch any unexpected errors
                textBox1.Text = $"Error: {ex.Message}";

                // Ensure safe state
                if (animationTimer != null) animationTimer.Stop();
                button2.Text = "Show Gallery";
            }
        }



    }
}
