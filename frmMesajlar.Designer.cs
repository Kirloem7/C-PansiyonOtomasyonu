namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmMesajlar
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
            NameAndSurnameLabel = new Label();
            NameAndSurnameTextBox = new TextBox();
            CustomerMessageLabel = new Label();
            CustomerMessageRichTextBox = new RichTextBox();
            CustomerMessageListView = new ListView();
            IdColumnHeader = new ColumnHeader();
            NameAndSurnameColumnHeader = new ColumnHeader();
            MessageColumnHeader = new ColumnHeader();
            SaveMessageButton = new Button();
            SuspendLayout();
            // 
            // NameAndSurnameLabel
            // 
            NameAndSurnameLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameAndSurnameLabel.Location = new Point(12, 50);
            NameAndSurnameLabel.Name = "NameAndSurnameLabel";
            NameAndSurnameLabel.Size = new Size(75, 52);
            NameAndSurnameLabel.TabIndex = 0;
            NameAndSurnameLabel.Text = "Ad Soyad:";
            NameAndSurnameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameAndSurnameTextBox
            // 
            NameAndSurnameTextBox.BackColor = SystemColors.Info;
            NameAndSurnameTextBox.Location = new Point(93, 61);
            NameAndSurnameTextBox.Name = "NameAndSurnameTextBox";
            NameAndSurnameTextBox.Size = new Size(300, 27);
            NameAndSurnameTextBox.TabIndex = 1;
            // 
            // CustomerMessageLabel
            // 
            CustomerMessageLabel.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerMessageLabel.Location = new Point(-1, 185);
            CustomerMessageLabel.Name = "CustomerMessageLabel";
            CustomerMessageLabel.Size = new Size(89, 22);
            CustomerMessageLabel.TabIndex = 2;
            CustomerMessageLabel.Text = "Mesajınız:";
            CustomerMessageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CustomerMessageRichTextBox
            // 
            CustomerMessageRichTextBox.BackColor = SystemColors.Info;
            CustomerMessageRichTextBox.Location = new Point(93, 137);
            CustomerMessageRichTextBox.Name = "CustomerMessageRichTextBox";
            CustomerMessageRichTextBox.Size = new Size(300, 218);
            CustomerMessageRichTextBox.TabIndex = 3;
            CustomerMessageRichTextBox.Text = "";
            // 
            // CustomerMessageListView
            // 
            CustomerMessageListView.Columns.AddRange(new ColumnHeader[] { IdColumnHeader, NameAndSurnameColumnHeader, MessageColumnHeader });
            CustomerMessageListView.Location = new Point(-1, 416);
            CustomerMessageListView.Name = "CustomerMessageListView";
            CustomerMessageListView.Size = new Size(482, 91);
            CustomerMessageListView.TabIndex = 4;
            CustomerMessageListView.UseCompatibleStateImageBehavior = false;
            CustomerMessageListView.View = View.Details;
            // 
            // IdColumnHeader
            // 
            IdColumnHeader.Text = "Id";
            IdColumnHeader.Width = 100;
            // 
            // NameAndSurnameColumnHeader
            // 
            NameAndSurnameColumnHeader.Text = "Ad Soyad";
            NameAndSurnameColumnHeader.Width = 100;
            // 
            // MessageColumnHeader
            // 
            MessageColumnHeader.Text = "Mesaj";
            MessageColumnHeader.Width = 100;
            // 
            // SaveMessageButton
            // 
            SaveMessageButton.BackColor = SystemColors.ControlLightLight;
            SaveMessageButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveMessageButton.Location = new Point(190, 370);
            SaveMessageButton.Name = "SaveMessageButton";
            SaveMessageButton.Size = new Size(94, 29);
            SaveMessageButton.TabIndex = 5;
            SaveMessageButton.Text = "Kaydet";
            SaveMessageButton.UseVisualStyleBackColor = false;
            SaveMessageButton.Click += SaveMessageButton_Click;
            // 
            // frmMesajlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(480, 505);
            Controls.Add(SaveMessageButton);
            Controls.Add(CustomerMessageListView);
            Controls.Add(CustomerMessageRichTextBox);
            Controls.Add(CustomerMessageLabel);
            Controls.Add(NameAndSurnameTextBox);
            Controls.Add(NameAndSurnameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMesajlar";
            Text = "Mesajlar";
            Load += frmMesajlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameAndSurnameLabel;
        private TextBox NameAndSurnameTextBox;
        private Label CustomerMessageLabel;
        private RichTextBox CustomerMessageRichTextBox;
        private ListView CustomerMessageListView;
        private ColumnHeader IdColumnHeader;
        private ColumnHeader NameAndSurnameColumnHeader;
        private ColumnHeader MessageColumnHeader;
        private Button SaveMessageButton;
    }
}