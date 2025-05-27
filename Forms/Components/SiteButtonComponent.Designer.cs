namespace HashWarden.Forms.Components
{
    partial class SiteButtonComponent
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
            SiteButton = new Button();
            SuspendLayout();
            // 
            // SiteButton
            // 
            SiteButton.AutoEllipsis = true;
            SiteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SiteButton.BackColor = Color.FromArgb(40, 40, 40);
            SiteButton.Dock = DockStyle.Fill;
            SiteButton.FlatAppearance.BorderSize = 0;
            SiteButton.FlatStyle = FlatStyle.Popup;
            SiteButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SiteButton.ForeColor = Color.Gainsboro;
            SiteButton.ImageAlign = ContentAlignment.MiddleLeft;
            SiteButton.ImageIndex = 1;
            SiteButton.Location = new Point(0, 0);
            SiteButton.Margin = new Padding(3, 4, 3, 4);
            SiteButton.Name = "SiteButton";
            SiteButton.Padding = new Padding(11, 0, 0, 0);
            SiteButton.Size = new Size(260, 40);
            SiteButton.TabIndex = 6;
            SiteButton.Text = "   (Brak nazwy)";
            SiteButton.TextAlign = ContentAlignment.MiddleLeft;
            SiteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SiteButton.UseVisualStyleBackColor = false;
            SiteButton.Click += SiteButton_Click;
            // 
            // SiteButtonComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(SiteButton);
            Margin = new Padding(0);
            Name = "SiteButtonComponent";
            Size = new Size(260, 40);
            ResumeLayout(false);
        }

        #endregion

        private Button SiteButton;
    }
}
