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

namespace MusicTool.Fenster.Testanzeigen
{
	/// <summary> Klasse       : <b>Anz_Ton_Objekt
	/// </b><para></para>
	/// <para> Zeig den Inhalt des übergebenen Ton-Objekts an.
	/// </para>
	/// <b><i> </i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public partial class Anz_Ton_Objekt : Form
	{
		#region VersionInfo

		private static string zz_klassenName= "Anz_Ton_Objekt";
		private static string zz_namespace = "MusicTool.Fenster.Testanzeigen";
		private static dType zz_datenTyp = dType.InfoFenster;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-12-11 14:43.18";
		private static string zz_ersteBearbeitung= "2016-12-11 14:43.18";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		/// <summary> Methode: VersionInfo()
		/// <para>gibt Infos zur Version aus</para>
		/// </summary>
		/// <returns>Versions-Infos</returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-23  18:30:44</para>
		/// <para>    ersteBearbeitung : 2016-11-23  18:30:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static string VersionInfo()
		{
			string ausgabe = "";
			string neueZeile = "/n";
			ausgabe += zz_klassenName + neueZeile;
			ausgabe += zz_namespace + neueZeile;
			ausgabe += zz_datenTyp.ToString() + neueZeile;
			ausgabe += zz_getestet + neueZeile;
			ausgabe += zz_Pfad + neueZeile;
			ausgabe += zz_VersionInfo + neueZeile;
			ausgabe += zz_letzteBearbeitung + neueZeile;
			ausgabe += zz_ersteBearbeitung + neueZeile;
			ausgabe += "---------------------------------" + neueZeile;
			return ausgabe;
		}
		/// <summary> Eigenschaft: zz_Pfad
		/// <para>gibt den Pfad (Namespace + Klassenname) aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:33:31</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:33:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		/// <summary> Eigenschaft: zz_VersionInfo
		/// <para>gibt die Version der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:34:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:34:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		string titel_bas = "Ton: ";

		/// <summary> Konstruktor(methode,tonObj)
		/// <para>erstellt das Fenster mit den Daten des übergebenen Ton-Objekts</para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="tonObj">darzustellendes Ton-Objekt, TYP: ds_Ton</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-11  14:41:10</para>
		/// <para>    ersteBearbeitung : 2016-12-11  14:41:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_Ton_Objekt( string methode , ds_Ton tonObj)
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			grb_Ton.Text = titel_bas + tonObj.TonName;
			lblW_Name.Text = tonObj.Name;
			lblW_ID.Text = tonObj.TonID.ToString();
			lblW2_ID.Text = tonObj.ID.ToString();
			lblW_Grundton.Text = tonObj.Grundton.ToString();
			lblW2_Grundton.Text = tonObj.IntGrundton.ToString();
			lblW_enhU.Text = tonObj.EnhU.ToString();
			lblW2_enhU.Text = tonObj.IntEnhU.ToString();
			lblW_enhO.Text = tonObj.EnhO.ToString();
			lblW2_enhO.Text = tonObj.IntEnhO.ToString();

			ShowDialog();
		}

		/// <summary> Methode: btn_Verlassen_Click ...
		/// <para>wird durch den Button VERLASSEN aufgerufen,</para>
		/// Ist zum Verlassen des Fensters
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-11  14:46:19</para>
		/// <para>    ersteBearbeitung : 2016-12-11  14:46:19</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
