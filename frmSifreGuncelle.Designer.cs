namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmSifreGuncelle
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
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(97, 106);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(127, 20);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Kullanıcı Adı:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = SystemColors.Info;
            UserNameTextBox.Location = new Point(230, 102);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(156, 27);
            UserNameTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(97, 182);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(127, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Şifre:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.Info;
            PasswordTextBox.Location = new Point(230, 175);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(156, 27);
            PasswordTextBox.TabIndex = 5;
            // 
            // UpdateButton
            // 
            UpdateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateButton.BackColor = SystemColors.ControlLightLight;
            UpdateButton.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(186, 260);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(136, 29);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Güncelle";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // frmSifreGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(526, 329);
            Controls.Add(UpdateButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserNameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSifreGuncelle";
            Text = "Şifre Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button UpdateButton;
    }
}