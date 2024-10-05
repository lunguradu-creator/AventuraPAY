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
            userComboBox = new ComboBox();
            cardLabel = new Label();
            cashLabel = new Label();
            protocolLabel = new Label();
            totalLabel = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            showStatisticsButton = new Button();
            backButton = new Button();
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(75, 75);
            userComboBox.Margin = new Padding(4, 4, 4, 4);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(448, 38);
            userComboBox.TabIndex = 0;
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Location = new Point(75, 150);
            cardLabel.Margin = new Padding(4, 0, 4, 0);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new Size(110, 30);
            cardLabel.TabIndex = 1;
            cardLabel.Text = "Card: 0 Lei";
            // 
            // cashLabel
            // 
            cashLabel.AutoSize = true;
            cashLabel.Location = new Point(75, 210);
            cashLabel.Margin = new Padding(4, 0, 4, 0);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new Size(112, 30);
            cashLabel.TabIndex = 2;
            cashLabel.Text = "Cash: 0 Lei";
            // 
            // protocolLabel
            // 
            protocolLabel.AutoSize = true;
            protocolLabel.Location = new Point(75, 270);
            protocolLabel.Margin = new Padding(4, 0, 4, 0);
            protocolLabel.Name = "protocolLabel";
            protocolLabel.Size = new Size(144, 30);
            protocolLabel.TabIndex = 3;
            protocolLabel.Text = "Protocol: 0 Lei";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(75, 330);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(111, 30);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total: 0 Lei";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(75, 390);
            startDatePicker.Margin = new Padding(4, 4, 4, 4);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(448, 35);
            startDatePicker.TabIndex = 5;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(75, 450);
            endDatePicker.Margin = new Padding(4, 4, 4, 4);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(448, 35);
            endDatePicker.TabIndex = 6;
            // 
            // showStatisticsButton
            // 
            showStatisticsButton.Location = new Point(75, 525);
            showStatisticsButton.Margin = new Padding(4, 4, 4, 4);
            showStatisticsButton.Name = "showStatisticsButton";
            showStatisticsButton.Size = new Size(450, 60);
            showStatisticsButton.TabIndex = 7;
            showStatisticsButton.Text = "Show Statistics";
            showStatisticsButton.UseVisualStyleBackColor = true;
            showStatisticsButton.Click += showStatisticsButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(75, 600);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(450, 60);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(75, 675);
            buttonLogout.Margin = new Padding(4, 4, 4, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(450, 60);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // statistica2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2279, 1140);
            Controls.Add(buttonLogout);
            Controls.Add(backButton);
            Controls.Add(showStatisticsButton);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(totalLabel);
            Controls.Add(protocolLabel);
            Controls.Add(cashLabel);
            Controls.Add(cardLabel);
            Controls.Add(userComboBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "statistica2";
            Text = "Statistics";
            Load += statistica2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
