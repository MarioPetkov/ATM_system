namespace ATM_system
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            label_services = new Label();
            btn_language = new Button();
            btn_balance = new Button();
            btn_withdraw = new Button();
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
            label_services.AutoSize = true;
            label_services.BackColor = Color.FromArgb(0, 158, 255);
            label_services.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_services.Location = new Point(234, 18);
            label_services.Name = "label_services";
            label_services.Size = new Size(145, 30);
            label_services.TabIndex = 0;
            label_services.Text = "ATM SYSTEM";
            // 
            // btn_language
            // 
            btn_language.BackColor = Color.FromArgb(0, 158, 255);
            btn_language.Cursor = Cursors.Hand;
            btn_language.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            btn_language.Location = new Point(350, 200);
            btn_language.Name = "btn_language";
            btn_language.Size = new Size(100, 50);
            btn_language.TabIndex = 1;
            btn_language.Text = "Language";
            btn_language.UseVisualStyleBackColor = false;
            btn_language.Click += btn_language_Click;
            // 
            // btn_balance
            // 
            btn_balance.BackColor = Color.FromArgb(0, 158, 255);
            btn_balance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_balance.Location = new Point(150, 120);
            btn_balance.Name = "btn_balance";
            btn_balance.Size = new Size(100, 50);
            btn_balance.TabIndex = 2;
            btn_balance.Text = "Balance";
            btn_balance.UseVisualStyleBackColor = false;
            // 
            // btn_withdraw
            // 
            btn_withdraw.BackColor = Color.FromArgb(0, 158, 255);
            btn_withdraw.Cursor = Cursors.Hand;
            btn_withdraw.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            btn_withdraw.Location = new Point(350, 120);
            btn_withdraw.Name = "btn_withdraw";
            btn_withdraw.Size = new Size(100, 50);
            btn_withdraw.TabIndex = 3;
            btn_withdraw.Text = "Withdraw";
            btn_withdraw.UseVisualStyleBackColor = false;
            // 
            // btn_transfer
            // 
            btn_transfer.BackColor = Color.FromArgb(0, 158, 255);
            btn_transfer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_transfer.Location = new Point(150, 200);
            btn_transfer.Name = "btn_transfer";
            btn_transfer.Size = new Size(100, 50);
            btn_transfer.TabIndex = 4;
            btn_transfer.Text = "Deposit";
            btn_transfer.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            btn_exit.AutoEllipsis = true;
            btn_exit.BackColor = Color.White;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_exit.ForeColor = Color.FromArgb(0, 158, 255);
            btn_exit.Location = new Point(250, 280);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(100, 50);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_services);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 70);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 158, 255);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 351);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 10);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 158, 255);
            label1.Location = new Point(183, 73);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 16;
            label1.Text = "Please choose a service";
            // 
            // services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(584, 361);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_exit);
            Controls.Add(btn_transfer);
            Controls.Add(btn_withdraw);
            Controls.Add(btn_balance);
            Controls.Add(btn_language);
            Cursor = Cursors.Hand;
            Name = "services";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "services";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_services;
        private Button btn_language;
        private Button btn_balance;
        private Button btn_withdraw;
        private Button btn_transfer;
        private Button btn_exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Label label1;
    }
}