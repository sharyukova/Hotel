namespace Hotel
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allGuestsBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxGuests = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusField = new System.Windows.Forms.ComboBox();
            this.openGuestFormButton = new System.Windows.Forms.Button();
            this.checkoutDTime = new System.Windows.Forms.DateTimePicker();
            this.checkinDTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.availGuestsBtn = new System.Windows.Forms.Label();
            this.reserGuestsBtn = new System.Windows.Forms.Label();
            this.checkoutGuestsBtn = new System.Windows.Forms.Label();
            this.occupGuestsBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 56);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(1104, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 42);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "закрыть";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hotel.Properties.Resources._3643779_clock_hour_ticker_time_times_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(55, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(111, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "timeLabel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.occupGuestsBtn);
            this.panel2.Controls.Add(this.checkoutGuestsBtn);
            this.panel2.Controls.Add(this.reserGuestsBtn);
            this.panel2.Controls.Add(this.availGuestsBtn);
            this.panel2.Controls.Add(this.allGuestsBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 684);
            this.panel2.TabIndex = 1;
            // 
            // allGuestsBtn
            // 
            this.allGuestsBtn.AutoSize = true;
            this.allGuestsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allGuestsBtn.Location = new System.Drawing.Point(188, 194);
            this.allGuestsBtn.Name = "allGuestsBtn";
            this.allGuestsBtn.Size = new System.Drawing.Size(53, 32);
            this.allGuestsBtn.TabIndex = 1;
            this.allGuestsBtn.Text = "Все";
            this.allGuestsBtn.Click += new System.EventHandler(this.allGuestsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.listBoxGuests);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(303, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 684);
            this.panel3.TabIndex = 2;
            // 
            // listBoxGuests
            // 
            this.listBoxGuests.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGuests.FormattingEnabled = true;
            this.listBoxGuests.ItemHeight = 21;
            this.listBoxGuests.Location = new System.Drawing.Point(33, 169);
            this.listBoxGuests.Name = "listBoxGuests";
            this.listBoxGuests.Size = new System.Drawing.Size(385, 487);
            this.listBoxGuests.TabIndex = 2;
            this.listBoxGuests.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список гостей";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.statusField);
            this.panel4.Controls.Add(this.openGuestFormButton);
            this.panel4.Controls.Add(this.checkoutDTime);
            this.panel4.Controls.Add(this.checkinDTime);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.nameField);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.idField);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(777, 80);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 684);
            this.panel4.TabIndex = 3;
            // 
            // statusField
            // 
            this.statusField.Enabled = false;
            this.statusField.ForeColor = System.Drawing.Color.Navy;
            this.statusField.FormattingEnabled = true;
            this.statusField.Items.AddRange(new object[] {
            "Свободен",
            "Зарезервирован",
            "Выписывается",
            "Занят"});
            this.statusField.Location = new System.Drawing.Point(138, 194);
            this.statusField.Name = "statusField";
            this.statusField.Size = new System.Drawing.Size(256, 28);
            this.statusField.TabIndex = 13;
            // 
            // openGuestFormButton
            // 
            this.openGuestFormButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.openGuestFormButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openGuestFormButton.Location = new System.Drawing.Point(204, 507);
            this.openGuestFormButton.Name = "openGuestFormButton";
            this.openGuestFormButton.Size = new System.Drawing.Size(205, 40);
            this.openGuestFormButton.TabIndex = 12;
            this.openGuestFormButton.Text = "Просмотр карточки";
            this.openGuestFormButton.UseVisualStyleBackColor = false;
            this.openGuestFormButton.Click += new System.EventHandler(this.openGuestFormButton_Click);
            // 
            // checkoutDTime
            // 
            this.checkoutDTime.Enabled = false;
            this.checkoutDTime.Location = new System.Drawing.Point(172, 421);
            this.checkoutDTime.Name = "checkoutDTime";
            this.checkoutDTime.Size = new System.Drawing.Size(200, 26);
            this.checkoutDTime.TabIndex = 11;
            // 
            // checkinDTime
            // 
            this.checkinDTime.Enabled = false;
            this.checkinDTime.Location = new System.Drawing.Point(172, 355);
            this.checkinDTime.Name = "checkinDTime";
            this.checkinDTime.Size = new System.Drawing.Size(200, 26);
            this.checkinDTime.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Дата выезда:";
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Enabled = false;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(138, 259);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(256, 63);
            this.nameField.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата заезда:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(52, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус:";
            // 
            // idField
            // 
            this.idField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idField.Enabled = false;
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.idField.Location = new System.Drawing.Point(247, 76);
            this.idField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(60, 27);
            this.idField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер №";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // availGuestsBtn
            // 
            this.availGuestsBtn.AutoSize = true;
            this.availGuestsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availGuestsBtn.Location = new System.Drawing.Point(98, 251);
            this.availGuestsBtn.Name = "availGuestsBtn";
            this.availGuestsBtn.Size = new System.Drawing.Size(143, 32);
            this.availGuestsBtn.TabIndex = 2;
            this.availGuestsBtn.Text = "Свободные";
            this.availGuestsBtn.Click += new System.EventHandler(this.availGuestsBtn_Click);
            // 
            // reserGuestsBtn
            // 
            this.reserGuestsBtn.AutoSize = true;
            this.reserGuestsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reserGuestsBtn.Location = new System.Drawing.Point(23, 319);
            this.reserGuestsBtn.Name = "reserGuestsBtn";
            this.reserGuestsBtn.Size = new System.Drawing.Size(218, 32);
            this.reserGuestsBtn.TabIndex = 3;
            this.reserGuestsBtn.Text = "Зарезервированы";
            this.reserGuestsBtn.Click += new System.EventHandler(this.reserGuestsBtn_Click);
            // 
            // checkoutGuestsBtn
            // 
            this.checkoutGuestsBtn.AutoSize = true;
            this.checkoutGuestsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkoutGuestsBtn.Location = new System.Drawing.Point(57, 387);
            this.checkoutGuestsBtn.Name = "checkoutGuestsBtn";
            this.checkoutGuestsBtn.Size = new System.Drawing.Size(184, 32);
            this.checkoutGuestsBtn.TabIndex = 4;
            this.checkoutGuestsBtn.Text = "Выписываются";
            this.checkoutGuestsBtn.Click += new System.EventHandler(this.checkoutGuestsBtn_Click);
            // 
            // occupGuestsBtn
            // 
            this.occupGuestsBtn.AutoSize = true;
            this.occupGuestsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.occupGuestsBtn.Location = new System.Drawing.Point(146, 452);
            this.occupGuestsBtn.Name = "occupGuestsBtn";
            this.occupGuestsBtn.Size = new System.Drawing.Size(95, 32);
            this.occupGuestsBtn.TabIndex = 5;
            this.occupGuestsBtn.Text = "Заняты";
            this.occupGuestsBtn.Click += new System.EventHandler(this.occupGuestsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1228, 800);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkinDTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button openGuestFormButton;
        private System.Windows.Forms.DateTimePicker checkoutDTime;
        private System.Windows.Forms.ComboBox statusField;
        private System.Windows.Forms.ListBox listBoxGuests;
        private System.Windows.Forms.Label allGuestsBtn;
        private System.Windows.Forms.Label availGuestsBtn;
        private System.Windows.Forms.Label reserGuestsBtn;
        private System.Windows.Forms.Label checkoutGuestsBtn;
        private System.Windows.Forms.Label occupGuestsBtn;
    }
}

