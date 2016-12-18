namespace MusicTool.Fenster.Testanzeigen
{
	partial class wnd_Info
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
			this.Zeile1 = new System.Windows.Forms.Label();
			this.Zeile2 = new System.Windows.Forms.Label();
			this.Zeile3 = new System.Windows.Forms.Label();
			this.Zeile4 = new System.Windows.Forms.Label();
			this.lbl_Methode = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Verlassen
			// 
			this.btn_Verlassen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Verlassen.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Verlassen.Location = new System.Drawing.Point(12, 47);
			this.btn_Verlassen.Name = "btn_Verlassen";
			this.btn_Verlassen.Size = new System.Drawing.Size(102, 34);
			this.btn_Verlassen.TabIndex = 0;
			this.btn_Verlassen.Text = "OK";
			this.btn_Verlassen.UseVisualStyleBackColor = false;
			this.btn_Verlassen.Click += new System.EventHandler(this.btn_Verlassen_Click);
			// 
			// Zeile1
			// 
			this.Zeile1.AutoSize = true;
			this.Zeile1.BackColor = System.Drawing.Color.Silver;
			this.Zeile1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Zeile1.Location = new System.Drawing.Point(13, 88);
			this.Zeile1.Name = "Zeile1";
			this.Zeile1.Size = new System.Drawing.Size(46, 20);
			this.Zeile1.TabIndex = 5;
			this.Zeile1.Text = "Zeile1";
			// 
			// Zeile2
			// 
			this.Zeile2.AutoSize = true;
			this.Zeile2.BackColor = System.Drawing.Color.Silver;
			this.Zeile2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Zeile2.Location = new System.Drawing.Point(13, 117);
			this.Zeile2.Name = "Zeile2";
			this.Zeile2.Size = new System.Drawing.Size(46, 20);
			this.Zeile2.TabIndex = 6;
			this.Zeile2.Text = "Zeile2";
			// 
			// Zeile3
			// 
			this.Zeile3.AutoSize = true;
			this.Zeile3.BackColor = System.Drawing.Color.Silver;
			this.Zeile3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Zeile3.Location = new System.Drawing.Point(13, 146);
			this.Zeile3.Name = "Zeile3";
			this.Zeile3.Size = new System.Drawing.Size(46, 20);
			this.Zeile3.TabIndex = 7;
			this.Zeile3.Text = "Zeile3";
			// 
			// Zeile4
			// 
			this.Zeile4.AutoSize = true;
			this.Zeile4.BackColor = System.Drawing.Color.Silver;
			this.Zeile4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Zeile4.Location = new System.Drawing.Point(13, 176);
			this.Zeile4.Name = "Zeile4";
			this.Zeile4.Size = new System.Drawing.Size(46, 20);
			this.Zeile4.TabIndex = 8;
			this.Zeile4.Text = "Zeile4";
			// 
			// lbl_Methode
			// 
			this.lbl_Methode.AutoSize = true;
			this.lbl_Methode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Methode.Location = new System.Drawing.Point(14, 25);
			this.lbl_Methode.Name = "lbl_Methode";
			this.lbl_Methode.Size = new System.Drawing.Size(54, 19);
			this.lbl_Methode.TabIndex = 12;
			this.lbl_Methode.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Ausführend: ";
			// 
			// wnd_Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(696, 116);
			this.Controls.Add(this.lbl_Methode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Zeile4);
			this.Controls.Add(this.Zeile3);
			this.Controls.Add(this.Zeile2);
			this.Controls.Add(this.Zeile1);
			this.Controls.Add(this.btn_Verlassen);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "wnd_Info";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Info:";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Verlassen;
		private System.Windows.Forms.Label Zeile1;
		private System.Windows.Forms.Label Zeile2;
		private System.Windows.Forms.Label Zeile3;
		private System.Windows.Forms.Label Zeile4;
		private System.Windows.Forms.Label lbl_Methode;
		private System.Windows.Forms.Label label4;
	}
}