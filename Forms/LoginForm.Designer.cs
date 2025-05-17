namespace HashWarden
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            RegisterFormButton = new Button();
            label1 = new Label();
            LoginButton = new Button();
            label2 = new Label();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            EmailInput = new TextBox();
            UsernameLabel = new Label();
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            MinimalizeButton = new Button();
            HeaderImages = new ImageList(components);
            ExitButton = new Button();
            LogoImage = new ImageList(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(Header);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 496);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 60);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(380, 436);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(RegisterFormButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LoginButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PasswordInput);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(EmailInput);
            panel2.Controls.Add(UsernameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(60, 67);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 301);
            panel2.TabIndex = 0;
            // 
            // RegisterFormButton
            // 
            RegisterFormButton.AutoEllipsis = true;
            RegisterFormButton.BackColor = Color.FromArgb(40, 40, 40);
            RegisterFormButton.Dock = DockStyle.Top;
            RegisterFormButton.FlatAppearance.BorderSize = 0;
            RegisterFormButton.FlatStyle = FlatStyle.Flat;
            RegisterFormButton.ForeColor = Color.Gainsboro;
            RegisterFormButton.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterFormButton.ImageIndex = 2;
            RegisterFormButton.Location = new Point(0, 262);
            RegisterFormButton.Margin = new Padding(3, 2, 3, 2);
            RegisterFormButton.Name = "RegisterFormButton";
            RegisterFormButton.Padding = new Padding(9, 0, 0, 4);
            RegisterFormButton.Size = new Size(260, 38);
            RegisterFormButton.TabIndex = 7;
            RegisterFormButton.Text = "Zarejestruj się";
            RegisterFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RegisterFormButton.UseVisualStyleBackColor = false;
            RegisterFormButton.Click += RegisterFormButton_click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(0, 172);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 8);
            label1.Size = new Size(260, 90);
            label1.TabIndex = 6;
            label1.Text = "Nie masz konta?";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LogoutButton
            // 
            LoginButton.AutoEllipsis = true;
            LoginButton.BackColor = Color.FromArgb(40, 40, 40);
            LoginButton.Dock = DockStyle.Top;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = Color.Gainsboro;
            LoginButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginButton.ImageIndex = 2;
            LoginButton.Location = new Point(0, 134);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LogoutButton";
            LoginButton.Padding = new Padding(9, 0, 0, 4);
            LoginButton.Size = new Size(260, 38);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Zaloguj";
            LoginButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 104);
            label2.Name = "label2";
            label2.Size = new Size(260, 30);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Dock = DockStyle.Top;
            PasswordInput.Font = new Font("Segoe UI", 12F);
            PasswordInput.ImeMode = ImeMode.NoControl;
            PasswordInput.Location = new Point(0, 82);
            PasswordInput.Margin = new Padding(3, 2, 3, 2);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(260, 22);
            PasswordInput.TabIndex = 3;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Dock = DockStyle.Top;
            PasswordLabel.Font = new Font("Segoe UI", 12F);
            PasswordLabel.ForeColor = Color.Gainsboro;
            PasswordLabel.Location = new Point(0, 52);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(260, 30);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Hasło";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailInput
            // 
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Dock = DockStyle.Top;
            EmailInput.Font = new Font("Segoe UI", 12F);
            EmailInput.ImeMode = ImeMode.NoControl;
            EmailInput.Location = new Point(0, 30);
            EmailInput.Margin = new Padding(3, 2, 3, 2);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(260, 22);
            EmailInput.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Dock = DockStyle.Top;
            UsernameLabel.Font = new Font("Segoe UI", 12F);
            UsernameLabel.ForeColor = Color.Gainsboro;
            UsernameLabel.Location = new Point(0, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(260, 30);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Email";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(10, 10, 10);
            Header.Controls.Add(LogoLabel);
            Header.Controls.Add(Logo);
            Header.Controls.Add(MinimalizeButton);
            Header.Controls.Add(ExitButton);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(3, 2, 3, 2);
            Header.Name = "Header";
            Header.Size = new Size(380, 60);
            Header.TabIndex = 3;
            // 
            // LogoLabel
            // 
            LogoLabel.AccessibleRole = AccessibleRole.None;
            LogoLabel.CausesValidation = false;
            LogoLabel.Dock = DockStyle.Left;
            LogoLabel.FlatStyle = FlatStyle.Flat;
            LogoLabel.Font = new Font("OCR A Extended", 16F, FontStyle.Bold);
            LogoLabel.ForeColor = Color.Gainsboro;
            LogoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LogoLabel.Location = new Point(70, 0);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(208, 60);
            LogoLabel.TabIndex = 6;
            LogoLabel.Text = "HashWarden";
            LogoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Left;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.ImageLocation = "";
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(70, 60);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // MinimalizeButton
            // 
            MinimalizeButton.BackColor = Color.FromArgb(10, 10, 10);
            MinimalizeButton.Dock = DockStyle.Right;
            MinimalizeButton.FlatAppearance.BorderSize = 0;
            MinimalizeButton.FlatStyle = FlatStyle.Flat;
            MinimalizeButton.ForeColor = Color.Gainsboro;
            MinimalizeButton.ImageIndex = 0;
            MinimalizeButton.ImageList = HeaderImages;
            MinimalizeButton.Location = new Point(284, 0);
            MinimalizeButton.Margin = new Padding(3, 2, 3, 2);
            MinimalizeButton.Name = "MinimalizeButton";
            MinimalizeButton.Size = new Size(48, 60);
            MinimalizeButton.TabIndex = 2;
            MinimalizeButton.UseVisualStyleBackColor = false;
            MinimalizeButton.Click += MinimalizeButton_Click;
            // 
            // HeaderImages
            // 
            HeaderImages.ColorDepth = ColorDepth.Depth32Bit;
            HeaderImages.ImageStream = (ImageListStreamer)resources.GetObject("HeaderImages.ImageStream");
            HeaderImages.TransparentColor = Color.Transparent;
            HeaderImages.Images.SetKeyName(0, "minimizeIcon.png");
            HeaderImages.Images.SetKeyName(1, "maximizeIcon.png");
            HeaderImages.Images.SetKeyName(2, "closeIcon.png");
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(10, 10, 10);
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ImageIndex = 2;
            ExitButton.ImageList = HeaderImages;
            ExitButton.Location = new Point(332, 0);
            ExitButton.Margin = new Padding(3, 2, 3, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(48, 60);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogoImage
            // 
            LogoImage.ColorDepth = ColorDepth.Depth32Bit;
            LogoImage.ImageStream = (ImageListStreamer)resources.GetObject("LogoImage.ImageStream");
            LogoImage.TransparentColor = Color.Transparent;
            LogoImage.Images.SetKeyName(0, "Logo.png");
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 496);
            ControlBox = false;
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(396, 535);
            MinimumSize = new Size(396, 535);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Header;
        private Button MinimalizeButton;
        private Button ExitButton;
        private ImageList HeaderImages;
        private ImageList LogoImage;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label UsernameLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TextBox EmailInput;
        private Button LoginButton;
        private Button RegisterFormButton;
        private Label label1;
        private Label label2;
        private Label LogoLabel;
        private PictureBox Logo;
    }
}