namespace Final_Project_App
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            button1.Text = "Settings";
            button2.Text = "Our timeline";
            label2.Text = label2.Text;
            label3.Text = label3.Text;
            lable1.Text = lable1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // button for timeline
        private void button2_Click(object sender, EventArgs e)
        {
            
            Page2 page2 = new Page2(this);
            page2.Show();
            this.Hide();  // Hide home page
        }
    }
}
