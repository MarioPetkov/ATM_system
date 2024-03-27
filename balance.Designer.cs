namespace ATM_system
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label_services = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btn_back = new Button();
            btn_exit = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            lbl_balance = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(0, 158, 255);
            panel2.Controls.Add(panel1);
            panel2.Name = "panel2";
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
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(0, 158, 255);
            label2.Name = "label2";
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
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbl_balance
            // 
            resources.ApplyResources(lbl_balance, "lbl_balance");
            lbl_balance.Name = "lbl_balance";
            // 
            // Balance
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_balance);
            Controls.Add(btn_back);
            Controls.Add(btn_exit);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Balance";
            Load += balance_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label_services;
        private Label label2;
        private Button btn_back;
        private Button btn_exit;
        private FileSystemWatcher fileSystemWatcher1;
        private Label lbl_balance;
    }
}