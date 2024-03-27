namespace ATM_system
{
    public partial class welcome_form : Form
    {  
        
        public welcome_form()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            var servicesForm = new Services();
            var languageForm = new Language_form(servicesForm);
            languageForm.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
