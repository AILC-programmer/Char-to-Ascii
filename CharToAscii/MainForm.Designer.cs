namespace CharToAscii
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AsciiCodeLabel = new System.Windows.Forms.Label();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.AILCLabel = new System.Windows.Forms.Label();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.LightRadioButton = new System.Windows.Forms.RadioButton();
            this.ThemePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsciiCodeLabel
            // 
            this.AsciiCodeLabel.AutoSize = true;
            this.AsciiCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AsciiCodeLabel.Location = new System.Drawing.Point(14, 102);
            this.AsciiCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AsciiCodeLabel.Name = "AsciiCodeLabel";
            this.AsciiCodeLabel.Size = new System.Drawing.Size(65, 23);
            this.AsciiCodeLabel.TabIndex = 2;
            this.AsciiCodeLabel.Text = "Hello";
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.BackColor = System.Drawing.Color.White;
            this.CharacterTextBox.Location = new System.Drawing.Point(14, 50);
            this.CharacterTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CharacterTextBox.MaxLength = 1;
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(141, 38);
            this.CharacterTextBox.TabIndex = 1;
            this.CharacterTextBox.TextChanged += new System.EventHandler(this.CharacterTextBox_TextChanged);
            // 
            // AILCLabel
            // 
            this.AILCLabel.AutoSize = true;
            this.AILCLabel.BackColor = System.Drawing.Color.Transparent;
            this.AILCLabel.Font = new System.Drawing.Font("Kunstler Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AILCLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.AILCLabel.Location = new System.Drawing.Point(14, 9);
            this.AILCLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AILCLabel.Name = "AILCLabel";
            this.AILCLabel.Size = new System.Drawing.Size(118, 37);
            this.AILCLabel.TabIndex = 0;
            this.AILCLabel.Text = "AICL";
            // 
            // ThemePanel
            // 
            this.ThemePanel.BackColor = System.Drawing.Color.Transparent;
            this.ThemePanel.Controls.Add(this.DarkRadioButton);
            this.ThemePanel.Controls.Add(this.LightRadioButton);
            this.ThemePanel.Location = new System.Drawing.Point(163, 12);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(90, 113);
            this.ThemePanel.TabIndex = 3;
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.DarkRadioButton.Location = new System.Drawing.Point(3, 83);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(81, 27);
            this.DarkRadioButton.TabIndex = 1;
            this.DarkRadioButton.Text = "Dark";
            this.DarkRadioButton.UseVisualStyleBackColor = false;
            this.DarkRadioButton.CheckedChanged += new System.EventHandler(this.DarkRadioButton_CheckedChanged);
            // 
            // LightRadioButton
            // 
            this.LightRadioButton.AutoSize = true;
            this.LightRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LightRadioButton.Checked = true;
            this.LightRadioButton.Location = new System.Drawing.Point(3, 7);
            this.LightRadioButton.Name = "LightRadioButton";
            this.LightRadioButton.Size = new System.Drawing.Size(84, 27);
            this.LightRadioButton.TabIndex = 0;
            this.LightRadioButton.TabStop = true;
            this.LightRadioButton.Text = "Light";
            this.LightRadioButton.UseVisualStyleBackColor = false;
            this.LightRadioButton.CheckedChanged += new System.EventHandler(this.LightRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 142);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.CharacterTextBox);
            this.Controls.Add(this.AILCLabel);
            this.Controls.Add(this.AsciiCodeLabel);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caster";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ThemePanel.ResumeLayout(false);
            this.ThemePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AsciiCodeLabel;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.Label AILCLabel;
        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.RadioButton LightRadioButton;
    }
}

