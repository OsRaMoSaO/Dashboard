namespace Zipperoni
{
    partial class DashboardMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMain));
            panel1 = new Panel();
            pnlNav = new Panel();
            settingsBtn = new Button();
            statsBtn = new Button();
            dashboardBtn = new Button();
            panel2 = new Panel();
            userNameText = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userInfoText = new Label();
            panel3 = new Panel();
            button2 = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            quantumPicture = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantumPicture).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(statsBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 577);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 4;
            // 
            // settingsBtn
            // 
            settingsBtn.BackgroundImageLayout = ImageLayout.None;
            settingsBtn.Dock = DockStyle.Bottom;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            settingsBtn.ForeColor = Color.FromArgb(0, 126, 249);
            settingsBtn.ImageAlign = ContentAlignment.MiddleRight;
            settingsBtn.Location = new Point(0, 535);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(185, 42);
            settingsBtn.TabIndex = 3;
            settingsBtn.Text = "Settings";
            settingsBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            settingsBtn.Leave += settingsBtn_Leave;
            // 
            // statsBtn
            // 
            statsBtn.BackgroundImageLayout = ImageLayout.None;
            statsBtn.Dock = DockStyle.Top;
            statsBtn.FlatAppearance.BorderSize = 0;
            statsBtn.FlatStyle = FlatStyle.Flat;
            statsBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            statsBtn.ForeColor = Color.FromArgb(0, 126, 249);
            statsBtn.ImageAlign = ContentAlignment.MiddleRight;
            statsBtn.Location = new Point(0, 192);
            statsBtn.Name = "statsBtn";
            statsBtn.Size = new Size(185, 42);
            statsBtn.TabIndex = 2;
            statsBtn.Text = "Statistics";
            statsBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            statsBtn.UseVisualStyleBackColor = true;
            statsBtn.Click += statsBtn_Click;
            statsBtn.Leave += statsBtn_Leave;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackgroundImageLayout = ImageLayout.None;
            dashboardBtn.Dock = DockStyle.Top;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.FromArgb(0, 126, 249);
            dashboardBtn.ImageAlign = ContentAlignment.MiddleRight;
            dashboardBtn.Location = new Point(0, 150);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(185, 42);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            dashboardBtn.Leave += dashboardBtn_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(userNameText);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(userInfoText);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 150);
            panel2.TabIndex = 0;
            // 
            // userNameText
            // 
            userNameText.AutoSize = true;
            userNameText.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            userNameText.ForeColor = Color.FromArgb(0, 126, 249);
            userNameText.Location = new Point(50, 86);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(83, 19);
            userNameText.TabIndex = 1;
            userNameText.Text = "User Name";
            userNameText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(181, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(770, 574);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(181, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 562);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // userInfoText
            // 
            userInfoText.AutoSize = true;
            userInfoText.Font = new Font("Microsoft YaHei UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            userInfoText.ForeColor = Color.FromArgb(158, 161, 178);
            userInfoText.Location = new Point(34, 116);
            userInfoText.Name = "userInfoText";
            userInfoText.Size = new Size(109, 14);
            userInfoText.TabIndex = 2;
            userInfoText.Text = "User Information here";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(quantumPicture);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 152);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(484, 103);
            button2.Name = "button2";
            button2.Size = new Size(247, 38);
            button2.TabIndex = 6;
            button2.Text = "Launch!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            pictureBox2.BackgroundImage = Dashboard.Properties.Resources.green_circle_2866218524;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 146, 249);
            label3.Location = new Point(644, 4);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 1;
            label3.Text = "Free!";
            label3.Click += label3_Click;
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
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(208, 22);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(578, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 26);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search for an app";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(914, 12);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel3);
            flowLayoutPanel3.Location = new Point(192, 79);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(747, 623);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantumPicture).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label userInfoText;
        private Button dashboardBtn;
        private Button settingsBtn;
        private Button statsBtn;
        private Panel pnlNav;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox quantumPicture;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private Label userNameText;
    }
}