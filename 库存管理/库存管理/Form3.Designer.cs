namespace 库存管理
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(118, 149);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 60);
            button1.TabIndex = 1;
            button1.Text = "员工管理";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(295, 149);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(97, 60);
            button2.TabIndex = 2;
            button2.Text = "商品管理";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.Location = new Point(97, 32);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(312, 84);
            button3.TabIndex = 3;
            button3.Text = "请选择进入的界面";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(118, 225);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(97, 52);
            button4.TabIndex = 4;
            button4.Text = "员工信息";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(295, 225);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(97, 53);
            button5.TabIndex = 5;
            button5.Text = "商品信息";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 319);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "库存管理系统v24.6.10";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}