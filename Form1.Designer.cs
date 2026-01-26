namespace Calculator2
{
    partial class Calculator2
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator2));
            AddButton = new Button();
            SubtractButton = new Button();
            MultiplyButton = new Button();
            NumberInput1 = new TextBox();
            NumberInput2 = new TextBox();
            DivideButton = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.ForeColor = SystemColors.ControlText;
            AddButton.Location = new Point(235, 199);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.ForeColor = SystemColors.ControlText;
            SubtractButton.Location = new Point(335, 199);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(94, 29);
            SubtractButton.TabIndex = 1;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.ForeColor = SystemColors.ControlText;
            MultiplyButton.Location = new Point(435, 199);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(94, 29);
            MultiplyButton.TabIndex = 2;
            MultiplyButton.Text = "x";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // NumberInput1
            // 
            NumberInput1.Location = new Point(235, 151);
            NumberInput1.Name = "NumberInput1";
            NumberInput1.Size = new Size(125, 27);
            NumberInput1.TabIndex = 3;
            NumberInput1.TextChanged += textBox1_TextChanged;
            // 
            // NumberInput2
            // 
            NumberInput2.Location = new Point(366, 151);
            NumberInput2.Name = "NumberInput2";
            NumberInput2.Size = new Size(125, 27);
            NumberInput2.TabIndex = 4;
            // 
            // DivideButton
            // 
            DivideButton.ForeColor = SystemColors.ControlText;
            DivideButton.Location = new Point(535, 199);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(94, 29);
            DivideButton.TabIndex = 5;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // Calculator2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DivideButton);
            Controls.Add(NumberInput2);
            Controls.Add(NumberInput1);
            Controls.Add(MultiplyButton);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator2";
            Text = "Calculator2";
            Load += Calculator2_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button AddButton;
        private Button SubtractButton;
        private Button MultiplyButton;
        private TextBox NumberInput1;
        private TextBox NumberInput2;
        private Button DivideButton;
    }
}
