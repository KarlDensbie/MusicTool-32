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
	/// <summary> Klasse       : DB_Intervalle
	/// <para></para>
	/// <i>STATISCHE KLASSE</i>
	/// <para>Datenbank der Intervalle</para>
	/// <para>enthält alle Daten aller Intervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Intervalle
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Intervalle";
		private static string zz_namespace = "MusicTool.Datenbanken";
		private static dType zz_datenTyp = dType.DB_Intervalle;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "3";
		private static string zz_letzteBearbeitung= "2016-12-17  15:48:18";
		private static string zz_ersteBearbeitung= "2016-11-14 13:49.04";
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
		/// <para>Liste der Intervalle</para>
		/// <para> </para>
		/// TYP: <b><i>List &lt;ds_Intervall&gt;</i></b>
		/// </summary>
		private static bcl_BasisListe<ds_Intervall> _liste;

		private static string KLASSE = "Datenbanken.bcl_BasisListe";

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
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:33:29</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:22:52</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		static DB_Intervalle()
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"()";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste = new bcl_BasisListe<ds_Intervall>( "DB_Intervalle" , dType.DB_Intervalle , 0 );
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName , "Die Initialisierung startet ..." );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			INIT();
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName , "... Die Initialisierung wurde beendet." );
#endif //INIT
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die Datenbank mit allen Daten</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:34:47</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:22:07</para>
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
			_liste.ADD( setMember( "I" , "" , eIntervall.Prime , eBasisIntervall.Prime ) );

			_liste.ADD( setMember( "b9" , "b2" , eIntervall.None_K , eBasisIntervall.None ) );
			_liste.ADD( setMember( "9" , "2" , eIntervall.None_G , eBasisIntervall.None ) );
			_liste.ADD( setMember( "#9" , "#2" , eIntervall.None_Ü , eBasisIntervall.None ) );

			_liste.ADD( setMember( "m" , "" , eIntervall.Terz_K , eBasisIntervall.Terz ) );
			_liste.ADD( setMember( "III" , "" , eIntervall.Terz_G , eBasisIntervall.Terz ) );

			_liste.ADD( setMember( "b11" , "b4" , eIntervall.Undez_V , eBasisIntervall.Undez ) );
			_liste.ADD( setMember( "11" , "4" , eIntervall.Undez , eBasisIntervall.Undez ) );
			_liste.ADD( setMember( "#11" , "#4" , eIntervall.Undez_Ü , eBasisIntervall.Undez ) );

			_liste.ADD( setMember( "b5" , "" , eIntervall.Quinte_V , eBasisIntervall.Quinte ) );
			_liste.ADD( setMember( "V" , "" , eIntervall.Quinte , eBasisIntervall.Quinte ) );
			_liste.ADD( setMember( "#5" , "" , eIntervall.Quinte_Ü , eBasisIntervall.Quinte ) );

			_liste.ADD( setMember( "b13" , "b6" , eIntervall.Tredez_K , eBasisIntervall.Tredez ) );
			_liste.ADD( setMember( "13" , "6" , eIntervall.Tredez_G , eBasisIntervall.Tredez ) );

			_liste.ADD( setMember( "b7" , "" , eIntervall.Sept_V , eBasisIntervall.Sept ) );
			_liste.ADD( setMember( "7" , "" , eIntervall.Sept_K , eBasisIntervall.Sept ) );
			_liste.ADD( setMember( "MAJ" , "" , eIntervall.Sept_G , eBasisIntervall.Sept ) );
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: setMember(name,altName,id,basisIntervall)
		/// <para>Hilfsmethode zur einfacheren Initialisierung</para>
		/// </summary>
		/// <param name="name">lbl_Name des Intervalls, TYP: <b><i>STRING</i></b></param>
		/// <param name="altName">alternativer lbl_Name des Intervalls, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID des Intervalls in der Datenbank DB_Intervalle, TYP: <b><i>eIntervall</i></b></param>
		/// <param name="bas">Basis-Intervall, TYP: <b><i>eBasisIntervall</i></b></param>
		/// <returns>Datensatz, TYP: ds_Intervall</returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:36:48</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:04:25</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private static ds_Intervall setMember( string name , string altName , eIntervall id , eBasisIntervall bas )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".setMember(name,altName,id,basisIntervall)";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			ds_Intervall ausgabe = new ds_Intervall( name , altName , id , bas );
			#region DEBUG_INFO
#if TEST
#if INIT
			AnzeigeIntervallObjekt = new Anz_Intervall_Objekt( MethodenName , ausgabe );
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
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:32</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:10:14</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static int Anzahl { get { return _liste.Anzahl; } }

		/// <summary> Eigenschaft: lbl_Name
		/// <para>gibt den Namen der Liste aus</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:16</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:13:21</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static string Name { get { return _liste.Name; } }

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Daten-Typ der Liste aus</para>
		/// <para></para>
		/// TYP: <b><i>dType</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:01</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:14:50</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static dType Typ { get { return _liste.Typ; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: get(eIntervall id)
		/// <para>gibt einen Intervall-Datensatz aus</para>
		/// </summary>
		/// <param name="id">ID des Intervall, TYP: <b><i>eIntervall</i></b></param>
		/// <returns>Intervall-Datensatz, TYP: <b><i>ds_Intervall</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:38:28</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:28:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static ds_Intervall get( eIntervall id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".get(eIntervall id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			if( id == eIntervall.X ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "kein gültiges Intervall gefunden." );
#endif //INFO
#if START
				MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
				#endregion DEBUG_INFO
				return null;
			}
			ds_Intervall ausgabe = _liste.getElement( (int)id );
			#region DEBUG_INFO
#if TEST
#if AUSGABE
			AnzeigeIntervallObjekt = new Anz_Intervall_Objekt( MethodenName , ausgabe );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
			return ausgabe;
		}

		/// <summary> Methode: get(int id)
		/// <para>gibt einen Intervall-Datensatz aus</para>
		/// </summary>
		/// <param name="id">ID des Intervall, TYP: <b><i>INT</i></b></param>
		/// <returns>Intervall-Datensatz, TYP: <b><i>ds_Intervall</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  15:47:42</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:28:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static ds_Intervall get( int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".get(int id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id );
#endif //EINGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Intervall datensatz;
			try {
				datensatz = _liste.getElement( id );
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "kein gültiges Intervall gefunden." );
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
			AnzeigeIntervallObjekt = new Anz_Intervall_Objekt( MethodenName , datensatz );
#endif //AUSGABE
#if START
			MethodeEnde = new Fenster.Testanzeigen.wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
			return datensatz;
		}

		#endregion Methoden
	}
}