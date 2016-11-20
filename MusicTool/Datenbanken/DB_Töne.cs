using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken.Datensätze;

namespace MusicTool.Datenbanken
{
	/// <summary> Klasse       : DB_Töne
	/// <para>STATISCHE KLASSE</para>
	/// <para>Datenbank der Töne</para>
	/// <para>enthält alle Daten aller Töne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class DB_Töne
	{
		#region VersionInfo

		private static string zz_klassenName= "DB_Töne";
		private static string zz_namespace = "MusicTool.Datenbanken";
		private static dType zz_datenTyp = dType.DB_Töne;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-14  13:57:06";
		private static string zz_ersteBearbeitung= "2016-11-13 12:17.48";
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
		/// <para>Liste der Töne</para>
		/// <para> TYP: Liste von ds_Ton</para>
		/// </summary>
		private static bcl_BasisListe<ds_Ton> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary>  Standardkonstruktor()
		/// <para>initialisiert die Datenbank</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:08:00</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:08:00</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static DB_Töne()
		{
			_liste = new bcl_BasisListe<ds_Ton>( "DB_Töne" , dType.DB_Töne , 0 );
				INIT();
		}

		/// <summary> Methode: INIT()
		/// <para>initialisiert die Datenbank mit allen Tönen</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:07:02</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:07:02</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void INIT()
		{
			_liste.ADD( setMember( "Cbb" , eTon.Ceses , eGrundton.C , eTon.Ais , eTon.B ) );
			_liste.ADD( setMember( "Cb" , eTon.Ces, eGrundton.C, eTon.Aisis, eTon.H) );
			_liste.ADD( setMember( "C" , eTon.C , eGrundton.C , eTon.His , eTon.Deses ) );
			_liste.ADD( setMember( "C#" , eTon.Cis , eGrundton.C , eTon.Hisis , eTon.Des ) );
			_liste.ADD( setMember( "C##" , eTon.Cisis , eGrundton.C , eTon.D , eTon.Eses ) );

			_liste.ADD( setMember( "Dbb" , eTon.Deses , eGrundton.D , eTon.His , eTon.C ) );
			_liste.ADD( setMember( "Db" , eTon.Des , eGrundton.D , eTon.Hisis , eTon.Cis ) );
			_liste.ADD( setMember( "D" , eTon.D , eGrundton.D , eTon.Cisis , eTon.Eses ) );
			_liste.ADD( setMember( "D#" , eTon.Dis , eGrundton.D , eTon.Es , eTon.Feses ) );
			_liste.ADD( setMember( "D##" , eTon.Disis , eGrundton.D , eTon.E , eTon.Fes ) );

			_liste.ADD( setMember( "Ebb" , eTon.Eses , eGrundton.E , eTon.Cisis , eTon.D ) );
			_liste.ADD( setMember( "Eb" , eTon.Es , eGrundton.E , eTon.Dis , eTon.Feses ) );
			_liste.ADD( setMember( "E" , eTon.E , eGrundton.E , eTon.Disis , eTon.Fes ) );
			_liste.ADD( setMember( "E#" , eTon.Eis , eGrundton.E , eTon.F , eTon.Geses ) );
			_liste.ADD( setMember( "E##" , eTon.Eisis , eGrundton.E , eTon.Fis , eTon.Ges ) );

			_liste.ADD( setMember( "Fbb" , eTon.Feses , eGrundton.F , eTon.Dis , eTon.Es ) );
			_liste.ADD( setMember( "Fb" , eTon.Fes , eGrundton.F , eTon.Disis , eTon.E ) );
			_liste.ADD( setMember( "F" , eTon.F , eGrundton.F , eTon.Eis , eTon.Geses ) );
			_liste.ADD( setMember( "F#" , eTon.Fis , eGrundton.F , eTon.Eisis , eTon.Ges ) );
			_liste.ADD( setMember( "F##" , eTon.Fisis , eGrundton.F , eTon.G , eTon.Ases ) );

			_liste.ADD( setMember( "Gbb" , eTon.Geses , eGrundton.G , eTon.Eis , eTon.F ) );
			_liste.ADD( setMember( "Gb" , eTon.Ges , eGrundton.G , eTon.Eisis , eTon.Fis ) );
			_liste.ADD( setMember( "G" , eTon.G , eGrundton.G , eTon.Fisis , eTon.Ases ) );
			_liste.ADD( setMember( "G#" , eTon.Gis , eGrundton.G , eTon.As , eTon.As ) );
			_liste.ADD( setMember( "G##" , eTon.Gisis , eGrundton.G , eTon.A , eTon.Heses ) );

			_liste.ADD( setMember( "Abb" , eTon.Ases , eGrundton.A , eTon.Fisis , eTon.G ) );
			_liste.ADD( setMember( "Ab" , eTon.As , eGrundton.A , eTon.Gis , eTon.Gis ) );
			_liste.ADD( setMember( "A" , eTon.A , eGrundton.A , eTon.Gisis , eTon.Heses ) );
			_liste.ADD( setMember( "A#" , eTon.Ais , eGrundton.A , eTon.B , eTon.Ceses ) );
			_liste.ADD( setMember( "A##" , eTon.Aisis , eGrundton.A , eTon.H , eTon.Ces ) );

			_liste.ADD( setMember( "Hbb" , eTon.Heses , eGrundton.H , eTon.Gisis , eTon.A ) );
			_liste.ADD( setMember( "B" , eTon.B , eGrundton.H , eTon.Ais , eTon.Ceses ) );
			_liste.ADD( setMember( "H" , eTon.H , eGrundton.H , eTon.Aisis , eTon.Ces ) );
			_liste.ADD( setMember( "H#" , eTon.His , eGrundton.H , eTon.C , eTon.Deses ) );
			_liste.ADD( setMember( "H##" , eTon.Hisis , eGrundton.H , eTon.Cis , eTon.Des ) );
		}

		/// <summary> Methode: setMember(name,idx,grundton,enhU,enhO)
		/// <para>erzeugt einen Datensatz für Töne</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  12:30:17</para>
		/// <para>    ersteBearbeitung : 2016-11-13  12:30:17</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Tons, TYP: STRING</param>
		/// <param name="idx">Index des Tons, TYP: eTon</param>
		/// <param name="grundton">Grundton, TYP: eGrundton</param>
		/// <param name="enhU">untere enharmonische Verwechselung, TYP: eTon</param>
		/// <param name="enhO">obere enharmonische Verwechselung, TYP: eTon</param>
		/// <returns>Ton-Datensatz, TYP: ds_Ton</returns>
		private static ds_Ton setMember(string name,eTon idx,eGrundton grundton,eTon enhU,eTon enhO)
		{
			return new ds_Ton( name , idx , grundton , enhU , enhO );
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
		/// <para>    letzteBearbeitung: 2016-11-13  13:10:14</para>
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
		/// <para>    letzteBearbeitung: 2016-11-13  13:13:21</para>
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
		/// <para>    letzteBearbeitung: 2016-11-13  13:14:50</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:14:50</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static dType Typ { get { return _liste.Typ; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: getTon(eTon idx)
		/// <para>gibt einen Ton-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  13:24:18</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:24:18</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="idx">Index des Tons, TYP: eTon</param>
		/// <returns>Ton-Datensatz, TYP: ds_Ton</returns>
		public static ds_Ton getTon(eTon idx)
		{
			if( idx == eTon.X ) return null;
			return _liste.getElement( (int)idx );
		}

		/// <summary> Methode: getTon(int idx)
		/// <para>gibt einen Ton-Datensatz aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-13  14:43:14</para>
		/// <para>    ersteBearbeitung : 2016-11-13  13:24:18</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="idx">Index des Tons, TYP: INT</param>
		/// <returns>Ton-Datensatz, TYP: ds_Ton</returns>
		public static ds_Ton getTon( int idx )
		{
			ds_Ton datensatz;
			try {
				datensatz=_liste.getElement( idx );
			}
			catch( ArgumentOutOfRangeException ) {

				return null;
			}
			return datensatz;
		}

		#endregion Methoden
	}
}