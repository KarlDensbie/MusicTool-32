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
	/// <summary> Klasse       : <b>ds_Tonart</b><para></para>
	/// ABGELEITET VON: <b><i>bcl_BasisListe</i></b>
	/// <para>Datensatz für eine Tonart</para>
	/// speichert Elemente der Klasse <b><i>ds_Ton</i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Tonart : bcl_BasisListe<ds_Ton>
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Tonart";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Tonart;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "2";
		private static string zz_letzteBearbeitung= "2016-12-17  16:29:44";
		private static string zz_ersteBearbeitung= "2016-11-23 14:05.48";
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
		/// <para>    letzteBearbeitung: 2016-11-24  19:25:23</para>
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

		/// <summary>_id
		/// <para>ID der Tonart</para>
		/// <para></para>
		/// TYP: <b><i>eTonart</i></b>
		/// </summary>
		private eTonart _id;

		private string KLASSE = "Datenbanken.Datensätze.ds_Tonart";

		private static wnd_StatusOn MethodeStart;
		private static wnd_StatusOff MethodeEnde;
		private static wnd_Info MethodeInfo;
		private static Anz_Ton_Objekt AnzeigeTonObjekt;
		private static Anz_TonData AnzeigeTonData;
		private static Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private static Anz_IntervallData AnzeigeIntervallData;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,id)
		/// <para>initialisiert die Klasse mit:</para>
		/// <para>- lbl_Name der Tonart</para>
		/// <para>- ID der Tonart</para>
		/// </summary>
		/// <param name="name">lbl_Name der Tonart, TYP: STRING</param>
		/// <param name="id">ID der Tonart, TYP: INT</param>
		/// .
		/// <remarks>
		/// <para>Der Typ der Instanz ist "Tonart"</para>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  16:04:39</para>
		/// <para>    ersteBearbeitung : 2016-11-23  14:17:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Tonart( string name , eTonart id ) :
			base( name , dType.Tonart , (int)id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name,id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if INIT
			MethodeInfo = new wnd_Info( MethodenName , "EINGABEN:","NAME: "+name,"ID: "+id );
			MethodeInfo = new wnd_Info( MethodenName , "an BASISKLASSE weitergeleitet:" , "Name: " + name , "Typ: " + dType.Tonart , "ID: " + id.ToString() );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_id = id;
			#region DEBUG_INFO
#if TEST
#if START
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: TonartName
		/// <para>gibt den Namen der Tonart aus</para>
		/// <para></para>
		/// Typ: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-23  19:50:36</para>
		/// <para>    ersteBearbeitung : 2016-11-23  19:50:36</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public string TonartName
		{
			get { return Name; }
		}

		/// <summary> Eigenschaft: Tonart
		/// <para>gibt die Tonart als Objekt aus</para>
		/// <para></para>
		/// Typ: <b><i>List&lt;ds_Ton&gt;</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-23  20:27:39</para>
		/// <para>    ersteBearbeitung : 2016-11-23  19:57:18</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public List<ds_Ton> Tonart
		{
			get { return Liste; }
		}

		/// <summary> Eigenschaft: TonartIndex
		/// <para>gibt den ID der Tonart aus</para>
		/// <para></para>
		/// Typ: <b><i>eTonart</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-24  13:10:29</para>
		/// <para>    ersteBearbeitung : 2016-11-23  20:32:03</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public eTonart TonartIndex
		{
			get { return _id; }
		}

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: getTon(INT id)
		/// <para>gibt den Ton mit dem angegebenen ID aus</para>
		/// </summary>
		/// <param name="id">ID des Tons, TYP: <b><i>INT</i></b></param>
		/// <returns>Ton-Objekt, TYP: <b><i>ds_Ton</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  16:23:02</para>
		/// <para>    ersteBearbeitung : 2016-11-23  20:36:27</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Ton getTon(int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getTon(INT id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if AUSGABE
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "ID: "+id );
#endif //AUSGABE

#endif //TEST
#endregion DEBUG_INFO
			ds_Ton ausgabe;
			try {
				ausgabe = getElement( id );
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if AUSGABE
				MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "KEINEN Ton gefunden" );
#endif //AUSGABE

#endif //TEST
#endregion DEBUG_INFO
				ausgabe = null;
			}

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

		/// <summary> Methode: getTon(eIntervall id)
		/// <para>gibt den Ton mit dem angegebenen ID aus</para>
		/// </summary>
		/// <param name="id">Intervall-ID des Tons, TYP: <b><i>eIntervall</i></b></param>
		/// <returns>Ton-Objekt, TYP: <b><i>ds_Ton</i></b></returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-12-17  16:29:14</para>
		/// <para>    ersteBearbeitung : 2016-11-23  20:42:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public ds_Ton getTon(eIntervall id )
		{
			ds_Ton ausgabe;
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getTon(eIntervall id)";
#if START
			MethodeStart = new Fenster.Testanzeigen.wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new Fenster.Testanzeigen.wnd_Info( MethodenName , "ID: "+id.ToString() );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO

			ausgabe =getTon( (int)id );

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

		#endregion DEBUG_INFO
	}
}