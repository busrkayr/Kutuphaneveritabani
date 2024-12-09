namespace kutuphane.FORMS
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox_Pass = new PictureBox();
            textBox1 = new TextBox();
            pictureBox_User = new PictureBox();
            label_close = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Pass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_User).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox_Pass);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox_User);
            panel1.Controls.Add(label_close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 291);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(95, 240);
            button1.Name = "button1";
            button1.Size = new Size(239, 39);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(95, 177);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 47);
            textBox2.TabIndex = 5;
            // 
            // pictureBox_Pass
            // 
            pictureBox_Pass.BackColor = Color.Aqua;
            pictureBox_Pass.BackgroundImage = (Image)resources.GetObject("pictureBox_Pass.BackgroundImage");
            pictureBox_Pass.Location = new Point(30, 177);
            pictureBox_Pass.Name = "pictureBox_Pass";
            pictureBox_Pass.Size = new Size(43, 47);
            pictureBox_Pass.TabIndex = 4;
            pictureBox_Pass.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(95, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 47);
            textBox1.TabIndex = 3;
            // 
            // pictureBox_User
            // 
            pictureBox_User.BackColor = Color.Aqua;
            pictureBox_User.BackgroundImage = (Image)resources.GetObject("pictureBox_User.BackgroundImage");
            pictureBox_User.Location = new Point(30, 90);
            pictureBox_User.Name = "pictureBox_User";
            pictureBox_User.Size = new Size(43, 47);
            pictureBox_User.TabIndex = 2;
            pictureBox_User.TabStop = false;
            // 
            // label_close
            // 
            label_close.BackColor = Color.IndianRed;
            label_close.Cursor = Cursors.Hand;
            label_close.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_close.ForeColor = SystemColors.ActiveCaptionText;
            label_close.Location = new Point(361, 0);
            label_close.Name = "label_close";
            label_close.Size = new Size(28, 28);
            label_close.TabIndex = 1;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            label_close.MouseEnter += label_close_MouseEnter;
            label_close.MouseLeave += label_close_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.IndianRed;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(389, 67);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Girişi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 291);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Pass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label_close;
        private TextBox textBox2;
        private PictureBox pictureBox_Pass;
        private TextBox textBox1;
        private PictureBox pictureBox_User;
        private Button button1;
    }
}