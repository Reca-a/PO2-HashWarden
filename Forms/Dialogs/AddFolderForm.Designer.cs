namespace HashWarden.Forms.Dialogs
{
    partial class AddFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFolderForm));
            LayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            AddButton = new Button();
            label2 = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
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
            LayoutPanel.Size = new Size(450, 220);
            LayoutPanel.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(NameInput);
            panel2.Controls.Add(NameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(70, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 165);
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
            AddButton.Location = new Point(0, 114);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(10, 0, 0, 5);
            AddButton.Size = new Size(309, 51);
            AddButton.TabIndex = 1;
            AddButton.Text = "Dodaj";
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Size = new Size(309, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameInput
            // 
            NameInput.Dock = DockStyle.Top;
            NameInput.Font = new Font("Segoe UI", 12F);
            NameInput.ImeMode = ImeMode.NoControl;
            NameInput.Location = new Point(0, 40);
            NameInput.MaxLength = 40;
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "Nazwa";
            NameInput.Size = new Size(309, 34);
            NameInput.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.Dock = DockStyle.Top;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.ForeColor = Color.Gainsboro;
            NameLabel.Location = new Point(0, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(309, 40);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Nazwa folderu";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            Header.Size = new Size(450, 80);
            Header.TabIndex = 6;
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
            ExitButton.Location = new Point(395, 0);
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
            // AddFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            ControlBox = false;
            Controls.Add(LayoutPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(450, 300);
            MinimumSize = new Size(450, 300);
            Name = "AddFolderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddFolderForm";
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
        private Button AddButton;
        private Label label2;
        private TextBox NameInput;
        private Label NameLabel;
        private Panel Header;
        private Label LogoLabel;
        private PictureBox Logo;
        private Button ExitButton;
        private ImageList HeaderImages;
    }
}