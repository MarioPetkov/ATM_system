namespace ATM_system
{
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
            btn_continue.Click += Btn_continue_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            language_form languageForm = new language_form(); // Създаваме инстанция на формата Language_form
            languageForm.Show(); // Показваме формата Language_form
            this.Hide(); // Скриваме текущата форма
        }
    }
}
