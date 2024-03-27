namespace ATM_system
{
    partial class Services
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            label_services = new Label();
            btn_language = new Button();
            btn_balance = new Button();
            btn_Withdraw = new Button();
            btn_transfer = new Button();
            btn_exit = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_services
            // 
            resources.ApplyResources(label_services, "label_services");
            label_services.BackColor = Color.FromArgb(0, 158, 255);
            label_services.Name = "label_services";
            // 
            // btn_language
            // 
            resources.ApplyResources(btn_language, "btn_language");
            btn_language.BackColor = Color.FromArgb(0, 158, 255);
            btn_language.Cursor = Cursors.Hand;
            btn_language.Name = "btn_language";
            btn_language.UseVisualStyleBackColor = false;
            btn_language.Click += btn_language_Click;
            // 
            // btn_balance
            // 
            resources.ApplyResources(btn_balance, "btn_balance");
            btn_balance.BackColor = Color.FromArgb(0, 158, 255);
            btn_balance.Name = "btn_balance";
            btn_balance.UseVisualStyleBackColor = false;
            btn_balance.Click += btn_balance_Click;
            // 
            // btn_Withdraw
            // 
            resources.ApplyResources(btn_Withdraw, "btn_Withdraw");
            btn_Withdraw.BackColor = Color.FromArgb(0, 158, 255);
            btn_Withdraw.Cursor = Cursors.Hand;
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = false;
            btn_Withdraw.Click += btn_Withdraw_Click;
            // 
            // btn_transfer
            // 
            resources.ApplyResources(btn_transfer, "btn_transfer");
            btn_transfer.BackColor = Color.FromArgb(0, 158, 255);
            btn_transfer.Name = "btn_transfer";
            btn_transfer.UseVisualStyleBackColor = false;
            btn_transfer.Click += btn_transfer_Click;
            // 
            // btn_exit
            // 
            resources.ApplyResources(btn_exit, "btn_exit");
            btn_exit.AutoEllipsis = true;
            btn_exit.BackColor = Color.White;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.ForeColor = Color.FromArgb(0, 158, 255);
            btn_exit.Name = "btn_exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_services);
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(0, 158, 255);
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 158, 255);
            label1.Name = "label1";
            // 
            // Services
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_exit);
            Controls.Add(btn_transfer);
            Controls.Add(btn_Withdraw);
            Controls.Add(btn_balance);
            Controls.Add(btn_language);
            Cursor = Cursors.Hand;
            Name = "Services";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_services;
        private Button btn_language;
        public Button btn_balance;
        public Button btn_Withdraw;
        public Button btn_transfer;
        private Button btn_exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Label label1;
    }
}