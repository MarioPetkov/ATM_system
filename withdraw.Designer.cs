namespace ATM_system
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            panel1 = new Panel();
            panel3 = new Panel();
            label_services = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btn_Withdraw = new Button();
            btn_back = new Button();
            btn_exit = new Button();
            tb_Withdraw = new TextBox();
            label2 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Name = "panel1";
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
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 158, 255);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // btn_Withdraw
            // 
            resources.ApplyResources(btn_Withdraw, "btn_Withdraw");
            btn_Withdraw.AutoEllipsis = true;
            btn_Withdraw.BackColor = Color.White;
            btn_Withdraw.Cursor = Cursors.Hand;
            btn_Withdraw.ForeColor = Color.FromArgb(0, 158, 255);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = false;
            btn_Withdraw.Click += btn_Withdraw_Click;
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
            // tb_Withdraw
            // 
            resources.ApplyResources(tb_Withdraw, "tb_Withdraw");
            tb_Withdraw.Name = "tb_Withdraw";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // Withdraw
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Withdraw);
            Controls.Add(btn_back);
            Controls.Add(btn_exit);
            Controls.Add(tb_Withdraw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Withdraw";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label_services;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btn_Withdraw;
        private Button btn_back;
        private Button btn_exit;
        private TextBox tb_Withdraw;
        private Label label2;
    }
}