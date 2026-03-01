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

        // Product model
        private class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public override string ToString() => $"{Name} - ${Price}";
        }

        private Product[] products;

        // fields declared as variables
        private Button button1, button2, button3, button4;
        private TextBox textBox1;
        private Label label1, label2, label3, label4, label5, label6, label7;
        private NumericUpDown numericUpDown1;
        private CheckedListBox checkedListBox1, checkedListBox2;
        private Label label8;
        private ProgressBar progressBar1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public MainPage()
        {
            InitializeComponent();
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
            numericUpDown1 = new NumericUpDown();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            textBox1.Location = new Point(298, 261);
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
            label2.Size = new Size(328, 60);
            label2.TabIndex = 7;
            label2.Text = "The Lambda Corporation is a conglomerate that\r\noversees the implementation of internet-based\r\ndetection systems.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 143);
            label3.Name = "label3";
            label3.Size = new Size(340, 60);
            label3.TabIndex = 8;
            label3.Text = "Our main product is the Wave Interference system.\r\nA comprehensive person detection method for\r\nevery home.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 213);
            label4.Name = "label4";
            label4.Size = new Size(273, 40);
            label4.TabIndex = 9;
            label4.Text = "Please send any and all HR needs to our\r\ndedicated HR website.";
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1024, 145);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(850, 145);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(168, 114);
            checkedListBox1.TabIndex = 13;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(850, 213);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(168, 114);
            checkedListBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1024, 183);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 15;
            label7.Text = "TOTAL: $0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1024, 213);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 16;
            label8.Text = "TOTAL: $0";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1155, 721);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // hiding all the lables so they dont interfere with each other
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            // hiding aLL product UI completely at start
            checkedListBox1.Visible = false;
            label7.Visible = false;
            checkedListBox2.Visible = false;
            label8.Visible = false;

            // Product Array
            products = new[]
            {
        new Product { Name = "Home Scanner",  Price = 25m  },
        new Product { Name = "Wave Sensor",   Price = 99m  },
        new Product { Name = "Full Suite",    Price = 199m }
    };
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(products);
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

            // HR websites Array
            var complaintProducts = new[]
            {
    new Product { Name = "Compensation Dispute", Price = 1m },    // HR website 1
    new Product { Name = "Retaliation Complaint", Price = 2m },   // HR website 2  
    new Product { Name = "OSHA Violation", Price = 3m }           // HR website 3
};

            checkedListBox2.Items.Clear();
            checkedListBox2.Items.AddRange(complaintProducts);
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
        }

        // HR websites 
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                string websiteLink = "No website selected";
                int highestSite = 0;

                foreach (var item in checkedListBox2.CheckedItems.Cast<object>())
                {
                    if (item is Product p && p.Price >= 1m && p.Price <= 3m)
                        highestSite = Math.Max(highestSite, (int)p.Price);
                }

                if (e.Index >= 0 && e.Index < checkedListBox2.Items.Count)
                {
                    if (checkedListBox2.Items[e.Index] is Product changing && changing.Price >= 1m && changing.Price <= 3m)
                    {
                        int siteNum = (int)changing.Price;
                        if (e.NewValue == CheckState.Checked)
                            highestSite = Math.Max(highestSite, siteNum);
                    }
                }

                if (highestSite >= 1 && highestSite <= 3)
                    websiteLink = $"HR WEBSITE {highestSite}: http://hr.lambda-corp.com/{highestSite}";

                label8.Text = websiteLink;
                label8.ForeColor = Color.DarkBlue;
            }
            // Array exeption message
            catch (Exception)
            {
                label8.Text = "WEBSITE ERROR";
                label8.ForeColor = Color.Red;
            }
        }





        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;
                string input = textBox1.Text.Trim();

                bool wasHRopen = label4.Visible;

                // Hide ALL content sections
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

                // Hide ALL product UI 
                checkedListBox1.Visible = false;
                label7.Visible = false;
                checkedListBox2.Visible = false;  
                label8.Visible = false;           

                switch (clickedButton.Name)
                {
                    case "button1": // Mission statement Button
                        label2.Visible = true;
                        break;

                    case "button2": // Product Button
                        label3.Visible = true;
                        checkedListBox1.Visible = true;
                        label7.Visible = true;
                        label7.Text = "TOTAL: $0";  // Reset
                        break;

                    case "button3":  // HR Button
                        label4.Visible = true;
                        checkedListBox2.Visible = true; 
                        label8.Visible = true;           
                        label8.Text = "HR FEE: $0.00";   // Reset
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


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            decimal total = 0m;

            // Sum currently checked items
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item is Product p)
                    total += p.Price;
            }

            // Adjust for item being toggled
            if (checkedListBox1.Items[e.Index] is Product changing)
            {
                if (e.NewValue == CheckState.Checked)
                    total += changing.Price;
                else if (e.NewValue == CheckState.Unchecked)
                    total -= changing.Price;
            }

            label7.Text = $"TOTAL: ${total}";
            label7.ForeColor = Color.DarkGreen;
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

        private void label2_Click(object sender, EventArgs e) { }
    }
}
