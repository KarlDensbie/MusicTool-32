#define TEST
/* genereller Schalter zum Testen
#undef TEST
*/
#define EINGABE
/* eingegebene Werte anzeigen
#undef EINGABE
*/
#define START
/* Start bzw. Ende von Methoden anzeigen
#undef START
*/
#define AUSGABE
/* Ausgabe-Werte anzeigen
#undef AUSGABE
*/
#define ZWISCHENWERTE
/* Zwischenergebnisse anzeigen
#undef ZWISCHENWERTE
*/
#define INFO
/* diverse Informationen anzeigen
#undef INFO
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken;
using MusicTool.Datenbanken.Datensätze;
using MusicTool.Eingabe;
using MusicTool.Fenster;
using MusicTool.Fenster.Testanzeigen;

namespace MusicTool._TEST
{
	/// <summary> Klasse       : <b>Teste_TonDB
	/// </b><para></para>
	/// <para>testet die Ton_DB
	/// </para>
	/// <b><i> </i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class Teste_TonDB
	{
		#region VersionInfo

		private static string zz_klassenName= "Teste_TonDB";
		private static string zz_namespace = "MusicTool._TEST";
		private static dType zz_datenTyp = dType.TEST;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-12-14 14:07.20";
		private static string zz_ersteBearbeitung= "2016-12-14 14:07.20";
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

		#region Attribute

		private static List<string> Tonliste = new List<string>();
		private static ds_Ton aktTon;
		private static ds_Ton tmpTon;

		#endregion Attribute

		#region Konstruktor

		static Teste_TonDB()
		{
			Tonliste.Add( "C" );
			Tonliste.Add( "E" );
			Tonliste.Add( "G" );
			Tonliste.Add( "B" );
		}

		#endregion Konstruktor

		#region Eigenschaften

		#endregion Eigenschaften

		#region Methoden

		public static void START()
		{
			int _intwert;
			string _aktGesucht;
			int _id;
			dType _typ;
			string _name;
			eTon _tonID;
			eGrundton _grundton;
			_name = DB_Töne.Name;
			_typ = DB_Töne.Typ;
			for( int a = 0 ; a < Tonliste.Count ; a++ ) {
				_aktGesucht = Tonliste[a];
				aktTon = DB_Töne.findTon( _aktGesucht );
				tmpTon = aktTon.enhO();
				_id = tmpTon.ID;
				_typ = tmpTon.Typ;
				_tonID = tmpTon.TonID;
				_grundton = tmpTon.Grundton;
				_intwert = tmpTon.IntGrundton;
				_tonID = tmpTon.EnhU;
				_intwert = tmpTon.IntEnhU;
				_tonID = tmpTon.EnhO;
				_intwert = tmpTon.IntEnhO;
				tmpTon = aktTon.enhU();
			}
		}

		#endregion Methoden
	}
}
