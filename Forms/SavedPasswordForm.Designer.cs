namespace HashWarden
{
    partial class SavedPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedPasswordForm));
            HeaderLabel = new Label();
            LayoutPanel = new TableLayoutPanel();
            InfoBgPanel = new Panel();
            FolderLabel = new Label();
            TimestampsBgPanel = new Panel();
            UpdatedAtLabel = new Label();
            CreatedAtLabel = new Label();
            DescLabel5 = new Label();
            ServiceNameLabel = new Label();
            DescLabel4 = new Label();
            PasswordContainer = new TableLayoutPanel();
            PasswordLabel = new Label();
            ViewPassButton = new Button();
            Icons = new ImageList(components);
            DescLabel3 = new Label();
            UsernameLabel = new Label();
            DescLabel2 = new Label();
            TitleLabel = new Label();
            DescLabel1 = new Label();
            DeleteRecordButton = new Button();
            EditRecordButton = new Button();
            BottomButtonBar = new Panel();
            MarginPanel = new Panel();
            LayoutPanel.SuspendLayout();
            InfoBgPanel.SuspendLayout();
            TimestampsBgPanel.SuspendLayout();
            PasswordContainer.SuspendLayout();
            BottomButtonBar.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.BackColor = Color.Transparent;
            HeaderLabel.Dock = DockStyle.Top;
            HeaderLabel.FlatStyle = FlatStyle.Flat;
            HeaderLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HeaderLabel.ForeColor = Color.Gainsboro;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(926, 65);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Informacje o elemencie";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LayoutPanel
            // 
            LayoutPanel.ColumnCount = 3;
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            LayoutPanel.Controls.Add(InfoBgPanel, 1, 0);
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.Location = new Point(0, 65);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.RowCount = 1;
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LayoutPanel.Size = new Size(926, 605);
            LayoutPanel.TabIndex = 2;
            // 
            // InfoBgPanel
            // 
            InfoBgPanel.Controls.Add(FolderLabel);
            InfoBgPanel.Controls.Add(TimestampsBgPanel);
            InfoBgPanel.Controls.Add(DescLabel5);
            InfoBgPanel.Controls.Add(ServiceNameLabel);
            InfoBgPanel.Controls.Add(DescLabel4);
            InfoBgPanel.Controls.Add(PasswordContainer);
            InfoBgPanel.Controls.Add(DescLabel3);
            InfoBgPanel.Controls.Add(UsernameLabel);
            InfoBgPanel.Controls.Add(DescLabel2);
            InfoBgPanel.Controls.Add(TitleLabel);
            InfoBgPanel.Controls.Add(DescLabel1);
            InfoBgPanel.Dock = DockStyle.Fill;
            InfoBgPanel.Location = new Point(234, 3);
            InfoBgPanel.Name = "InfoBgPanel";
            InfoBgPanel.Size = new Size(457, 599);
            InfoBgPanel.TabIndex = 2;
            // 
            // FolderLabel
            // 
            FolderLabel.AutoEllipsis = true;
            FolderLabel.BackColor = Color.FromArgb(40, 40, 40);
            FolderLabel.Dock = DockStyle.Top;
            FolderLabel.Font = new Font("Segoe UI", 10F);
            FolderLabel.ForeColor = Color.Gainsboro;
            FolderLabel.Location = new Point(0, 465);
            FolderLabel.Name = "FolderLabel";
            FolderLabel.Padding = new Padding(10);
            FolderLabel.Size = new Size(457, 45);
            FolderLabel.TabIndex = 11;
            FolderLabel.Text = "Folder";
            FolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TimestampsBgPanel
            // 
            TimestampsBgPanel.Controls.Add(UpdatedAtLabel);
            TimestampsBgPanel.Controls.Add(CreatedAtLabel);
            TimestampsBgPanel.Dock = DockStyle.Bottom;
            TimestampsBgPanel.Location = new Point(0, 509);
            TimestampsBgPanel.Name = "TimestampsBgPanel";
            TimestampsBgPanel.Padding = new Padding(20, 0, 0, 20);
            TimestampsBgPanel.Size = new Size(457, 90);
            TimestampsBgPanel.TabIndex = 1;
            // 
            // UpdatedAtLabel
            // 
            UpdatedAtLabel.AutoEllipsis = true;
            UpdatedAtLabel.Dock = DockStyle.Bottom;
            UpdatedAtLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            UpdatedAtLabel.ForeColor = Color.Gainsboro;
            UpdatedAtLabel.Location = new Point(20, 10);
            UpdatedAtLabel.Name = "UpdatedAtLabel";
            UpdatedAtLabel.Size = new Size(437, 30);
            UpdatedAtLabel.TabIndex = 1;
            UpdatedAtLabel.Text = "Aktualizowano: ";
            // 
            // CreatedAtLabel
            // 
            CreatedAtLabel.AutoEllipsis = true;
            CreatedAtLabel.Dock = DockStyle.Bottom;
            CreatedAtLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            CreatedAtLabel.ForeColor = Color.Gainsboro;
            CreatedAtLabel.Location = new Point(20, 40);
            CreatedAtLabel.Name = "CreatedAtLabel";
            CreatedAtLabel.Size = new Size(437, 30);
            CreatedAtLabel.TabIndex = 0;
            CreatedAtLabel.Text = "Utworzono: ";
            // 
            // DescLabel5
            // 
            DescLabel5.AutoEllipsis = true;
            DescLabel5.BackColor = Color.FromArgb(35, 35, 35);
            DescLabel5.Dock = DockStyle.Top;
            DescLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescLabel5.ForeColor = Color.Gainsboro;
            DescLabel5.Location = new Point(0, 410);
            DescLabel5.Name = "DescLabel5";
            DescLabel5.Padding = new Padding(10);
            DescLabel5.Size = new Size(457, 55);
            DescLabel5.TabIndex = 10;
            DescLabel5.Text = "Folder";
            DescLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ServiceNameLabel
            // 
            ServiceNameLabel.AutoEllipsis = true;
            ServiceNameLabel.BackColor = Color.FromArgb(40, 40, 40);
            ServiceNameLabel.Dock = DockStyle.Top;
            ServiceNameLabel.Font = new Font("Segoe UI", 10F);
            ServiceNameLabel.ForeColor = Color.Gainsboro;
            ServiceNameLabel.Location = new Point(0, 365);
            ServiceNameLabel.Name = "ServiceNameLabel";
            ServiceNameLabel.Padding = new Padding(10);
            ServiceNameLabel.Size = new Size(457, 45);
            ServiceNameLabel.TabIndex = 9;
            ServiceNameLabel.Text = "google.com";
            ServiceNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DescLabel4
            // 
            DescLabel4.AutoEllipsis = true;
            DescLabel4.BackColor = Color.FromArgb(35, 35, 35);
            DescLabel4.Dock = DockStyle.Top;
            DescLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescLabel4.ForeColor = Color.Gainsboro;
            DescLabel4.Location = new Point(0, 310);
            DescLabel4.Name = "DescLabel4";
            DescLabel4.Padding = new Padding(10);
            DescLabel4.Size = new Size(457, 55);
            DescLabel4.TabIndex = 8;
            DescLabel4.Text = "Strona";
            DescLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordContainer
            // 
            PasswordContainer.BackColor = Color.FromArgb(40, 40, 40);
            PasswordContainer.ColumnCount = 2;
            PasswordContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            PasswordContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PasswordContainer.Controls.Add(PasswordLabel, 0, 0);
            PasswordContainer.Controls.Add(ViewPassButton, 1, 0);
            PasswordContainer.Dock = DockStyle.Top;
            PasswordContainer.Location = new Point(0, 255);
            PasswordContainer.Name = "PasswordContainer";
            PasswordContainer.Padding = new Padding(10);
            PasswordContainer.RowCount = 1;
            PasswordContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PasswordContainer.Size = new Size(457, 55);
            PasswordContainer.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoEllipsis = true;
            PasswordLabel.Dock = DockStyle.Fill;
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.ForeColor = Color.Gainsboro;
            PasswordLabel.Location = new Point(13, 10);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(343, 35);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "************";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ViewPassButton
            // 
            ViewPassButton.Dock = DockStyle.Left;
            ViewPassButton.FlatAppearance.BorderSize = 0;
            ViewPassButton.FlatStyle = FlatStyle.Flat;
            ViewPassButton.ImageIndex = 0;
            ViewPassButton.ImageList = Icons;
            ViewPassButton.Location = new Point(362, 13);
            ViewPassButton.Name = "ViewPassButton";
            ViewPassButton.Size = new Size(51, 29);
            ViewPassButton.TabIndex = 8;
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
            DescLabel3.AutoEllipsis = true;
            DescLabel3.BackColor = Color.FromArgb(35, 35, 35);
            DescLabel3.Dock = DockStyle.Top;
            DescLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescLabel3.ForeColor = Color.Gainsboro;
            DescLabel3.Location = new Point(0, 200);
            DescLabel3.Name = "DescLabel3";
            DescLabel3.Padding = new Padding(10);
            DescLabel3.Size = new Size(457, 55);
            DescLabel3.TabIndex = 6;
            DescLabel3.Text = "Hasło";
            DescLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoEllipsis = true;
            UsernameLabel.BackColor = Color.FromArgb(40, 40, 40);
            UsernameLabel.Dock = DockStyle.Top;
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.ForeColor = Color.Gainsboro;
            UsernameLabel.Location = new Point(0, 155);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Padding = new Padding(10);
            UsernameLabel.Size = new Size(457, 45);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "roszul@wp.pl";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DescLabel2
            // 
            DescLabel2.AutoEllipsis = true;
            DescLabel2.BackColor = Color.FromArgb(35, 35, 35);
            DescLabel2.Dock = DockStyle.Top;
            DescLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescLabel2.ForeColor = Color.Gainsboro;
            DescLabel2.Location = new Point(0, 100);
            DescLabel2.Name = "DescLabel2";
            DescLabel2.Padding = new Padding(10);
            DescLabel2.Size = new Size(457, 55);
            DescLabel2.TabIndex = 4;
            DescLabel2.Text = "Nazwa użytkownika";
            DescLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoEllipsis = true;
            TitleLabel.BackColor = Color.FromArgb(40, 40, 40);
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Segoe UI", 10F);
            TitleLabel.ForeColor = Color.Gainsboro;
            TitleLabel.Location = new Point(0, 55);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Padding = new Padding(10);
            TitleLabel.Size = new Size(457, 45);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Google";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DescLabel1
            // 
            DescLabel1.AutoEllipsis = true;
            DescLabel1.BackColor = Color.FromArgb(35, 35, 35);
            DescLabel1.Dock = DockStyle.Top;
            DescLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescLabel1.ForeColor = Color.Gainsboro;
            DescLabel1.Location = new Point(0, 0);
            DescLabel1.Name = "DescLabel1";
            DescLabel1.Padding = new Padding(10);
            DescLabel1.Size = new Size(457, 55);
            DescLabel1.TabIndex = 2;
            DescLabel1.Text = "Nazwa";
            DescLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteRecordButton
            // 
            DeleteRecordButton.BackColor = Color.FromArgb(60, 60, 60);
            DeleteRecordButton.Dock = DockStyle.Left;
            DeleteRecordButton.FlatAppearance.BorderColor = Color.Black;
            DeleteRecordButton.FlatAppearance.BorderSize = 0;
            DeleteRecordButton.FlatStyle = FlatStyle.Flat;
            DeleteRecordButton.ForeColor = Color.Gainsboro;
            DeleteRecordButton.ImageIndex = 3;
            DeleteRecordButton.ImageList = Icons;
            DeleteRecordButton.Location = new Point(105, 0);
            DeleteRecordButton.Name = "DeleteRecordButton";
            DeleteRecordButton.Size = new Size(82, 50);
            DeleteRecordButton.TabIndex = 10;
            DeleteRecordButton.UseVisualStyleBackColor = false;
            DeleteRecordButton.Click += DeleteRecordButton_Click;
            // 
            // EditRecordButton
            // 
            EditRecordButton.BackColor = Color.FromArgb(60, 60, 60);
            EditRecordButton.Dock = DockStyle.Left;
            EditRecordButton.FlatAppearance.BorderColor = Color.Black;
            EditRecordButton.FlatAppearance.BorderSize = 0;
            EditRecordButton.FlatStyle = FlatStyle.Flat;
            EditRecordButton.ForeColor = Color.Gainsboro;
            EditRecordButton.ImageIndex = 2;
            EditRecordButton.ImageList = Icons;
            EditRecordButton.Location = new Point(23, 0);
            EditRecordButton.Name = "EditRecordButton";
            EditRecordButton.Size = new Size(82, 50);
            EditRecordButton.TabIndex = 9;
            EditRecordButton.UseVisualStyleBackColor = false;
            EditRecordButton.Click += EditRecordButton_Click;
            // 
            // BottomButtonBar
            // 
            BottomButtonBar.BackColor = Color.FromArgb(60, 60, 60);
            BottomButtonBar.Controls.Add(DeleteRecordButton);
            BottomButtonBar.Controls.Add(EditRecordButton);
            BottomButtonBar.Controls.Add(MarginPanel);
            BottomButtonBar.Dock = DockStyle.Bottom;
            BottomButtonBar.Location = new Point(0, 670);
            BottomButtonBar.Name = "BottomButtonBar";
            BottomButtonBar.Size = new Size(926, 50);
            BottomButtonBar.TabIndex = 3;
            // 
            // MarginPanel
            // 
            MarginPanel.Dock = DockStyle.Left;
            MarginPanel.Location = new Point(0, 0);
            MarginPanel.Name = "MarginPanel";
            MarginPanel.Size = new Size(23, 50);
            MarginPanel.TabIndex = 5;
            // 
            // SavedPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(926, 720);
            Controls.Add(LayoutPanel);
            Controls.Add(HeaderLabel);
            Controls.Add(BottomButtonBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SavedPasswordForm";
            Text = "Form1";
            LayoutPanel.ResumeLayout(false);
            InfoBgPanel.ResumeLayout(false);
            TimestampsBgPanel.ResumeLayout(false);
            PasswordContainer.ResumeLayout(false);
            BottomButtonBar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private TableLayoutPanel LayoutPanel;
        private Panel TimestampsBgPanel;
        private Label UpdatedAtLabel;
        private Label CreatedAtLabel;
        private Panel InfoBgPanel;
        private Label DescLabel1;
        private Label DescLabel5;
        private Label ServiceNameLabel;
        private Label DescLabel4;
        private Label PasswordLabel;
        private Label DescLabel3;
        private Label UsernameLabel;
        private Label DescLabel2;
        private Label TitleLabel;
        private Label FolderLabel;
        private TableLayoutPanel PasswordContainer;
        private Button ViewPassButton;
        private ImageList Icons;
        private Button DeleteRecordButton;
        private Button EditRecordButton;
        private Panel BottomButtonBar;
        private Panel MarginPanel;
    }
}