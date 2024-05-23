namespace ahmad_project_Game
{
    partial class Form4
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
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            btn_next = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Xbox2;
            pictureBox1.Location = new Point(247, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Lime;
            textBox5.Location = new Point(247, 298);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(343, 27);
            textBox5.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Lime;
            textBox3.Location = new Point(247, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(57, 297);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 17;
            label5.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(57, 229);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 15;
            label3.Text = "email";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Lime;
            btn_next.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_next.Location = new Point(354, 388);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(138, 40);
            btn_next.TabIndex = 12;
            btn_next.Text = "next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(721, 537);
            button4.Name = "button4";
            button4.Size = new Size(112, 40);
            button4.TabIndex = 34;
            button4.Text = "Exet";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1, 537);
            button3.Name = "button3";
            button3.Size = new Size(105, 40);
            button3.TabIndex = 33;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(836, 579);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btn_next);
            Name = "Form4";
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label5;
        private Label label3;
        private Button btn_next;
        private Button button4;
        private Button button3;
    }
}