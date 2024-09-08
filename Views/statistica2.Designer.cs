namespace AventuraPAY.Views
{
    partial class statistica2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button showStatisticsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buttonLogout;

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

        private void InitializeComponent()
        {
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.showStatisticsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(50, 50);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(300, 28);
            this.userComboBox.TabIndex = 0;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(50, 100);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(77, 20);
            this.cardLabel.TabIndex = 1;
            this.cardLabel.Text = "Card: 0 Lei";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(50, 140);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(83, 20);
            this.cashLabel.TabIndex = 2;
            this.cashLabel.Text = "Cash: 0 Lei";
            // 
            // protocolLabel
            // 
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Location = new System.Drawing.Point(50, 180);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(112, 20);
            this.protocolLabel.TabIndex = 3;
            this.protocolLabel.Text = "Protocol: 0 Lei";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(50, 220);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(90, 20);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total: 0 Lei";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(50, 260);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(300, 27);
            this.startDatePicker.TabIndex = 5;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(50, 300);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(300, 27);
            this.endDatePicker.TabIndex = 6;
            // 
            // showStatisticsButton
            // 
            this.showStatisticsButton.Location = new System.Drawing.Point(50, 350);
            this.showStatisticsButton.Name = "showStatisticsButton";
            this.showStatisticsButton.Size = new System.Drawing.Size(300, 40);
            this.showStatisticsButton.TabIndex = 7;
            this.showStatisticsButton.Text = "Show Statistics";
            this.showStatisticsButton.UseVisualStyleBackColor = true;
            this.showStatisticsButton.Click += new System.EventHandler(this.showStatisticsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 400);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 40);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(50, 450);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(300, 40);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // statistica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showStatisticsButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.protocolLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.userComboBox);
            this.Name = "statistica2";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.statistica2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
