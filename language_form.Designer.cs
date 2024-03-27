namespace ATM_system
{
    partial class Language_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language_form));
            label_language = new Label();
            bulgarian_flag = new PictureBox();
            german_flag = new PictureBox();
            english_flag = new PictureBox();
            french_flag = new PictureBox();
            radbtn_bulgarian = new RadioButton();
            radbtn_french = new RadioButton();
            radbtn_german = new RadioButton();
            radbtn_english = new RadioButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_exit = new Button();
            btn_continue = new Button();
            ((System.ComponentModel.ISupportInitialize)bulgarian_flag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)german_flag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)english_flag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)french_flag).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_language
            // 
            resources.ApplyResources(label_language, "label_language");
            label_language.Name = "label_language";
            // 
            // bulgarian_flag
            // 
            resources.ApplyResources(bulgarian_flag, "bulgarian_flag");
            bulgarian_flag.Name = "bulgarian_flag";
            bulgarian_flag.TabStop = false;
            // 
            // german_flag
            // 
            resources.ApplyResources(german_flag, "german_flag");
            german_flag.Name = "german_flag";
            german_flag.TabStop = false;
            // 
            // english_flag
            // 
            resources.ApplyResources(english_flag, "english_flag");
            english_flag.Name = "english_flag";
            english_flag.TabStop = false;
            // 
            // french_flag
            // 
            resources.ApplyResources(french_flag, "french_flag");
            french_flag.Name = "french_flag";
            french_flag.TabStop = false;
            // 
            // radbtn_bulgarian
            // 
            resources.ApplyResources(radbtn_bulgarian, "radbtn_bulgarian");
            radbtn_bulgarian.Name = "radbtn_bulgarian";
            radbtn_bulgarian.CheckedChanged += radbtn_CheckedChanged;
            radbtn_bulgarian.Click += radbtn_CheckedChanged;
            // 
            // radbtn_french
            // 
            resources.ApplyResources(radbtn_french, "radbtn_french");
            radbtn_french.Name = "radbtn_french";
            radbtn_french.CheckedChanged += radbtn_CheckedChanged;
            radbtn_french.Click += radbtn_CheckedChanged;
            // 
            // radbtn_german
            // 
            resources.ApplyResources(radbtn_german, "radbtn_german");
            radbtn_german.Cursor = Cursors.Hand;
            radbtn_german.Name = "radbtn_german";
            radbtn_german.CheckedChanged += radbtn_CheckedChanged;
            radbtn_german.Click += radbtn_CheckedChanged;
            // 
            // radbtn_english
            // 
            resources.ApplyResources(radbtn_english, "radbtn_english");
            radbtn_english.Name = "radbtn_english";
            radbtn_english.CheckedChanged += radbtn_CheckedChanged;
            radbtn_english.Click += radbtn_CheckedChanged;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(0, 158, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_language);
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
            // btn_continue
            // 
            resources.ApplyResources(btn_continue, "btn_continue");
            btn_continue.BackColor = Color.White;
            btn_continue.Cursor = Cursors.Hand;
            btn_continue.ForeColor = Color.FromArgb(0, 158, 255);
            btn_continue.Name = "btn_continue";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // Language_form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_continue);
            Controls.Add(btn_exit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(radbtn_french);
            Controls.Add(radbtn_bulgarian);
            Controls.Add(french_flag);
            Controls.Add(english_flag);
            Controls.Add(german_flag);
            Controls.Add(bulgarian_flag);
            Controls.Add(radbtn_german);
            Controls.Add(radbtn_english);
            Name = "Language_form";
            ((System.ComponentModel.ISupportInitialize)bulgarian_flag).EndInit();
            ((System.ComponentModel.ISupportInitialize)german_flag).EndInit();
            ((System.ComponentModel.ISupportInitialize)english_flag).EndInit();
            ((System.ComponentModel.ISupportInitialize)french_flag).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_language;
        private PictureBox bulgarian_flag;
        private PictureBox german_flag;
        private PictureBox english_flag;
        private PictureBox french_flag;
        private RadioButton radbtn_bulgarian;
        private RadioButton radbtn_french;
        private RadioButton radbtn_german;
        private RadioButton radbtn_english;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_exit;
        private Button btn_continue;
    }
}