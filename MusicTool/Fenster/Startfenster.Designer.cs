namespace MusicTool.Fenster
{
	partial class Startfenster
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
			this.btn_TestTonDB = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_TestTonDB
			// 
			this.btn_TestTonDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_TestTonDB.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TestTonDB.Location = new System.Drawing.Point(13, 13);
			this.btn_TestTonDB.Name = "btn_TestTonDB";
			this.btn_TestTonDB.Size = new System.Drawing.Size(127, 34);
			this.btn_TestTonDB.TabIndex = 0;
			this.btn_TestTonDB.Text = "Teste Ton-DB";
			this.btn_TestTonDB.UseVisualStyleBackColor = false;
			this.btn_TestTonDB.Click += new System.EventHandler(this.btn_TestTonDB_Click);
			// 
			// Startfenster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btn_TestTonDB);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "Startfenster";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Startfenster";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_TestTonDB;
	}
}