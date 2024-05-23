namespace ahmad_project_Game
{
    partial class Form9cs
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
            label1 = new Label();
            btn_next = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(284, 99);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 0;
            label1.Text = "Game over";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Lime;
            btn_next.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_next.Location = new Point(553, 235);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(138, 40);
            btn_next.TabIndex = 29;
            btn_next.Text = "play again";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(109, 235);
            label2.Name = "label2";
            label2.Size = new Size(133, 46);
            label2.TabIndex = 30;
            label2.Text = "score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(263, 235);
            label3.Name = "label3";
            label3.Size = new Size(42, 46);
            label3.TabIndex = 31;
            label3.Text = "0";
            // 
            // Form9cs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 497);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_next);
            Controls.Add(label1);
            Name = "Form9cs";
            Text = "Form9cs";
            Load += Form9cs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_next;
        private Label label2;
        private Label label3;
    }
}