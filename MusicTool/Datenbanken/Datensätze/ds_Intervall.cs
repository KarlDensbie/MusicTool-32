using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbanken.Datensätze
{
	/// <summary> Klasse       : ds_Intervall
	/// <para>ABGELEITET VON: bcl_Basisdata2</para>
	/// <para>Datensatz für Intervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Intervall:bcl_Basisdata2
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Intervall";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Intervalldaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-14  14:03:55";
		private static string zz_ersteBearbeitung= "2016-11-12 19:26.39";
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
		public static new string zz_KlassenName { get { return zz_klassenName; } }
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
		public static new string zz_Namespace { get { return zz_namespace; } }
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
		public static new string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
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
		public static new string zz_VersionInfo
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
		public static new string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
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
		public static new string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
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
		public static new dType zz_DatenTyp { get { return zz_datenTyp; } }
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
		public static new string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>_intervallIndex
		/// <para>Index des Intervalls</para>
		/// <para>TYP: eIntervall</para>
		/// </summary>
		private eIntervall _intervallIndex;

		/// <summary>_basisIntervall
		/// <para>Basis-Intervall</para>
		/// <para>TYP: eBasisIntervall</para>
		/// </summary>
		private eBasisIntervall _basisIntervall;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,altName,index,basisIntervall)
		/// <para>initialisiert die Klasse mit allen erforderlichen Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:03:44</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:35:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Intervalls, TYP: STRING</param>
		/// <param name="altName">alternativer Name des Intervalls, TYP: STRING</param>
		/// <param name="idx">Index des Intervalls in der Datenbank DB_Intervalle, TYP: eIntervall</param>
		/// <param name="bas">Basis-Intervall, TYP: eBasisIntervall</param>
		public ds_Intervall( string name,string altName,eIntervall idx,eBasisIntervall bas):
			base(name,altName,(int)idx,dType.Intervalldaten)
		{
			_intervallIndex = idx;
			_basisIntervall = bas;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: IntervallName
		/// <para>gibt den Intervall-Namen aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:40:34</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:40:34</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string IntervallName { get { return Name; } }

		/// <summary> Eigenschaft: AltIntervallName
		/// <para>gibt den alternativen Intervall-Namen aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:41:59</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:40:34</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string AltIntervallName { get { return Name; } }

		/// <summary> Eigenschaft: IntervallIndex
		/// <para>gibt das IntervallIndex aus</para>
		/// <para>TYP: eIntervall</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:43:00</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:43:00</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eIntervall IntervallIndex { get { return _intervallIndex; } }

		/// <summary> Eigenschaft: BasisIntervall
		/// <para>gibt das BasisIntervall aus</para>
		/// <para>TYP: eBasisIntervall</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:44:33</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:44:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eBasisIntervall BasisIntervall { get { return _basisIntervall; } }

		/// <summary> Eigenschaft: IntBasisIntervall
		/// <para>gibt das BasisIntervall aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  19:44:33</para>
		/// <para>    ersteBearbeitung : 2016-11-12  19:44:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eBasisIntervall IntBasisIntervall { get { return _basisIntervall; } }

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}