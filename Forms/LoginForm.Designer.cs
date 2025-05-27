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
            LayoutPanel = new TableLayoutPanel();
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
            LayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(LayoutPanel);
            panel1.Controls.Add(Header);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 700);
            panel1.TabIndex = 0;
            // 
            // LayoutPanel
            // 
            LayoutPanel.ColumnCount = 3;
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            LayoutPanel.Controls.Add(panel2, 1, 1);
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LayoutPanel.Location = new Point(0, 80);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.RowCount = 3;
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 78F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            LayoutPanel.Size = new Size(450, 620);
            LayoutPanel.TabIndex = 4;
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
            panel2.Location = new Point(70, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 477);
            panel2.TabIndex = 0;
            // 
            // RegisterFormButton
            // 
            RegisterFormButton.AutoEllipsis = true;
            RegisterFormButton.BackColor = Color.FromArgb(40, 40, 40);
            RegisterFormButton.Dock = DockStyle.Top;
            RegisterFormButton.FlatAppearance.BorderSize = 0;
            RegisterFormButton.FlatStyle = FlatStyle.Popup;
            RegisterFormButton.ForeColor = Color.Gainsboro;
            RegisterFormButton.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterFormButton.ImageIndex = 2;
            RegisterFormButton.Location = new Point(0, 359);
            RegisterFormButton.Name = "RegisterFormButton";
            RegisterFormButton.Padding = new Padding(10, 0, 0, 5);
            RegisterFormButton.Size = new Size(309, 51);
            RegisterFormButton.TabIndex = 3;
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
            label1.Location = new Point(0, 239);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 11);
            label1.Size = new Size(309, 120);
            label1.TabIndex = 0;
            label1.Text = "Nie masz konta?";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LoginButton
            // 
            LoginButton.AutoEllipsis = true;
            LoginButton.BackColor = Color.FromArgb(40, 40, 40);
            LoginButton.Dock = DockStyle.Top;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.ForeColor = Color.Gainsboro;
            LoginButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginButton.ImageIndex = 2;
            LoginButton.Location = new Point(0, 188);
            LoginButton.Name = "LoginButton";
            LoginButton.Padding = new Padding(10, 0, 0, 5);
            LoginButton.Size = new Size(309, 51);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Zaloguj";
            LoginButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 148);
            label2.Name = "label2";
            label2.Size = new Size(309, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Dock = DockStyle.Top;
            PasswordInput.Font = new Font("Segoe UI", 12F);
            PasswordInput.ImeMode = ImeMode.NoControl;
            PasswordInput.Location = new Point(0, 114);
            PasswordInput.MaxLength = 40;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Hasło";
            PasswordInput.Size = new Size(309, 34);
            PasswordInput.TabIndex = 1;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Dock = DockStyle.Top;
            PasswordLabel.Font = new Font("Segoe UI", 12F);
            PasswordLabel.ForeColor = Color.Gainsboro;
            PasswordLabel.Location = new Point(0, 74);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(309, 40);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Hasło";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailInput
            // 
            EmailInput.Dock = DockStyle.Top;
            EmailInput.Font = new Font("Segoe UI", 12F);
            EmailInput.ImeMode = ImeMode.NoControl;
            EmailInput.Location = new Point(0, 40);
            EmailInput.MaxLength = 40;
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = "nazwa@email.com";
            EmailInput.Size = new Size(309, 34);
            EmailInput.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Dock = DockStyle.Top;
            UsernameLabel.Font = new Font("Segoe UI", 12F);
            UsernameLabel.ForeColor = Color.Gainsboro;
            UsernameLabel.Location = new Point(0, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(309, 40);
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
            Header.Name = "Header";
            Header.Size = new Size(450, 80);
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
            LogoLabel.Location = new Point(80, 0);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(254, 80);
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
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(80, 80);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // MinimalizeButton
            // 
            MinimalizeButton.BackColor = Color.FromArgb(10, 10, 10);
            MinimalizeButton.Dock = DockStyle.Right;
            MinimalizeButton.FlatAppearance.BorderSize = 0;
            MinimalizeButton.FlatStyle = FlatStyle.Popup;
            MinimalizeButton.ForeColor = Color.Gainsboro;
            MinimalizeButton.ImageIndex = 0;
            MinimalizeButton.ImageList = HeaderImages;
            MinimalizeButton.Location = new Point(340, 0);
            MinimalizeButton.Name = "MinimalizeButton";
            MinimalizeButton.Size = new Size(55, 80);
            MinimalizeButton.TabIndex = 0;
            MinimalizeButton.TabStop = false;
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
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.ImageIndex = 2;
            ExitButton.ImageList = HeaderImages;
            ExitButton.Location = new Point(395, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 80);
            ExitButton.TabIndex = 0;
            ExitButton.TabStop = false;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 700);
            MinimumSize = new Size(450, 700);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            LayoutPanel.ResumeLayout(false);
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
        private TableLayoutPanel LayoutPanel;
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