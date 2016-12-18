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

namespace MusicTool.Datenbanken
{
	/// <summary> Klasse       : <b>DB_Tonarten
	/// </b><para></para>
	/// <i>STATISCHE KLASSE</i>
	/// <para>Datenbank der Tonarten
	/// </para>
	/// <b><i> </i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Tonarten
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Tonarten";
		private static string zz_namespace = "MusicTool.Datenbanken";
		private static dType zz_datenTyp = dType.DB_Tonarten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-12-17  18:02:40";
		private static string zz_ersteBearbeitung= "2016-11-24 13:48.00";
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

		/// <summary>_liste
		/// <para>Liste der Tonarten</para>
		/// TYP: <b><i>List&lt;ds_Tonart&gt;</i></b>
		/// </summary>
		private static List<ds_Tonart> _liste;

		/// <summary>tmpTA
		/// <para>temporäre Tonart zur Initialisierung</para>
		/// TYP: <b><i>ds_Tonart</i></b>
		/// </summary>
		private static ds_Tonart tmpTA;

		private static string KLASSE = "Datenbanken.DB_Tonarten";

		private static wnd_StatusOn MethodeStart;
		private static wnd_StatusOff MethodeEnde;
		private static wnd_Info MethodeInfo;
		private static Anz_Ton_Objekt AnzeigeTonObjekt;
		private static Anz_TonData AnzeigeTonData;
		private static Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private static Anz_IntervallData AnzeigeIntervallData;
		private static Anz_TonartData AnzeigeTonartData;

		#endregion Attribute

		#region Konstruktor

