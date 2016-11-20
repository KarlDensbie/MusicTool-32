using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken.Datensätze;

namespace MusicTool.Datenbanken
{
	/// <summary> Klasse       : DB_Intervalle
	/// <para>STATISCHE KLASSE</para>
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
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-14  14:34:14";
		private static string zz_ersteBearbeitung= "2016-11-14 13:49.04";
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

		/// <summary>_liste
		/// <para>Liste der Intervalle</para>
		/// <para> TYP: Liste von ds_Ton</para>
		/// </summary>
		private static bcl_BasisListe<ds_Intervall> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary>  Standardkonstruktor()
		/// <para>initialisiert die Datenbank</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:22:52</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:22:52</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static DB_Intervalle()
		{
			_liste = new bcl_BasisListe<ds_Intervall>( "DB_Intervalle" , dType.DB_Intervalle , 0 );
			INIT();
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die Datenbank mit allen Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:22:07</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:22:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void INIT()
		{
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
		}

		/// <summary> Methode: ds_Intervall setMember(name,altName,idx,basisIntervall)
		/// <para>Hilfsmethode zur einfacheren initialisierung</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:07:10</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:04:25</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Intervalls, TYP: STRING</param>
		/// <param name="altName">alternativer Name des Intervalls, TYP: STRING</param>
		/// <param name="idx">Index des Intervalls in der Datenbank DB_Intervalle, TYP: eIntervall</param>
		/// <param name="bas">Basis-Intervall, TYP: eBasisIntervall</param>
		/// <returns>Datensatz, TYP: ds_Intervall</returns>
		private static ds_Intervall setMember(string name,string altName,eIntervall idx,eBasisIntervall bas)
		{
			return new ds_Intervall( name , altName,idx , bas );
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der Datensätze aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:32</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:10:14</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static int Anzahl { get { return _liste.Anzahl; } }

		/// <summary> Eigenschaft: Name
		/// <para>gibt den Namen der Liste aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:16</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:13:21</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static string Name { get { return _liste.Name; } }

		/// <summary> Eigenschaft: Typ
		/// <para>gibt den Daten-Typ der Liste aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  13:54:01</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:14:50</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static dType Typ { get { return _liste.Typ; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: get(eIntervall idx)
		/// <para>gibt einen Intervall-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:28:02</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:28:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="idx">Index des Intervall, TYP: eIntervall</param>
		/// <returns>Intervall-Datensatz, TYP: ds_Intervall</returns>
		public static ds_Intervall get(eIntervall idx)
		{
			if( idx == eIntervall.X ) return null;
			return _liste.getElement( (int)idx );
		}

		/// <summary> Methode: get(int idx)
		/// <para>gibt einen Intervall-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-14  14:33:31</para>
		/// <para>    ersteBearbeitung : 2016-11-14  14:28:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="idx">Index des Intervall, TYP: int</param>
		/// <returns>Intervall-Datensatz, TYP: ds_Intervall</returns>
		public static ds_Intervall get( int idx )
		{
			ds_Intervall datensatz;
			try {
				datensatz = _liste.getElement( idx );
			}
			catch( ArgumentOutOfRangeException ) {
				return null;
			}

			return datensatz;
		}

		#endregion Methoden
	}
}