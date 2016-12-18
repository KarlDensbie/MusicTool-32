namespace MusicTool.Fenster.Testanzeigen
{
	partial class wnd_StatusOff
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
			this.button1 = new System.Windows.Forms.Button();
			this.anzeigebereich1 = new michaL.Anzeigen.Anzeigebereich_NameWert();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(9, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// anzeigebereich1
			// 
			this.anzeigebereich1.AutoSize = true;
			this.anzeigebereich1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.anzeigebereich1.BackColor = System.Drawing.Color.LemonChiffon;
			this.anzeigebereich1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anzeigebereich1.Location = new System.Drawing.Point(13, 13);
			this.anzeigebereich1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.anzeigebereich1.Name = "anzeigebereich1";
			this.anzeigebereich1.Size = new System.Drawing.Size(71, 50);
			this.anzeigebereich1.TabIndex = 0;
			this.anzeigebereich1.TabStop = false;
			// 
			// wnd_StatusOff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(528, 118);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.anzeigebereich1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "wnd_StatusOff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "StausOn";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private michaL.Anzeigen.Anzeigebereich_NameWert  anzeigebereich1;
	}
}