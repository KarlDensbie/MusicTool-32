namespace MusicTool.Fenster.Testanzeigen
{
	partial class Anz_TonData
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Verlassen = new System.Windows.Forms.Button();
			this.tonAnzeige1 = new michaL.Anzeige.TonAnzeige();
			this.lbl_Methode = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Verlassen
			// 
			this.btn_Verlassen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Verlassen.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Verlassen.Location = new System.Drawing.Point(12, 181);
			this.btn_Verlassen.Name = "btn_Verlassen";
			this.btn_Verlassen.Size = new System.Drawing.Size(102, 34);
			this.btn_Verlassen.TabIndex = 0;
			this.btn_Verlassen.Text = "OK";
			this.btn_Verlassen.UseVisualStyleBackColor = false;
			this.btn_Verlassen.Click += new System.EventHandler(this.btn_Verlassen_Click);
			// 
			// tonAnzeige1
			// 
			this.tonAnzeige1.AutoSize = true;
			this.tonAnzeige1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tonAnzeige1.Location = new System.Drawing.Point(12, 47);
			this.tonAnzeige1.Name = "tonAnzeige1";
			this.tonAnzeige1.Size = new System.Drawing.Size(136, 135);
			this.tonAnzeige1.TabIndex = 0;
			// 
			// lbl_Methode
			// 
			this.lbl_Methode.AutoSize = true;
			this.lbl_Methode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Methode.Location = new System.Drawing.Point(12, 25);
			this.lbl_Methode.Name = "lbl_Methode";
			this.lbl_Methode.Size = new System.Drawing.Size(54, 19);
			this.lbl_Methode.TabIndex = 12;
			this.lbl_Methode.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Ausführend: ";
			// 
			// Anz_TonData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(189, 220);
			this.Controls.Add(this.lbl_Methode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Verlassen);
			this.Controls.Add(this.tonAnzeige1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "Anz_TonData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "TonData";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private michaL.Anzeige.TonAnzeige tonAnzeige1;
		private System.Windows.Forms.Button btn_Verlassen;
		private System.Windows.Forms.Label lbl_Methode;
		private System.Windows.Forms.Label label4;
	}
}