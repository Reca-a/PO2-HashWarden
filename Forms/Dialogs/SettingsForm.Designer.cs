namespace HashWarden.Forms.Dialogs
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            HeaderImages = new ImageList(components);
            LayoutPanel = new TableLayoutPanel();
            ExportButton = new Button();
            DescLabel3 = new Label();
            DescLabel5 = new Label();
            DescLabel4 = new Label();
            ImportButton = new Button();
            ConnStringButton = new Button();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            LayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(10, 10, 10);
            Header.Controls.Add(LogoLabel);
            Header.Controls.Add(Logo);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(622, 80);
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
            LogoLabel.Size = new Size(226, 80);
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
            // LayoutPanel
            // 
            LayoutPanel.BackColor = Color.FromArgb(15, 15, 15);
            LayoutPanel.ColumnCount = 2;
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanel.Controls.Add(ExportButton, 1, 1);
            LayoutPanel.Controls.Add(DescLabel3, 0, 1);
            LayoutPanel.Controls.Add(DescLabel5, 0, 3);
            LayoutPanel.Controls.Add(DescLabel4, 0, 2);
            LayoutPanel.Controls.Add(ImportButton, 1, 2);
            LayoutPanel.Controls.Add(ConnStringButton, 1, 3);
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LayoutPanel.Location = new Point(0, 80);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.RowCount = 5;
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.395349F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 29.069767F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 29.069767F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 29.069767F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.395349F));
            LayoutPanel.Size = new Size(622, 370);
            LayoutPanel.TabIndex = 8;
            // 
            // ExportButton
            // 
            ExportButton.AutoEllipsis = true;
            ExportButton.BackColor = Color.FromArgb(40, 40, 40);
            ExportButton.Dock = DockStyle.Top;
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Popup;
            ExportButton.ForeColor = Color.Gainsboro;
            ExportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExportButton.ImageIndex = 2;
            ExportButton.Location = new Point(314, 26);
            ExportButton.Margin = new Padding(3, 3, 15, 3);
            ExportButton.Name = "ExportButton";
            ExportButton.Padding = new Padding(10, 0, 0, 5);
            ExportButton.Size = new Size(293, 51);
            ExportButton.TabIndex = 1;
            ExportButton.Text = "Eksportuj";
            ExportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // DescLabel3
            // 
            DescLabel3.Dock = DockStyle.Fill;
            DescLabel3.Font = new Font("Segoe UI", 12F);
            DescLabel3.ForeColor = Color.Gainsboro;
            DescLabel3.Location = new Point(15, 23);
            DescLabel3.Margin = new Padding(15, 0, 3, 0);
            DescLabel3.Name = "DescLabel3";
            DescLabel3.Size = new Size(293, 107);
            DescLabel3.TabIndex = 12;
            DescLabel3.Text = "Eksportuj hasła";
            // 
            // DescLabel5
            // 
            DescLabel5.Dock = DockStyle.Fill;
            DescLabel5.Font = new Font("Segoe UI", 12F);
            DescLabel5.ForeColor = Color.Gainsboro;
            DescLabel5.Location = new Point(15, 237);
            DescLabel5.Margin = new Padding(15, 0, 3, 0);
            DescLabel5.Name = "DescLabel5";
            DescLabel5.Size = new Size(293, 107);
            DescLabel5.TabIndex = 16;
            DescLabel5.Text = "Zmiana połączenia z bazą";
            // 
            // DescLabel4
            // 
            DescLabel4.Dock = DockStyle.Fill;
            DescLabel4.Font = new Font("Segoe UI", 12F);
            DescLabel4.ForeColor = Color.Gainsboro;
            DescLabel4.Location = new Point(15, 130);
            DescLabel4.Margin = new Padding(15, 0, 3, 0);
            DescLabel4.Name = "DescLabel4";
            DescLabel4.Size = new Size(293, 107);
            DescLabel4.TabIndex = 14;
            DescLabel4.Text = "Importuj hasła";
            // 
            // ImportButton
            // 
            ImportButton.AutoEllipsis = true;
            ImportButton.BackColor = Color.FromArgb(40, 40, 40);
            ImportButton.Dock = DockStyle.Top;
            ImportButton.FlatAppearance.BorderSize = 0;
            ImportButton.FlatStyle = FlatStyle.Popup;
            ImportButton.ForeColor = Color.Gainsboro;
            ImportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ImportButton.ImageIndex = 2;
            ImportButton.Location = new Point(314, 133);
            ImportButton.Margin = new Padding(3, 3, 15, 3);
            ImportButton.Name = "ImportButton";
            ImportButton.Padding = new Padding(10, 0, 0, 5);
            ImportButton.Size = new Size(293, 51);
            ImportButton.TabIndex = 2;
            ImportButton.Text = "Importuj";
            ImportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // ConnStringButton
            // 
            ConnStringButton.AutoEllipsis = true;
            ConnStringButton.BackColor = Color.FromArgb(40, 40, 40);
            ConnStringButton.Dock = DockStyle.Top;
            ConnStringButton.FlatAppearance.BorderSize = 0;
            ConnStringButton.FlatStyle = FlatStyle.Popup;
            ConnStringButton.ForeColor = Color.Gainsboro;
            ConnStringButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConnStringButton.ImageIndex = 2;
            ConnStringButton.Location = new Point(314, 240);
            ConnStringButton.Margin = new Padding(3, 3, 15, 3);
            ConnStringButton.Name = "ConnStringButton";
            ConnStringButton.Padding = new Padding(10, 0, 0, 5);
            ConnStringButton.Size = new Size(293, 51);
            ConnStringButton.TabIndex = 3;
            ConnStringButton.Text = "Zmień";
            ConnStringButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ConnStringButton.UseVisualStyleBackColor = false;
            ConnStringButton.Click += ConnStringButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(LayoutPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ustawienia";
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            LayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Label LogoLabel;
        private PictureBox Logo;
        private ImageList HeaderImages;
        private TableLayoutPanel LayoutPanel;
        private Panel panel2;
        private Button ExportButton;
        private Label label2;
        private Label DescLabel2;
        private Label DescLabel3;
        private Label DescLabel5;
        private Label DescLabel4;
        private Button ImportButton;
        private Button ConnStringButton;
    }
}