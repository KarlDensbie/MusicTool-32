using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_Basisdata2
	/// <para>Basisklasse für alle Datensätze mit 2 Namen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_Basisdata2
	{
		#region VersionInfo

		private static string zz_klassenName= "Basisdata2";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Basisdaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "3";
		private static string zz_letzteBearbeitung= "2016-11-11  12:31:24";
		private static string zz_ersteBearbeitung= "2016-11-06 12:35.35";
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:31:43</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:32:38</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:33:31</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:34:43</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:35:45</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:36:44</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:37:35</para>
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
		/// <para>    letzteBearbeitung: 2016-07-10  12:43:07</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:43:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>_typ
		/// <para>Datentyp des Objekts</para>
		/// </summary>
		private dType _typ;

		/// <summary>_name
		/// <para>Name des Objekts</para>
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _name;

		/// <summary>_altName
		/// <para>alternativer Name des Objekts</para>
		/// <para>TYP: STRING</para>
		/// </summary>
		private string _altName;

		/// <summary>_index
		/// <para>Index des Objekts</para>
		/// <para>TYP: INT</para>
		/// </summary>
		private int _index;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,name2,idx,typ)
		/// <para>initialisiert die Instanz</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-11-11  12:28:11</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:46:24</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Objekts, TYP: STRING</param>
		/// <param name="altName">alternativer Name des Objekts, TYP: STRING</param>
		/// <param name="idx">Index des Objekts, TYP: INT</param>
		/// <param name="typ">Datentyp des Objekts, TYP: dType</param>
		public bcl_Basisdata2( string name , string altName , int idx ,dType typ )
		{
			_name = name;
			_altName = altName;
			_index = idx;
			_typ = typ;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Index
		/// <para>gibt den Index des Objekts aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-11-11  12:28:54</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:50:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Index { get { return _index; } }

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen des Objekts aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-06  12:51:49</para>
		/// <para>    ersteBearbeitung : 2016-11-06  12:51:49</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary> Eigenschaft: AltName
		/// <para>gibt den alternativen Namen des Objekts aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-06  13:10:57</para>		
		/// <para>    ersteBearbeitung : 2016-11-06  12:51:49</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string AltName { get { return _altName; } }

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Datentyp des Objekts aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-06  17:13:43</para>
		/// <para>    ersteBearbeitung : 2016-11-06  17:13:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public dType Typ { get { return _typ; } }

		#endregion Eigenschaften

	}
}