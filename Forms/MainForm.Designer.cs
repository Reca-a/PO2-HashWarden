namespace HashWarden
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ContentPanel = new Panel();
            ContentDefaultLogo = new PictureBox();
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            HeaderImages = new ImageList(components);
            LogoImage = new ImageList(components);
            SidebarMenu = new Panel();
            FolderListPanel = new FlowLayoutPanel();
            AddFolderButton = new Button();
            FolderSearchPanel = new Panel();
            FolderSearchTextBox = new TextBox();
            FolderSearchButton = new Button();
            FolderClearSearchButton = new Button();
            FolderSortButton = new Button();
            FoldersLabel = new Label();
            AccountContainer = new SplitContainer();
            LogoutButton = new Button();
            SidebarMenuImages = new ImageList(components);
            SettingsButton = new Button();
            AllElementsButton = new Button();
            SidebarSubMenu = new Panel();
            PasswordListPanel = new FlowLayoutPanel();
            AddRecordButton = new Button();
            PasswordSearchPanel = new Panel();
            PasswordSearchTextBox = new TextBox();
            PasswordSearchButton = new Button();
            PasswordClearSearchButton = new Button();
            PasswordSortButton = new Button();
            SidebarPanel = new Panel();
            MarginPanel = new Panel();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContentDefaultLogo).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SidebarMenu.SuspendLayout();
            FolderSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountContainer).BeginInit();
            AccountContainer.Panel1.SuspendLayout();
            AccountContainer.Panel2.SuspendLayout();
            AccountContainer.SuspendLayout();
            SidebarSubMenu.SuspendLayout();
            PasswordSearchPanel.SuspendLayout();
            SidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.FromArgb(20, 20, 20);
            ContentPanel.BackgroundImageLayout = ImageLayout.Center;
            ContentPanel.Controls.Add(ContentDefaultLogo);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(505, 68);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(474, 719);
            ContentPanel.TabIndex = 1;
            // 
            // ContentDefaultLogo
            // 
            ContentDefaultLogo.Anchor = AnchorStyles.None;
            ContentDefaultLogo.Image = (Image)resources.GetObject("ContentDefaultLogo.Image");
            ContentDefaultLogo.Location = new Point(31, 264);
            ContentDefaultLogo.Name = "ContentDefaultLogo";
            ContentDefaultLogo.Size = new Size(418, 165);
            ContentDefaultLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ContentDefaultLogo.TabIndex = 1;
            ContentDefaultLogo.TabStop = false;
            // 
            // Header
            // 
            Header.Controls.Add(LogoLabel);
            Header.Controls.Add(Logo);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(3, 3);
            Header.Name = "Header";
            Header.Size = new Size(976, 65);
            Header.TabIndex = 2;
            // 
            // LogoLabel
            // 
            LogoLabel.AccessibleRole = AccessibleRole.None;
            LogoLabel.CausesValidation = false;
            LogoLabel.Dock = DockStyle.Left;
            LogoLabel.FlatStyle = FlatStyle.Flat;
            LogoLabel.Font = new Font("OCR A Extended", 16F, FontStyle.Bold);
            LogoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LogoLabel.Location = new Point(70, 0);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(228, 65);
            LogoLabel.TabIndex = 4;
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
            Logo.Size = new Size(70, 65);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 5;
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
            // LogoImage
            // 
            LogoImage.ColorDepth = ColorDepth.Depth32Bit;
            LogoImage.ImageStream = (ImageListStreamer)resources.GetObject("LogoImage.ImageStream");
            LogoImage.TransparentColor = Color.Transparent;
            LogoImage.Images.SetKeyName(0, "Logo.png");
            // 
            // SidebarMenu
            // 
            SidebarMenu.BackColor = Color.FromArgb(25, 25, 25);
            SidebarMenu.Controls.Add(FolderListPanel);
            SidebarMenu.Controls.Add(AddFolderButton);
            SidebarMenu.Controls.Add(FolderSearchPanel);
            SidebarMenu.Controls.Add(FoldersLabel);
            SidebarMenu.Controls.Add(AccountContainer);
            SidebarMenu.Controls.Add(AllElementsButton);
            SidebarMenu.Dock = DockStyle.Left;
            SidebarMenu.Location = new Point(0, 0);
            SidebarMenu.Name = "SidebarMenu";
            SidebarMenu.Size = new Size(230, 719);
            SidebarMenu.TabIndex = 3;
            // 
            // FolderListPanel
            // 
            FolderListPanel.AutoScroll = true;
            FolderListPanel.Dock = DockStyle.Fill;
            FolderListPanel.FlowDirection = FlowDirection.TopDown;
            FolderListPanel.Location = new Point(0, 128);
            FolderListPanel.Name = "FolderListPanel";
            FolderListPanel.Size = new Size(230, 501);
            FolderListPanel.TabIndex = 3;
            FolderListPanel.TabStop = true;
            FolderListPanel.WrapContents = false;
            // 
            // AddFolderButton
            // 
            AddFolderButton.Dock = DockStyle.Bottom;
            AddFolderButton.FlatStyle = FlatStyle.Popup;
            AddFolderButton.Font = new Font("Microsoft Sans Serif", 17F);
            AddFolderButton.Location = new Point(0, 629);
            AddFolderButton.Name = "AddFolderButton";
            AddFolderButton.Size = new Size(230, 40);
            AddFolderButton.TabIndex = 4;
            AddFolderButton.Text = "+";
            AddFolderButton.UseVisualStyleBackColor = true;
            AddFolderButton.Click += AddFolderButton_Click;
            // 
            // FolderSearchPanel
            // 
            FolderSearchPanel.Controls.Add(FolderSearchTextBox);
            FolderSearchPanel.Controls.Add(FolderSearchButton);
            FolderSearchPanel.Controls.Add(FolderClearSearchButton);
            FolderSearchPanel.Controls.Add(FolderSortButton);
            FolderSearchPanel.Dock = DockStyle.Top;
            FolderSearchPanel.Location = new Point(0, 100);
            FolderSearchPanel.Margin = new Padding(0);
            FolderSearchPanel.Name = "FolderSearchPanel";
            FolderSearchPanel.Size = new Size(230, 28);
            FolderSearchPanel.TabIndex = 2;
            // 
            // FolderSearchTextBox
            // 
            FolderSearchTextBox.BackColor = Color.FromArgb(40, 40, 40);
            FolderSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            FolderSearchTextBox.Dock = DockStyle.Fill;
            FolderSearchTextBox.Font = new Font("Microsoft Sans Serif", 11F);
            FolderSearchTextBox.ForeColor = Color.Gainsboro;
            FolderSearchTextBox.Location = new Point(0, 0);
            FolderSearchTextBox.Margin = new Padding(0);
            FolderSearchTextBox.MaxLength = 50;
            FolderSearchTextBox.Name = "FolderSearchTextBox";
            FolderSearchTextBox.PlaceholderText = "Szukaj folderu...";
            FolderSearchTextBox.Size = new Size(149, 28);
            FolderSearchTextBox.TabIndex = 0;
            FolderSearchTextBox.KeyDown += FolderSearchTextBox_KeyDown;
            // 
            // FolderSearchButton
            // 
            FolderSearchButton.BackColor = Color.FromArgb(40, 40, 40);
            FolderSearchButton.Dock = DockStyle.Right;
            FolderSearchButton.FlatAppearance.BorderSize = 0;
            FolderSearchButton.FlatStyle = FlatStyle.Popup;
            FolderSearchButton.Location = new Point(149, 0);
            FolderSearchButton.Name = "FolderSearchButton";
            FolderSearchButton.Size = new Size(30, 28);
            FolderSearchButton.TabIndex = 1;
            FolderSearchButton.Text = "🔍";
            FolderSearchButton.UseVisualStyleBackColor = false;
            FolderSearchButton.Click += FolderSearchButton_Click;
            // 
            // FolderClearSearchButton
            // 
            FolderClearSearchButton.BackColor = Color.FromArgb(40, 40, 40);
            FolderClearSearchButton.Dock = DockStyle.Right;
            FolderClearSearchButton.FlatAppearance.BorderSize = 0;
            FolderClearSearchButton.FlatStyle = FlatStyle.Popup;
            FolderClearSearchButton.Location = new Point(179, 0);
            FolderClearSearchButton.Name = "FolderClearSearchButton";
            FolderClearSearchButton.Size = new Size(26, 28);
            FolderClearSearchButton.TabIndex = 2;
            FolderClearSearchButton.Text = "✕";
            FolderClearSearchButton.UseVisualStyleBackColor = false;
            FolderClearSearchButton.Click += FolderClearSearchButton_Click;
            // 
            // FolderSortButton
            // 
            FolderSortButton.BackColor = Color.FromArgb(40, 40, 40);
            FolderSortButton.Dock = DockStyle.Right;
            FolderSortButton.FlatAppearance.BorderSize = 0;
            FolderSortButton.FlatStyle = FlatStyle.Popup;
            FolderSortButton.Location = new Point(205, 0);
            FolderSortButton.Name = "FolderSortButton";
            FolderSortButton.Size = new Size(25, 28);
            FolderSortButton.TabIndex = 3;
            FolderSortButton.Text = "↕";
            FolderSortButton.UseVisualStyleBackColor = false;
            FolderSortButton.Click += FolderSortButton_Click;
            // 
            // FoldersLabel
            // 
            FoldersLabel.BackColor = Color.FromArgb(10, 10, 10);
            FoldersLabel.Dock = DockStyle.Top;
            FoldersLabel.Font = new Font("Microsoft Sans Serif", 14F);
            FoldersLabel.Location = new Point(0, 60);
            FoldersLabel.Name = "FoldersLabel";
            FoldersLabel.Size = new Size(230, 40);
            FoldersLabel.TabIndex = 4;
            FoldersLabel.Text = "Foldery";
            FoldersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountContainer
            // 
            AccountContainer.Dock = DockStyle.Bottom;
            AccountContainer.IsSplitterFixed = true;
            AccountContainer.Location = new Point(0, 669);
            AccountContainer.Name = "AccountContainer";
            // 
            // AccountContainer.Panel1
            // 
            AccountContainer.Panel1.Controls.Add(LogoutButton);
            // 
            // AccountContainer.Panel2
            // 
            AccountContainer.Panel2.Controls.Add(SettingsButton);
            AccountContainer.Size = new Size(230, 50);
            AccountContainer.SplitterDistance = 108;
            AccountContainer.SplitterWidth = 1;
            AccountContainer.TabIndex = 4;
            AccountContainer.TabStop = false;
            // 
            // LogoutButton
            // 
            LogoutButton.AutoEllipsis = true;
            LogoutButton.BackColor = Color.FromArgb(40, 40, 40);
            LogoutButton.Dock = DockStyle.Fill;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Popup;
            LogoutButton.ImageIndex = 2;
            LogoutButton.ImageList = SidebarMenuImages;
            LogoutButton.Location = new Point(0, 0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(108, 50);
            LogoutButton.TabIndex = 5;
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // SidebarMenuImages
            // 
            SidebarMenuImages.ColorDepth = ColorDepth.Depth32Bit;
            SidebarMenuImages.ImageStream = (ImageListStreamer)resources.GetObject("SidebarMenuImages.ImageStream");
            SidebarMenuImages.TransparentColor = Color.Transparent;
            SidebarMenuImages.Images.SetKeyName(0, "allElementsIcon.png");
            SidebarMenuImages.Images.SetKeyName(1, "foldersIcon.png");
            SidebarMenuImages.Images.SetKeyName(2, "signOutIcon.png");
            SidebarMenuImages.Images.SetKeyName(3, "optionsIcon.png");
            // 
            // SettingsButton
            // 
            SettingsButton.AutoEllipsis = true;
            SettingsButton.BackColor = Color.FromArgb(40, 40, 40);
            SettingsButton.Dock = DockStyle.Fill;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Popup;
            SettingsButton.ImageIndex = 3;
            SettingsButton.ImageList = SidebarMenuImages;
            SettingsButton.Location = new Point(0, 0);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(121, 50);
            SettingsButton.TabIndex = 6;
            SettingsButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // AllElementsButton
            // 
            AllElementsButton.AutoEllipsis = true;
            AllElementsButton.BackColor = Color.FromArgb(40, 40, 40);
            AllElementsButton.Dock = DockStyle.Top;
            AllElementsButton.FlatAppearance.BorderSize = 0;
            AllElementsButton.FlatStyle = FlatStyle.Popup;
            AllElementsButton.ImageAlign = ContentAlignment.MiddleLeft;
            AllElementsButton.ImageIndex = 0;
            AllElementsButton.ImageList = SidebarMenuImages;
            AllElementsButton.Location = new Point(0, 0);
            AllElementsButton.Name = "AllElementsButton";
            AllElementsButton.Padding = new Padding(10, 0, 0, 10);
            AllElementsButton.Size = new Size(230, 60);
            AllElementsButton.TabIndex = 1;
            AllElementsButton.Text = "   Wszystkie elementy";
            AllElementsButton.TextAlign = ContentAlignment.MiddleLeft;
            AllElementsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AllElementsButton.UseVisualStyleBackColor = false;
            AllElementsButton.Click += AllElementsButton_Click;
            // 
            // SidebarSubMenu
            // 
            SidebarSubMenu.BackColor = Color.FromArgb(15, 15, 15);
            SidebarSubMenu.Controls.Add(PasswordListPanel);
            SidebarSubMenu.Controls.Add(AddRecordButton);
            SidebarSubMenu.Controls.Add(PasswordSearchPanel);
            SidebarSubMenu.Dock = DockStyle.Right;
            SidebarSubMenu.Location = new Point(232, 0);
            SidebarSubMenu.Name = "SidebarSubMenu";
            SidebarSubMenu.Size = new Size(270, 719);
            SidebarSubMenu.TabIndex = 4;
            // 
            // PasswordListPanel
            // 
            PasswordListPanel.AutoScroll = true;
            PasswordListPanel.Dock = DockStyle.Fill;
            PasswordListPanel.Location = new Point(0, 28);
            PasswordListPanel.Name = "PasswordListPanel";
            PasswordListPanel.Size = new Size(270, 641);
            PasswordListPanel.TabIndex = 8;
            // 
            // AddRecordButton
            // 
            AddRecordButton.BackColor = Color.FromArgb(25, 25, 25);
            AddRecordButton.Dock = DockStyle.Bottom;
            AddRecordButton.FlatAppearance.BorderSize = 0;
            AddRecordButton.FlatStyle = FlatStyle.Popup;
            AddRecordButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddRecordButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddRecordButton.ImageIndex = 2;
            AddRecordButton.Location = new Point(0, 669);
            AddRecordButton.Name = "AddRecordButton";
            AddRecordButton.Size = new Size(270, 50);
            AddRecordButton.TabIndex = 9;
            AddRecordButton.Text = "+";
            AddRecordButton.UseVisualStyleBackColor = true;
            AddRecordButton.Click += AddRecordButton_Click;
            // 
            // PasswordSearchPanel
            // 
            PasswordSearchPanel.Controls.Add(PasswordSearchTextBox);
            PasswordSearchPanel.Controls.Add(PasswordSearchButton);
            PasswordSearchPanel.Controls.Add(PasswordClearSearchButton);
            PasswordSearchPanel.Controls.Add(PasswordSortButton);
            PasswordSearchPanel.Dock = DockStyle.Top;
            PasswordSearchPanel.Location = new Point(0, 0);
            PasswordSearchPanel.Margin = new Padding(0);
            PasswordSearchPanel.Name = "PasswordSearchPanel";
            PasswordSearchPanel.Size = new Size(270, 28);
            PasswordSearchPanel.TabIndex = 7;
            // 
            // PasswordSearchTextBox
            // 
            PasswordSearchTextBox.BackColor = Color.FromArgb(40, 40, 40);
            PasswordSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordSearchTextBox.Dock = DockStyle.Fill;
            PasswordSearchTextBox.Font = new Font("Microsoft Sans Serif", 11F);
            PasswordSearchTextBox.ForeColor = Color.Gainsboro;
            PasswordSearchTextBox.Location = new Point(0, 0);
            PasswordSearchTextBox.Margin = new Padding(0);
            PasswordSearchTextBox.MaxLength = 50;
            PasswordSearchTextBox.Name = "PasswordSearchTextBox";
            PasswordSearchTextBox.PlaceholderText = "Szukaj wpisu...";
            PasswordSearchTextBox.Size = new Size(189, 28);
            PasswordSearchTextBox.TabIndex = 0;
            PasswordSearchTextBox.KeyDown += PasswordSearchTextBox_KeyDown;
            // 
            // PasswordSearchButton
            // 
            PasswordSearchButton.BackColor = Color.FromArgb(40, 40, 40);
            PasswordSearchButton.Dock = DockStyle.Right;
            PasswordSearchButton.FlatAppearance.BorderSize = 0;
            PasswordSearchButton.FlatStyle = FlatStyle.Popup;
            PasswordSearchButton.Location = new Point(189, 0);
            PasswordSearchButton.Name = "PasswordSearchButton";
            PasswordSearchButton.Size = new Size(30, 28);
            PasswordSearchButton.TabIndex = 1;
            PasswordSearchButton.Text = "🔍";
            PasswordSearchButton.UseVisualStyleBackColor = false;
            PasswordSearchButton.Click += PasswordSearchButton_Click;
            // 
            // PasswordClearSearchButton
            // 
            PasswordClearSearchButton.BackColor = Color.FromArgb(40, 40, 40);
            PasswordClearSearchButton.Dock = DockStyle.Right;
            PasswordClearSearchButton.FlatAppearance.BorderSize = 0;
            PasswordClearSearchButton.FlatStyle = FlatStyle.Popup;
            PasswordClearSearchButton.Location = new Point(219, 0);
            PasswordClearSearchButton.Name = "PasswordClearSearchButton";
            PasswordClearSearchButton.Size = new Size(26, 28);
            PasswordClearSearchButton.TabIndex = 2;
            PasswordClearSearchButton.Text = "✕";
            PasswordClearSearchButton.UseVisualStyleBackColor = false;
            PasswordClearSearchButton.Click += PasswordClearSearchButton_Click;
            // 
            // PasswordSortButton
            // 
            PasswordSortButton.BackColor = Color.FromArgb(40, 40, 40);
            PasswordSortButton.Dock = DockStyle.Right;
            PasswordSortButton.FlatAppearance.BorderSize = 0;
            PasswordSortButton.FlatStyle = FlatStyle.Popup;
            PasswordSortButton.Location = new Point(245, 0);
            PasswordSortButton.Name = "PasswordSortButton";
            PasswordSortButton.Size = new Size(25, 28);
            PasswordSortButton.TabIndex = 3;
            PasswordSortButton.Text = "↕";
            PasswordSortButton.UseVisualStyleBackColor = false;
            PasswordSortButton.Click += PasswordSortButton_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(SidebarSubMenu);
            SidebarPanel.Controls.Add(SidebarMenu);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(3, 68);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(502, 719);
            SidebarPanel.TabIndex = 2;
            // 
            // MarginPanel
            // 
            MarginPanel.BackColor = Color.FromArgb(10, 10, 10);
            MarginPanel.Dock = DockStyle.Bottom;
            MarginPanel.Location = new Point(3, 787);
            MarginPanel.Name = "MarginPanel";
            MarginPanel.Size = new Size(976, 13);
            MarginPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(982, 803);
            Controls.Add(ContentPanel);
            Controls.Add(SidebarPanel);
            Controls.Add(Header);
            Controls.Add(MarginPanel);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.Gainsboro;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 850);
            Name = "MainForm";
            Padding = new Padding(3);
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContentDefaultLogo).EndInit();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            SidebarMenu.ResumeLayout(false);
            FolderSearchPanel.ResumeLayout(false);
            FolderSearchPanel.PerformLayout();
            AccountContainer.Panel1.ResumeLayout(false);
            AccountContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AccountContainer).EndInit();
            AccountContainer.ResumeLayout(false);
            SidebarSubMenu.ResumeLayout(false);
            PasswordSearchPanel.ResumeLayout(false);
            PasswordSearchPanel.PerformLayout();
            SidebarPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SidebarMenu;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AllElementsButton;
        private System.Windows.Forms.ImageList SidebarMenuImages;
        private System.Windows.Forms.ImageList HeaderImages;
        private System.Windows.Forms.ImageList LogoImage;
        private System.Windows.Forms.PictureBox ContentDefaultLogo;
        private System.Windows.Forms.Panel SidebarSubMenu;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Panel FolderSearchPanel;
        private System.Windows.Forms.TextBox FolderSearchTextBox;
        private System.Windows.Forms.Button FolderSortButton;
        private System.Windows.Forms.Button FolderSearchButton;
        private System.Windows.Forms.Button FolderClearSearchButton;
        private Panel MarginPanel;
        private Label LogoLabel;
        private PictureBox Logo;
        private Label FoldersLabel;
        private FlowLayoutPanel FolderListPanel;
        private FlowLayoutPanel PasswordListPanel;
        private Button AddFolderButton;
        private Button SettingsButton;
        private SplitContainer AccountContainer;
        private Panel PasswordSearchPanel;
        private TextBox PasswordSearchTextBox;
        private Button PasswordSortButton;
        private Button PasswordSearchButton;
        private Button PasswordClearSearchButton;
    }
}

