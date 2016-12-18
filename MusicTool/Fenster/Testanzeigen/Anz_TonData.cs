using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken;
using MusicTool.Datenbanken.Datensätze;
using MusicTool.Eingabe;
using MusicTool.Fenster;
using MusicTool.Fenster.Testanzeigen;

namespace MusicTool.Fenster.Testanzeigen
{
	public partial class Anz_TonData : Form
	{
		/// <summary> Konstruktor(methode,name,id,grundton,enhU,enhO)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="name">Name des Tons, TYP: STRING</param>
		/// <param name="id">ID des Tons, TYP: eTon</param>
		/// <param name="grundton">Grundton, TYP: eGrundton</param>
		/// <param name="enhU">untere enharm. Verwechselung, TYP: eTon</param>
		/// <param name="enhO">obere enharm. Verwechselung, TYP: eTon</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:37:19</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:37:19</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_TonData( string methode , string name,eTon id,eGrundton grundton,eTon enhU,eTon enhO)
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			tonAnzeige1.TonName = name;
			tonAnzeige1.TonID = id.ToString();
			tonAnzeige1.grundton = grundton.ToString();
			tonAnzeige1.enhU = enhU.ToString();
			tonAnzeige1.enhO = enhO.ToString();

			ShowDialog();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
