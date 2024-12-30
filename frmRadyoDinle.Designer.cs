namespace LotusPansiyonVeDinlenmeTesisleri
{
    partial class frmRadyoDinle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadyoDinle));
            RadioChannel1LinkLabel = new LinkLabel();
            RadioChannel2LinkLabel = new LinkLabel();
            RadioChannel3LinkLabel = new LinkLabel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // RadioChannel1LinkLabel
            // 
            RadioChannel1LinkLabel.Font = new Font("SimSun-ExtG", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadioChannel1LinkLabel.LinkColor = Color.FromArgb(255, 255, 192);
            RadioChannel1LinkLabel.Location = new Point(27, 332);
            RadioChannel1LinkLabel.Name = "RadioChannel1LinkLabel";
            RadioChannel1LinkLabel.Size = new Size(186, 52);
            RadioChannel1LinkLabel.TabIndex = 0;
            RadioChannel1LinkLabel.TabStop = true;
            RadioChannel1LinkLabel.Text = "Kanal 1";
            RadioChannel1LinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            RadioChannel1LinkLabel.LinkClicked += RadioChannel1LinkLabel_LinkClicked;
            // 
            // RadioChannel2LinkLabel
            // 
            RadioChannel2LinkLabel.Font = new Font("SimSun-ExtG", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadioChannel2LinkLabel.LinkColor = Color.FromArgb(255, 255, 192);
            RadioChannel2LinkLabel.Location = new Point(297, 332);
            RadioChannel2LinkLabel.Name = "RadioChannel2LinkLabel";
            RadioChannel2LinkLabel.Size = new Size(186, 52);
            RadioChannel2LinkLabel.TabIndex = 1;
            RadioChannel2LinkLabel.TabStop = true;
            RadioChannel2LinkLabel.Text = "Kanal 2";
            RadioChannel2LinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            RadioChannel2LinkLabel.LinkClicked += RadioChannel2LinkLabel_LinkClicked;
            // 
            // RadioChannel3LinkLabel
            // 
            RadioChannel3LinkLabel.Font = new Font("SimSun-ExtG", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RadioChannel3LinkLabel.LinkColor = Color.FromArgb(255, 255, 192);
            RadioChannel3LinkLabel.Location = new Point(567, 332);
            RadioChannel3LinkLabel.Name = "RadioChannel3LinkLabel";
            RadioChannel3LinkLabel.Size = new Size(186, 52);
            RadioChannel3LinkLabel.TabIndex = 2;
            RadioChannel3LinkLabel.TabStop = true;
            RadioChannel3LinkLabel.Text = "Kanal 3";
            RadioChannel3LinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            RadioChannel3LinkLabel.LinkClicked += RadioChannel3LinkLabel_LinkClicked;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(-1, -2);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(803, 258);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmRadyoDinle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(800, 450);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(RadioChannel3LinkLabel);
            Controls.Add(RadioChannel2LinkLabel);
            Controls.Add(RadioChannel1LinkLabel);
            Name = "frmRadyoDinle";
            Text = "Radyo";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel RadioChannel1LinkLabel;
        private LinkLabel RadioChannel2LinkLabel;
        private LinkLabel RadioChannel3LinkLabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}