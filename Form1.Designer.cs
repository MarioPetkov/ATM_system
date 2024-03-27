namespace ATM_system
{
    partial class welcome_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_form));
            btn_continue = new Button();
            label_welcome = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_continue
            // 
            resources.ApplyResources(btn_continue, "btn_continue");
            btn_continue.BackColor = Color.Transparent;
            btn_continue.Cursor = Cursors.Hand;
            btn_continue.Name = "btn_continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // label_welcome
            // 
            resources.ApplyResources(label_welcome, "label_welcome");
            label_welcome.BackColor = Color.Transparent;
            label_welcome.ForeColor = Color.Black;
            label_welcome.Name = "label_welcome";
            // 
            // btn_exit
            // 
            resources.ApplyResources(btn_exit, "btn_exit");
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Name = "btn_exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // welcome_form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_exit);
            Controls.Add(btn_continue);
            Controls.Add(label_welcome);
            Name = "welcome_form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_continue;
        private Label label_welcome;
        private Button btn_exit;
    }
}
