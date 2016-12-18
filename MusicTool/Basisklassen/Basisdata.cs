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

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Basisdata
	/// <para>Basisklasse für alle Datensätze mit 1 Namen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	/// <remarks> Getestet:
	/// <para>Konstruktor - getestet am      : 2016-12-14  19:24:23</para>
	/// <para>Name - getestet am      : 2016-12-14  19:24:23</para>
	/// <para>ID - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>Typ - getestet am      : 2016-12-14  20:23:30</para>
	/// </remarks>
	public class bcl_Basisdata
	{
		#region VersionInfo

		private static string zz_klassenName= "Basisdata";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Basisdaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "4";
		private static string zz_letzteBearbeitung= "2016-12-17  14:16:13";
		private static string zz_ersteBearbeitung= "2016-11-06 12:35.35";
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
		/// <summary>_name
		/// <para>lbl_Name der Instanz</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		private string _name;

		/// <summary>_id
		/// <para>ID der Instanz</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		private int _id;

		/// <summary>_typ
		/// <para>Datentyp der Instanz</para>
		/// <para></para>
		/// TYP: <b><i>dType</i></b>
		/// </summary>
		private dType _typ;

		private string KLASSE = "Basisklassen.bcl_Basisdata";

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name, typ,id)
		/// <para>instanziiert die Instanz</para>
		/// </summary>
		/// <param name="name">lbl_Name des Objekts, TYP: <b><i>STRING</i></b></param>
		/// <param name="typ">Typ der Klasse, TYP: <b><i>dType</i></b></param>
		/// <param name="id">ID des Objekts, TYP: <b><i>INT</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  14:15:58</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:46:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public bcl_Basisdata( string name , dType typ , int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name, typ,id)";
#if INIT
			wnd_StatusOn ein = new wnd_StatusOn( MethodenName );
#endif //INIT
#if EINGABE
			Anz_Basisdata info = new Anz_Basisdata(MethodenName, name,typ,id );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			_name = name;
			_typ = typ;
			_id = id;
			#region DEBUG_INFO
#if TEST
#if INIT
			wnd_StatusOff aus = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: ID
		/// <para>gibt die ID der Instanz aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-11-24  13:16:48</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:50:10</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public int ID
		{
			get { return _id; }
		}

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Typ des Datensatzes aus</para>
		/// <para></para>
		/// TYP: <b><i>dType</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-06  15:52:41</para>
		/// <para>    ersteBearbeitung : 2016-11-06  15:52:41</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public dType Typ
		{
			get { return _typ; }
		}

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen des Objekts aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-06  12:51:49</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:51:49</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:24:23</para>
		/// </remarks>
		public string Name
		{
			get { return _name; }
		}

		#endregion Eigenschaften
	}
}