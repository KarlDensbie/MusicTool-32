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
	public partial class Anz_Basisdata : Form
	{
		/// <summary> Konstruktor(methode,name,typ,id)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="name">Name des Datensatzes, TYP: STRING</param>
		/// <param name="typ">Typ der Daten, TYP: dType</param>
		/// <param name="id">ID des Datensatzes, TYP: INT</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:25:09</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:25:09</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_Basisdata( string methode , string name , dType typ , int id )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			lbl_Name.Text = name;
			lbl_Typ.Text = typ.ToString();
			lbl_ID.Text = id.ToString();
			lbl_altNameTitel.Visible = false;
			lbl_AltName.Visible = false;

			ShowDialog();
		}

		/// <summary> Konstruktor(methode,name,altName,typ,id)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="name">Name des Datensatzes, TYP: STRING</param>
		/// <param name="altName">alternativer Name des Datensatzes, TYP: STRING</param>
		/// <param name="typ">Typ der Daten, TYP: dType</param>
		/// <param name="id">ID des Datensatzes, TYP: INT</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:25:09</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:25:09</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_Basisdata( string methode , string name ,string altName , dType typ , int id )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			lbl_Name.Text = name;
			lbl_Typ.Text = typ.ToString();
			lbl_ID.Text = id.ToString();
			lbl_AltName.Text = altName;

			ShowDialog();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
