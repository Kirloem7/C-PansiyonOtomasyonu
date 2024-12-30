namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmGelirGider
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
            TotalAmountInCashLabel = new Label();
            TotalCostLabel = new Label();
            StaffWagesLabel = new Label();
            StaffWagesCost = new Label();
            AllProductsCosts = new Label();
            FoodCostsLabel = new Label();
            BillsLabel = new Label();
            ElectricBillsCostsLabel = new Label();
            StaffNumberLabel = new Label();
            StaffNumberTextBox = new TextBox();
            CalculateButton = new Button();
            ResultLabel = new Label();
            ResultCostLabel = new Label();
            DrinksCostsLabel = new Label();
            TotalSnacksCostsLabel = new Label();
            label2 = new Label();
            WaterBillsCostsLabel = new Label();
            InternetBillsCostsLabel = new Label();
            SuspendLayout();
            // 
            // TotalAmountInCashLabel
            // 
            TotalAmountInCashLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAmountInCashLabel.Location = new Point(50, 31);
            TotalAmountInCashLabel.Name = "TotalAmountInCashLabel";
            TotalAmountInCashLabel.Size = new Size(171, 47);
            TotalAmountInCashLabel.TabIndex = 0;
            TotalAmountInCashLabel.Text = "Kasadaki Toplam Tutar:";
            TotalAmountInCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCostLabel.Location = new Point(213, 31);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(171, 47);
            TotalCostLabel.TabIndex = 1;
            TotalCostLabel.Text = "00";
            TotalCostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaffWagesLabel
            // 
            StaffWagesLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StaffWagesLabel.Location = new Point(50, 99);
            StaffWagesLabel.Name = "StaffWagesLabel";
            StaffWagesLabel.Size = new Size(171, 47);
            StaffWagesLabel.TabIndex = 2;
            StaffWagesLabel.Text = "Personel Maaşları:";
            StaffWagesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaffWagesCost
            // 
            StaffWagesCost.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StaffWagesCost.Location = new Point(213, 99);
            StaffWagesCost.Name = "StaffWagesCost";
            StaffWagesCost.Size = new Size(171, 47);
            StaffWagesCost.TabIndex = 3;
            StaffWagesCost.Text = "00";
            StaffWagesCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AllProductsCosts
            // 
            AllProductsCosts.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllProductsCosts.Location = new Point(50, 155);
            AllProductsCosts.Name = "AllProductsCosts";
            AllProductsCosts.Size = new Size(171, 58);
            AllProductsCosts.TabIndex = 4;
            AllProductsCosts.Text = "Alınan Ürünlerin Tutarı:";
            AllProductsCosts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoodCostsLabel
            // 
            FoodCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodCostsLabel.Location = new Point(213, 155);
            FoodCostsLabel.Name = "FoodCostsLabel";
            FoodCostsLabel.Size = new Size(171, 47);
            FoodCostsLabel.TabIndex = 5;
            FoodCostsLabel.Text = "00";
            FoodCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BillsLabel
            // 
            BillsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillsLabel.Location = new Point(50, 213);
            BillsLabel.Name = "BillsLabel";
            BillsLabel.Size = new Size(171, 47);
            BillsLabel.TabIndex = 6;
            BillsLabel.Text = "Faturalar:";
            BillsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElectricBillsCostsLabel
            // 
            ElectricBillsCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ElectricBillsCostsLabel.Location = new Point(213, 213);
            ElectricBillsCostsLabel.Name = "ElectricBillsCostsLabel";
            ElectricBillsCostsLabel.Size = new Size(171, 47);
            ElectricBillsCostsLabel.TabIndex = 7;
            ElectricBillsCostsLabel.Text = "00";
            ElectricBillsCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaffNumberLabel
            // 
            StaffNumberLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StaffNumberLabel.Location = new Point(416, 55);
            StaffNumberLabel.Name = "StaffNumberLabel";
            StaffNumberLabel.Size = new Size(171, 52);
            StaffNumberLabel.TabIndex = 8;
            StaffNumberLabel.Text = "Personel Sayısı:";
            StaffNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaffNumberTextBox
            // 
            StaffNumberTextBox.BackColor = SystemColors.Info;
            StaffNumberTextBox.Location = new Point(610, 68);
            StaffNumberTextBox.Name = "StaffNumberTextBox";
            StaffNumberTextBox.Size = new Size(170, 27);
            StaffNumberTextBox.TabIndex = 9;
            // 
            // CalculateButton
            // 
            CalculateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalculateButton.BackColor = SystemColors.ControlLightLight;
            CalculateButton.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculateButton.Location = new Point(686, 320);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 29);
            CalculateButton.TabIndex = 10;
            CalculateButton.Text = "Hesapla";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.Location = new Point(82, 327);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(62, 25);
            ResultLabel.TabIndex = 12;
            ResultLabel.Text = "Sonuç:";
            // 
            // ResultCostLabel
            // 
            ResultCostLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultCostLabel.Location = new Point(286, 327);
            ResultCostLabel.Name = "ResultCostLabel";
            ResultCostLabel.Size = new Size(62, 25);
            ResultCostLabel.TabIndex = 13;
            ResultCostLabel.Text = "00";
            // 
            // DrinksCostsLabel
            // 
            DrinksCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DrinksCostsLabel.Location = new Point(348, 155);
            DrinksCostsLabel.Name = "DrinksCostsLabel";
            DrinksCostsLabel.Size = new Size(171, 47);
            DrinksCostsLabel.TabIndex = 14;
            DrinksCostsLabel.Text = "00";
            DrinksCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalSnacksCostsLabel
            // 
            TotalSnacksCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalSnacksCostsLabel.Location = new Point(470, 155);
            TotalSnacksCostsLabel.Name = "TotalSnacksCostsLabel";
            TotalSnacksCostsLabel.Size = new Size(171, 47);
            TotalSnacksCostsLabel.TabIndex = 15;
            TotalSnacksCostsLabel.Text = "00";
            TotalSnacksCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(-1, 279);
            label2.Name = "label2";
            label2.Size = new Size(857, 23);
            label2.TabIndex = 11;
            label2.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // WaterBillsCostsLabel
            // 
            WaterBillsCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WaterBillsCostsLabel.Location = new Point(348, 213);
            WaterBillsCostsLabel.Name = "WaterBillsCostsLabel";
            WaterBillsCostsLabel.Size = new Size(171, 47);
            WaterBillsCostsLabel.TabIndex = 16;
            WaterBillsCostsLabel.Text = "00";
            WaterBillsCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InternetBillsCostsLabel
            // 
            InternetBillsCostsLabel.Font = new Font("SimSun-ExtG", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InternetBillsCostsLabel.Location = new Point(491, 213);
            InternetBillsCostsLabel.Name = "InternetBillsCostsLabel";
            InternetBillsCostsLabel.Size = new Size(171, 47);
            InternetBillsCostsLabel.TabIndex = 17;
            InternetBillsCostsLabel.Text = "00";
            InternetBillsCostsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmGelirGider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(856, 450);
            Controls.Add(InternetBillsCostsLabel);
            Controls.Add(WaterBillsCostsLabel);
            Controls.Add(TotalSnacksCostsLabel);
            Controls.Add(DrinksCostsLabel);
            Controls.Add(ResultCostLabel);
            Controls.Add(ResultLabel);
            Controls.Add(label2);
            Controls.Add(CalculateButton);
            Controls.Add(StaffNumberTextBox);
            Controls.Add(StaffNumberLabel);
            Controls.Add(ElectricBillsCostsLabel);
            Controls.Add(BillsLabel);
            Controls.Add(FoodCostsLabel);
            Controls.Add(AllProductsCosts);
            Controls.Add(StaffWagesCost);
            Controls.Add(StaffWagesLabel);
            Controls.Add(TotalCostLabel);
            Controls.Add(TotalAmountInCashLabel);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGelirGider";
            Text = "Gelir Gider Tablosu";
            Load += frmGelirGider_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TotalAmountInCashLabel;
        private Label TotalCostLabel;
        private Label StaffWagesLabel;
        private Label StaffWagesCost;
        private Label AllProductsCosts;
        private Label FoodCostsLabel;
        private Label BillsLabel;
        private Label ElectricBillsCostsLabel;
        private Label StaffNumberLabel;
        private TextBox StaffNumberTextBox;
        private Button CalculateButton;
        private Label ResultLabel;
        private Label ResultCostLabel;
        private Label DrinksCostsLabel;
        private Label TotalSnacksCostsLabel;
        private Label label2;
        private Label WaterBillsCostsLabel;
        private Label InternetBillsCostsLabel;
    }
}