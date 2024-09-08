using System;
using System.Windows.Forms;

namespace AventuraPAY
{
    partial class AventuraPAY : Form
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AventuraPAY));
            label1 = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonSubmit = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(761, 1136);
            label1.Name = "label1";
            label1.Size = new Size(587, 32);
            label1.TabIndex = 1;
            label1.Text = "BLEDEA I. MARIA INTREPRINDERE INDIVIDUALĂ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(850, 750);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(185, 38);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top;
            textBoxUsername.Font = new Font("Arial", 14F);
            textBoxUsername.Location = new Point(850, 786);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(398, 45);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.TextChanged += textBox1_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelPassword.Location = new Point(850, 865);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(127, 38);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Parola:";
            labelPassword.Click += labelPassword_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Font = new Font("Arial", 14F);
            textBoxPassword.Location = new Point(850, 901);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(398, 45);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Top;
            buttonSubmit.Font = new Font("Arial", 14F, FontStyle.Bold);
            buttonSubmit.Location = new Point(850, 1004);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(398, 52);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Login";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(885, 1168);
            label2.Name = "label2";
            label2.Size = new Size(353, 32);
            label2.TabIndex = 7;
            label2.Text = "CUI 50174577, F24/376/2024";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 1289);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 1341);
            label3.Name = "label3";
            label3.Size = new Size(478, 34);
            label3.TabIndex = 9;
            label3.Text = "lrcoders.ro - Softwere & WebDesign - 0745-539333";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(794, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(777, 1212);
            label4.Name = "label4";
            label4.Size = new Size(552, 32);
            label4.TabIndex = 11;
            label4.Text = "COMUNA SĂPÂNȚA, MARAMUREȘ, NR. 1170.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // AventuraPAY
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2104, 1422);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(label1);
            Name = "AventuraPAY";
            Text = "AventuraPAY";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSubmit.PerformClick();
            }
        }
    }
}
