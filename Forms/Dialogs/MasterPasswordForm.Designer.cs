namespace HashWarden.Forms.Dialogs
{
    partial class MasterPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPasswordForm));
            LayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            ProceedButton = new Button();
            label2 = new Label();
            PasswordInput = new TextBox();
            DescLabel3 = new Label();
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            ExitButton = new Button();
            HeaderImages = new ImageList(components);
            LayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
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
            LayoutPanel.Size = new Size(400, 220);
            LayoutPanel.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(ProceedButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PasswordInput);
            panel2.Controls.Add(DescLabel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(63, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 165);
            panel2.TabIndex = 0;
            // 
            // ProceedButton
            // 
            ProceedButton.AutoEllipsis = true;
            ProceedButton.BackColor = Color.FromArgb(40, 40, 40);
            ProceedButton.Dock = DockStyle.Top;
            ProceedButton.FlatAppearance.BorderSize = 0;
            ProceedButton.FlatStyle = FlatStyle.Popup;
            ProceedButton.ForeColor = Color.Gainsboro;
            ProceedButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProceedButton.ImageIndex = 2;
            ProceedButton.Location = new Point(0, 114);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Padding = new Padding(10, 0, 0, 5);
            ProceedButton.Size = new Size(274, 51);
            ProceedButton.TabIndex = 2;
            ProceedButton.Text = "Zatwierdź";
            ProceedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProceedButton.UseVisualStyleBackColor = false;
            ProceedButton.Click += ProceedButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Size = new Size(274, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Dock = DockStyle.Top;
            PasswordInput.Font = new Font("Segoe UI", 12F);
            PasswordInput.ImeMode = ImeMode.NoControl;
            PasswordInput.Location = new Point(0, 40);
            PasswordInput.MaxLength = 40;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Hasło";
            PasswordInput.Size = new Size(274, 34);
            PasswordInput.TabIndex = 1;
            // 
            // DescLabel3
            // 
            DescLabel3.Dock = DockStyle.Top;
            DescLabel3.Font = new Font("Segoe UI", 12F);
            DescLabel3.ForeColor = Color.Gainsboro;
            DescLabel3.Location = new Point(0, 0);
            DescLabel3.Name = "DescLabel3";
            DescLabel3.Size = new Size(274, 40);
            DescLabel3.TabIndex = 12;
            DescLabel3.Text = "Hasło";
            DescLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(10, 10, 10);
            Header.Controls.Add(LogoLabel);
            Header.Controls.Add(Logo);
            Header.Controls.Add(ExitButton);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(400, 80);
            Header.TabIndex = 8;
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
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(10, 10, 10);
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.ImageIndex = 2;
            ExitButton.ImageList = HeaderImages;
            ExitButton.Location = new Point(345, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 80);
            ExitButton.TabIndex = 0;
            ExitButton.TabStop = false;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
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
            // MasterPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(LayoutPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 300);
            MinimizeBox = false;
            MinimumSize = new Size(400, 300);
            Name = "MasterPasswordForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MasterPasswordForm";
            TopMost = true;
            Click += ExitButton_Click;
            LayoutPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LayoutPanel;
        private Panel panel2;
        private Button ProceedButton;
        private Label label2;
        private TextBox PasswordInput;
        private Label DescLabel3;
        private Panel Header;
        private Label LogoLabel;
        private PictureBox Logo;
        private ImageList HeaderImages;
        private Button ExitButton;
    }
}