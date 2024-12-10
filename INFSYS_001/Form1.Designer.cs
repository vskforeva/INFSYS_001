namespace INFSYS_001
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(607, 375);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(520, 375);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 4;
            label1.Text = "Количество переменных: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 46);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 5;
            label2.Text = "Количество ограничений: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(197, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(307, 79);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(185, 46);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(109, 23);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(185, 20);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(109, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 99);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 9;
            label3.Text = "Целевая функция";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 166);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "Ограничения";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(10, 116);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(10, 183);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 188);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 59);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label7);
            panel3.Location = new Point(10, 401);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 236);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 0;
            label7.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 384);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 13;
            label6.Text = "Решение";
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "min", "max" });
            comboBox1.Location = new Point(606, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "min";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(700, 648);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Button button3;
        private Label label7;
        private ComboBox comboBox1;
    }
}