		/// <summary>  Standardkonstruktor()
		/// <para>initialisiert die Datenbank</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  16:36:42</para>
		/// <para>    ersteBearbeitung : 2016-11-24  14:00:12</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		static DB_Tonarten()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"()";
#if INIT
			MethodeStart = new Fenster.Testanzeigen.wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste = new List<ds_Tonart>();

			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "Die Initialisierung beginnt ..." );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			INIT();
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "... Die Initialisierung wurde beendet" );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die gesamte Datenbank</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  17:36:14</para>
		/// <para>    ersteBearbeitung : 2016-11-24  14:05:11</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static void INIT()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".INIT()";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO

			#region C
			tmpTA = erzeugeTonart( "C" , eTonart.C );
			tmpTA.ADD( AddTon( eTon.C ) );          // Prime
			tmpTA.ADD( AddTon( eTon.Des ) );    // kl. None
			tmpTA.ADD( AddTon( eTon.D ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.Dis ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.Es ) );     // kl. Terz
			tmpTA.ADD( AddTon( eTon.E ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Fes ) );    // verm. Undezime
			tmpTA.ADD( AddTon( eTon.F ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.Fis ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Ges ) );    // verm. Quinte
			tmpTA.ADD( AddTon( eTon.G ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.Gis ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.As ) );     // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.A ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Heses ) );  // verm. Sept
			tmpTA.ADD( AddTon( eTon.B ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.H ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion C
			#region C#
			tmpTA = erzeugeTonart( "C#" , eTonart.Cis );
			tmpTA.ADD( AddTon( eTon.Cis ) );    // Prime
			tmpTA.ADD( AddTon( eTon.D ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Dis ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Disis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.E ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.Eis ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.F ) );      // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Fis ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // überm. Undezime
			tmpTA.ADD( AddTon( eTon.G ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Gis ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Gisis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.A ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Ais ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.B ) );      // verm. Sept
			tmpTA.ADD( AddTon( eTon.H ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.His ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion C#

			#region Db
			tmpTA = erzeugeTonart( "Db" , eTonart.Des );
			tmpTA.ADD( AddTon( eTon.Des ) );    // Prime
			tmpTA.ADD( AddTon( eTon.Eses ) );   // kl. None
			tmpTA.ADD( AddTon( eTon.Es ) );     // gr. None
			tmpTA.ADD( AddTon( eTon.E ) );      // überm. None
			tmpTA.ADD( AddTon( eTon.Fes ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.F ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Geses ) );  // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Ges ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.G ) );      // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Ases ) );   // verm. Quinte
			tmpTA.ADD( AddTon( eTon.As ) );     // Quinte
			tmpTA.ADD( AddTon( eTon.A ) );      // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Heses ) );  // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.B ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Ceses ) );  // verm. Sept
			tmpTA.ADD( AddTon( eTon.Ces ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.C ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion Db
			#region D
			tmpTA = erzeugeTonart( "D" , eTonart.D );
			tmpTA.ADD( AddTon( eTon.D ) );    // Prime
			tmpTA.ADD( AddTon( eTon.Es ) );   // kl. None
			tmpTA.ADD( AddTon( eTon.E ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Eis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.F ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.Fis ) );  // gr. Terz
			tmpTA.ADD( AddTon( eTon.Ges ) );  // verm. Undezime
			tmpTA.ADD( AddTon( eTon.G ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.Gis ) );  // überm. Undezime
			tmpTA.ADD( AddTon( eTon.As ) );   // verm. Quinte
			tmpTA.ADD( AddTon( eTon.A ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Ais ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.B ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.H ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Ces ) );  // verm. Sept
			tmpTA.ADD( AddTon( eTon.C ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.Cis ) );  // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion D
			#region D#
			tmpTA = erzeugeTonart( "D#" , eTonart.Dis );
			tmpTA.ADD( AddTon( eTon.Dis ) );    // Prime
			tmpTA.ADD( AddTon( eTon.E ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Eis ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Eisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.Fis ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // gr. Terz
			tmpTA.ADD( AddTon( eTon.G ) );      // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Gis ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.Gisis ) );  // überm. Undezime
			tmpTA.ADD( AddTon( eTon.A ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Ais ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Aisis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.H ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.His ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.C ) );      // verm. Sept
			tmpTA.ADD( AddTon( eTon.Cis ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.Cisis ) );  // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion D#

			#region Eb
			tmpTA = erzeugeTonart( "Eb" , eTonart.Es );
			tmpTA.ADD( AddTon( eTon.Es ) );     // Prime
			tmpTA.ADD( AddTon( eTon.Fes ) );    // kl. None
			tmpTA.ADD( AddTon( eTon.F ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.Fis ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.Ges ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.G ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Ases ) );   // verm. Undezime
			tmpTA.ADD( AddTon( eTon.As ) );     // Undezime
			tmpTA.ADD( AddTon( eTon.A ) );      // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Heses ) );  // verm. Quinte
			tmpTA.ADD( AddTon( eTon.B ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.H ) );      // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Ces ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.C ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Deses ) );  // verm. Sept
			tmpTA.ADD( AddTon( eTon.Des ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.D ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion Eb
			#region E
			tmpTA = erzeugeTonart( "E" , eTonart.E );
			tmpTA.ADD( AddTon( eTon.E ) );      // Prime
			tmpTA.ADD( AddTon( eTon.F ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Fis ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.G ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.Gis ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.As ) );     // verm. Undezime
			tmpTA.ADD( AddTon( eTon.A ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.Ais ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.B ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.H ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.His ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.C ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Cis ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Des ) );    // verm. Sept
			tmpTA.ADD( AddTon( eTon.D ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.Dis ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion E

			#region F
			tmpTA = erzeugeTonart( "F" , eTonart.F );
			tmpTA.ADD( AddTon( eTon.F ) );      // Prime
			tmpTA.ADD( AddTon( eTon.Ges ) );    // kl. None
			tmpTA.ADD( AddTon( eTon.G ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.Gis ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.As ) );     // kl. Terz
			tmpTA.ADD( AddTon( eTon.A ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Heses ) );  // verm. Undezime
			tmpTA.ADD( AddTon( eTon.B ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.H ) );      // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Ces ) );    // verm. Quinte
			tmpTA.ADD( AddTon( eTon.C ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.Cis ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Des ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.D ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Eses ) );   // verm. Sept
			tmpTA.ADD( AddTon( eTon.Es ) );     // kl. Sept
			tmpTA.ADD( AddTon( eTon.E ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion F
			#region F#
			tmpTA = erzeugeTonart( "F#" , eTonart.Fis );
			tmpTA.ADD( AddTon( eTon.Fis ) );    // Prime
			tmpTA.ADD( AddTon( eTon.G ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Gis ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Gisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.A ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.Ais ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.B ) );      // verm. Undezime
			tmpTA.ADD( AddTon( eTon.H ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.His ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.C ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Cis ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Cisis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.D ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Dis ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Es ) );     // verm. Sept
			tmpTA.ADD( AddTon( eTon.E ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.Eis ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion F#

			#region Gb
			tmpTA = erzeugeTonart( "Gb" , eTonart.Ges );
			tmpTA.ADD( AddTon( eTon.Ges ) );    // Prime
			tmpTA.ADD( AddTon( eTon.Ases ) );    // kl. None
			tmpTA.ADD( AddTon( eTon.As ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.A ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.Heses ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.B ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.Ceses ) );    // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Ces ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.C ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Deses ) );    // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Des ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.D ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Eses ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Es ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Feses ) );    // verm. Sept
			tmpTA.ADD( AddTon( eTon.Fes ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.F ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion Gb
			#region G
			tmpTA = erzeugeTonart( "G" , eTonart.G );
			tmpTA.ADD( AddTon( eTon.G ) );      // Prime
			tmpTA.ADD( AddTon( eTon.As ) );     // kl. None
			tmpTA.ADD( AddTon( eTon.A ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.Ais ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.B ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.H ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Ces ) );    // verm. Undezime
			tmpTA.ADD( AddTon( eTon.C ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.Cis ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Des ) );    // verm. Quinte
			tmpTA.ADD( AddTon( eTon.D ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.Dis ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Es ) );     // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.E ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Fes ) );    // verm. Sept
			tmpTA.ADD( AddTon( eTon.F ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.Fis ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion G
			#region G#
			tmpTA = erzeugeTonart( "G#" , eTonart.Gis );
			tmpTA.ADD( AddTon( eTon.Gis ) );    // Prime
			tmpTA.ADD( AddTon( eTon.A ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Ais ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Aisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.H ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.His ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.C ) );      // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Cis ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.Cisis ) );  // überm. Undezime
			tmpTA.ADD( AddTon( eTon.D ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Dis ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Disis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.E ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Eis ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.F ) );      // verm. Sept
			tmpTA.ADD( AddTon( eTon.Fis ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion G#

			#region Ab
			tmpTA = erzeugeTonart( "Ab" , eTonart.As );
			tmpTA.ADD( AddTon( eTon.As ) );     // Prime
			tmpTA.ADD( AddTon( eTon.Heses ) );  // kl. None
			tmpTA.ADD( AddTon( eTon.B ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.H ) );      // überm. None
			tmpTA.ADD( AddTon( eTon.Ces ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.C ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Deses ) );  // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Des ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.D ) );      // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Eses ) );   // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Es ) );     // Quinte
			tmpTA.ADD( AddTon( eTon.E ) );      // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Fes ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.F ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Geses ) );  // verm. Sept
			tmpTA.ADD( AddTon( eTon.Ges ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.G ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion Ab
			#region A
			tmpTA = erzeugeTonart( "A" , eTonart.A );
			tmpTA.ADD( AddTon( eTon.A ) );      // Prime
			tmpTA.ADD( AddTon( eTon.B ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.H ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.His ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.C ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.Cis ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.Des ) );    // verm. Undezime
			tmpTA.ADD( AddTon( eTon.D ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.Dis ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Es ) );     // verm. Quinte
			tmpTA.ADD( AddTon( eTon.E ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.Eis ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.F ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Fis ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Ges ) );    // verm. Sept
			tmpTA.ADD( AddTon( eTon.G ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.Gis ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion A
			#region A#
			tmpTA = erzeugeTonart( "A#" , eTonart.Ais );
			tmpTA.ADD( AddTon( eTon.Ais ) );    // Prime
			tmpTA.ADD( AddTon( eTon.H ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.His ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Hisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.Cis ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.Cisis ) );  // gr. Terz
			tmpTA.ADD( AddTon( eTon.D ) );      // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Dis ) );    // Undezime
			tmpTA.ADD( AddTon( eTon.Disis ) );  // überm. Undezime
			tmpTA.ADD( AddTon( eTon.E ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Eis ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Eisis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Fis ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.G ) );      // verm. Sept
			tmpTA.ADD( AddTon( eTon.Gis ) );    // kl. Sept
			tmpTA.ADD( AddTon( eTon.Gisis ) );  // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion A#

			#region B
			tmpTA = erzeugeTonart( "B" , eTonart.B );
			tmpTA.ADD( AddTon( eTon.B ) );      // Prime
			tmpTA.ADD( AddTon( eTon.Ces ) );    // kl. None
			tmpTA.ADD( AddTon( eTon.C ) );      // gr. None
			tmpTA.ADD( AddTon( eTon.Cis ) );    // überm. None
			tmpTA.ADD( AddTon( eTon.Des ) );    // kl. Terz
			tmpTA.ADD( AddTon( eTon.D ) );      // gr. Terz
			tmpTA.ADD( AddTon( eTon.Eses ) );   // verm. Undezime
			tmpTA.ADD( AddTon( eTon.Es ) );     // Undezime
			tmpTA.ADD( AddTon( eTon.E ) );      // überm. Undezime
			tmpTA.ADD( AddTon( eTon.Fes ) );    // verm. Quinte
			tmpTA.ADD( AddTon( eTon.F ) );      // Quinte
			tmpTA.ADD( AddTon( eTon.Fis ) );    // überm. Quinte
			tmpTA.ADD( AddTon( eTon.Ges ) );    // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.G ) );      // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.Ases ) );    // verm. Sept
			tmpTA.ADD( AddTon( eTon.As ) );     // kl. Sept
			tmpTA.ADD( AddTon( eTon.A ) );      // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion B
			#region H
			tmpTA = erzeugeTonart( "H" , eTonart.H );
			tmpTA.ADD( AddTon( eTon.H ) );      // Prime
			tmpTA.ADD( AddTon( eTon.C ) );      // kl. None
			tmpTA.ADD( AddTon( eTon.Cis ) );    // gr. None
			tmpTA.ADD( AddTon( eTon.Cisis ) );  // überm. None
			tmpTA.ADD( AddTon( eTon.D ) );      // kl. Terz
			tmpTA.ADD( AddTon( eTon.Dis ) );    // gr. Terz
			tmpTA.ADD( AddTon( eTon.Es ) );     // verm. Undezime
			tmpTA.ADD( AddTon( eTon.E ) );      // Undezime
			tmpTA.ADD( AddTon( eTon.Eis ) );    // überm. Undezime
			tmpTA.ADD( AddTon( eTon.F ) );      // verm. Quinte
			tmpTA.ADD( AddTon( eTon.Fis ) );    // Quinte
			tmpTA.ADD( AddTon( eTon.Fisis ) );  // überm. Quinte
			tmpTA.ADD( AddTon( eTon.G ) );      // kl. Tredezime
			tmpTA.ADD( AddTon( eTon.Gis ) );    // gr. Tredezime
			tmpTA.ADD( AddTon( eTon.As ) );     // verm. Sept
			tmpTA.ADD( AddTon( eTon.A ) );      // kl. Sept
			tmpTA.ADD( AddTon( eTon.Ais ) );    // gr. Sept
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonartData = new Anz_TonartData( MethodenName , tmpTA );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpTA );
			#endregion H

			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeEnde = new Fenster.Testanzeigen.wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: erzeugeTonart(name,id)
		/// <para>erzeugt eine neue Datenbank</para>
		/// </summary>
		/// <param name="name">lbl_Name der Tonart, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID der Tonart, TYP: <b><i>eTonart</i></b></param>
		/// <returns>Tonart, TYP: <b><i>ds_Tonart</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  17:44:15</para>
		/// <para>    ersteBearbeitung : 2016-11-24  14:07:18</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static ds_Tonart erzeugeTonart( string name , eTonart id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".erzeugeTonart(name,id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO

			ds_Tonart ausgabe = new ds_Tonart( name , id );

			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName , "Name der Tonart: " + name , "ID der Tonart: " + id.ToString() );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		/// <summary> Methode: AddTon(id)
		/// <para>fügt einen neuen Ton an die temporäre Tonart an</para>
		/// </summary>
		/// <param name="id">ID des Tons, TYP: <b><i>eTon</i></b></param>
		/// <returns>Ton-Objekt, TYP: <b><i>ds_Ton</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  14:23:22</para>
		/// <para>    ersteBearbeitung : 2016-11-24  14:20:32</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static ds_Ton AddTon(eTon id )
		{
			return DB_Töne.getTon( id );
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Tonarten aus</para>
		/// <para></para>
		/// Typ: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  15:21:02</para>
		/// <para>    ersteBearbeitung : 2016-11-24  15:21:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static int Anzahl { get { return _liste.Count; } }
		
        /// <summary> Eigenschaft: Tonarten
        /// <para>gibt die Liste der Tonarten aus</para>
        /// <para></para>
		/// Typ: <b><i>List%lt;ds_Tonart&gt;</i></b>
        /// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  15:23:36</para>
		/// <para>    ersteBearbeitung : 2016-11-24  15:23:36</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static List<ds_Tonart> Tonarten { get { return _liste; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: getTonart(INT id)
		/// <para>gibt eine Tonart aus</para>
		/// </summary>
		/// <param name="id">ID der Tonart, TYP: <b><i>INT</i></b></param>
		/// <returns>Tonart-Objekt, TYP: <b><i>ds_Tonart</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  17:52:13</para>
		/// <para>    ersteBearbeitung : 2016-11-24  15:25:51</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static ds_Tonart getTonart(int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getTonart(INT id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Tonart ausgabe;

			try {
				ausgabe = _liste[id];
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if EINGABE
				MethodeInfo = new wnd_Info( MethodenName , "Tonart "+id+" => wurde NICHT gefunden" );
#endif //EINGABE
#if START
				MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
				#endregion DEBUG_INFO
				return null;
			}

			#region DEBUG_INFO
#if TEST
#if AUSGABE
			AnzeigeTonartData = new Anz_TonartData( MethodenName , ausgabe );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
			return ausgabe;
		}

		/// <summary> Methode: getTonart(eTonart id)
		/// <para>gibt eine Tonart aus</para>
		/// </summary>
		/// <param name="id">ID der Tonart, TYP: <b><i>eTonart</i></b></param>
		/// <returns>Tonart-Objekt, TYP: <b><i>ds_Tonart</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  18:00:11</para>
		/// <para>    ersteBearbeitung : 2016-12-17  17:57:48</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static ds_Tonart getTonart(eTonart id)
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getTonart(eTonart id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id.ToString() );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Tonart ausgabe = _liste[(int)id];

			#region DEBUG_INFO
#if TEST
#if AUSGABE
			AnzeigeTonartData = new Anz_TonartData( MethodenName , ausgabe );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
			return ausgabe;
		}

		#endregion DEBUG_INFO
	}
}
