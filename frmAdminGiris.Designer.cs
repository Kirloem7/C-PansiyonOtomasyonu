namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGiris));
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            WelcomeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(230, 260);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(127, 20);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "Kullanıcı Adı:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(230, 325);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(127, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Şifre:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = SystemColors.Info;
            UserNameTextBox.Location = new Point(375, 256);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(129, 27);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.Info;
            PasswordTextBox.Location = new Point(375, 318);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(129, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.BackColor = SystemColors.ButtonHighlight;
            LoginButton.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(331, 378);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(118, 34);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Giriş Yap";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(596, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("SimSun-ExtG", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(139, 40);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(365, 128);
            WelcomeLabel.TabIndex = 6;
            WelcomeLabel.Text = "Lotus Pansiyon Ve Dinlenme Tesislerine Hoş Geldiniz";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminGiris";
            Text = "Admin Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Label WelcomeLabel;
    }
}