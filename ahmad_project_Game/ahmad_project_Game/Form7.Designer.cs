namespace ahmad_project_Game
{
    partial class Form77
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form77));
            beard = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            topp = new PictureBox();
            ground = new PictureBox();
            botomm = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)beard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botomm).BeginInit();
            SuspendLayout();
            // 
            // beard
            // 
            beard.Image = Properties.Resources.bird1;
            beard.Location = new Point(128, 186);
            beard.Name = "beard";
            beard.Size = new Size(56, 49);
            beard.SizeMode = PictureBoxSizeMode.StretchImage;
            beard.TabIndex = 0;
            beard.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // topp
            // 
            topp.Image = (Image)resources.GetObject("topp.Image");
            topp.Location = new Point(648, 2);
            topp.Name = "topp";
            topp.Size = new Size(125, 135);
            topp.SizeMode = PictureBoxSizeMode.StretchImage;
            topp.TabIndex = 1;
            topp.TabStop = false;
            topp.Click += pictureBox2_Click;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-8, 486);
            ground.Name = "ground";
            ground.Size = new Size(795, 91);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // botomm
            // 
            botomm.Image = (Image)resources.GetObject("botomm.Image");
            botomm.Location = new Point(483, 313);
            botomm.Name = "botomm";
            botomm.Size = new Size(125, 178);
            botomm.SizeMode = PictureBoxSizeMode.StretchImage;
            botomm.TabIndex = 3;
            botomm.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 29);
            label1.TabIndex = 4;
            label1.Text = "score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F);
            label2.Location = new Point(112, 21);
            label2.Name = "label2";
            label2.Size = new Size(27, 29);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // Form77
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(785, 573);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botomm);
            Controls.Add(ground);
            Controls.Add(topp);
            Controls.Add(beard);
            Name = "Form77";
            Text = "Form7";
            Load += Form7_Load;
            KeyDown += Form77_KeyDown;
            KeyUp += Form77_KeyUp;
            ((System.ComponentModel.ISupportInitialize)beard).EndInit();
            ((System.ComponentModel.ISupportInitialize)topp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)botomm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox beard;
        private System.Windows.Forms.Timer timer1;
        private PictureBox topp;
        private PictureBox ground;
        private PictureBox botomm;
        private Label label1;
        private Label label2;
    }
}