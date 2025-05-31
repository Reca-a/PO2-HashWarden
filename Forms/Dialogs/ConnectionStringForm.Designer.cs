namespace HashWarden.Forms.Dialogs
{
    partial class ConnectionStringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionStringForm));
            Header = new Panel();
            LogoLabel = new Label();
            Logo = new PictureBox();
            ExitButton = new Button();
            LayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            ChangeButton = new Button();
            label2 = new Label();
            StringInput = new TextBox();
            NameLabel = new Label();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            LayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            Header.Size = new Size(800, 80);
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
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(10, 10, 10);
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.ImageIndex = 2;
            ExitButton.Location = new Point(745, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 80);
            ExitButton.TabIndex = 0;
            ExitButton.TabStop = false;
            ExitButton.UseVisualStyleBackColor = false;
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
            LayoutPanel.Size = new Size(800, 273);
            LayoutPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(ChangeButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(StringInput);
            panel2.Controls.Add(NameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(123, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 206);
            panel2.TabIndex = 0;
            // 
            // ChangeButton
            // 
            ChangeButton.AutoEllipsis = true;
            ChangeButton.BackColor = Color.FromArgb(40, 40, 40);
            ChangeButton.Dock = DockStyle.Top;
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Popup;
            ChangeButton.ForeColor = Color.Gainsboro;
            ChangeButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChangeButton.ImageIndex = 2;
            ChangeButton.Location = new Point(0, 114);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Padding = new Padding(10, 0, 0, 5);
            ChangeButton.Size = new Size(554, 51);
            ChangeButton.TabIndex = 1;
            ChangeButton.Text = "Zmień";
            ChangeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Size = new Size(554, 40);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StringInput
            // 
            StringInput.Dock = DockStyle.Top;
            StringInput.Font = new Font("Segoe UI", 12F);
            StringInput.ImeMode = ImeMode.NoControl;
            StringInput.Location = new Point(0, 40);
            StringInput.MaxLength = 255;
            StringInput.Name = "StringInput";
            StringInput.PlaceholderText = "...";
            StringInput.Size = new Size(554, 34);
            StringInput.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.Dock = DockStyle.Top;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.ForeColor = Color.Gainsboro;
            NameLabel.Location = new Point(0, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(554, 40);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Podaj ConnectionString";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ConnectionStringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(LayoutPanel);
            Controls.Add(Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConnectionStringForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zmiana połączenia z bazą";
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            LayoutPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Label LogoLabel;
        private PictureBox Logo;
        private Button ExitButton;
        private TableLayoutPanel LayoutPanel;
        private Panel panel2;
        private Button ChangeButton;
        private Label label2;
        private TextBox StringInput;
        private Label NameLabel;
    }
}