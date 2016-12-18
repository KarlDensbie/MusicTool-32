using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTool.Fenster.Testanzeigen
{
	public partial class wnd_Info : Form
	{
		/// <summary> Konstruktor(methode,info1)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="info1">1.Infozeile, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:42:59</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:42:59</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_Info( string methode , string info1 )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			Zeile1.Text = info1;
			Zeile2.Visible = false;
			Zeile3.Visible = false;
			Zeile4.Visible = false;
			this.ClientSize = new System.Drawing.Size( 696 , 116 ) ;

			ShowDialog();
		}

		/// <summary> Konstruktor(methode,info1,info2)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="info1">1.Infozeile, TYP: STRING</param>
		/// <param name="info2">2.Infozeile, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:42:59</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:42:59</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_Info( string methode , string info1 , string info2 )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			Zeile1.Text = info1;
			Zeile2.Text = info2;
			Zeile3.Visible = false;
			Zeile4.Visible = false;
			this.ClientSize = new System.Drawing.Size( 696 , 144 );

			ShowDialog();
		}

		/// <summary> Konstruktor(methode,info1,info2,info3)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="info1">1.Infozeile, TYP: STRING</param>
		/// <param name="info2">2.Infozeile, TYP: STRING</param>
		/// <param name="info3">3.Infozeile, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:42:59</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:42:59</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_Info( string methode , string info1 , string info2 , string info3 )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			Zeile1.Text = info1;
			Zeile2.Text = info2;
			Zeile3.Text = info3;
			Zeile4.Visible = false;
			this.ClientSize = new System.Drawing.Size( 696 , 174 );

			ShowDialog();
		}

		/// <summary> Konstruktor(methode,info1,info2,info3,info4)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="info1">1.Infozeile, TYP: STRING</param>
		/// <param name="info2">2.Infozeile, TYP: STRING</param>
		/// <param name="info3">3.Infozeile, TYP: STRING</param>
		/// <param name="info4">4.Infozeile, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:42:59</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:42:59</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_Info( string methode , string info1 , string info2 , string info3 , string info4 )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			Zeile1.Text = info1;
			Zeile2.Text = info2;
			Zeile3.Text = info3;
			Zeile4.Text = info4;
			this.ClientSize = new System.Drawing.Size( 696 , 203 );

			ShowDialog();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
