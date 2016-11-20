using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbanken.Datensätze
{
	/// <summary> Klasse       : ds_Ton
	/// <para>ABGELEITET VON: bcl_Basisdata</para>
	/// <para></para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Ton:bcl_Basisdata
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Ton";
		private static string zz_namespace = "MusicTool.Datenbanken.Datensätze";
		private static dType zz_datenTyp = dType.Tondaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-12  17:17:37";
		private static string zz_ersteBearbeitung= "2016-11-12 16:31.31";
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

		/// <summary>_tonIndex
		/// <para>Index des Tons in der Datenbank DB_Töne</para>
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _tonIndex;

		/// <summary>_grundton
		/// <para>Grundton des Tons (Tonfamilie)</para>
		/// <para>TYP: eGrundton</para>
		/// </summary>
		private eGrundton _grundton;

		/// <summary>_enhU
		/// <para>Index der unteren enharmonischen Verwechselung</para>
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _enhU;

		/// <summary>_enhO
		/// <para>Index der oberen enharmonischen Verwechselung</para>
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _enhO;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,index,grundTon,enhU,enhO)
		/// <para>initialisiert die Klasse mit allen nötigen Informationen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:03:53</para>
		/// <para>    ersteBearbeitung : 2016-11-12  16:56:45</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Tons, TYP: STRING</param>
		/// <param name="idx">Index des Tons in der Datenbank DB_Töne, TYP: eTon</param>
		/// <param name="grundTon">Grundton des Tons (Tonfamilie), TYP: eGrundton</param>
		/// <param name="enhU">Index der unteren enharmonischen Verwechselung, TYP: eTon</param>
		/// <param name="enhO">Index der oberen enharmonischen Verwechselung, TYP: eTon</param>
		public ds_Ton(string name,eTon idx,eGrundton grundTon,eTon enhU,eTon enhO):
			base(name,dType.Tondaten , (int)idx)
		{
			_tonIndex = idx;
			_grundton = grundTon;
			_enhO = enhO;
			_enhU = enhU;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: TonName
		/// <para>gibt den Namen des Tons aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:05:23</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:05:23</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public string TonName { get { return Name; } }

		/// <summary> Eigenschaft: TonIndex
		/// <para>gibt den Ton-Index als eTon aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:07:54</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:07:54</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon TonIndex { get { return _tonIndex; } }

		/// <summary> Eigenschaft: Grundton
		/// <para>gibt den Grundton als eGrundton aus</para>
		/// <para>TYP: eGrundton</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:09:54</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:09:54</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eGrundton Grundton { get { return _grundton; } }

		/// <summary> Eigenschaft: IntGrundton
		/// <para>gibt den Grundton als INT aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:12:10</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:09:54</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int IntGrundton { get { return (int)_grundton; } }

		/// <summary> Eigenschaft: EnhU
		/// <para>gibt den Ton-Index der unteren enharmonischen Verwechselung als eTon aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon EnhU { get { return _enhU; } }

		/// <summary> Eigenschaft: IntEnhU
		/// <para>gibt den Ton-Index der unteren enharmonischen Verwechselung als INT aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int IntEnhU { get { return (int)_enhU; } }

		/// <summary> Eigenschaft: EnhO
		/// <para>gibt den Ton-Index der oberen enharmonischen Verwechselung als eTon aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon EnhO { get { return _enhO; } }

		/// <summary> Eigenschaft: IntEnhO
		/// <para>gibt den Ton-Index der oberen enharmonischen Verwechselung als INT aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-12  17:13:16</para>
		/// <para>    ersteBearbeitung : 2016-11-12  17:13:16</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int IntEnhO { get { return (int)_enhO; } }

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}
