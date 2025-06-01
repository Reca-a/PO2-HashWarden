namespace HashWarden.Forms.Dialogs
{
    partial class AddPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPasswordForm));
            LayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            AddButton = new Button();
            label2 = new Label();
            FolderPicker = new ComboBox();
            DescLabel5 = new Label();
            ServiceUrlInput = new TextBox();
            DescLabel4 = new Label();
            PasswordContainer = new TableLayoutPanel();
            PasswordInput = new TextBox();
            ViewPassButton = new Button();
            Icons = new ImageList(components);
            DescLabel3 = new Label();
            UsernameInput = new TextBox();
            DescLabel2 = new Label();
            TitleInput = new TextBox();
            DescLabel1 = new Label();
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            HeaderImages = new ImageList(components);
            LayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            PasswordContainer.SuspendLayout();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.BackColor = Color.FromArgb(15, 15, 15);
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
            LayoutPanel.Size = new Size(432, 623);
            LayoutPanel.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(FolderPicker);
            panel2.Controls.Add(DescLabel5);
            panel2.Controls.Add(ServiceUrlInput);
            panel2.Controls.Add(DescLabel4);
            panel2.Controls.Add(PasswordContainer);
            panel2.Controls.Add(DescLabel3);
            panel2.Controls.Add(UsernameInput);
            panel2.Controls.Add(DescLabel2);
            panel2.Controls.Add(TitleInput);
            panel2.Controls.Add(DescLabel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(67, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 479);
            panel2.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.AutoEllipsis = true;
            AddButton.BackColor = Color.FromArgb(40, 40, 40);
            AddButton.Dock = DockStyle.Top;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.ForeColor = Color.Gainsboro;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.ImageIndex = 2;
            AddButton.Location = new Point(0, 425);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(10, 0, 0, 5);
            AddButton.Size = new Size(296, 51);
            AddButton.TabIndex = 7;
            AddButton.Text = "Dodaj";
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 385);
            label2.Name = "label2";
            label2.Size = new Size(296, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FolderPicker
            // 
            FolderPicker.AutoCompleteCustomSource.AddRange(new string[] { "test", "test", "testt", "test" });
            FolderPicker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FolderPicker.Dock = DockStyle.Top;
            FolderPicker.DropDownHeight = 120;
            FolderPicker.FormattingEnabled = true;
            FolderPicker.IntegralHeight = false;
            FolderPicker.Location = new Point(0, 357);
            FolderPicker.MaxDropDownItems = 6;
            FolderPicker.MaxLength = 50;
            FolderPicker.Name = "FolderPicker";
            FolderPicker.Size = new Size(296, 28);
            FolderPicker.Sorted = true;
            FolderPicker.TabIndex = 6;
            // 
            // DescLabel5
            // 
            DescLabel5.Dock = DockStyle.Top;
            DescLabel5.Font = new Font("Segoe UI", 12F);
            DescLabel5.ForeColor = Color.Gainsboro;
            DescLabel5.Location = new Point(0, 317);
            DescLabel5.Name = "DescLabel5";
            DescLabel5.Size = new Size(296, 40);
            DescLabel5.TabIndex = 16;
            DescLabel5.Text = "Folder";
            DescLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ServiceUrlInput
            // 
            ServiceUrlInput.Dock = DockStyle.Top;
            ServiceUrlInput.Font = new Font("Segoe UI", 12F);
            ServiceUrlInput.ImeMode = ImeMode.NoControl;
            ServiceUrlInput.Location = new Point(0, 283);
            ServiceUrlInput.MaxLength = 40;
            ServiceUrlInput.Name = "ServiceUrlInput";
            ServiceUrlInput.PlaceholderText = "www.adres.pl";
            ServiceUrlInput.Size = new Size(296, 34);
            ServiceUrlInput.TabIndex = 5;
            // 
            // DescLabel4
            // 
            DescLabel4.Dock = DockStyle.Top;
            DescLabel4.Font = new Font("Segoe UI", 12F);
            DescLabel4.ForeColor = Color.Gainsboro;
            DescLabel4.Location = new Point(0, 243);
            DescLabel4.Name = "DescLabel4";
            DescLabel4.Size = new Size(296, 40);
            DescLabel4.TabIndex = 14;
            DescLabel4.Text = "Strona";
            DescLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordContainer
            // 
            PasswordContainer.BackColor = Color.FromArgb(15, 15, 15);
            PasswordContainer.ColumnCount = 2;
            PasswordContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            PasswordContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PasswordContainer.Controls.Add(PasswordInput, 0, 0);
            PasswordContainer.Controls.Add(ViewPassButton, 1, 0);
            PasswordContainer.Dock = DockStyle.Top;
            PasswordContainer.Location = new Point(0, 188);
            PasswordContainer.Name = "PasswordContainer";
            PasswordContainer.Padding = new Padding(0, 10, 0, 10);
            PasswordContainer.RowCount = 1;
            PasswordContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PasswordContainer.Size = new Size(296, 55);
            PasswordContainer.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Dock = DockStyle.Fill;
            PasswordInput.Font = new Font("Segoe UI", 12F);
            PasswordInput.ImeMode = ImeMode.NoControl;
            PasswordInput.Location = new Point(0, 10);
            PasswordInput.Margin = new Padding(0);
            PasswordInput.MaxLength = 40;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Hasło";
            PasswordInput.Size = new Size(236, 34);
            PasswordInput.TabIndex = 3;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // ViewPassButton
            // 
            ViewPassButton.Dock = DockStyle.Left;
            ViewPassButton.FlatAppearance.BorderSize = 0;
            ViewPassButton.FlatStyle = FlatStyle.Flat;
            ViewPassButton.ImageIndex = 0;
            ViewPassButton.ImageList = Icons;
            ViewPassButton.Location = new Point(239, 13);
            ViewPassButton.Name = "ViewPassButton";
            ViewPassButton.Size = new Size(51, 29);
            ViewPassButton.TabIndex = 4;
            ViewPassButton.UseVisualStyleBackColor = true;
            ViewPassButton.Click += ViewPassButton_Click;
            // 
            // Icons
            // 
            Icons.ColorDepth = ColorDepth.Depth32Bit;
            Icons.ImageStream = (ImageListStreamer)resources.GetObject("Icons.ImageStream");
            Icons.TransparentColor = Color.Transparent;
            Icons.Images.SetKeyName(0, "viewPassFalse.png");
            Icons.Images.SetKeyName(1, "viewPassTrue.png");
            Icons.Images.SetKeyName(2, "edit.png");
            Icons.Images.SetKeyName(3, "trash.png");
            // 
            // DescLabel3
            // 
            DescLabel3.Dock = DockStyle.Top;
            DescLabel3.Font = new Font("Segoe UI", 12F);
            DescLabel3.ForeColor = Color.Gainsboro;
            DescLabel3.Location = new Point(0, 148);
            DescLabel3.Name = "DescLabel3";
            DescLabel3.Size = new Size(296, 40);
            DescLabel3.TabIndex = 12;
            DescLabel3.Text = "Hasło";
            DescLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameInput
            // 
            UsernameInput.Dock = DockStyle.Top;
            UsernameInput.Font = new Font("Segoe UI", 12F);
            UsernameInput.ImeMode = ImeMode.NoControl;
            UsernameInput.Location = new Point(0, 114);
            UsernameInput.MaxLength = 40;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.PlaceholderText = "Nazwa";
            UsernameInput.Size = new Size(296, 34);
            UsernameInput.TabIndex = 2;
            // 
            // DescLabel2
            // 
            DescLabel2.Dock = DockStyle.Top;
            DescLabel2.Font = new Font("Segoe UI", 12F);
            DescLabel2.ForeColor = Color.Gainsboro;
            DescLabel2.Location = new Point(0, 74);
            DescLabel2.Name = "DescLabel2";
            DescLabel2.Size = new Size(296, 40);
            DescLabel2.TabIndex = 10;
            DescLabel2.Text = "Nazwa użytkownika";
            DescLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitleInput
            // 
            TitleInput.Dock = DockStyle.Top;
            TitleInput.Font = new Font("Segoe UI", 12F);
            TitleInput.ImeMode = ImeMode.NoControl;
            TitleInput.Location = new Point(0, 40);
            TitleInput.MaxLength = 40;
            TitleInput.Name = "TitleInput";
            TitleInput.PlaceholderText = "Tytuł";
            TitleInput.Size = new Size(296, 34);
            TitleInput.TabIndex = 1;
            // 
            // DescLabel1
            // 
            DescLabel1.Dock = DockStyle.Top;
            DescLabel1.Font = new Font("Segoe UI", 12F);
            DescLabel1.ForeColor = Color.Gainsboro;
            DescLabel1.Location = new Point(0, 0);
            DescLabel1.Name = "DescLabel1";
            DescLabel1.Size = new Size(296, 40);
            DescLabel1.TabIndex = 0;
            DescLabel1.Text = "Tytuł wpisu";
            DescLabel1.TextAlign = ContentAlignment.MiddleLeft;
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
            Header.TabIndex = 7;
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
            LogoLabel.Size = new Size(309, 80);
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
            // HeaderImages
            // 
            HeaderImages.ColorDepth = ColorDepth.Depth32Bit;
            HeaderImages.ImageStream = (ImageListStreamer)resources.GetObject("HeaderImages.ImageStream");
            HeaderImages.TransparentColor = Color.Transparent;
            HeaderImages.Images.SetKeyName(0, "minimizeIcon.png");
            HeaderImages.Images.SetKeyName(1, "maximizeIcon.png");
            HeaderImages.Images.SetKeyName(2, "closeIcon.png");
            // 
            // AddPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 703);
            Controls.Add(LayoutPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 750);
            MinimizeBox = false;
            MinimumSize = new Size(450, 750);
            Name = "AddPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodawanie wpisu";
            LayoutPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PasswordContainer.ResumeLayout(false);
            PasswordContainer.PerformLayout();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LayoutPanel;
        private Panel panel2;
        private Button AddButton;
        private Label label2;
        private TextBox TitleInput;
        private Label DescLabel1;
        private Panel Header;
        private Label LogoLabel;
        private PictureBox Logo;
        private TextBox ServiceUrlInput;
        private Label DescLabel4;
        private TextBox PasswordInput;
        private Label DescLabel3;
        private TextBox UsernameInput;
        private Label DescLabel2;
        private ImageList HeaderImages;
        private ComboBox FolderPicker;
        private Label DescLabel5;
        private TableLayoutPanel PasswordContainer;
        private Button ViewPassButton;
        private ImageList Icons;
    }
}