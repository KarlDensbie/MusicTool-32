using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken;
using MusicTool.Datenbanken.Datensätze;

namespace MusicTool.Eingabe
{
	/// <summary> Klasse       : <b>Eingaben
	/// </b><para></para>
	/// speichert alle eingegebenen Töne
	/// <para></para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class Eingaben
	{
		#region VersionInfo

		private static string zz_klassenName= "Eingaben";
		private static string zz_namespace = "MusicTool.Eingabe";
		private static dType zz_datenTyp = dType.Eingabe;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-11-25 18:49.42";
		private static string zz_ersteBearbeitung= "2016-11-25 18:49.42";
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
		/// <para>    letzteBearbeitung: 2016-11-23  18:30:44</para>
		/// <para>    ersteBearbeitung : 2016-11-23  18:30:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public static string VersionInfo()
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

		/// <summary> _eingabeNamen
		/// <para>Liste der eingegebenen TonNamen</para>
		/// <para>TYP: <b><i>List&lt;STRING&gt;</i></b></para>
		/// </summary>
		private List<string> _eingabeNamen;

		/// <summary>_eingegebeneTöne
		/// <para>Liste der eingegebenen Töne</para>
		/// <para>TYP: <b><i>List&lt;ds_Ton&gt;</i></b></para>
		/// </summary>
		private List<ds_Ton> _eingegebeneTöne;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(eingaben)
		/// <para>instanziiert die Instanz,
		/// initialisiert die Listen,
		/// speichert die Eingaben und
		/// speichert dazu die gefundenen Tonobjekte</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-11-25  19:15:37</para>
		/// <para>    ersteBearbeitung : 2016-11-25  19:05:50</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Eingaben(params string[] eingaben )
		{
			_eingabeNamen = new List<string>();
			_eingegebeneTöne = new List<ds_Ton>();

			string e;	// eingegebener Ton
			ds_Ton f;	// gefundenes Ton-Objekt

			for( int i = 0 ; i < eingaben.Length ; i++ ) {
				e = eingaben[i];			// eingegebenen Ton zur Liste hinzufügen
				_eingabeNamen.Add( e );		
				for( int s = 0 ; s < DB_Töne.Anzahl ; s++ ) {
					f = DB_Töne.getTon( s );
					// gefundenes  Tonobjekt speichern
					if( f.TonName == e&&f!=null ) _eingegebeneTöne.Add( f );
				}
			}
		}

		#endregion Konstruktor

		#region Eigenschaften

		#endregion Eigenschaften

		#region Methoden

		#endregion Methoden
	}
}
