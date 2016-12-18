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
	/// <summary> Klasse       : <b>ds_Modus
	/// </b><para></para>
	/// ABGELEITET VON: <b><i>bcl_BasisListe2&lt;eIntervall&gt;
	/// </i></b>
	/// <para> Datensatz für einen Modus</para>
	/// speichert Elemente der Aufzählung <b><i>eIntervall</i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Modus : bcl_BasisListe2<eIntervall>
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Modus";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Modus;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-12-17  19:43:45";
		private static string zz_ersteBearbeitung= "2016-11-24 15:33.32";
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
		/// <para>    letzteBearbeitung: 2016-11-24  19:26:28</para>
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

		private static string KLASSE = "Datenbanken.Datensätze.ds_Modus";

		private static wnd_StatusOn MethodeStart;
		private static wnd_StatusOff MethodeEnde;
		private static wnd_Info MethodeInfo;
		private static Anz_Ton_Objekt AnzeigeTonObjekt;
		private static Anz_TonData AnzeigeTonData;
		private static Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private static Anz_IntervallData AnzeigeIntervallData;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,altName,id)
		/// <para>instanziiert die Liste mit den Intervall-IDs der Intervalle</para>
		/// </summary>
		/// <param name="name">lbl_Name des Modus, TYP: <b><i>STRING</i></b></param>
		/// <param name="altName">langer lbl_Name des Modus, TYP: <b><i>STRING</i></b></param>
		/// <param name="id">ID des Modus, TYP: <b><i>INT</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  15:49:35</para>
		/// <para>    ersteBearbeitung : 2016-11-24  15:49:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Modus( string name , string altName , int id ) :
			base( name , altName , dType.Modus , id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name,altName,id)";
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "Name: " + name , "altName: " + altName , "ID: " + id.ToString() );
			MethodeInfo = new wnd_Info( MethodenName , "an BASISKLASSE weitergeleitet:" , "Name: " + name , "Typ: " + dType.Modus , "ID: " + id.ToString() );

#endif //EINGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: AddIntervall(intervall)
		/// <para>fügt ein Intervall an die Liste der Intervalle an</para>
		/// </summary>
		/// <param name="itv">Intervall, TYP: <b><i>eIntervall</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  19:33:10</para>
		/// <para>    ersteBearbeitung : 2016-11-24  15:56:34</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public void AddIntervall( eIntervall itv )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".AddIntervall(eIntervall itv)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START

#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "intervall: " + itv.ToString() );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			if( itv != eIntervall.X ) {
				ADD( itv );
				#region DEBUG_INFO
#if TEST
#if START
				MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
				#endregion DEBUG_INFO
			}
			#region DEBUG_INFO
#if TEST
#if START
			MethodeEnde = new Fenster.Testanzeigen.wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: get( INT id)
		/// <para>gibt ein Intervall-Objekt aus</para>
		/// </summary>
		/// <param name="id">ID des Intervalls in der Liste des Modus, TYP: <b><i>INT</i></b></param>
		/// <returns>Intervall-Objekt, TYP: <b><i>ds_Intervall</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  19:42:29</para>
		/// <para>    ersteBearbeitung : 2016-11-24  16:02:46</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Intervall get( int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".get(INT id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: " + id );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			ds_Intervall ausgabe;
			try {
				ausgabe = DB_Intervalle.get( Liste[id] );
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if INFO
				MethodeInfo = new wnd_Info( MethodenName , "Element wurde NICHT gefunden" );
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
			AnzeigeIntervallObjekt = new Anz_Intervall_Objekt( MethodenName , ausgabe );
#endif //AUSGABE
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
			return ausgabe;
		}

		#endregion Methoden
	}
}