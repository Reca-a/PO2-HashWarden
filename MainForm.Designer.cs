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
            LogoImage = new ImageList(components);
            MinimalizeButton = new Button();
            HeaderImages = new ImageList(components);
            MaximizeButton = new Button();
            ExitButton = new Button();
            this.LogoLabel = new Label();
            Logo = new PictureBox();
            SidebarMenu = new Panel();
            FavoritesButton = new Button();
            SidebarMenuImages = new ImageList(components);
            LogoutButton = new Button();
            FoldersButton = new Button();
            AllElementsButton = new Button();
            SidebarSubMenu = new Panel();
            AddRecordButton = new Button();
            NoElemLabel = new Label();
            SidebarPanel = new Panel();
            MarginPanel = new Panel();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContentDefaultLogo).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SidebarMenu.SuspendLayout();
            SidebarSubMenu.SuspendLayout();
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
            ContentPanel.Size = new Size(476, 700);
            ContentPanel.TabIndex = 1;
            // 
            // ContentDefaultLogo
            // 
            ContentDefaultLogo.Anchor = AnchorStyles.None;
            ContentDefaultLogo.Image = (Image)resources.GetObject("ContentDefaultLogo.Image");
            ContentDefaultLogo.Location = new Point(32, 255);
            ContentDefaultLogo.Name = "ContentDefaultLogo";
            ContentDefaultLogo.Size = new Size(418, 165);
            ContentDefaultLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ContentDefaultLogo.TabIndex = 1;
            ContentDefaultLogo.TabStop = false;
            // 
            // Header
            // 
            Header.Controls.Add(MinimalizeButton);
            Header.Controls.Add(MaximizeButton);
            Header.Controls.Add(ExitButton);
            Header.Controls.Add(this.LogoLabel);
            Header.Controls.Add(Logo);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(3, 3);
            Header.Name = "Header";
            Header.Size = new Size(978, 65);
            Header.TabIndex = 2;
            Header.MouseDown += Header_MouseDown;
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
            MinimalizeButton.ImageIndex = 0;
            MinimalizeButton.ImageList = HeaderImages;
            MinimalizeButton.Location = new Point(813, 0);
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
            // MaximizeButton
            // 
            MaximizeButton.BackColor = Color.FromArgb(10, 10, 10);
            MaximizeButton.Dock = DockStyle.Right;
            MaximizeButton.FlatAppearance.BorderSize = 0;
            MaximizeButton.FlatStyle = FlatStyle.Flat;
            MaximizeButton.ImageIndex = 1;
            MaximizeButton.ImageList = HeaderImages;
            MaximizeButton.Location = new Point(868, 0);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(55, 65);
            MaximizeButton.TabIndex = 1;
            MaximizeButton.UseVisualStyleBackColor = false;
            MaximizeButton.Click += MaximizeButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(10, 10, 10);
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ImageIndex = 2;
            ExitButton.ImageList = HeaderImages;
            ExitButton.Location = new Point(923, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 65);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AccessibleRole = AccessibleRole.None;
            this.LogoLabel.CausesValidation = false;
            this.LogoLabel.Dock = DockStyle.Left;
            this.LogoLabel.FlatStyle = FlatStyle.Flat;
            this.LogoLabel.Font = new Font("OCR A Extended", 16F, FontStyle.Bold);
            this.LogoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            this.LogoLabel.Location = new Point(70, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new Size(228, 65);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "HashWarden";
            this.LogoLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            // SidebarMenu
            // 
            SidebarMenu.BackColor = Color.FromArgb(25, 25, 25);
            SidebarMenu.Controls.Add(FavoritesButton);
            SidebarMenu.Controls.Add(LogoutButton);
            SidebarMenu.Controls.Add(FoldersButton);
            SidebarMenu.Controls.Add(AllElementsButton);
            SidebarMenu.Dock = DockStyle.Left;
            SidebarMenu.Location = new Point(0, 0);
            SidebarMenu.Name = "SidebarMenu";
            SidebarMenu.Size = new Size(230, 700);
            SidebarMenu.TabIndex = 3;
            // 
            // FavoritesButton
            // 
            FavoritesButton.AutoEllipsis = true;
            FavoritesButton.BackColor = Color.FromArgb(40, 40, 40);
            FavoritesButton.Dock = DockStyle.Top;
            FavoritesButton.FlatAppearance.BorderSize = 0;
            FavoritesButton.FlatStyle = FlatStyle.Popup;
            FavoritesButton.ImageAlign = ContentAlignment.MiddleLeft;
            FavoritesButton.ImageIndex = 1;
            FavoritesButton.ImageList = SidebarMenuImages;
            FavoritesButton.Location = new Point(0, 100);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Padding = new Padding(10, 0, 0, 0);
            FavoritesButton.Size = new Size(230, 50);
            FavoritesButton.TabIndex = 3;
            FavoritesButton.Text = "   Ulubione";
            FavoritesButton.TextAlign = ContentAlignment.MiddleLeft;
            FavoritesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FavoritesButton.UseVisualStyleBackColor = false;
            // 
            // SidebarMenuImages
            // 
            SidebarMenuImages.ColorDepth = ColorDepth.Depth32Bit;
            SidebarMenuImages.ImageStream = (ImageListStreamer)resources.GetObject("SidebarMenuImages.ImageStream");
            SidebarMenuImages.TransparentColor = Color.Transparent;
            SidebarMenuImages.Images.SetKeyName(0, "allElementsIcon.png");
            SidebarMenuImages.Images.SetKeyName(1, "foldersIcon.png");
            SidebarMenuImages.Images.SetKeyName(2, "signOutIcon.png");
            // 
            // LogoutButton
            // 
            LogoutButton.AutoEllipsis = true;
            LogoutButton.BackColor = Color.FromArgb(40, 40, 40);
            LogoutButton.Dock = DockStyle.Bottom;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Popup;
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.ImageIndex = 2;
            LogoutButton.ImageList = SidebarMenuImages;
            LogoutButton.Location = new Point(0, 650);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Padding = new Padding(10, 0, 0, 5);
            LogoutButton.Size = new Size(230, 50);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "   Wyloguj";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // FoldersButton
            // 
            FoldersButton.AutoEllipsis = true;
            FoldersButton.BackColor = Color.FromArgb(40, 40, 40);
            FoldersButton.Dock = DockStyle.Top;
            FoldersButton.FlatAppearance.BorderSize = 0;
            FoldersButton.FlatStyle = FlatStyle.Popup;
            FoldersButton.ImageAlign = ContentAlignment.MiddleLeft;
            FoldersButton.ImageIndex = 1;
            FoldersButton.ImageList = SidebarMenuImages;
            FoldersButton.Location = new Point(0, 50);
            FoldersButton.Name = "FoldersButton";
            FoldersButton.Padding = new Padding(10, 0, 0, 0);
            FoldersButton.Size = new Size(230, 50);
            FoldersButton.TabIndex = 1;
            FoldersButton.Text = "   Foldery";
            FoldersButton.TextAlign = ContentAlignment.MiddleLeft;
            FoldersButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FoldersButton.UseVisualStyleBackColor = false;
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
            AllElementsButton.Padding = new Padding(10, 0, 0, 0);
            AllElementsButton.Size = new Size(230, 50);
            AllElementsButton.TabIndex = 0;
            AllElementsButton.Text = "   Wszystkie elementy";
            AllElementsButton.TextAlign = ContentAlignment.MiddleLeft;
            AllElementsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AllElementsButton.UseVisualStyleBackColor = false;
            AllElementsButton.Click += AllElementsButton_Click;
            // 
            // SidebarSubMenu
            // 
            SidebarSubMenu.BackColor = Color.FromArgb(15, 15, 15);
            SidebarSubMenu.Controls.Add(AddRecordButton);
            SidebarSubMenu.Controls.Add(NoElemLabel);
            SidebarSubMenu.Dock = DockStyle.Right;
            SidebarSubMenu.Location = new Point(232, 0);
            SidebarSubMenu.Name = "SidebarSubMenu";
            SidebarSubMenu.Size = new Size(270, 700);
            SidebarSubMenu.TabIndex = 4;
            // 
            // AddRecordButton
            // 
            AddRecordButton.AutoEllipsis = true;
            AddRecordButton.BackColor = Color.FromArgb(25, 25, 25);
            AddRecordButton.Dock = DockStyle.Bottom;
            AddRecordButton.FlatAppearance.BorderSize = 0;
            AddRecordButton.FlatStyle = FlatStyle.Popup;
            AddRecordButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddRecordButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddRecordButton.ImageIndex = 2;
            AddRecordButton.Location = new Point(0, 650);
            AddRecordButton.Name = "AddRecordButton";
            AddRecordButton.Padding = new Padding(10, 0, 0, 5);
            AddRecordButton.Size = new Size(270, 50);
            AddRecordButton.TabIndex = 5;
            AddRecordButton.Text = "+";
            AddRecordButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddRecordButton.UseVisualStyleBackColor = false;
            // 
            // NoElemLabel
            // 
            NoElemLabel.Dock = DockStyle.Fill;
            NoElemLabel.Location = new Point(0, 0);
            NoElemLabel.Name = "NoElemLabel";
            NoElemLabel.Size = new Size(270, 700);
            NoElemLabel.TabIndex = 4;
            NoElemLabel.Text = "Brak elementów";
            NoElemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(SidebarSubMenu);
            SidebarPanel.Controls.Add(SidebarMenu);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(3, 68);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(502, 700);
            SidebarPanel.TabIndex = 2;
            // 
            // MarginPanel
            // 
            MarginPanel.BackColor = Color.FromArgb(10, 10, 10);
            MarginPanel.Dock = DockStyle.Bottom;
            MarginPanel.Location = new Point(3, 768);
            MarginPanel.Name = "MarginPanel";
            MarginPanel.Size = new Size(978, 13);
            MarginPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(984, 784);
            ControlBox = false;
            Controls.Add(ContentPanel);
            Controls.Add(SidebarPanel);
            Controls.Add(Header);
            Controls.Add(MarginPanel);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.Gainsboro;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 800);
            Name = "MainForm";
            Padding = new Padding(3);
            SizeGripStyle = SizeGripStyle.Show;
            Activated += MainForm_Activated;
            Deactivate += MainForm_Deactivate;
            Load += MainForm_Load;
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContentDefaultLogo).EndInit();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            SidebarMenu.ResumeLayout(false);
            SidebarSubMenu.ResumeLayout(false);
            SidebarPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SidebarMenu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button FoldersButton;
        private System.Windows.Forms.Button AllElementsButton;
        private System.Windows.Forms.Button MinimalizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.ImageList SidebarMenuImages;
        private System.Windows.Forms.ImageList HeaderImages;
        private System.Windows.Forms.ImageList LogoImage;
        private System.Windows.Forms.PictureBox ContentDefaultLogo;
        private System.Windows.Forms.Panel SidebarSubMenu;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Label NoElemLabel;
        private System.Windows.Forms.Button FavoritesButton;
        private System.Windows.Forms.Button AddRecordButton;
        private Panel MarginPanel;
        private Label LogoLabel;
        private PictureBox Logo;
    }
}

