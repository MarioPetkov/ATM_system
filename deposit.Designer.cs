namespace ATM_system
{
    partial class deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deposit));
            panel3 = new Panel();
            label_services = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            tb_balance = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_exit = new Button();
            btn_back = new Button();
            btn_deposit = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 158, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label_services);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 70);
            panel3.TabIndex = 11;
            // 
            // label_services
            // 
            label_services.AutoSize = true;
            label_services.BackColor = Color.FromArgb(0, 158, 255);
            label_services.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_services.Location = new Point(138, 19);
            label_services.Name = "label_services";
            label_services.Size = new Size(145, 30);
            label_services.TabIndex = 16;
            label_services.Text = "ATM SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 10);
            panel1.TabIndex = 12;
            // 
            // tb_balance
            // 
            tb_balance.Location = new Point(139, 130);
            tb_balance.Name = "tb_balance";
            tb_balance.Size = new Size(130, 23);
            tb_balance.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(46, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 20;
            label2.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 158, 255);
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(325, 30);
            label1.TabIndex = 19;
            label1.Text = "Please insert amount to deposit";
            // 
            // btn_exit
            // 
            btn_exit.AutoEllipsis = true;
            btn_exit.BackColor = Color.White;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_exit.ForeColor = Color.FromArgb(0, 158, 255);
            btn_exit.Location = new Point(302, 159);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(80, 40);
            btn_exit.TabIndex = 22;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            btn_back.AutoEllipsis = true;
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_back.ForeColor = Color.FromArgb(0, 158, 255);
            btn_back.Location = new Point(302, 118);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(80, 40);
            btn_back.TabIndex = 23;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_deposit
            // 
            btn_deposit.AutoEllipsis = true;
            btn_deposit.BackColor = Color.White;
            btn_deposit.Cursor = Cursors.Hand;
            btn_deposit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_deposit.ForeColor = Color.FromArgb(0, 158, 255);
            btn_deposit.Location = new Point(139, 159);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.Size = new Size(130, 40);
            btn_deposit.TabIndex = 24;
            btn_deposit.Text = "Deposit";
            btn_deposit.UseVisualStyleBackColor = false;
            // 
            // deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(384, 211);
            Controls.Add(btn_deposit);
            Controls.Add(btn_back);
            Controls.Add(btn_exit);
            Controls.Add(tb_balance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "deposit";
            Text = "deposit";
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
        private TextBox tb_balance;
        private Label label2;
        private Label label1;
        private Button btn_exit;
        private Button btn_back;
        private Button btn_deposit;
    }
}