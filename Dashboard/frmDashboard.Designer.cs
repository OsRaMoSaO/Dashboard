namespace Dashboard
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel3 = new Panel();
            quantumLaunchBtn = new Button();
            quantumUninstallBtn = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            quantumPicture = new PictureBox();
            label4 = new Label();
            quantumPriceText = new Label();
            label2 = new Label();
            flowLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantumPicture).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel3);
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(766, 477);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(quantumLaunchBtn);
            panel3.Controls.Add(quantumUninstallBtn);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(quantumPicture);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(quantumPriceText);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 152);
            panel3.TabIndex = 4;
            // 
            // quantumLaunchBtn
            // 
            quantumLaunchBtn.BackColor = Color.LightBlue;
            quantumLaunchBtn.FlatAppearance.BorderSize = 0;
            quantumLaunchBtn.FlatStyle = FlatStyle.Flat;
            quantumLaunchBtn.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quantumLaunchBtn.ForeColor = Color.Black;
            quantumLaunchBtn.Location = new Point(504, 103);
            quantumLaunchBtn.Name = "quantumLaunchBtn";
            quantumLaunchBtn.Size = new Size(247, 38);
            quantumLaunchBtn.TabIndex = 6;
            quantumLaunchBtn.Text = "Install";
            quantumLaunchBtn.UseVisualStyleBackColor = false;
            quantumLaunchBtn.Click += quantumLaunchBtn_Click;
            // 
            // quantumUninstallBtn
            // 
            quantumUninstallBtn.BackColor = Color.Brown;
            quantumUninstallBtn.BackgroundImage = Properties.Resources.bin;
            quantumUninstallBtn.BackgroundImageLayout = ImageLayout.Zoom;
            quantumUninstallBtn.FlatAppearance.BorderSize = 0;
            quantumUninstallBtn.FlatStyle = FlatStyle.Flat;
            quantumUninstallBtn.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quantumUninstallBtn.ForeColor = Color.Black;
            quantumUninstallBtn.Location = new Point(460, 103);
            quantumUninstallBtn.Name = "quantumUninstallBtn";
            quantumUninstallBtn.Size = new Size(38, 38);
            quantumUninstallBtn.TabIndex = 7;
            quantumUninstallBtn.UseVisualStyleBackColor = false;
            quantumUninstallBtn.Visible = false;
            quantumUninstallBtn.Click += quantumUninstallBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(159, 151, 176);
            label5.Location = new Point(209, 113);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 5;
            label5.Text = "- Meme";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.green_circle_2866218524;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(173, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // quantumPicture
            // 
            quantumPicture.BackgroundImage = (Image)resources.GetObject("quantumPicture.BackgroundImage");
            quantumPicture.BackgroundImageLayout = ImageLayout.Zoom;
            quantumPicture.Location = new Point(3, 4);
            quantumPicture.Name = "quantumPicture";
            quantumPicture.Size = new Size(164, 143);
            quantumPicture.TabIndex = 3;
            quantumPicture.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(159, 151, 176);
            label4.Location = new Point(182, 47);
            label4.Name = "label4";
            label4.Size = new Size(193, 21);
            label4.TabIndex = 2;
            label4.Text = "Very fun classic calculator!";
            // 
            // quantumPriceText
            // 
            quantumPriceText.AutoSize = true;
            quantumPriceText.Font = new Font("Microsoft YaHei UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            quantumPriceText.ForeColor = Color.FromArgb(0, 146, 249);
            quantumPriceText.Location = new Point(664, 4);
            quantumPriceText.Name = "quantumPriceText";
            quantumPriceText.Size = new Size(87, 37);
            quantumPriceText.TabIndex = 1;
            quantumPriceText.Text = "Free!";
            quantumPriceText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 4);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 0;
            label2.Text = "Quantum Calculator";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(766, 477);
            Controls.Add(flowLayoutPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            flowLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantumPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel3;
        private Button quantumLaunchBtn;
        private Button quantumUninstallBtn;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox quantumPicture;
        private Label label4;
        private Label quantumPriceText;
        private Label label2;
    }
}