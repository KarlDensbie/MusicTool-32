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
	/// <summary> Klasse       : bcl_BasisListe2&lt;T&gt;
	/// <para>ABGELEITET VON: <b><i>bcl_Basisdata2</i></b></para>
	/// <para>Basisklasse für Listen mit 2 Namen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_BasisListe2<T>
	{
		#region VersionInfo

		private string zz_klassenName= "BasisListe2<T>";
		private string zz_namespace = "MusicTool.Basisklassen";
		private dType zz_datenTyp = dType.Basisliste;
		private string zz_hauptversion= "0";
		private string zz_nebenversion= "1";
		private string zz_revision= "5";
		private static string zz_letzteBearbeitung= "2016-12-17  14:54:55";
		private string zz_ersteBearbeitung= "2016-11-12 10:40.55";
		private string zz_getestet= "";
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
		public string VersionInfo()
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
		private string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
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
		private string zz_VersionInfo
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
		/// <para>allgemeine Liste unbestimmten Typs</para>
		/// <para></para>
		/// TYP: <b><i>List&lt;T&gt;</i></b>
		/// </summary>
		private List<T> _liste;

		/// <summary>_name
		/// <para>lbl_Name der Liste</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		private string _name;

		/// <summary>_altName
		/// <para>alternativer lbl_Name der Liste</para>
		/// <para></para>
		/// TYP: <b><i>STRING</i></b>
		/// </summary>
		private string _altName;

		/// <summary>_typ
		/// <para>Datentyp der Liste</para>
		/// <para></para>
		/// TYP: <b><i>dType</i></b>
		/// </summary>
		private dType _typ;

		/// <summary>_id
		/// <para>ID der Liste</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		private int _id;

		private string KLASSE = "Basisklassen.bcl_BasisListe2";

		private wnd_StatusOn MethodeStart;
		private wnd_StatusOff MethodeEnde;
		private wnd_Info MethodeInfo;
		private Anz_Ton_Objekt AnzeigeTonObjekt;
		private Anz_TonData AnzeigeTonData;
		private Anz_Intervall_Objekt AnzeigeIntervallObjekt;
		private Anz_IntervallData AnzeigeIntervallData;
		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,altName,typ,id)
		/// <para>instanziiert die Liste mit:</para>
		/// <para>- lbl_Name,   </para>
		/// <para>- alternativen Namen,</para>
		/// <para>- Typ der Liste,</para>
		/// <para>- ID der Liste</para>
		/// </summary>
		/// <param name="name">lbl_Name der Liste, TYP: <b><i>STRING</i></b></param>
		/// <param name="altName">alternativer lbl_Name der Liste, TYP: <b><i>STRING</i></b></param>
		/// <param name="typ">Typ der Liste, TYP: <b><i>dType</i></b></param>
		/// <param name="id">ID der Liste, TYP: <b><i>INT</i></b></param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 5
		/// <para>    letzteBearbeitung: 2016-12-17  14:49:44</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:22:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public bcl_BasisListe2( string name , string altName , dType typ , int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+"(name,altName,typ,id)";
#if INIT
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
			_liste = new List<T>();
			_name = name;
			_altName = altName;
			_id = id;
			_typ = typ;
			#region DEBUG_INFO
#if TEST
#if INIT
			MethodeInfo = new wnd_Info( MethodenName," - eingegebene Daten",
				"Name: "+name+", altern. Name: "+altName,"Typ: "+typ.ToString(),"ID: "+id.ToString() );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //INIT

#endif //TEST
			#endregion DEBUG_INFO
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Listen-Elemente aus</para>
		/// <para></para>
		/// TYP: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:25:44</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:25:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public int Anzahl { get { return _liste.Count; } }

		/// <summary> Eigenschaft: Liste
		/// <para>gibt die Liste der Elemente aus</para>
		/// <para></para>
		/// TYP: <b><i>T</i></b>(generisch)
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:27:57</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:27:57</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public List<T> Liste { get { return _liste; } }

		/// <summary> Eigenschaft: lbl_Name
		/// <para>gibt den Namen der Liste aus</para>
		/// <para></para>
		/// Typ: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-30  17:22:13</para>
		/// <para>    ersteBearbeitung : 2016-11-30  17:22:13</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: AltName
		/// <para>gibt den alternativen Namen der Liste aus</para>
		/// <para></para>
		/// Typ: <b><i>STRING</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-30  17:23:32</para>
		/// <para>    ersteBearbeitung : 2016-11-30  17:23:32</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public string AltName { get { return _altName; } }

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Typ der Liste aus</para>
		/// <para></para>
		/// Typ: <b><i>dType</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-30  17:24:28</para>
		/// <para>    ersteBearbeitung : 2016-11-30  17:24:28</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public dType Typ { get { return _typ; } }

		/// <summary> Eigenschaft: ID
		/// <para>gibt die ID der Liste aus</para>
		/// <para></para>
		/// Typ: <b><i>INT</i></b>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-30  17:25:22</para>
		/// <para>    ersteBearbeitung : 2016-11-30  17:25:22</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public int ID { get { return _id; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: ADD(element)
		/// <para>fügt ein Element an die Liste an</para>
		/// </summary>
		/// <param name="element">neues Element der Liste, TYP: <b><i>T</i></b>(generisch)</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-12-17  14:52:35</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:30:37</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public void ADD( T element )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".ADD(element)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
			_liste.Add( element );
			#region DEBUG_INFO
#if TEST
#if START
			MethodeInfo = new wnd_Info( MethodenName , "Element wurde gespeichert" );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
		}

		/// <summary> Methode: getElement(id)
		/// <para>gibt ein Element der Liste aus</para>
		/// </summary>
		/// <param name="id">ID des Listen-Elements, TYP: <b><i>INT</i></b></param>
		/// <returns>Listen-Element, TYP: <b><i>T</i></b>(generisch)</returns>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 4
		/// <para>    letzteBearbeitung: 2016-12-17  14:54:24</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:36:20</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public T getElement( int id )
		{
			#region DEBUG_INFO
#if TEST
			string MethodenName =KLASSE+".getElement(id)";
#if START
			MethodeStart = new wnd_StatusOn( MethodenName );
#endif //START
#if EINGABE
			MethodeInfo = new wnd_Info( MethodenName , "ID: "+id );
#endif //EINGABE

#endif //TEST
			#endregion DEBUG_INFO
			T element;

			try {
				element = _liste[id];
			}
			catch( ArgumentOutOfRangeException ) {
				#region DEBUG_INFO
#if TEST
#if INFO
#if AUSGABE
				MethodeInfo = new wnd_Info( MethodenName,"KEIN Element gefunden" );
#endif //AUSGABE
#if START
				MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //INFO
#endif //TEST
				#endregion DEBUG_INFO
				element = default( T );
			}

			#region DEBUG_INFO
#if TEST
#if START
			MethodeInfo = new wnd_Info( MethodenName , "Element["+id+"] gefunden" );
			MethodeEnde = new wnd_StatusOff( MethodenName );
#endif //START

#endif //TEST
			#endregion DEBUG_INFO
			return element;
		}

		#endregion Methoden
	}
}