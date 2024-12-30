namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmStoklar
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
            FoodAmountLabel = new Label();
            DrinkAmountLabel = new Label();
            SnacksLabel = new Label();
            FoodAmountTextBox = new TextBox();
            DrinksAmountTextBox = new TextBox();
            SnacksTextBox = new TextBox();
            StocsListView = new ListView();
            FoodColumnHeader = new ColumnHeader();
            DrinksColumnHeader = new ColumnHeader();
            SnacksColumnHeader = new ColumnHeader();
            SaveButton = new Button();
            KitchenGroupBox = new GroupBox();
            BillGroupBox = new GroupBox();
            SaveButton2 = new Button();
            BillListView = new ListView();
            ElectricColumnHeader = new ColumnHeader();
            WaterColumnHeader = new ColumnHeader();
            InternetColumnHeader = new ColumnHeader();
            InternetBillTextBox = new TextBox();
            WaterBillTextBox = new TextBox();
            ElectricBillTextBox = new TextBox();
            InternetBillLabel = new Label();
            WaterBillLabel = new Label();
            ElectricBillLabel = new Label();
            KitchenGroupBox.SuspendLayout();
            BillGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FoodAmountLabel
            // 
            FoodAmountLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodAmountLabel.Location = new Point(34, 38);
            FoodAmountLabel.Name = "FoodAmountLabel";
            FoodAmountLabel.Size = new Size(103, 37);
            FoodAmountLabel.TabIndex = 0;
            FoodAmountLabel.Text = "Gıda Tutarı:";
            FoodAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DrinkAmountLabel
            // 
            DrinkAmountLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DrinkAmountLabel.Location = new Point(30, 93);
            DrinkAmountLabel.Name = "DrinkAmountLabel";
            DrinkAmountLabel.Size = new Size(124, 37);
            DrinkAmountLabel.TabIndex = 1;
            DrinkAmountLabel.Text = "İçecek Tutarı:";
            DrinkAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SnacksLabel
            // 
            SnacksLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SnacksLabel.Location = new Point(30, 151);
            SnacksLabel.Name = "SnacksLabel";
            SnacksLabel.Size = new Size(126, 37);
            SnacksLabel.TabIndex = 2;
            SnacksLabel.Text = "Atıştırmalıklar:";
            SnacksLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoodAmountTextBox
            // 
            FoodAmountTextBox.BackColor = SystemColors.Info;
            FoodAmountTextBox.Location = new Point(162, 43);
            FoodAmountTextBox.Name = "FoodAmountTextBox";
            FoodAmountTextBox.Size = new Size(149, 22);
            FoodAmountTextBox.TabIndex = 3;
            // 
            // DrinksAmountTextBox
            // 
            DrinksAmountTextBox.BackColor = SystemColors.Info;
            DrinksAmountTextBox.Location = new Point(162, 103);
            DrinksAmountTextBox.Name = "DrinksAmountTextBox";
            DrinksAmountTextBox.Size = new Size(149, 22);
            DrinksAmountTextBox.TabIndex = 4;
            // 
            // SnacksTextBox
            // 
            SnacksTextBox.BackColor = SystemColors.Info;
            SnacksTextBox.Location = new Point(162, 156);
            SnacksTextBox.Name = "SnacksTextBox";
            SnacksTextBox.Size = new Size(149, 22);
            SnacksTextBox.TabIndex = 5;
            // 
            // StocsListView
            // 
            StocsListView.Columns.AddRange(new ColumnHeader[] { FoodColumnHeader, DrinksColumnHeader, SnacksColumnHeader });
            StocsListView.Location = new Point(0, 290);
            StocsListView.Name = "StocsListView";
            StocsListView.Size = new Size(484, 110);
            StocsListView.TabIndex = 6;
            StocsListView.UseCompatibleStateImageBehavior = false;
            StocsListView.View = View.Details;
            // 
            // FoodColumnHeader
            // 
            FoodColumnHeader.Text = "Gıda";
            FoodColumnHeader.Width = 100;
            // 
            // DrinksColumnHeader
            // 
            DrinksColumnHeader.Text = "İçecek";
            DrinksColumnHeader.Width = 100;
            // 
            // SnacksColumnHeader
            // 
            SnacksColumnHeader.Text = "Çerezler";
            SnacksColumnHeader.Width = 100;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.ControlLightLight;
            SaveButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(188, 205);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // KitchenGroupBox
            // 
            KitchenGroupBox.Controls.Add(SaveButton);
            KitchenGroupBox.Controls.Add(StocsListView);
            KitchenGroupBox.Controls.Add(SnacksTextBox);
            KitchenGroupBox.Controls.Add(DrinksAmountTextBox);
            KitchenGroupBox.Controls.Add(FoodAmountTextBox);
            KitchenGroupBox.Controls.Add(SnacksLabel);
            KitchenGroupBox.Controls.Add(DrinkAmountLabel);
            KitchenGroupBox.Controls.Add(FoodAmountLabel);
            KitchenGroupBox.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KitchenGroupBox.Location = new Point(37, 18);
            KitchenGroupBox.Name = "KitchenGroupBox";
            KitchenGroupBox.Size = new Size(484, 400);
            KitchenGroupBox.TabIndex = 8;
            KitchenGroupBox.TabStop = false;
            KitchenGroupBox.Text = "Mutfak";
            // 
            // BillGroupBox
            // 
            BillGroupBox.Controls.Add(SaveButton2);
            BillGroupBox.Controls.Add(BillListView);
            BillGroupBox.Controls.Add(InternetBillTextBox);
            BillGroupBox.Controls.Add(WaterBillTextBox);
            BillGroupBox.Controls.Add(ElectricBillTextBox);
            BillGroupBox.Controls.Add(InternetBillLabel);
            BillGroupBox.Controls.Add(WaterBillLabel);
            BillGroupBox.Controls.Add(ElectricBillLabel);
            BillGroupBox.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillGroupBox.Location = new Point(539, 18);
            BillGroupBox.Name = "BillGroupBox";
            BillGroupBox.Size = new Size(484, 400);
            BillGroupBox.TabIndex = 9;
            BillGroupBox.TabStop = false;
            BillGroupBox.Text = "Faturalar";
            // 
            // SaveButton2
            // 
            SaveButton2.BackColor = SystemColors.ControlLightLight;
            SaveButton2.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton2.Location = new Point(188, 205);
            SaveButton2.Name = "SaveButton2";
            SaveButton2.Size = new Size(94, 29);
            SaveButton2.TabIndex = 7;
            SaveButton2.Text = "Kaydet";
            SaveButton2.UseVisualStyleBackColor = false;
            SaveButton2.Click += SaveButton2_Click;
            // 
            // BillListView
            // 
            BillListView.Columns.AddRange(new ColumnHeader[] { ElectricColumnHeader, WaterColumnHeader, InternetColumnHeader });
            BillListView.Location = new Point(0, 290);
            BillListView.Name = "BillListView";
            BillListView.Size = new Size(484, 110);
            BillListView.TabIndex = 6;
            BillListView.UseCompatibleStateImageBehavior = false;
            BillListView.View = View.Details;
            // 
            // ElectricColumnHeader
            // 
            ElectricColumnHeader.Text = "Elektrik";
            ElectricColumnHeader.Width = 100;
            // 
            // WaterColumnHeader
            // 
            WaterColumnHeader.Text = "Su";
            WaterColumnHeader.Width = 100;
            // 
            // InternetColumnHeader
            // 
            InternetColumnHeader.Text = "İnternet";
            InternetColumnHeader.Width = 100;
            // 
            // InternetBillTextBox
            // 
            InternetBillTextBox.BackColor = SystemColors.Info;
            InternetBillTextBox.Location = new Point(162, 156);
            InternetBillTextBox.Name = "InternetBillTextBox";
            InternetBillTextBox.Size = new Size(149, 22);
            InternetBillTextBox.TabIndex = 5;
            // 
            // WaterBillTextBox
            // 
            WaterBillTextBox.BackColor = SystemColors.Info;
            WaterBillTextBox.Location = new Point(162, 103);
            WaterBillTextBox.Name = "WaterBillTextBox";
            WaterBillTextBox.Size = new Size(149, 22);
            WaterBillTextBox.TabIndex = 4;
            // 
            // ElectricBillTextBox
            // 
            ElectricBillTextBox.BackColor = SystemColors.Info;
            ElectricBillTextBox.Location = new Point(162, 43);
            ElectricBillTextBox.Name = "ElectricBillTextBox";
            ElectricBillTextBox.Size = new Size(149, 22);
            ElectricBillTextBox.TabIndex = 3;
            // 
            // InternetBillLabel
            // 
            InternetBillLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InternetBillLabel.Location = new Point(30, 151);
            InternetBillLabel.Name = "InternetBillLabel";
            InternetBillLabel.Size = new Size(126, 37);
            InternetBillLabel.TabIndex = 2;
            InternetBillLabel.Text = "İnternet:";
            InternetBillLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WaterBillLabel
            // 
            WaterBillLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WaterBillLabel.Location = new Point(30, 93);
            WaterBillLabel.Name = "WaterBillLabel";
            WaterBillLabel.Size = new Size(124, 37);
            WaterBillLabel.TabIndex = 1;
            WaterBillLabel.Text = "Su:";
            WaterBillLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElectricBillLabel
            // 
            ElectricBillLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ElectricBillLabel.Location = new Point(34, 38);
            ElectricBillLabel.Name = "ElectricBillLabel";
            ElectricBillLabel.Size = new Size(103, 37);
            ElectricBillLabel.TabIndex = 0;
            ElectricBillLabel.Text = "Elektrik";
            ElectricBillLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(1047, 423);
            Controls.Add(BillGroupBox);
            Controls.Add(KitchenGroupBox);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStoklar";
            Text = "Stoklar";
            Load += frmStoklar_Load;
            KitchenGroupBox.ResumeLayout(false);
            KitchenGroupBox.PerformLayout();
            BillGroupBox.ResumeLayout(false);
            BillGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label FoodAmountLabel;
        private Label DrinkAmountLabel;
        private Label SnacksLabel;
        private TextBox FoodAmountTextBox;
        private TextBox DrinksAmountTextBox;
        private TextBox SnacksTextBox;
        private ListView StocsListView;
        private Button SaveButton;
        private ColumnHeader FoodColumnHeader;
        private ColumnHeader DrinksColumnHeader;
        private ColumnHeader SnacksColumnHeader;
        private GroupBox KitchenGroupBox;
        private GroupBox BillGroupBox;
        private Button SaveButton2;
        private ListView BillListView;
        private ColumnHeader ElectricColumnHeader;
        private ColumnHeader WaterColumnHeader;
        private ColumnHeader InternetColumnHeader;
        private TextBox InternetBillTextBox;
        private TextBox WaterBillTextBox;
        private TextBox ElectricBillTextBox;
        private Label InternetBillLabel;
        private Label WaterBillLabel;
        private Label ElectricBillLabel;
    }
}