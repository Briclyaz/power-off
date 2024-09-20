namespace PowerOFF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            panel2 = new Panel();
            checkedListBox2 = new CheckedListBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 6);
            label1.Name = "label1";
            label1.Size = new Size(315, 60);
            label1.TabIndex = 0;
            label1.Text = "Настрой меня";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 544);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(4, 371);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 42);
            panel5.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(201, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 24);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(266, 10);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 2;
            label8.Text = "часов";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(192, 23);
            label7.TabIndex = 2;
            label7.Text = "Выключить ПК через:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(6, 329);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 303);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 2;
            label3.Text = "Выберите время:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(301, 39);
            label2.TabIndex = 2;
            label2.Text = "Время выключения:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(4, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 253);
            panel3.TabIndex = 10;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" });
            checkedListBox1.Location = new Point(13, 56);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(129, 112);
            checkedListBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 19);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 2;
            label4.Text = "Будние дни:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkedListBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(172, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 253);
            panel2.TabIndex = 10;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Суббота", "Воскресенье" });
            checkedListBox2.Location = new Point(17, 56);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(129, 112);
            checkedListBox2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 191);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 2;
            label6.Text = "Выберите время:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(5, 217);
            dateTimePicker2.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(148, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 19);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 2;
            label5.Text = "Выходные дни:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(4, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 119);
            panel4.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(2, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 45);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Применять при \r\nзапуске системы";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(165, 5);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(168, 45);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Не закрывать,\r\nсворачивать в трей";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(234, 75);
            button2.Name = "button2";
            button2.Size = new Size(93, 35);
            button2.TabIndex = 4;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(148, 54);
            button1.TabIndex = 4;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Приложение свёрнуто";
            notifyIcon1.BalloonTipTitle = "PowerOFF";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Приложение работает в свёрнутом режиме";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(365, 570);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PowerOFF";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Label label3;
        private CheckBox checkBox2;
        private NotifyIcon notifyIcon1;
        private CheckedListBox checkedListBox2;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
        private Button button2;
    }
}
