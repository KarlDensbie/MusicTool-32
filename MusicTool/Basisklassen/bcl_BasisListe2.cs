using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_BasisListe
	/// <para>ABGELEITET VON: bcl_Basisdata2</para>
	/// <para>Basisklasse für Listen mit 2 Namen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_BasisListe2<T>
	{
		#region VersionInfo

		private static string zz_klassenName= "BasisListe2<T>";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Basisliste;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-12  16:26:28";
		private static string zz_ersteBearbeitung= "2016-11-12 10:40.55";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		/// <summary> Eigenschaft: zz_KlassenName
		/// <para>gibt den Namen der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:41:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:31:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_KlassenName { get { return zz_klassenName; } }
		/// <summary> Eigenschaft: zz_Namespace
		/// <para>gibt den Namespace der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:42:04</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:32:38</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Namespace { get { return zz_namespace; } }
		/// <summary> Eigenschaft: zz_Pfad
		/// <para>gibt den Pfad (Namespace + Klassenname) aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:42:20</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:33:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		/// <summary> Eigenschaft: zz_VersionInfo
		/// <para>gibt die Version der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:42:37</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:34:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		/// <summary> Eigenschaft: zz_AktBearbeitung
		/// <para>gibt das Datum der letzten Bearbeitung der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:43:03</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:35:45</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		/// <summary> Eigenschaft: zz_BearbeitungsBeginn
		/// <para>gibt aus, ab wann diese Klasse programmiert wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:43:21</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:36:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		/// <summary> Eigenschaft: zz_DatenTyp
		/// <para>gibt den Datentyp der Klasse aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:43:37</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:37:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static dType zz_DatenTyp { get { return zz_datenTyp; } }
		/// <summary> Eigenschaft: zz_Getestet
		/// <para>gibt aus, wann die Klasse getestet wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:43:55</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:43:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>_liste
		/// <para>allgemeine Liste unbestimmten Typs</para>
		/// </summary>
		private List<T> _liste;

		/// <summary>_name
		/// <para>Name der Liste</para>
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

		/// <summary>_altName
		/// <para>alternativer Name der Liste</para>
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _altName;

		/// <summary>_typ
		/// <para>Datentyp der Liste</para>
		/// <para>TYP: dType</para>
		/// </summary>
		private dType _typ;

		/// <summary>_index
		/// <para>Index der Liste</para>
		/// <para>TYP: INT</para>
		/// </summary>
		private int _index;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,altName,typ,index)
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:22:24</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:22:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name der Liste, TYP: STRING</param>
		/// <param name="altName">alternativer Name der Liste, TYP: STRING</param>
		/// <param name="typ">Typ der Liste, TYP: dType</param>
		/// <param name="idx">index der Liste, TYP: INT</param>
		public bcl_BasisListe2( string name,string altName , dType typ , int idx )
		{
			_liste = new List<T>();
			_name = name;
			_altName = altName;
			_index = idx;
			_typ = typ;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Listen-Elemente aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:25:44</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:25:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Anzahl { get { return _liste.Count; } }

		/// <summary> Eigenschaft: Liste
		/// <para>gibt die Liste der Elemente aus</para>
		/// <para>TYP: T(generisch)</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:27:57</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:27:57</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public List<T> Liste { get { return _liste; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: ADD(element)
		/// <para>fügt ein Element an die Liste an</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:30:37</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:30:37</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="element">neues Element der Liste, TYP: T(generisch)</param>
		public void ADD( T element )
		{
			_liste.Add( element );
		}

		/// <summary> Methode: getElement(idx)
		/// <para>gibt ein Element der Liste aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  10:36:20</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:36:20</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="idx">Index des Listen-Elements, TYP: INT</param>
		/// <returns>Listen-Element, TYP: T(generisch)</returns>
		public T getElement( int idx )
		{
			T element;

			try {
				element = _liste[idx];
			}
			catch( ArgumentOutOfRangeException ) {

				element = default( T );
			}

			return element;
		}

		#endregion Methoden
	}
}