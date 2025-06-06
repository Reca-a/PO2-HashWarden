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
            TableLayoutPanel = new TableLayoutPanel();
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
            LogoImage = new ImageList(components);
            panel1.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(TableLayoutPanel);
            panel1.Controls.Add(Header);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 651);
            panel1.TabIndex = 0;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TableLayoutPanel.Controls.Add(panel2, 1, 1);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 80);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.791209F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82.41758F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.791209F));
            TableLayoutPanel.Size = new Size(432, 571);
            TableLayoutPanel.TabIndex = 4;
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
            panel2.Location = new Point(67, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 464);
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
            LoginFormButton.Size = new Size(296, 51);
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
            label1.Size = new Size(296, 80);
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
            RegisterButton.Size = new Size(296, 51);
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
            label2.Size = new Size(296, 40);
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
            PasswordRepeatInput.PlaceholderText = "Powtórz hasło";
            PasswordRepeatInput.Size = new Size(296, 34);
            PasswordRepeatInput.TabIndex = 2;
            PasswordRepeatInput.UseSystemPasswordChar = true;
            PasswordRepeatInput.KeyDown += Input_KeyDown;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(0, 148);
            label3.Name = "label3";
            label3.Size = new Size(296, 40);
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
            PasswordInput.PlaceholderText = "Hasło";
            PasswordInput.Size = new Size(296, 34);
            PasswordInput.TabIndex = 1;
            PasswordInput.UseSystemPasswordChar = true;
            PasswordInput.KeyDown += Input_KeyDown;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Dock = DockStyle.Top;
            PasswordLabel.Font = new Font("Segoe UI", 12F);
            PasswordLabel.ForeColor = Color.Gainsboro;
            PasswordLabel.Location = new Point(0, 74);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(296, 40);
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
            EmailInput.PlaceholderText = "nazwa@email.com";
            EmailInput.Size = new Size(296, 34);
            EmailInput.TabIndex = 0;
            EmailInput.KeyDown += Input_KeyDown;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Dock = DockStyle.Top;
            UsernameLabel.Font = new Font("Segoe UI", 12F);
            UsernameLabel.ForeColor = Color.Gainsboro;
            UsernameLabel.Location = new Point(0, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(296, 40);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Email";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(10, 10, 10);
            Header.Controls.Add(LogoLabel);
            Header.Controls.Add(Logo);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(432, 80);
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 698);
            MinimizeBox = false;
            MinimumSize = new Size(450, 698);
            Name = "RegisterForm";
            Text = "Rejestracja";
            panel1.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
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
        private TableLayoutPanel TableLayoutPanel;
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