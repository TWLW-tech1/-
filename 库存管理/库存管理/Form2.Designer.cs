namespace 库存管理
{
    partial class Form2
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
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 108);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 155);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(224, 203);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(172, 23);
            textBox7.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(199, 259);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 7;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(161, 11);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(171, 62);
            button2.TabIndex = 8;
            button2.Text = "欢迎注册";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(104, 105);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(87, 24);
            button3.TabIndex = 9;
            button3.Text = "请输入用户名";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(104, 155);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(87, 24);
            button4.TabIndex = 10;
            button4.Text = "请输入密码";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(104, 203);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(87, 23);
            button5.TabIndex = 11;
            button5.Text = "请确认密码";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 319);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "库存管理系统v24.6.10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}