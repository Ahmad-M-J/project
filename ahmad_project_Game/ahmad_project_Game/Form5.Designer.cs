
namespace ahmad_project_Game
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_next = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(123, 57);
            label1.Name = "label1";
            label1.Size = new Size(601, 75);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(123, 132);
            label2.Name = "label2";
            label2.Size = new Size(601, 75);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(123, 207);
            label3.Name = "label3";
            label3.Size = new Size(601, 75);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(123, 271);
            label4.Name = "label4";
            label4.Size = new Size(601, 75);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Lime;
            btn_next.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_next.Location = new Point(416, 393);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(138, 40);
            btn_next.TabIndex = 13;
            btn_next.Text = "cancel";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(560, 393);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 14;
            button1.Text = "next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(144, 409);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "i accebt all this";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(722, 537);
            button4.Name = "button4";
            button4.Size = new Size(112, 40);
            button4.TabIndex = 34;
            button4.Text = "Exet";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(2, 537);
            button3.Name = "button3";
            button3.Size = new Size(105, 40);
            button3.TabIndex = 33;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += this.button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(836, 579);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(btn_next);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_next;
        private Button button1;
        private CheckBox checkBox1;
        private Button button4;
        private Button button3;
    }
}