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
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken;
using MusicTool.Datenbanken.Datensätze;
using MusicTool.Eingabe;
using MusicTool.Fenster;
using MusicTool.Fenster.Testanzeigen;

namespace MusicTool.Datenbanken.Datensätze
{
	/// <summary> Klasse       : ds_Ton
	/// <para></para>
	/// ABGELEITET VON: <b><i>bcl_Basisdata&lt;T&gt;</i></b>
	/// <para>Datensatz für einen Ton</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : 2016-12-14  21:22:55</para>
	/// </summary>
	/// <remarks> Getestet:
	/// <para>Konstruktor -  getestet am      : 2016-12-14  19:24:23</para>
	/// <para>TonName - getestet am      : 2016-12-14  19:24:23</para>
	/// <para>TonID - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>Grundton - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>IntGrundton - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>EnhU - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>IntEnhU - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>EnhO - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>IntEnhO - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>enhU() - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>enhO() - getestet am      : 2016-12-14  20:23:30</para>
	/// </remarks>
	public class ds_Ton : bcl_Basisdata
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Ton";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Tondaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "5";
		private static string zz_letzteBearbeitung= "2016-12-17  15:03:33";
		private static string zz_ersteBearbeitung= "2016-11-12 16:31.31";
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

		/// <summary>_tonID
		/// <para>ID des Tons in der Datenbank DB_Töne</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		private eTon _tonID;

		/// <summary>_grundton
		/// <para>Grundton des Tons (Tonfamilie)</para>
		/// <para></para>
		/// TYP: <b><i>eGrundton</i></b>
		/// </summary>
		private eGrundton _grundton;

		/// <summary>_enhU
		/// <para>ID der unteren enharmonischen Verwechselung</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		private eTon _enhU;

		/// <summary>_enhO
		/// <para>ID der oberen enharmonischen Verwechselung</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		private eTon _enhO;

		private string KLASSE = "Datenbanken.Datensätze.ds_Ton";

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,id,grundTon,enhU,enhO)
		/// <para>instanziiert die Klasse mit:</para>
		/// <para>- lbl_Name des Tons,</para>
		/// <para>- ID des Tons,</para>
		/// <para>- Grundton,</para>
		/// <para>- unterer enharmonischer Verwechselung des Tons,</para>
		/// <para>- oberer enharmonischer Verwechselung des Tons</para>
		/// </summary>
		/// <param name="name">lbl_Name des Tons, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID des Tons in der Datenbank DB_Töne, TYP: <b><i>eTon</i></b></param>
		/// <param name="grundTon">Grundton des Tons (Tonfamilie), TYP: <b><i>eGrundton</i></b></param>
		/// <param name="enhU">ID der unteren enharmonischen Verwechselung, TYP: <b><i>eTon</i></b></param>
		/// <param name="enhO">ID der oberen enharmonischen Verwechselung, TYP: <b><i>eTon</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  14:07:45</para>
		/// <para>    letzteBearbeitung: 2016-12-17  14:57:35</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:24:23</para>
		/// </remarks>
		public ds_Ton( string name , eTon id , eGrundton grundTon , eTon enhU , eTon enhO ) :
			base( name , dType.Tondaten , (int)id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name,id,grundTon,enhU,enhO)";
#if INIT
			wnd_StatusOn ein = new wnd_StatusOn( MethodenName );
#endif //INIT
#endif //TEST
			#endregion DEBUG_INFO
			_tonID = id;
			_grundton = grundTon;
			_enhO = enhO;
			_enhU = enhU;
			#region DEBUG_INFO
#if TEST
#if INIT
			Anz_Ton_Objekt info = new Anz_Ton_Objekt(MethodenName, this );
			wnd_StatusOff aus = new wnd_StatusOff( MethodenName );
#endif //INIT
#endif //TEST
			#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: TonName
		/// <para>gibt den Namen des Tons aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:05:23</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:05:23</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:24:23</para>
		/// </remarks>
		public string TonName
		{
			get { return Name; }
		}

		/// <summary> Eigenschaft: TonID
		/// <para>gibt den Ton-ID als eTon aus</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  12:20:44</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:07:54</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public eTon TonID
		{
			get { return _tonID; }
		}

		/// <summary> Eigenschaft: Grundton
		/// <para>gibt den Grundton als eGrundton aus</para>
		/// <para></para>
		/// TYP: <b><i>eGrundton</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:09:54</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:09:54</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public eGrundton Grundton
		{
			get { return _grundton; }
		}

		/// <summary> Eigenschaft: IntGrundton
		/// <para>gibt den Grundton als INT aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:12:10</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:09:54</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public int IntGrundton
		{
			get { return (int)_grundton; }
		}

		/// <summary> Eigenschaft: EnhU
		/// <para>gibt den Ton-ID der unteren enharmonischen Verwechselung als eTon aus</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public eTon EnhU
		{
			get { return _enhU; }
		}

		/// <summary> Eigenschaft: IntEnhU
		/// <para>gibt den Ton-ID der unteren enharmonischen Verwechselung als INT aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public int IntEnhU
		{
			get { return (int)_enhU; }
		}

		/// <summary> Eigenschaft: EnhO
		/// <para>gibt den Ton-ID der oberen enharmonischen Verwechselung als eTon aus</para>
		/// <para></para>
		/// TYP: <b><i>eTon</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public eTon EnhO { get { return _enhO; } }

		/// <summary> Eigenschaft: IntEnhO
		/// <para>gibt den Ton-ID der oberen enharmonischen Verwechselung als INT aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public int IntEnhO
		{
			get { return (int)_enhO; }
		}

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: enhU()
		/// <para>gibt die untere enharmonische Verwechselung als Ton-Objekt aus</para>
		/// </summary>
		/// <returns>Ton-Objekt, TYP: <b><i>ds_Ton</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  14:59:06</para>
		/// <para>    ersteBearbeitung : 2016-11-23  13:59:22</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public ds_Ton enhU()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".enhU()";
#if START
			wnd_StatusOn ein = new wnd_StatusOn( MethodenName );
#endif //START
#endif //TEST
			#endregion DEBUG_INFO
			ds_Ton ausgabe = DB_Töne.getTon( _enhU );
			#region DEBUG_INFO
#if TEST

#if AUSGABE
			Anz_Ton_Objekt info = new Anz_Ton_Objekt(MethodenName, ausgabe );
#endif //AUSGABE
			#if START
			wnd_StatusOff aus = new wnd_StatusOff( MethodenName );
#endif //START
			#endif //TEST
#endregion DEBUG_INFO
			return ausgabe;
		}

		/// <summary> Methode: enhO()
		/// <para>gibt die obere enharmonische Verwechselung als Ton-Objekt aus</para>
		/// </summary>
		/// <returns>Ton-Objekt, TYP: <b><i>ds_Ton</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  15:00:05</para>
		/// <para>    ersteBearbeitung : 2016-11-23  14:02:03</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </remarks>
		public ds_Ton enhO()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".enhO()";
#if START
			wnd_StatusOn ein = new wnd_StatusOn( MethodenName );
#endif //START
#endif //TEST
			#endregion DEBUG_INFO
			ds_Ton ausgabe = DB_Töne.getTon( _enhO );
			#region DEBUG_INFO
#if TEST

#if AUSGABE
			Anz_Ton_Objekt info = new Anz_Ton_Objekt(MethodenName, ausgabe );
#endif //AUSGABE
#if START
			wnd_StatusOff aus = new wnd_StatusOff( MethodenName );
#endif //START
#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		#endregion Methoden
	}
}
