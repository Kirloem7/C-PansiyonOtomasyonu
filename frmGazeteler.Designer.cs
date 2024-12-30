namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmGazeteler
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
            NewspaperWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            NewspaperButton1 = new Button();
            Newspaper2Button = new Button();
            NewspaperButton3 = new Button();
            NewspaperButton4 = new Button();
            ((System.ComponentModel.ISupportInitialize)NewspaperWebView).BeginInit();
            SuspendLayout();
            // 
            // NewspaperWebView
            // 
            NewspaperWebView.AllowExternalDrop = true;
            NewspaperWebView.CreationProperties = null;
            NewspaperWebView.DefaultBackgroundColor = Color.White;
            NewspaperWebView.Location = new Point(2, 34);
            NewspaperWebView.Name = "NewspaperWebView";
            NewspaperWebView.Size = new Size(893, 416);
            NewspaperWebView.TabIndex = 0;
            NewspaperWebView.ZoomFactor = 1D;
            // 
            // NewspaperButton1
            // 
            NewspaperButton1.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewspaperButton1.Location = new Point(2, -1);
            NewspaperButton1.Name = "NewspaperButton1";
            NewspaperButton1.Size = new Size(226, 37);
            NewspaperButton1.TabIndex = 1;
            NewspaperButton1.Text = "Hürriyet";
            NewspaperButton1.UseVisualStyleBackColor = true;
            NewspaperButton1.Click += NewspaperButton1_Click;
            // 
            // Newspaper2Button
            // 
            Newspaper2Button.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Newspaper2Button.Location = new Point(224, -1);
            Newspaper2Button.Name = "Newspaper2Button";
            Newspaper2Button.Size = new Size(226, 37);
            Newspaper2Button.TabIndex = 2;
            Newspaper2Button.Text = "Sözcü";
            Newspaper2Button.UseVisualStyleBackColor = true;
            Newspaper2Button.Click += Newspaper2Button_Click;
            // 
            // NewspaperButton3
            // 
            NewspaperButton3.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewspaperButton3.Location = new Point(443, -1);
            NewspaperButton3.Name = "NewspaperButton3";
            NewspaperButton3.Size = new Size(226, 37);
            NewspaperButton3.TabIndex = 3;
            NewspaperButton3.Text = "Cumhuriyet";
            NewspaperButton3.UseVisualStyleBackColor = true;
            NewspaperButton3.Click += NewspaperButton3_Click;
            // 
            // NewspaperButton4
            // 
            NewspaperButton4.Font = new Font("SimSun-ExtG", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewspaperButton4.Location = new Point(664, -1);
            NewspaperButton4.Name = "NewspaperButton4";
            NewspaperButton4.Size = new Size(231, 37);
            NewspaperButton4.TabIndex = 4;
            NewspaperButton4.Text = "Fanatik";
            NewspaperButton4.UseVisualStyleBackColor = true;
            NewspaperButton4.Click += NewspaperButton4_Click;
            // 
            // frmGazeteler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(895, 450);
            Controls.Add(NewspaperButton4);
            Controls.Add(NewspaperButton3);
            Controls.Add(Newspaper2Button);
            Controls.Add(NewspaperButton1);
            Controls.Add(NewspaperWebView);
            Name = "frmGazeteler";
            Text = "Gazeteler";
            ((System.ComponentModel.ISupportInitialize)NewspaperWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 NewspaperWebView;
        private Button NewspaperButton1;
        private Button Newspaper2Button;
        private Button NewspaperButton3;
        private Button NewspaperButton4;
    }
}