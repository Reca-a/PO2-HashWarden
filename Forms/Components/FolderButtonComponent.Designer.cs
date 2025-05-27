namespace HashWarden.Forms.Components
{
    partial class FolderButtonComponent
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderButtonComponent));
            FolderButton = new Button();
            SidebarMenuImages = new ImageList(components);
            SuspendLayout();
            // 
            // FolderButton
            // 
            FolderButton.AutoEllipsis = true;
            FolderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FolderButton.BackColor = Color.FromArgb(40, 40, 40);
            FolderButton.Dock = DockStyle.Fill;
            FolderButton.FlatAppearance.BorderSize = 0;
            FolderButton.FlatStyle = FlatStyle.Popup;
            FolderButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FolderButton.ForeColor = Color.Gainsboro;
            FolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            FolderButton.ImageIndex = 1;
            FolderButton.ImageList = SidebarMenuImages;
            FolderButton.Location = new Point(0, 0);
            FolderButton.Margin = new Padding(3, 4, 3, 4);
            FolderButton.Name = "FolderButton";
            FolderButton.Padding = new Padding(11, 0, 0, 0);
            FolderButton.Size = new Size(260, 60);
            FolderButton.TabIndex = 4;
            FolderButton.Text = "   (Brak nazwy)";
            FolderButton.TextAlign = ContentAlignment.MiddleLeft;
            FolderButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FolderButton.UseVisualStyleBackColor = false;
            FolderButton.Click += FolderButton_Click;
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
            // FolderButtonComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(FolderButton);
            Margin = new Padding(0);
            Name = "FolderButtonComponent";
            Size = new Size(260, 60);
            ResumeLayout(false);
        }

        #endregion

        private Button FolderButton;
        private ImageList SidebarMenuImages;
    }
}
