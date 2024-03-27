namespace ATM_system
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            panel3 = new Panel();
            label_services = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btn_exit = new Button();
            btn_back = new Button();
            btn_deposit = new Button();
            tb_balance = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.FromArgb(0, 158, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label_services);
            panel3.Controls.Add(pictureBox2);
            panel3.Name = "panel3";
            // 
            // label_services
            // 
            resources.ApplyResources(label_services, "label_services");
            label_services.BackColor = Color.FromArgb(0, 158, 255);
            label_services.Name = "label_services";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 158, 255);
            label1.Name = "label1";
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
            // btn_back
            // 
            resources.ApplyResources(btn_back, "btn_back");
            btn_back.AutoEllipsis = true;
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.ForeColor = Color.FromArgb(0, 158, 255);
            btn_back.Name = "btn_back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_deposit
            // 
            resources.ApplyResources(btn_deposit, "btn_deposit");
            btn_deposit.AutoEllipsis = true;
            btn_deposit.BackColor = Color.White;
            btn_deposit.Cursor = Cursors.Hand;
            btn_deposit.ForeColor = Color.FromArgb(0, 158, 255);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.UseVisualStyleBackColor = false;
            btn_deposit.Click += btn_deposit_Click;
            // 
            // tb_balance
            // 
            resources.ApplyResources(tb_balance, "tb_balance");
            tb_balance.Name = "tb_balance";
            tb_balance.TextChanged += tb_balance_TextChanged;
            // 
            // Deposit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_deposit);
            Controls.Add(btn_back);
            Controls.Add(btn_exit);
            Controls.Add(tb_balance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Deposit";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label_services;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btn_exit;
        private Button btn_back;
        private Button btn_deposit;
        private TextBox tb_balance;
    }
}