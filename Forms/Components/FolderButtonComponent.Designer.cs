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
            FoldersButton = new Button();
            SidebarMenuImages = new ImageList(components);
            SuspendLayout();
            // 
            // FoldersButton
            // 
            FoldersButton.AutoEllipsis = true;
            FoldersButton.BackColor = Color.FromArgb(40, 40, 40);
            FoldersButton.Dock = DockStyle.Fill;
            FoldersButton.FlatAppearance.BorderSize = 0;
            FoldersButton.FlatStyle = FlatStyle.Popup;
            FoldersButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoldersButton.ForeColor = Color.Gainsboro;
            FoldersButton.ImageAlign = ContentAlignment.MiddleLeft;
            FoldersButton.ImageIndex = 1;
            FoldersButton.ImageList = SidebarMenuImages;
            FoldersButton.Location = new Point(0, 0);
            FoldersButton.Name = "FoldersButton";
            FoldersButton.Padding = new Padding(10, 0, 0, 0);
            FoldersButton.Size = new Size(230, 50);
            FoldersButton.TabIndex = 2;
            FoldersButton.Text = "   Foldery";
            FoldersButton.TextAlign = ContentAlignment.MiddleLeft;
            FoldersButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FoldersButton.UseVisualStyleBackColor = false;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FoldersButton);
            Name = "FolderButtonComponent";
            Size = new Size(230, 50);
            ResumeLayout(false);
        }

        #endregion

        private Button FoldersButton;
        private ImageList SidebarMenuImages;
    }
}
