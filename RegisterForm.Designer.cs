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
            button1 = new Button();
            label1 = new Label();
            LogoutButton = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            PasswordLabel = new Label();
            textBox1 = new TextBox();
            UsernameLabel = new Label();
            Header = new Panel();
            Logo = new Button();
            LogoImage = new ImageList(components);
            MinimalizeButton = new Button();
            HeaderImages = new ImageList(components);
            ExitButton = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            Header.SuspendLayout();
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
            panel1.Size = new Size(432, 653);
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
            tableLayoutPanel1.Location = new Point(0, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(432, 588);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LogoutButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(UsernameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(67, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 435);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 2;
            button1.Location = new Point(0, 371);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 5);
            button1.Size = new Size(296, 50);
            button1.TabIndex = 7;
            button1.Text = "Zaloguj się";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(0, 291);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 10);
            label1.Size = new Size(296, 80);
            label1.TabIndex = 6;
            label1.Text = "Masz już konto?";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LogoutButton
            // 
            LogoutButton.AutoEllipsis = true;
            LogoutButton.BackColor = Color.FromArgb(40, 40, 40);
            LogoutButton.Dock = DockStyle.Top;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.Gainsboro;
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.ImageIndex = 2;
            LogoutButton.Location = new Point(0, 241);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Padding = new Padding(10, 0, 0, 5);
            LogoutButton.Size = new Size(296, 50);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Zarejestruj";
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 201);
            label2.Name = "label2";
            label2.Size = new Size(296, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(0, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 27);
            textBox2.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Dock = DockStyle.Top;
            PasswordLabel.Font = new Font("Segoe UI", 12F);
            PasswordLabel.ForeColor = Color.Gainsboro;
            PasswordLabel.Location = new Point(0, 67);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(296, 40);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Hasło";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(0, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 1;
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
            Header.Controls.Add(Logo);
            Header.Controls.Add(MinimalizeButton);
            Header.Controls.Add(ExitButton);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(432, 65);
            Header.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(10, 10, 10);
            Logo.Dock = DockStyle.Left;
            Logo.FlatAppearance.BorderSize = 0;
            Logo.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            Logo.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
            Logo.FlatStyle = FlatStyle.Flat;
            Logo.Font = new Font("OCR A Extended", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logo.ForeColor = Color.Gainsboro;
            Logo.ImageAlign = ContentAlignment.TopLeft;
            Logo.ImageIndex = 0;
            Logo.ImageList = LogoImage;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(258, 65);
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            Logo.Text = "HashWarden";
            Logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            Logo.UseVisualStyleBackColor = false;
            // 
            // LogoImage
            // 
            LogoImage.ColorDepth = ColorDepth.Depth32Bit;
            LogoImage.ImageStream = (ImageListStreamer)resources.GetObject("LogoImage.ImageStream");
            LogoImage.TransparentColor = Color.Transparent;
            LogoImage.Images.SetKeyName(0, "Logo.png");
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
            MinimalizeButton.Location = new Point(322, 0);
            MinimalizeButton.Name = "MinimalizeButton";
            MinimalizeButton.Size = new Size(55, 65);
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
            ExitButton.Location = new Point(377, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 65);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Top;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ImeMode = ImeMode.NoControl;
            textBox3.Location = new Point(0, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 27);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(0, 134);
            label3.Name = "label3";
            label3.Size = new Size(296, 40);
            label3.TabIndex = 9;
            label3.Text = "Powtórz hasło";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 653);
            ControlBox = false;
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(450, 700);
            MinimumSize = new Size(450, 700);
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Header;
        private Button Logo;
        private Button MinimalizeButton;
        private Button ExitButton;
        private ImageList HeaderImages;
        private ImageList LogoImage;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label UsernameLabel;
        private TextBox textBox2;
        private Label PasswordLabel;
        private TextBox textBox1;
        private Button LogoutButton;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}