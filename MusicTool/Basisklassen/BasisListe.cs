using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_BasisListe
	/// <para>ABGELEITET VON: </para>
	/// <para>Basisklasse für Listen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_BasisListe<T>
	{
		#region VersionInfo

		private string zz_klassenName= "BasisListe<T>";
		private string zz_namespace = "MusicTool.Basisklassen";
		private dType zz_datenTyp = dType.Basisliste;
		private string zz_hauptversion= "0";
		private string zz_nebenversion= "1";
		private string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-13  12:41:17";
		private string zz_ersteBearbeitung= "2016-11-06 18:09.43";
		private string zz_getestet= "";
		#region VersionInfoEigenschaften
		/// <summary> Eigenschaft: zz_KlassenName
		/// <para>gibt den Namen der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:38:11</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:31:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_KlassenName { get { return zz_klassenName; } }
		/// <summary> Eigenschaft: zz_Namespace
		/// <para>gibt den Namespace der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:38:38</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:32:38</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_Namespace { get { return zz_namespace; } }
		/// <summary> Eigenschaft: zz_Pfad
		/// <para>gibt den Pfad (Namespace + Klassenname) aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:38:57</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:33:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		/// <summary> Eigenschaft: zz_VersionInfo
		/// <para>gibt die Version der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:39:39</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:34:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_VersionInfo
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
		/// <para>    letzteBearbeitung: 2016-11-13  12:40:03</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:35:45</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		/// <summary> Eigenschaft: zz_BearbeitungsBeginn
		/// <para>gibt aus, ab wann diese Klasse programmiert wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:40:20</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:36:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		/// <summary> Eigenschaft: zz_DatenTyp
		/// <para>gibt den Datentyp der Klasse aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:40:37</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:37:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public dType zz_DatenTyp { get { return zz_datenTyp; } }
		/// <summary> Eigenschaft: zz_Getestet
		/// <para>gibt aus, wann die Klasse getestet wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:41:00</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:43:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>_liste
		/// <para>allgemeine Liste unbestimmten Typs</para>
		/// </summary>
		private List<T> _liste;

		/// <summary>_name
		/// <para>speichert den Namen der Liste</para>
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

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

		/// <summary> Konstruktor(name,typ,index)
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  13:03:32</para>
		/// <para>    ersteBearbeitung : 2016-11-12  10:22:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name der Liste, TYP: STRING</param>
		/// <param name="typ">Typ der Liste, TYP: dType</param>
		/// <param name="idx">index der Liste, TYP: INT</param>
		public bcl_BasisListe(string name,dType typ,int idx)
		{
			_name = name;
			_typ = typ;
			_index = idx;
			_liste = new List<T>();
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

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen der Liste aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  13:05:06</para>
		/// <para>    ersteBearbeitung : 2016-11-12  13:05:06</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Typ der Liste aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  13:06:36</para>
		/// <para>    ersteBearbeitung : 2016-11-12  13:06:36</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public dType Typ { get { return _typ; } }

		/// <summary> Eigenschaft: Index
		/// <para>gibt den Index der Liste aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  13:07:58</para>
		/// <para>    ersteBearbeitung : 2016-11-12  13:07:58</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Index { get { return _index; } }

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
		public void ADD(T element)
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
		public T getElement(int idx)
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