namespace ER_ProcessingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            General.role = "TEACHER";
            LoginForm login = new LoginForm();
            login.Show(); ;
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            General.role = "STUDENT";
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
