namespace michaL.Musik.Anzeigen.IntervallAnzeige
{
	partial class Anzeigebereich_Intervall
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.grb_Intervall = new System.Windows.Forms.GroupBox();
			this.lbl_BasisIntervall = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_ID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_AltName = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.grb_Intervall.SuspendLayout();
			this.SuspendLayout();
			// 
			// grb_Intervall
			// 
			this.grb_Intervall.AutoSize = true;
			this.grb_Intervall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.grb_Intervall.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.grb_Intervall.Controls.Add( this.lbl_BasisIntervall );
			this.grb_Intervall.Controls.Add( this.label2 );
			this.grb_Intervall.Controls.Add( this.lbl_ID );
			this.grb_Intervall.Controls.Add( this.label1 );
			this.grb_Intervall.Controls.Add( this.lbl_AltName );
			this.grb_Intervall.Controls.Add( this.lbl_Name );
			this.grb_Intervall.Font = new System.Drawing.Font( "Arial Narrow" , 9.75F , ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.grb_Intervall.Location = new System.Drawing.Point( 0 , 0 );
			this.grb_Intervall.Name = "grb_Intervall";
			this.grb_Intervall.Size = new System.Drawing.Size( 132 , 113 );
			this.grb_Intervall.TabIndex = 0;
			this.grb_Intervall.TabStop = false;
			this.grb_Intervall.Text = "Intervall:";
			// 
			// lbl_BasisIntervall
			// 
			this.lbl_BasisIntervall.AutoSize = true;
			this.lbl_BasisIntervall.Font = new System.Drawing.Font( "Arial" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.lbl_BasisIntervall.Location = new System.Drawing.Point( 99 , 76 );
			this.lbl_BasisIntervall.Name = "lbl_BasisIntervall";
			this.lbl_BasisIntervall.Size = new System.Drawing.Size( 27 , 19 );
			this.lbl_BasisIntervall.TabIndex = 8;
			this.lbl_BasisIntervall.Text = "itv";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font( "Arial Narrow" , 9.75F , ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.label2.Location = new System.Drawing.Point( 6 , 79 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 87 , 16 );
			this.label2.TabIndex = 7;
			this.label2.Text = "Basis-Intervall:";
			// 
			// lbl_ID
			// 
			this.lbl_ID.AutoSize = true;
			this.lbl_ID.Font = new System.Drawing.Font( "Arial" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.lbl_ID.Location = new System.Drawing.Point( 99 , 61 );
			this.lbl_ID.Name = "lbl_ID";
			this.lbl_ID.Size = new System.Drawing.Size( 25 , 19 );
			this.lbl_ID.TabIndex = 6;
			this.lbl_ID.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font( "Arial Narrow" , 9.75F , ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.label1.Location = new System.Drawing.Point( 70 , 63 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 23 , 16 );
			this.label1.TabIndex = 5;
			this.label1.Text = "ID:";
			// 
			// lbl_AltName
			// 
			this.lbl_AltName.AutoSize = true;
			this.lbl_AltName.Font = new System.Drawing.Font( "Arial" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.lbl_AltName.Location = new System.Drawing.Point( 6 , 37 );
			this.lbl_AltName.Name = "lbl_AltName";
			this.lbl_AltName.Size = new System.Drawing.Size( 62 , 19 );
			this.lbl_AltName.TabIndex = 2;
			this.lbl_AltName.Text = "Name2";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Font = new System.Drawing.Font( "Arial" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte)( 0 ) ) );
			this.lbl_Name.Location = new System.Drawing.Point( 6 , 18 );
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size( 53 , 19 );
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "Name";
			// 
			// Anzeige
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add( this.grb_Intervall );
			this.Name = "Anzeige";
			this.Size = new System.Drawing.Size( 135 , 116 );
			this.grb_Intervall.ResumeLayout( false );
			this.grb_Intervall.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grb_Intervall;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Label lbl_AltName;
		private System.Windows.Forms.Label lbl_BasisIntervall;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_ID;
		private System.Windows.Forms.Label label1;
	}
}
