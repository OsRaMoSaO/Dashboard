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
            panel4 = new Panel();
            lblTitle = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            minimizeBtn = new Button();
            formLoaderPnl = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(46, 51, 73);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(184, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(693, 19);
            panel4.TabIndex = 5;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            panel4.MouseUp += panel4_MouseUp;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(208, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "YLF Dashboard";
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
            textBox1.Visible = false;
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
            // minimizeBtn
            // 
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(883, 12);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(25, 25);
            minimizeBtn.TabIndex = 6;
            minimizeBtn.Text = "-";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // formLoaderPnl
            // 
            formLoaderPnl.Dock = DockStyle.Bottom;
            formLoaderPnl.Location = new Point(185, 79);
            formLoaderPnl.Name = "formLoaderPnl";
            formLoaderPnl.Size = new Size(766, 498);
            formLoaderPnl.TabIndex = 7;
            // 
            // DashboardMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(formLoaderPnl);
            Controls.Add(minimizeBtn);
            Controls.Add(panel4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblTitle;
        private TextBox textBox1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Label userNameText;
        private Panel panel4;
        private Button minimizeBtn;
        private Panel formLoaderPnl;
    }
}