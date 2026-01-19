namespace GUI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MultiplyButton = new Button();
            SubtractButton = new Button();
            Input1 = new TextBox();
            Input2 = new TextBox();
            DivideButton = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(259, 226);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(94, 29);
            MultiplyButton.TabIndex = 0;
            MultiplyButton.Text = "+";
            MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(359, 226);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(94, 29);
            SubtractButton.TabIndex = 1;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = true;
            // 
            // Input1
            // 
            Input1.Location = new Point(259, 139);
            Input1.Name = "Input1";
            Input1.Size = new Size(125, 27);
            Input1.TabIndex = 2;
            // 
            // Input2
            // 
            Input2.Location = new Point(491, 139);
            Input2.Name = "Input2";
            Input2.Size = new Size(125, 27);
            Input2.TabIndex = 3;
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(459, 226);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(94, 29);
            DivideButton.TabIndex = 4;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(259, 261);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(359, 261);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(852, 600);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(DivideButton);
            Controls.Add(Input2);
            Controls.Add(Input1);
            Controls.Add(SubtractButton);
            Controls.Add(MultiplyButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private Button MultiplyButton;
        private Button SubtractButton;
        private TextBox Input1;
        private TextBox Input2;
        private Button DivideButton;
        private Button button4;
        private Button button5;
    }
}
