namespace OpenCleaner
{
    public partial class OpenCleaner : Form
    {
        //counter variable
        int i = 0;
        public OpenCleaner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i = i + 1;
            if (i == 1) {
                InstLabel.Text = "Opening Task Manager.\n Choose what startup programs that you want to disable.";
            } 

            
        }
    }
}