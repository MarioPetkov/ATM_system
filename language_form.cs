using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace ATM_system
{
    public partial class Language_form : Form
    {
        private Services obj_services;

        public Language_form(Services servicesForm)
        {
            InitializeComponent();
            obj_services = servicesForm;
        }

        private void radbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
               
                switch (radioButton.Name)
                {
                    case "radbtn_english":
                        ChangeLanguage("en-US");
                        break;
                    case "radbtn_bulgarian":
                        ChangeLanguage("bg-BG");
                        break;
                    case "radbtn_french":
                        ChangeLanguage("fr-FR");
                        break;
                    case "radbtn_german":
                        ChangeLanguage("de-DE");
                        break;
                }
            }
        }

        private void ChangeLanguage(string cultureName)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureName);

            // Update language for all open forms
            foreach (Form form in Application.OpenForms)
            {
                ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
                resources.ApplyResources(form, "$this");
                ApplyResources(form.Controls, resources);
            }
        }

        private void ApplyResources(Control.ControlCollection controls, ComponentResourceManager resources)
        {
            foreach (Control control in controls)
            {
                resources.ApplyResources(control, control.Name);
                if (control.Controls.Count > 0)
                {
                    ApplyResources(control.Controls, resources);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            obj_services.Show(); // Show the existing Services form
            this.Hide();
        }
    }
}
