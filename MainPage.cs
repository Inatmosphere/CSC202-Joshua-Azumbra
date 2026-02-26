using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace _2000s_Analog_Horror_Page
{
    // made sure to properly change the file from "form1"
    public partial class MainPage : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 81);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 0;
            button1.Text = "Mission Statement";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(67, 143);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 1;
            button2.Text = "Our Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(67, 204);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 2;
            button3.Text = "Human Resources";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(67, 261);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 3;
            button4.Text = "Sign In";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 5;
            label1.Text = "LambdaCorp Website";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(238, 455);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(682, 29);
            progressBar1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 85);
            label2.Name = "label2";
            label2.Size = new Size(322, 60);
            label2.TabIndex = 7;
            label2.Text = "The Lamda Corperation is a conglemerate that \r\noversees the implementation of internet based \r\ndetection systems.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 143);
            label3.Name = "label3";
            label3.Size = new Size(340, 60);
            label3.TabIndex = 8;
            label3.Text = "Our main product is the Wave Interference system.\r\nA comprehensive person detection method for \r\nevery home.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 213);
            label4.Name = "label4";
            label4.Size = new Size(273, 40);
            label4.TabIndex = 9;
            label4.Text = "Please send any and all HR needs to our\r\ndeticated HR website.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 300);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 300);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1155, 721);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = "LambdaCorp";
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // fields declared as variables
        private Button button1, button2, button3, button4;
        private TextBox textBox1;
        private Label label1, label2, label3, label4, label5, label6;
        private ProgressBar progressBar1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // hiding all the lables so they dont interfere with each other
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        
        // Button_Click with HR intrusion detection
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;
                string input = textBox1.Text.Trim();

                // Check HR status BEFORE hiding labels
                bool wasHRopen = label4.Visible;

                // hide already open lables if another is clicked
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

                // show lables
                switch (clickedButton.Name)
                {
                    case "button1":
                        label2.Visible = true;
                        break;
                    case "button2":
                        label3.Visible = true;
                        break;
                    case "button3":
                        label4.Visible = true;
                        break;
                    case "button4":  // SIGN IN with HR INTRUSION CHECK (HR being useless joke)
                        if (string.IsNullOrEmpty(input))
                            throw new ArgumentException("Employee ID required.", "textBox1");

                        if (input.ToLower() != "corpse")
                            throw new UnauthorizedAccessException($"Access denied for ID: {textBox1.Text}");

                        // with the saved HR state**
                        if (wasHRopen)
                        {
                            label5.Text = "INTRUSION DETECTED";
                            label5.ForeColor = Color.DarkRed;
                            label5.Visible = true;
                            System.Media.SystemSounds.Asterisk.Play();
                            return;
                        }

                        // SUCCESS - corpse + no HR open
                        label5.Text = "ANOMALY CONFIRMED";
                        label5.ForeColor = Color.Red;
                        label5.Visible = true;
                        AnimateLoadingBar();
                        break;
                }
            }
            // No input exeption
            catch (ArgumentException ex)
            {
                label5.Text = $"VALIDATION ERROR: {ex.Message}";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
                System.Media.SystemSounds.Hand.Play();
            }
            // Wrong password exeption
            catch (UnauthorizedAccessException ex)
            {
                label5.Text = "ACCESS DENIED - SECURITY VIOLATION";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }


        // Loading loop and authorization
        private async void AnimateLoadingBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            
            // Loop handling loadingbar
            for (int i = 0; i <= 100; i += 2)
            {
                progressBar1.Value = i;
                label6.Text = $"CORPSE PROTOCOL: {i}%";
                label6.Visible = true;
                label6.ForeColor = Color.Red;

                await Task.Delay(30);
            }

            label6.Text = "PROTOCOL COMPLETE. TERMINATION AUTHORIZED.";
            label6.ForeColor = Color.DarkRed;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

    }
}
