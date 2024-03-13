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
            btn_continue.BackColor = Color.Transparent;
            btn_continue.Cursor = Cursors.Hand;
            btn_continue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_continue.Location = new Point(631, 377);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(117, 33);
            btn_continue.TabIndex = 0;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = Color.Transparent;
            label_welcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_welcome.ForeColor = Color.Black;
            label_welcome.Location = new Point(132, 9);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(427, 30);
            label_welcome.TabIndex = 1;
            label_welcome.Text = "Welcome to the ATM, please insert a card!";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_exit.Location = new Point(631, 416);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(117, 33);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            // 
            // welcome_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_exit);
            Controls.Add(btn_continue);
            Controls.Add(label_welcome);
            Name = "welcome_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to the ATM";
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
