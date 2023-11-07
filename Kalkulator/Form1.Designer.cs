namespace Kalkulator
{
    partial class Kalkulator
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
            label1 = new Label();
            label2 = new Label();
            button_added = new Button();
            button_divided = new Button();
            button_multiplied = new Button();
            button_minus = new Button();
            button_equal = new Button();
            button_decimal = new Button();
            button_0 = new Button();
            button_9 = new Button();
            button_8 = new Button();
            button_6 = new Button();
            button_clear = new Button();
            button_5 = new Button();
            button_7 = new Button();
            button_3 = new Button();
            button_4 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(300, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 0;
            label2.Visible = false;
            // 
            // button_added
            // 
            button_added.Location = new Point(275, 304);
            button_added.Name = "button_added";
            button_added.Size = new Size(80, 48);
            button_added.TabIndex = 21;
            button_added.Text = "+";
            button_added.UseVisualStyleBackColor = true;
            button_added.Click += button_added_Click;
            // 
            // button_divided
            // 
            button_divided.Location = new Point(275, 142);
            button_divided.Name = "button_divided";
            button_divided.Size = new Size(80, 48);
            button_divided.TabIndex = 19;
            button_divided.Text = "/";
            button_divided.UseVisualStyleBackColor = true;
            button_divided.Click += button_divided_Click;
            // 
            // button_multiplied
            // 
            button_multiplied.Location = new Point(275, 196);
            button_multiplied.Name = "button_multiplied";
            button_multiplied.Size = new Size(80, 48);
            button_multiplied.TabIndex = 18;
            button_multiplied.Text = "*";
            button_multiplied.UseVisualStyleBackColor = true;
            button_multiplied.Click += button_multiplied_Click;
            // 
            // button_minus
            // 
            button_minus.Location = new Point(275, 250);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(80, 48);
            button_minus.TabIndex = 17;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += button_minus_Click;
            // 
            // button_equal
            // 
            button_equal.Location = new Point(275, 358);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(80, 48);
            button_equal.TabIndex = 16;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += button_equal_Click;
            // 
            // button_decimal
            // 
            button_decimal.Location = new Point(189, 358);
            button_decimal.Name = "button_decimal";
            button_decimal.Size = new Size(80, 48);
            button_decimal.TabIndex = 15;
            button_decimal.Text = ".";
            button_decimal.UseVisualStyleBackColor = true;
            button_decimal.Click += button_decimal_Click;
            // 
            // button_0
            // 
            button_0.Location = new Point(103, 358);
            button_0.Name = "button_0";
            button_0.Size = new Size(80, 48);
            button_0.TabIndex = 14;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(189, 304);
            button_9.Name = "button_9";
            button_9.Size = new Size(80, 48);
            button_9.TabIndex = 13;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(103, 304);
            button_8.Name = "button_8";
            button_8.Size = new Size(80, 48);
            button_8.TabIndex = 12;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(189, 250);
            button_6.Name = "button_6";
            button_6.Size = new Size(80, 48);
            button_6.TabIndex = 11;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(17, 142);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(252, 48);
            button_clear.TabIndex = 10;
            button_clear.Text = "AC";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(103, 250);
            button_5.Name = "button_5";
            button_5.Size = new Size(80, 48);
            button_5.TabIndex = 9;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_7
            // 
            button_7.Location = new Point(17, 304);
            button_7.Name = "button_7";
            button_7.Size = new Size(80, 48);
            button_7.TabIndex = 8;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(189, 196);
            button_3.Name = "button_3";
            button_3.Size = new Size(80, 48);
            button_3.TabIndex = 7;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(17, 250);
            button_4.Name = "button_4";
            button_4.Size = new Size(80, 48);
            button_4.TabIndex = 6;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(103, 196);
            button_2.Name = "button_2";
            button_2.Size = new Size(80, 48);
            button_2.TabIndex = 5;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.Location = new Point(17, 196);
            button_1.Name = "button_1";
            button_1.Size = new Size(80, 48);
            button_1.TabIndex = 20;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(343, 66);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Kalkulator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(375, 419);
            Controls.Add(button_added);
            Controls.Add(button_divided);
            Controls.Add(button_multiplied);
            Controls.Add(button_minus);
            Controls.Add(button_equal);
            Controls.Add(button_decimal);
            Controls.Add(button_0);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_6);
            Controls.Add(button_clear);
            Controls.Add(button_5);
            Controls.Add(button_7);
            Controls.Add(button_3);
            Controls.Add(button_4);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kalkulator";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_added;
        private Button button_divided;
        private Button button_multiplied;
        private Button button_minus;
        private Button button_equal;
        private Button button_decimal;
        private Button button_0;
        private Button button_9;
        private Button button_8;
        private Button button_6;
        private Button button_clear;
        private Button button_5;
        private Button button_7;
        private Button button_3;
        private Button button_4;
        private Button button_2;
        private Button button_1;
        private TextBox textBox1;
    }
}