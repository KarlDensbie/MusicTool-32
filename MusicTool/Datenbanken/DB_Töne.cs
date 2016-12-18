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
	/// <summary> Klasse       : <b>DB_Töne</b>
	/// <para></para>
	/// <i>STATISCHE KLASSE</i>
	/// <para>Datenbank der Töne</para>
	/// <para>enthält alle Daten aller Töne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	/// <remarks> Getestet
	/// <para>Standardkonstruktor() - getestet am      : 2016-12-14  19:22:25</para>
	/// <para>INIT() - getestet am      : 2016-12-14  19:23:00</para>
	/// <para>setMember - getestet am      : 2016-12-14  19:23:29</para>
	/// <para>Anzahl - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>getTon(int id) - getestet am      : 2016-12-14  19:24:23</para>
	/// <para>findTon(gesucht) - getestet am      : 2016-12-14  19:24:43</para>
	/// <para>getTon(eTon id) - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>Name - getestet am      : 2016-12-14  20:23:30</para>
	/// <para>Typ - getestet am      : 2016-12-14  20:23:30</para>
	/// </remarks>
	public static class DB_Töne
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Töne";
		private static string zz_namespace = "MusicTool.Datenbanken";
		private static dType zz_datenTyp = dType.DB_Töne;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "4";
		private static string zz_letzteBearbeitung= "2016-12-17  15:29:10";
		private static string zz_ersteBearbeitung= "2016-11-13 12:17.48";
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
		/// <para>Liste der Töne</para>
		/// <para></para>
		/// TYP: <b><i>List&lt;ds_Ton&gt;</i></b>
		/// </summary>
		private static bcl_BasisListe<ds_Ton> _liste;

		private static string KLASSE = "Datenbanken.DB_Töne";

		private static wnd_StatusOn MethodeStart;
		private static wnd_StatusOff MethodeEnde;
		private static wnd_Info MethodeInfo;
		private static Anz_Ton_Objekt AnzeigeTonObjekt;
		private static Anz_TonData AnzeigeTonData;
		private static Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private static Anz_IntervallData AnzeigeIntervallData;

		#endregion Attribute

		#region Konstruktor

		/// <summary>  Standardkonstruktor()
		/// <para>initialisiert die Datenbank</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  15:15:21</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:08:00</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:22:25</para>
		/// </summary>
		static DB_Töne()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"()";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste = new bcl_BasisListe<ds_Ton>( "DB_Töne" , dType.DB_Töne , 0 );
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName, "Die Initialisierung startet ..." );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			INIT();
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName, "... Die Initialisierung wurde beendet." );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die Datenbank mit allen Tönen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:16:43</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:07:02</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:23:00</para>
		/// </summary>
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
			_liste.ADD( setMember( "Cbb" , eTon.Ceses , eGrundton.C , eTon.Ais , eTon.B ) );
			_liste.ADD( setMember( "Cb" , eTon.Ces , eGrundton.C , eTon.Aisis , eTon.H ) );
			_liste.ADD( setMember( "C" , eTon.C , eGrundton.C , eTon.His , eTon.Deses ) );
			_liste.ADD( setMember( "C#" , eTon.Cis , eGrundton.C , eTon.Hisis , eTon.Des ) );
			_liste.ADD( setMember( "C##" , eTon.Cisis , eGrundton.C , eTon.D , eTon.Eses ) );

			_liste.ADD( setMember( "Dbb" , eTon.Deses , eGrundton.D , eTon.His , eTon.C ) );
			_liste.ADD( setMember( "Db" , eTon.Des , eGrundton.D , eTon.Hisis , eTon.Cis ) );
			_liste.ADD( setMember( "D" , eTon.D , eGrundton.D , eTon.Cisis , eTon.Eses ) );
			_liste.ADD( setMember( "D#" , eTon.Dis , eGrundton.D , eTon.Es , eTon.Feses ) );
			_liste.ADD( setMember( "D##" , eTon.Disis , eGrundton.D , eTon.E , eTon.Fes ) );

			_liste.ADD( setMember( "Ebb" , eTon.Eses , eGrundton.E , eTon.Cisis , eTon.D ) );
			_liste.ADD( setMember( "Eb" , eTon.Es , eGrundton.E , eTon.Dis , eTon.Feses ) );
			_liste.ADD( setMember( "E" , eTon.E , eGrundton.E , eTon.Disis , eTon.Fes ) );
			_liste.ADD( setMember( "E#" , eTon.Eis , eGrundton.E , eTon.F , eTon.Geses ) );
			_liste.ADD( setMember( "E##" , eTon.Eisis , eGrundton.E , eTon.Fis , eTon.Ges ) );

			_liste.ADD( setMember( "Fbb" , eTon.Feses , eGrundton.F , eTon.Dis , eTon.Es ) );
			_liste.ADD( setMember( "Fb" , eTon.Fes , eGrundton.F , eTon.Disis , eTon.E ) );
			_liste.ADD( setMember( "F" , eTon.F , eGrundton.F , eTon.Eis , eTon.Geses ) );
			_liste.ADD( setMember( "F#" , eTon.Fis , eGrundton.F , eTon.Eisis , eTon.Ges ) );
			_liste.ADD( setMember( "F##" , eTon.Fisis , eGrundton.F , eTon.G , eTon.Ases ) );

			_liste.ADD( setMember( "Gbb" , eTon.Geses , eGrundton.G , eTon.Eis , eTon.F ) );
			_liste.ADD( setMember( "Gb" , eTon.Ges , eGrundton.G , eTon.Eisis , eTon.Fis ) );
			_liste.ADD( setMember( "G" , eTon.G , eGrundton.G , eTon.Fisis , eTon.Ases ) );
			_liste.ADD( setMember( "G#" , eTon.Gis , eGrundton.G , eTon.As , eTon.As ) );
			_liste.ADD( setMember( "G##" , eTon.Gisis , eGrundton.G , eTon.A , eTon.Heses ) );

			_liste.ADD( setMember( "Abb" , eTon.Ases , eGrundton.A , eTon.Fisis , eTon.G ) );
			_liste.ADD( setMember( "Ab" , eTon.As , eGrundton.A , eTon.Gis , eTon.Gis ) );
			_liste.ADD( setMember( "A" , eTon.A , eGrundton.A , eTon.Gisis , eTon.Heses ) );
			_liste.ADD( setMember( "A#" , eTon.Ais , eGrundton.A , eTon.B , eTon.Ceses ) );
			_liste.ADD( setMember( "A##" , eTon.Aisis , eGrundton.A , eTon.H , eTon.Ces ) );

			_liste.ADD( setMember( "Hbb" , eTon.Heses , eGrundton.H , eTon.Gisis , eTon.A ) );
			_liste.ADD( setMember( "B" , eTon.B , eGrundton.H , eTon.Ais , eTon.Ceses ) );
			_liste.ADD( setMember( "H" , eTon.H , eGrundton.H , eTon.Aisis , eTon.Ces ) );
			_liste.ADD( setMember( "H#" , eTon.His , eGrundton.H , eTon.C , eTon.Deses ) );
			_liste.ADD( setMember( "H##" , eTon.Hisis , eGrundton.H , eTon.Cis , eTon.Des ) );
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeEnde = new Fenster.Testanzeigen.wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: setMember(name,id,grundton,enhU,enhO)
		/// <para>erzeugt einen Datensatz für Töne</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:21:58</para>
		/// <para>    ersteBearbeitung : 2016-11-13  12:30:17</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:23:29</para>
		/// </summary>
		/// <param name="name">lbl_Name des Tons, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID des Tons, TYP: <b><i>eTon</i></b></param>
		/// <param name="grundton">Grundton, TYP: <b><i>eGrundton</i></b></param>
		/// <param name="enhU">untere enharmonische Verwechselung, TYP: <b><i>eTon</i></b></param>
		/// <param name="enhO">obere enharmonische Verwechselung, TYP: <b><i>eTon</i></b></param>
		/// <returns>Ton-Datensatz, TYP: <b><i>ds_Ton</i></b></returns>
		private static ds_Ton setMember( string name , eTon id , eGrundton grundton , eTon enhU , eTon enhO )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".setMember(name,id,grundton,enhU,enhO)";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			ds_Ton ausgabe = new ds_Ton( name , id , grundton , enhU , enhO );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeTonObjekt = new Anz_Ton_Objekt( MethodenName, ausgabe );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Datensätze aus</para>
		/// <para></para>
		/// TYP: <b>INT<i></i></b>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:10:14</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:10:14</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </summary>
		public static int Anzahl
		{
			get { return _liste.Anzahl; }
		}

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen der Liste aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:13:21</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:13:21</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </summary>
		public static string Name
		{
			get { return _liste.Name; }
		}

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Daten-Typ der Liste aus</para>
		/// <para></para>
		/// TYP: <b><i>dType</i></b>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:14:50</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:14:50</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </summary>
		public static dType Typ
		{
			get { return _liste.Typ; }
		}

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: getTon(eTon id)
		/// <para>gibt einen Ton-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:23:56</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:24:18</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  20:23:30</para>
		/// </summary>
		/// <param name="id">ID des Tons, TYP: <b><i>eTon</i></b></param>
		/// <returns>Ton-Datensatz, TYP: <b><i>ds_Ton</i></b></returns>
		public static ds_Ton getTon( eTon id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getTon(eTon id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: " + id );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			if( id == eTon.X ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "keinen gültigen Ton gefunden." );
#endif //INFO
#if START
				MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
				#endregion DEBUG_INFO
				return null;
			}
			ds_Ton ausgabe = _liste.getElement( (int)id );
			#region DEBUG_INFO
#if TEST
#if AUSGABE
			AnzeigeTonObjekt = new Anz_Ton_Objekt( MethodenName , ausgabe );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		/// <summary> Methode: getTon(int id)
		/// <para>gibt einen Ton-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:25:45</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:24:18</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:24:23</para>
		/// </summary>
		/// <param name="id">ID des Tons, TYP: <b><i>INT</i></b></param>
		/// <returns>Ton-Datensatz, TYP: <b><i>ds_Ton</i></b></returns>
		public static ds_Ton getTon( int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName ="KLASSE+.getTon(int id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: " + id );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			ds_Ton datensatz;
			try {
				datensatz = _liste.getElement( id );
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "keinen gültigen Ton gefunden." );
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
			AnzeigeTonObjekt = new Anz_Ton_Objekt( MethodenName , datensatz );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
			return datensatz;
		}

		/// <summary> Methode: findTon(gesucht)
		/// <para>sucht einen Tonnamen in der Datenbank</para>
		/// </summary>
		/// <param name="gesucht">gesuchter Ton, TYP: STRING</param>
		/// <returns>Ton-Objekt, TYP: ds_Ton</returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  15:28:43</para>
		/// <para>    ersteBearbeitung : 2016-12-14  14:17:39</para>
		/// .
		/// <para>    getestet am      : 2016-12-14  19:24:43</para>
		/// </remarks>
		public static ds_Ton findTon(string gesucht )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".findTon(gesucht)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "gesucht: "+gesucht );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Ton aktTon;
			#region DEBUG_INFO
