﻿namespace wTF
{
    partial class UserPanel
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
            this.Balance = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Recieve = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Label();
            this.otpBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transferAmmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(12, 126);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(168, 25);
            this.Balance.TabIndex = 0;
            this.Balance.Text = "Available Balance";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(12, 53);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(64, 25);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(104, 53);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(92, 25);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // Recieve
            // 
            this.Recieve.AutoSize = true;
            this.Recieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieve.Location = new System.Drawing.Point(312, 225);
            this.Recieve.Name = "Recieve";
            this.Recieve.Size = new System.Drawing.Size(82, 25);
            this.Recieve.TabIndex = 4;
            this.Recieve.Text = "Recieve";
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(2, 231);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(59, 25);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            // 
            // otpBox
            // 
            this.otpBox.Location = new System.Drawing.Point(67, 237);
            this.otpBox.Name = "otpBox";
            this.otpBox.Size = new System.Drawing.Size(100, 20);
            this.otpBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ammount";
            // 
            // transferAmmount
            // 
            this.transferAmmount.Location = new System.Drawing.Point(67, 198);
            this.transferAmmount.Name = "transferAmmount";
            this.transferAmmount.Size = new System.Drawing.Size(100, 20);
            this.transferAmmount.TabIndex = 8;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferAmmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otpBox);
            this.Controls.Add(this.Recieve);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Balance);
            this.Text = "Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Recieve;
        private System.Windows.Forms.Label Send;
        private System.Windows.Forms.TextBox otpBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transferAmmount;
    }
}