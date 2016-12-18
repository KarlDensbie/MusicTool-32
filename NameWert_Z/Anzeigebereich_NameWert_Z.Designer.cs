namespace michaL.Musik.Tools.Templates.NameWert_Z
{
    partial class Anzeigebereich_NameWert_Z 
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.anzeigebereich1 = new michaL.Anzeigen.Anzeigebereich_NameWert ();
			this.anzeigebereich2 = new michaL.Anzeigen.Anzeigebereich_NameWert ();
			this.SuspendLayout();
			// 
			// anzeigebereich1
			// 
			this.anzeigebereich1.AutoSize = true;
			this.anzeigebereich1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.anzeigebereich1.BackColor = System.Drawing.Color.LemonChiffon;
			this.anzeigebereich1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anzeigebereich1.Location = new System.Drawing.Point(0, 0);
			this.anzeigebereich1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.anzeigebereich1.Name = "anzeigebereich1";
			this.anzeigebereich1.Size = new System.Drawing.Size(71, 50);
			this.anzeigebereich1.TabIndex = 1;
			// 
			// anzeigebereich2
			// 
			this.anzeigebereich2.AutoSize = true;
			this.anzeigebereich2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.anzeigebereich2.BackColor = System.Drawing.Color.LemonChiffon;
			this.anzeigebereich2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anzeigebereich2.Location = new System.Drawing.Point(0, 58);
			this.anzeigebereich2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.anzeigebereich2.Name = "anzeigebereich2";
			this.anzeigebereich2.Size = new System.Drawing.Size(71, 50);
			this.anzeigebereich2.TabIndex = 2;
			// 
			// Anzeige
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.anzeigebereich2);
			this.Controls.Add(this.anzeigebereich1);
			this.Name = "Anzeige";
			this.Size = new System.Drawing.Size(74, 112);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private Anzeigen.Anzeigebereich_NameWert  anzeigebereich1;
		private Anzeigen.Anzeigebereich_NameWert  anzeigebereich2;
	}
}