#if TEST
#if ZWISCHENWERTE
			MethodeInfo = new wnd_Info( MethodenName , "Suche beginnt ..." );
#endif //ZWISCHENWERTE

#endif //TEST
			#endregion DEBUG_INFO
			for( int i = 0 ; i < DB_Töne.Anzahl ; i++ ) {
			aktTon = _liste.getElement( i );
				#region DEBUG_INFO
#if TEST
#if ZWISCHENWERTE
				MethodeInfo = new wnd_Info( MethodenName , "gesucht: "+gesucht, "gefunden: "+aktTon.TonName);
#endif //ZWISCHENWERTE

#endif //TEST
				#endregion DEBUG_INFO
				if( aktTon.TonName == gesucht ) {
					#region DEBUG_INFO
#if TEST
#if AUSGABE
					MethodeInfo = new wnd_Info( MethodenName , "Ton wurde GEFUNDEN !!!" );
					AnzeigeTonObjekt = new Anz_Ton_Objekt( MethodenName , aktTon );
#endif //AUSGABE
#if START
					MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
					return aktTon;
				}
			}
			#region DEBUG_INFO
#if TEST
#if AUSGABE
			MethodeInfo = new wnd_Info( MethodenName , "KEIN TON gefunden" );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
			return null;
		}

		#endregion Methoden
	}
}