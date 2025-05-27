namespace HashWarden
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            LoginFormButton = new Button();
            label1 = new Label();
            RegisterButton = new Button();
            label2 = new Label();
            PasswordRepeatInput = new TextBox();
            label3 = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 698);
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
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.791209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.41758F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.791209F));
            tableLayoutPanel1.Size = new Size(450, 618);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(LoginFormButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RegisterButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PasswordRepeatInput);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PasswordInput);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(EmailInput);
            panel2.Controls.Add(UsernameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(70, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 503);
            panel2.TabIndex = 0;
            // 
            // LoginFormButton
            // 
            LoginFormButton.AutoEllipsis = true;
            LoginFormButton.BackColor = Color.FromArgb(40, 40, 40);
            LoginFormButton.Dock = DockStyle.Top;
            LoginFormButton.FlatAppearance.BorderSize = 0;
            LoginFormButton.FlatStyle = FlatStyle.Popup;
            LoginFormButton.ForeColor = Color.Gainsboro;
            LoginFormButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginFormButton.ImageIndex = 2;
            LoginFormButton.Location = new Point(0, 393);
            LoginFormButton.Name = "LoginFormButton";
            LoginFormButton.Padding = new Padding(10, 0, 0, 5);
            LoginFormButton.Size = new Size(309, 51);
            LoginFormButton.TabIndex = 4;
            LoginFormButton.Text = "Zaloguj się";
            LoginFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginFormButton.UseVisualStyleBackColor = false;
            LoginFormButton.Click += LoginFormButton_click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(0, 313);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 11);
            label1.Size = new Size(309, 80);
            label1.TabIndex = 6;
            label1.Text = "Masz już konto?";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoEllipsis = true;
            RegisterButton.BackColor = Color.FromArgb(40, 40, 40);
            RegisterButton.Dock = DockStyle.Top;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.ForeColor = Color.Gainsboro;
            RegisterButton.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterButton.ImageIndex = 2;
            RegisterButton.Location = new Point(0, 262);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Padding = new Padding(10, 0, 0, 5);
            RegisterButton.Size = new Size(309, 51);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Zarejestruj";
            RegisterButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 222);
            label2.Name = "label2";
            label2.Size = new Size(309, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordRepeatInput
            // 
            PasswordRepeatInput.Dock = DockStyle.Top;
            PasswordRepeatInput.Font = new Font("Segoe UI", 12F);
            PasswordRepeatInput.ImeMode = ImeMode.NoControl;
            PasswordRepeatInput.Location = new Point(0, 188);
            PasswordRepeatInput.Name = "PasswordRepeatInput";
            PasswordRepeatInput.Size = new Size(309, 34);
            PasswordRepeatInput.TabIndex = 2;
            PasswordRepeatInput.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(0, 148);
            label3.Name = "label3";
            label3.Size = new Size(309, 40);
            label3.TabIndex = 9;
            label3.Text = "Powtórz hasło";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Dock = DockStyle.Top;
            PasswordInput.Font = new Font("Segoe UI", 12F);
            PasswordInput.ImeMode = ImeMode.NoControl;
            PasswordInput.Location = new Point(0, 114);
            PasswordInput.Name = "PasswordInput";
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
            EmailInput.Name = "EmailInput";
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
            LogoLabel.Size = new Size(238, 80);
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
            MinimalizeButton.TabIndex = 2;
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
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 651);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(450, 698);
            MinimumSize = new Size(450, 698);
            Name = "RegisterForm";
            Text = "RegisterForm";
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
        private Button RegisterButton;
        private Button LoginFormButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LogoLabel;
        private PictureBox Logo;
        private TextBox PasswordRepeatInput;
    }
}