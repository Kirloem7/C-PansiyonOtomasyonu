namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmMusteriler
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            GenderLabel = new Label();
            GenderComboBox = new ComboBox();
            IdentityLabel = new Label();
            IdentityTextBox = new TextBox();
            MailLabel = new Label();
            MailTextBox = new TextBox();
            RoomNumberLabel = new Label();
            RoomNumberTextBox = new TextBox();
            FeeLabel = new Label();
            FeeTextBox = new TextBox();
            EntryDateLabel = new Label();
            EntryDateDateTimePicker = new DateTimePicker();
            ExitDateLabel = new Label();
            ExitDateDateTimePicker = new DateTimePicker();
            ShowInfoButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ClearButton = new Button();
            SearchButton = new Button();
            CustomerInfoListView = new ListView();
            CustomerIdHeaderColumn = new ColumnHeader();
            NameColumnHeader = new ColumnHeader();
            SurnameColumnHeader = new ColumnHeader();
            GenderColumnHeader = new ColumnHeader();
            PhoneColumnHeader = new ColumnHeader();
            MailColumnHeader = new ColumnHeader();
            IdentityColumnHeader = new ColumnHeader();
            RoomNumberColumnHeader = new ColumnHeader();
            FeeColumnHeader = new ColumnHeader();
            EntryDateColumnHeader = new ColumnHeader();
            ExitDateColumnHeader = new ColumnHeader();
            PhoneLabel = new Label();
            PhoneMaskedTextBox = new MaskedTextBox();
            SearchLabel = new Label();
            SearchTextBox = new TextBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(22, 41);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(76, 25);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Adı:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(94, 39);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 27);
            NameTextBox.TabIndex = 10;
            // 
            // SurnameLabel
            // 
            SurnameLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SurnameLabel.Location = new Point(12, 91);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(76, 25);
            SurnameLabel.TabIndex = 11;
            SurnameLabel.Text = "Soyadı:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(94, 89);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(151, 27);
            SurnameTextBox.TabIndex = 23;
            // 
            // GenderLabel
            // 
            GenderLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderLabel.Location = new Point(0, 139);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(98, 26);
            GenderLabel.TabIndex = 24;
            GenderLabel.Text = "Cinsiyet:";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Kadın", "Erkek ", "Belirtmek İstemiyorum" });
            GenderComboBox.Location = new Point(94, 137);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(151, 28);
            GenderComboBox.TabIndex = 25;
            // 
            // IdentityLabel
            // 
            IdentityLabel.AutoSize = true;
            IdentityLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdentityLabel.Location = new Point(12, 238);
            IdentityLabel.Name = "IdentityLabel";
            IdentityLabel.Size = new Size(39, 20);
            IdentityLabel.TabIndex = 26;
            IdentityLabel.Text = "TC:";
            // 
            // IdentityTextBox
            // 
            IdentityTextBox.Location = new Point(94, 225);
            IdentityTextBox.MaxLength = 11;
            IdentityTextBox.Name = "IdentityTextBox";
            IdentityTextBox.Size = new Size(155, 27);
            IdentityTextBox.TabIndex = 27;
            // 
            // MailLabel
            // 
            MailLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MailLabel.Location = new Point(12, 278);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(76, 25);
            MailLabel.TabIndex = 28;
            MailLabel.Text = "Mail:";
            // 
            // MailTextBox
            // 
            MailTextBox.Location = new Point(97, 276);
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(151, 27);
            MailTextBox.TabIndex = 29;
            // 
            // RoomNumberLabel
            // 
            RoomNumberLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomNumberLabel.Location = new Point(401, 41);
            RoomNumberLabel.Name = "RoomNumberLabel";
            RoomNumberLabel.Size = new Size(98, 25);
            RoomNumberLabel.TabIndex = 30;
            RoomNumberLabel.Text = "Oda No:";
            // 
            // RoomNumberTextBox
            // 
            RoomNumberTextBox.Location = new Point(483, 39);
            RoomNumberTextBox.Name = "RoomNumberTextBox";
            RoomNumberTextBox.Size = new Size(161, 27);
            RoomNumberTextBox.TabIndex = 31;
            // 
            // FeeLabel
            // 
            FeeLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeeLabel.Location = new Point(401, 93);
            FeeLabel.Name = "FeeLabel";
            FeeLabel.Size = new Size(76, 25);
            FeeLabel.TabIndex = 32;
            FeeLabel.Text = "Ücret:";
            // 
            // FeeTextBox
            // 
            FeeTextBox.Location = new Point(483, 91);
            FeeTextBox.Name = "FeeTextBox";
            FeeTextBox.Size = new Size(161, 27);
            FeeTextBox.TabIndex = 33;
            // 
            // EntryDateLabel
            // 
            EntryDateLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryDateLabel.Location = new Point(401, 139);
            EntryDateLabel.Name = "EntryDateLabel";
            EntryDateLabel.Size = new Size(76, 49);
            EntryDateLabel.TabIndex = 34;
            EntryDateLabel.Text = "Giriş Tarih:";
            // 
            // EntryDateDateTimePicker
            // 
            EntryDateDateTimePicker.Location = new Point(483, 149);
            EntryDateDateTimePicker.Name = "EntryDateDateTimePicker";
            EntryDateDateTimePicker.Size = new Size(166, 27);
            EntryDateDateTimePicker.TabIndex = 35;
            // 
            // ExitDateLabel
            // 
            ExitDateLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitDateLabel.Location = new Point(401, 201);
            ExitDateLabel.Name = "ExitDateLabel";
            ExitDateLabel.Size = new Size(76, 52);
            ExitDateLabel.TabIndex = 36;
            ExitDateLabel.Text = "Çıkış Tarih:";
            // 
            // ExitDateDateTimePicker
            // 
            ExitDateDateTimePicker.Location = new Point(483, 211);
            ExitDateDateTimePicker.Name = "ExitDateDateTimePicker";
            ExitDateDateTimePicker.Size = new Size(166, 27);
            ExitDateDateTimePicker.TabIndex = 37;
            // 
            // ShowInfoButton
            // 
            ShowInfoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowInfoButton.BackColor = SystemColors.Info;
            ShowInfoButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowInfoButton.Location = new Point(774, 12);
            ShowInfoButton.Name = "ShowInfoButton";
            ShowInfoButton.Size = new Size(152, 29);
            ShowInfoButton.TabIndex = 38;
            ShowInfoButton.Text = "Verileri Göster";
            ShowInfoButton.UseVisualStyleBackColor = false;
            ShowInfoButton.Click += ShowInfoButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateButton.BackColor = SystemColors.Info;
            UpdateButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(774, 56);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(152, 29);
            UpdateButton.TabIndex = 39;
            UpdateButton.Text = "Güncelle";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteButton.BackColor = SystemColors.Info;
            DeleteButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(774, 102);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(152, 29);
            DeleteButton.TabIndex = 40;
            DeleteButton.Text = "Sil";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearButton.BackColor = SystemColors.Info;
            ClearButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(774, 150);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(152, 29);
            ClearButton.TabIndex = 41;
            ClearButton.Text = "Temizle";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SearchButton.BackColor = SystemColors.Info;
            SearchButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(774, 201);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(152, 29);
            SearchButton.TabIndex = 42;
            SearchButton.Text = "Ara";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // CustomerInfoListView
            // 
            CustomerInfoListView.Columns.AddRange(new ColumnHeader[] { CustomerIdHeaderColumn, NameColumnHeader, SurnameColumnHeader, GenderColumnHeader, PhoneColumnHeader, MailColumnHeader, IdentityColumnHeader, RoomNumberColumnHeader, FeeColumnHeader, EntryDateColumnHeader, ExitDateColumnHeader });
            CustomerInfoListView.Location = new Point(0, 314);
            CustomerInfoListView.Name = "CustomerInfoListView";
            CustomerInfoListView.Size = new Size(959, 136);
            CustomerInfoListView.TabIndex = 43;
            CustomerInfoListView.UseCompatibleStateImageBehavior = false;
            CustomerInfoListView.View = View.Details;
            CustomerInfoListView.DoubleClick += CustomerInfoListView_SelectedIndexChanged;
            // 
            // CustomerIdHeaderColumn
            // 
            CustomerIdHeaderColumn.Text = "Müşteri ID";
            CustomerIdHeaderColumn.Width = 70;
            // 
            // NameColumnHeader
            // 
            NameColumnHeader.Text = "Ad";
            // 
            // SurnameColumnHeader
            // 
            SurnameColumnHeader.Text = "Soyad";
            SurnameColumnHeader.Width = 70;
            // 
            // GenderColumnHeader
            // 
            GenderColumnHeader.Text = "Cinsiyet";
            GenderColumnHeader.Width = 70;
            // 
            // PhoneColumnHeader
            // 
            PhoneColumnHeader.Text = "Telefon";
            PhoneColumnHeader.Width = 70;
            // 
            // MailColumnHeader
            // 
            MailColumnHeader.Text = "Mail";
            MailColumnHeader.Width = 70;
            // 
            // IdentityColumnHeader
            // 
            IdentityColumnHeader.Text = "TC";
            IdentityColumnHeader.Width = 70;
            // 
            // RoomNumberColumnHeader
            // 
            RoomNumberColumnHeader.Text = "Oda No";
            RoomNumberColumnHeader.Width = 70;
            // 
            // FeeColumnHeader
            // 
            FeeColumnHeader.Text = "Ücret";
            FeeColumnHeader.Width = 70;
            // 
            // EntryDateColumnHeader
            // 
            EntryDateColumnHeader.Text = "Giriş Tarih";
            EntryDateColumnHeader.Width = 70;
            // 
            // ExitDateColumnHeader
            // 
            ExitDateColumnHeader.Text = "Çıkış Tarih";
            ExitDateColumnHeader.Width = 70;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(0, 188);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(98, 25);
            PhoneLabel.TabIndex = 44;
            PhoneLabel.Text = "Telefon:";
            // 
            // PhoneMaskedTextBox
            // 
            PhoneMaskedTextBox.Location = new Point(94, 186);
            PhoneMaskedTextBox.Mask = "(999) 000-0000";
            PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            PhoneMaskedTextBox.Size = new Size(151, 27);
            PhoneMaskedTextBox.TabIndex = 45;
            // 
            // SearchLabel
            // 
            SearchLabel.BackColor = Color.HotPink;
            SearchLabel.Font = new Font("SimSun-ExtG", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchLabel.Location = new Point(672, 256);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(70, 23);
            SearchLabel.TabIndex = 46;
            SearchLabel.Text = "İsim:";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = SystemColors.Info;
            SearchTextBox.Location = new Point(727, 252);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(151, 27);
            SearchTextBox.TabIndex = 47;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(958, 450);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchLabel);
            Controls.Add(PhoneMaskedTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(CustomerInfoListView);
            Controls.Add(SearchButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(ShowInfoButton);
            Controls.Add(ExitDateDateTimePicker);
            Controls.Add(ExitDateLabel);
            Controls.Add(EntryDateDateTimePicker);
            Controls.Add(EntryDateLabel);
            Controls.Add(FeeTextBox);
            Controls.Add(FeeLabel);
            Controls.Add(RoomNumberTextBox);
            Controls.Add(RoomNumberLabel);
            Controls.Add(MailTextBox);
            Controls.Add(MailLabel);
            Controls.Add(IdentityTextBox);
            Controls.Add(IdentityLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(GenderLabel);
            Controls.Add(SurnameTextBox);
            Controls.Add(SurnameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMusteriler";
            Text = "Müşteri Bigileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
        private Label GenderLabel;
        private ComboBox GenderComboBox;
        private Label IdentityLabel;
        private TextBox IdentityTextBox;
        private Label MailLabel;
        private TextBox MailTextBox;
        private Label RoomNumberLabel;
        private TextBox RoomNumberTextBox;
        private Label FeeLabel;
        private TextBox FeeTextBox;
        private Label EntryDateLabel;
        private DateTimePicker EntryDateDateTimePicker;
        private Label ExitDateLabel;
        private DateTimePicker ExitDateDateTimePicker;
        private Button ShowInfoButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearButton;
        private Button SearchButton;
        private ListView CustomerInfoListView;
        private ColumnHeader CustomerIdHeaderColumn;
        private ColumnHeader NameColumnHeader;
        private ColumnHeader SurnameColumnHeader;
        private ColumnHeader GenderColumnHeader;
        private ColumnHeader PhoneColumnHeader;
        private ColumnHeader MailColumnHeader;
        private ColumnHeader IdentityColumnHeader;
        private ColumnHeader RoomNumberColumnHeader;
        private ColumnHeader FeeColumnHeader;
        private ColumnHeader EntryDateColumnHeader;
        private ColumnHeader ExitDateColumnHeader;
        private Label PhoneLabel;
        private MaskedTextBox PhoneMaskedTextBox;
        private Label SearchLabel;
        private TextBox SearchTextBox;
    }
}