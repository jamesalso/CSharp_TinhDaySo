namespace CSharp_TinhDaySo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            input1 = new TextBox();
            input2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            inputTong = new TextBox();
            inputTich = new TextBox();
            inputTongSoChan = new TextBox();
            inputTongSoLe = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(453, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 39);
            label1.TabIndex = 0;
            label1.Text = "Tính Dãy Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label2.ForeColor = Color.YellowGreen;
            label2.Location = new Point(103, 95);
            label2.Name = "label2";
            label2.Size = new Size(222, 33);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn dãy số";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(217, 155);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 1;
            label3.Text = "Số bắt đầu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(568, 155);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 1;
            label4.Text = "Số kết thúc:";
            // 
            // input1
            // 
            input1.Location = new Point(355, 149);
            input1.Name = "input1";
            input1.Size = new Size(174, 33);
            input1.TabIndex = 2;
            // 
            // input2
            // 
            input2.Location = new Point(712, 149);
            input2.Name = "input2";
            input2.Size = new Size(174, 33);
            input2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label5.ForeColor = Color.YellowGreen;
            label5.Location = new Point(103, 215);
            label5.Name = "label5";
            label5.Size = new Size(119, 33);
            label5.TabIndex = 1;
            label5.Text = "Kết quả";
            label5.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(207, 272);
            label6.Name = "label6";
            label6.Size = new Size(137, 27);
            label6.TabIndex = 1;
            label6.Text = "Tổng các số:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(207, 314);
            label7.Name = "label7";
            label7.Size = new Size(128, 27);
            label7.TabIndex = 1;
            label7.Text = "Tích các số:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(207, 360);
            label8.Name = "label8";
            label8.Size = new Size(190, 27);
            label8.TabIndex = 1;
            label8.Text = "Tổng các số chẵn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(207, 405);
            label9.Name = "label9";
            label9.Size = new Size(161, 27);
            label9.TabIndex = 1;
            label9.Text = "Tổng các số lẻ:";
            // 
            // inputTong
            // 
            inputTong.Location = new Point(418, 266);
            inputTong.Name = "inputTong";
            inputTong.ReadOnly = true;
            inputTong.Size = new Size(189, 33);
            inputTong.TabIndex = 3;
            inputTong.TextChanged += textBox1_TextChanged;
            // 
            // inputTich
            // 
            inputTich.Location = new Point(418, 308);
            inputTich.Name = "inputTich";
            inputTich.ReadOnly = true;
            inputTich.Size = new Size(189, 33);
            inputTich.TabIndex = 3;
            // 
            // inputTongSoChan
            // 
            inputTongSoChan.Location = new Point(418, 354);
            inputTongSoChan.Name = "inputTongSoChan";
            inputTongSoChan.ReadOnly = true;
            inputTongSoChan.Size = new Size(189, 33);
            inputTongSoChan.TabIndex = 3;
            // 
            // inputTongSoLe
            // 
            inputTongSoLe.Location = new Point(418, 399);
            inputTongSoLe.Name = "inputTongSoLe";
            inputTongSoLe.ReadOnly = true;
            inputTongSoLe.Size = new Size(189, 33);
            inputTongSoLe.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(340, 512);
            button1.Name = "button1";
            button1.Size = new Size(213, 47);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            button2.Location = new Point(588, 512);
            button2.Name = "button2";
            button2.Size = new Size(213, 47);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1137, 633);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(inputTongSoLe);
            Controls.Add(inputTongSoChan);
            Controls.Add(inputTich);
            Controls.Add(inputTong);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 16F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox input1;
        private TextBox input2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox inputTong;
        private TextBox inputTich;
        private TextBox inputTongSoChan;
        private TextBox inputTongSoLe;
        private Button button1;
        private Button button2;
    }
}
