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
#define INIT
/* diverse Informationen anzeigen 
#undef INIT
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

namespace MusicTool.Datenbanken.Datensätze
{
	/// <summary> Klasse       : ds_Intervall
	/// <para></para>
	/// ABGELEITET VON: <b><i>bcl_Basisdata2&lt;T&gt;</i></b>
	/// <para>Datensatz für Intervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Intervall : bcl_Basisdata2
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Intervall";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Intervalldaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "4";
		private static string zz_letzteBearbeitung= "2016-12-17  15:08:42";
		private static string zz_ersteBearbeitung= "2016-11-12 19:26.39";
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
		public static new string VersionInfo()
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

		/// <summary>_intervallID
		/// <para>ID des Intervalls</para>
		/// <para></para>
		/// TYP: <b><i>eIntervall</i></b>
		/// </summary>
		private eIntervall _intervallID;

		/// <summary>_basisIntervall
		/// <para>Basis-Intervall</para>
		/// <para></para>
		/// TYP: <b><i>eBasisIntervall</i></b>
		/// </summary>
		private eBasisIntervall _basisIntervall;

		private string KLASSE = "Datenbanken.Datensätze.ds_Intervall";

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,altName,id,basisIntervall)
		/// <para>instanziiert die Klasse mit:</para>
		/// <para>- lbl_Name des Intervalls</para>
		/// <para>- alternativer lbl_Name des Intervalls</para>
		/// <para>- ID des Intervalls in der Datenbank DB_Intervalle</para>
		/// <para>- Basis-Intervall</para>
		/// </summary>
		/// <param name="name">lbl_Name des Intervalls, TYP: <b><i>STRING</i></b></param>
		/// <param name="altName">alternativer lbl_Name des Intervalls, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID des Intervalls in der Datenbank DB_Intervalle, TYP: <b><i>eIntervall</i></b></param>
		/// <param name="bas">Basis-Intervall, TYP: <b><i>eBasisIntervall</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  15:07:59</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:35:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Intervall( string name , string altName , eIntervall id , eBasisIntervall bas ) :
			base( name , altName , (int)id , dType.Intervalldaten )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name,altName,id,basisIntervall)";
#if INIT
			wnd_StatusOn ein = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_intervallID = id;
			_basisIntervall = bas;
			#region DEBUG_INFO
#if TEST
#if INIT
			Anz_IntervallData info = new Anz_IntervallData(MethodenName, name,altName,id,bas );
			wnd_StatusOff aus = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: IntervallName
		/// <para>gibt den Intervall-Namen aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:40:34</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:40:34</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public string IntervallName { get { return Name; } }

		/// <summary> Eigenschaft: AltIntervallName
		/// <para>gibt den alternativen Intervall-Namen aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:41:59</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:40:34</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public string AltIntervallName { get { return Name; } }

		/// <summary> Eigenschaft: IntervallID
		/// <para>gibt die IntervallID aus</para>
		/// <para></para>
		/// TYP: <b><i>eIntervall</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  12:23:39</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:43:00</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public eIntervall IntervallID { get { return _intervallID; } }

		/// <summary> Eigenschaft: BasisIntervall
		/// <para>gibt das BasisIntervall aus</para>
		/// <para></para>
		/// TYP: <b><i>eBasisIntervall</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:44:33</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:44:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public eBasisIntervall BasisIntervall { get { return _basisIntervall; } }

		/// <summary> Eigenschaft: IntBasisIntervall
		/// <para>gibt das BasisIntervall als INT aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:44:33</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:44:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public eBasisIntervall IntBasisIntervall { get { return _basisIntervall; } }

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}