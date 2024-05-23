namespace ahmad_project_Game
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
            btn_up = new Button();
            btn_inn = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_up
            // 
            btn_up.BackColor = SystemColors.ActiveCaptionText;
            btn_up.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_up.ForeColor = Color.Lime;
            btn_up.Location = new Point(249, 318);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(332, 46);
            btn_up.TabIndex = 0;
            btn_up.Text = "sign in";
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_in_Click;
            // 
            // btn_inn
            // 
            btn_inn.BackColor = SystemColors.ActiveCaptionText;
            btn_inn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_inn.ForeColor = Color.Lime;
            btn_inn.Location = new Point(249, 388);
            btn_inn.Name = "btn_inn";
            btn_inn.Size = new Size(332, 46);
            btn_inn.TabIndex = 1;
            btn_inn.Text = "sign up";
            btn_inn.UseVisualStyleBackColor = false;
            btn_inn.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Xbox1;
            pictureBox1.Location = new Point(180, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(722, 536);
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
            button3.Location = new Point(2, 536);
            button3.Name = "button3";
            button3.Size = new Size(105, 40);
            button3.TabIndex = 33;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(836, 579);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(btn_inn);
            Controls.Add(btn_up);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_up;
        private Button btn_inn;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
    }
}