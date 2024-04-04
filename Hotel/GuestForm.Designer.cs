namespace Hotel
{
    partial class GuestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daysField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPets = new System.Windows.Forms.CheckBox();
            this.chargeField = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.daysField)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(112, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Карточка гостя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Enabled = false;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(219, 154);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(256, 63);
            this.nameField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(130, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "ФИО:";
            // 
            // birthDTime
            // 
            this.birthDTime.Enabled = false;
            this.birthDTime.Location = new System.Drawing.Point(219, 256);
            this.birthDTime.Name = "birthDTime";
            this.birthDTime.Size = new System.Drawing.Size(200, 26);
            this.birthDTime.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(40, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата рождения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Оплата:";
            // 
            // daysField
            // 
            this.daysField.Enabled = false;
            this.daysField.Location = new System.Drawing.Point(219, 390);
            this.daysField.Name = "daysField";
            this.daysField.Size = new System.Drawing.Size(91, 26);
            this.daysField.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кол-во дней:";
            // 
            // checkBoxPets
            // 
            this.checkBoxPets.AutoEllipsis = true;
            this.checkBoxPets.AutoSize = true;
            this.checkBoxPets.Enabled = false;
            this.checkBoxPets.Location = new System.Drawing.Point(245, 451);
            this.checkBoxPets.Name = "checkBoxPets";
            this.checkBoxPets.Size = new System.Drawing.Size(242, 24);
            this.checkBoxPets.TabIndex = 16;
            this.checkBoxPets.Text = "Путешествую с животными";
            this.checkBoxPets.UseVisualStyleBackColor = true;
            // 
            // chargeField
            // 
            this.chargeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chargeField.Enabled = false;
            this.chargeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chargeField.Location = new System.Drawing.Point(219, 319);
            this.chargeField.Name = "chargeField";
            this.chargeField.Size = new System.Drawing.Size(169, 28);
            this.chargeField.TabIndex = 17;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.returnButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.returnButton.Location = new System.Drawing.Point(181, 524);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(129, 36);
            this.returnButton.TabIndex = 18;
            this.returnButton.Text = "Закрыть X";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 595);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.chargeField);
            this.Controls.Add(this.checkBoxPets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daysField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.daysField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown daysField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxPets;
        private System.Windows.Forms.TextBox chargeField;
        private System.Windows.Forms.Button returnButton;
    }
}