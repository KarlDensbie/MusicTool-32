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
	/// <summary> Klasse       : <b>DB_Modi
	/// </b><para></para>
	/// <para>Datenbank der Modi
	/// </para>
	/// <b><i> </i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Modi
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Modi";
		private static string zz_namespace = "MusicTool.Datenbanken";
		private static dType zz_datenTyp = dType.DB_Modi;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-12-17  22:14:19";
		private static string zz_ersteBearbeitung= "2016-11-24 17:51.49";
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
		/// <para>Liste der Modi</para>
		/// <para></para>
		/// TYP: <b><i>List&lt;ds_Modus&gt;</i></b>
		/// </summary>
		private static List<ds_Modus> _liste;

		/// <summary>id
		/// <para>ID des Modus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		private static int id;

		private static string KLASSE = "Datenbanken.DB_Modi";

		private static wnd_StatusOn MethodeStart;
		private static wnd_StatusOff MethodeEnde;
		private static wnd_Info MethodeInfo;
		private static Anz_Ton_Objekt AnzeigeTonObjekt;
		private static Anz_TonData AnzeigeTonData;
		private static Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private static Anz_IntervallData AnzeigeIntervallData;
		private static Anz_TonartData AnzeigeTonartData;
		private static Anz_ModusData AnzeigeModusData;

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
		/// <para>    letzteBearbeitung: 2016-12-17  21:44:04</para>
		/// <para>    ersteBearbeitung : 2016-11-24  17:59:46</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		static DB_Modi()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"()";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste = new List<ds_Modus>();
			id = 0;

			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "Initialisierung wird gestartet ..." );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			INIT();
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "... Initialisierung wurde beendet" );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die Datenbank</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  22:00:50</para>
		/// <para>    ersteBearbeitung : 2016-11-24  18:02:29</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static void INIT()
		{
			ds_Modus tmpModus;
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".INIT()";

#endif //TEST
			#endregion DEBUG_INFO

			#region Kirchentonarten
			tmpModus = erzeugeModus( "-Dur" , "-Jonisch (Dur)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-dorisch" , "-dorisch (moll)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-phrygisch" , "-phrygisch (moll)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lydisch" , "-lydisch (Dur #11)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-mixolydisch" , "-mixolydisch (Dur 7)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-äolisch" , "-äolisch (natürliches moll)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lokrisch" , "-lokrisch (moll vermindert)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );
			#endregion DEBUG_INFO
			#region Melodisch Moll

			tmpModus = erzeugeModus( "-mel. moll" , "-melodisch Moll I" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-dorisch b9" , "-dorisch b9(melodisch moll II)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lydisch #5" , "-lydisch #5 (melodisch moll III)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte_Ü );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-mixo #11" , "-mixolydisch #11 (melodisch moll IV)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-mixo b13" , "-mixolydisch b13 (melodisch moll V)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lokrisch 9" , "-lokrisch 9 (melodisch moll VI)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte_V );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-superlokrisch" , "-superlokrisch (melodisch moll VII)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez_V );
			tmpModus.ADD( eIntervall.Quinte_V );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			#endregion Melodisch Moll
			#region harmonisch Moll

			tmpModus = erzeugeModus( "-harm. Moll" , "-harmonisch Moll (HM I)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lokrisch 6" , "-lokrisch 6 (HM II)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte_V );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-jonisch #5" , "-jonisch #5 (HM III)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte_Ü );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-dorisch #11" , "-dorisch #11 (HM IV)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-phrygisch Dur" , "-phrygisch Dur (HM V)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-lydisch #9" , "-lydisch #9 (HM VI)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_Ü );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-harmonisch verm." , "-harmonisch vermindert (HM VII)" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez_V );
			tmpModus.ADD( eIntervall.Quinte_V );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_V );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			#endregion harmonisch Moll
			#region Pentatonisch

			tmpModus = erzeugeModus( "-penta I" , "-pentatonisch I" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-penta II" , "-pentatonisch II" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-penta III" , "-pentatonisch III" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-penta IV" , "-pentatonisch IV" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-penta V" , "-pentatonisch V" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			#endregion Pentatonisch
			#region Moll Pentatonisch

			tmpModus = erzeugeModus( "-moll penta I" , "moll pentatonisch I" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-moll penta II" , "moll pentatonisch II" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-moll penta III" , "moll pentatonisch III" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-moll penta IV" , "moll pentatonisch IV" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Tredez_K );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( "-moll penta V" , "moll pentatonisch V" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			#endregion Moll Pentatonisch
			#region Jazz

			tmpModus = erzeugeModus( "-Ganzton" , "-Ganzton" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte_Ü );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( " Ht-Gt" , " Halbton-Ganzton" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_K );
			tmpModus.ADD( eIntervall.None_Ü );
			tmpModus.ADD( eIntervall.Terz_G );
			tmpModus.ADD( eIntervall.Undez_Ü );
			tmpModus.ADD( eIntervall.Quinte );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_K );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			tmpModus = erzeugeModus( " GtHt" , " Ganzton-Halbton" );
			tmpModus.ADD( eIntervall.Prime );
			tmpModus.ADD( eIntervall.None_G );
			tmpModus.ADD( eIntervall.Terz_K );
			tmpModus.ADD( eIntervall.Undez );
			tmpModus.ADD( eIntervall.Quinte_V );
			tmpModus.ADD( eIntervall.Quinte_Ü );
			tmpModus.ADD( eIntervall.Tredez_G );
			tmpModus.ADD( eIntervall.Sept_G );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeModusData = new Anz_ModusData( MethodenName , tmpModus );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( tmpModus );

			#endregion Jazz
		}

		/// <summary> Methode: erzeugeModus(name,altName)
		/// <para>erzeugt einen neuen Modus</para>
		/// <para>Die ID wird automatisch gesetzt</para>
		/// </summary>
		/// <param name="name">lbl_Name des Modus, TYP: <b><i>STRING</i></b></param>
		/// <param name="altName">langer lbl_Name des Modus, TYP: <b><i>STRING</i></b></param>
		/// <returns>Modus-Objekt, TYP: <b><i>ds_Modus</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  22:09:14</para>
		/// <para>    ersteBearbeitung : 2016-11-24  18:10:17</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static ds_Modus erzeugeModus( string name , string altName )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".erzeugeModus(name,altName)";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
			MethodeInfo = new wnd_Info( MethodenName , "Erzeuge Modus:" , "   Name: " + name , "AltName: " + altName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			var ausgabe = new ds_Modus( name , altName , id );
			id++;
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT
#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		#endregion DEBUG_INFO

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Modi aus</para>
		/// <para></para>
		/// Typ: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  19:17:24</para>
		/// <para>    ersteBearbeitung : 2016-11-24  19:17:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static int Anzahl { get { return _liste.Count; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: get(id)
		/// <para>gibt einen Modus aus</para>
		/// </summary>
		/// <param name="id">ID des Modus, TYP: <b><i>INT</i></b></param>
		/// <returns>Modus-Objekt, TYP: <b><i>ds_Modus</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  22:13:41</para>
		/// <para>    ersteBearbeitung : 2016-11-24  19:20:19</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static ds_Modus get( int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".get(id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Modus ausgabe;
			try {
				ausgabe = _liste[id];
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "Modus wurde NICHT gefunden" );
#endif //INFO
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
			AnzeigeModusData = new Anz_ModusData( MethodenName , ausgabe );
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
