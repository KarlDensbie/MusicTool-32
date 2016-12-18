using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTool
{
	/// <summary>Aufzählung : dType
	/// <para>dient zur Angabe des Datentyps von Klassen</para>
	/// </summary>
	public enum dType
	{
		/// <summary>
		/// Basisdaten für alle Datenklassen:
		/// <para>Ton,Intervall,Tonart,Modus,Akkord und alle Datenbanken</para>
		/// </summary>
		Basisdaten = 0,
		/// <summary>
		/// Daten eines Tons
		/// </summary>
		Tondaten = 1,
		/// <summary>
		/// Daten eines Intervalls
		/// </summary>
		Intervalldaten = 2,
		/// <summary>
		/// Basisliste für alle listenbasierten Datenklassen:
		/// <para>Ton_DB, Intervall_DB, Tonart, Tonarten_DB, Akkord, Akkord_DB, Modus und Modi_DB</para>
		/// </summary>
		Basisliste = 3,
		/// <summary>
		/// Ton-Datenbank
		/// </summary>
		DB_Töne = 4,
		/// <summary>
		/// Intervall-Datenbank
		/// </summary>
		DB_Intervalle = 5,
		/// <summary>
		/// Tonart in der DB_tonarten
		/// </summary>
		Tonart = 6,
		/// <summary>
		/// Tonarten-Datenbank
		/// </summary>
		DB_Tonarten = 7,
		/// <summary>
		/// Modus-Datensatz der DB_Modi
		/// </summary>
		Modus =8 ,
		/// <summary>
		/// Modi-Datenbank
		/// </summary>
		DB_Modi =9 ,
		/// <summary>
		/// eingegebene Töne
		/// </summary>
		Eingabe = 10,
		/// <summary>
		/// Fenster zur Anzeige von Informationen
		/// </summary>
		InfoFenster = 253,
		/// <summary>Tool für diverse Zwecke
		/// </summary> 
		Tool = 254,
		/// <summary>
		/// The main PRG
		/// </summary>
		MainPrg = 255,
		/// <summary>
		/// Testprogramme
		/// </summary>
		TEST
	}

	/// <summary> AUFZÄHLUNG: eTon
	/// <para>Aufzählung der Tonindizes in der Datenbank Töne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-05-16</para>
	/// <para>    ersteBearbeitung : 2016-05-16</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum eTon
	{
		/// <summary>Ton Cbb
		/// </summary>
		Ceses = 0,
		/// <summary>Ton Cb
		/// </summary>
		Ces = 1,
		/// <summary>Ton C
		/// </summary>
		C = 2,
		/// <summary>Ton C#
		/// </summary>
		Cis = 3,
		/// <summary>Ton C##
		/// </summary>
		Cisis = 4,
		/// <summary>Ton Dbb
		/// </summary>
		Deses = 5,
		/// <summary>Ton Db
		/// </summary>
		Des = 6,
		/// <summary>Ton D
		/// </summary>
		D = 7,
		/// <summary>Ton D#
		/// </summary>
		Dis = 8,
		/// <summary>Ton D##
		/// </summary>
		Disis = 9,
		/// <summary>Ton Ebb
		/// </summary>
		Eses = 10,
		/// <summary>Ton Eb
		/// </summary>
		Es = 11,
		/// <summary>Ton E
		/// </summary>
		E = 12,
		/// <summary>Ton E#
		/// </summary>
		Eis = 13,
		/// <summary>Ton E##
		/// </summary>
		Eisis = 14,
		/// <summary>Ton Fbb
		/// </summary>
		Feses = 15,
		/// <summary>Ton Fb
		/// </summary>
		Fes = 16,
		/// <summary>Ton F
		/// </summary>
		F = 17,
		/// <summary>Ton F#
		/// </summary>
		Fis = 18,
		/// <summary>Ton F##
		/// </summary>
		Fisis = 19,
		/// <summary>Ton Gbb
		/// </summary>
		Geses = 20,
		/// <summary>Ton Gb
		/// </summary>
		Ges = 21,
		/// <summary>Ton G
		/// </summary>
		G = 22,
		/// <summary>Ton G#
		/// </summary>
		Gis = 23,
		/// <summary>Ton G##
		/// </summary>
		Gisis = 24,
		/// <summary>Ton Abb
		/// </summary>
		Ases = 25,
		/// <summary>Ton Ab
		/// </summary>
		As = 26,
		/// <summary>Ton A
		/// </summary>
		A = 27,
		/// <summary>Ton A#
		/// </summary>
		Ais = 28,
		/// <summary>Ton A##
		/// </summary>
		Aisis = 29,
		/// <summary>Ton Hbb
		/// </summary>
		Heses = 30,
		/// <summary>Ton Bb
		/// </summary>
		B = 31,
		/// <summary>Ton H
		/// </summary>
		H = 32,
		/// <summary>Ton H#
		/// </summary>
		His = 33,
		/// <summary>Ton H##
		/// </summary>
		Hisis = 34,
		/// <summary>KEIN Ton 
		/// </summary>
		X = 255
	}

	/// <summary> AUFZÄHLUNG: eGrundton
	/// <para>Aufzählung der Grundtöne</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-05-16</para>
	/// <para>    ersteBearbeitung : 2016-05-16</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum eGrundton
	{
		/// <summary> Grundton C
		/// </summary>
		C = 0,
		/// <summary> Grundton D
		/// </summary>
		D = 1,
		/// <summary> Grundton E
		/// </summary>
		E = 2,
		/// <summary> Grundton F
		/// </summary>
		F = 3,
		/// <summary> Grundton G
		/// </summary>
		G = 4,
		/// <summary> Grundton A
		/// </summary>
		A = 5,
		/// <summary> Grundton H
		/// </summary>
		H = 6,
		/// <summary> KEIN Grundton 
		/// </summary>
		X = 255
	}

	/// <summary> AUFZÄHLUNG: eIntervall
	/// <para>Aufzählung der Indizes der Intervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-05-17  13:41:43</para>
	/// <para>    ersteBearbeitung : 2016-05-17  13:41:43</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum eIntervall
	{
		/// <summary>Intervall I
		/// </summary>
		Prime = 0,
		/// <summary>Intervall b9
		/// </summary>
		None_K = 1,
		/// <summary>Intervall 9
		/// </summary>
		None_G = 2,
		/// <summary>Intervall #9
		/// </summary>
		None_Ü = 3,
		/// <summary>Intervall m
		/// </summary>
		Terz_K = 4,
		/// <summary>Intervall III
		/// </summary>
		Terz_G = 5,
		/// <summary>Intervall b11
		/// </summary>
		Undez_V = 6,
		/// <summary>Intervall 11
		/// </summary>
		Undez = 7,
		/// <summary>Intervall #11
		/// </summary>
		Undez_Ü = 8,
		/// <summary>Intervall b5
		/// </summary>
		Quinte_V = 9,
		/// <summary>Intervall V
		/// </summary>
		Quinte = 10,
		/// <summary>Intervall #5
		/// </summary>
		Quinte_Ü = 11,
		/// <summary>Intervall b13
		/// </summary>
		Tredez_K = 12,
		/// <summary>Intervall 13
		/// </summary>
		Tredez_G = 13,
		/// <summary>Intervall b7
		/// </summary>
		Sept_V = 14,
		/// <summary>Intervall 7
		/// </summary>
		Sept_K = 15,
		/// <summary>Intervall MAJ
		/// </summary>
		Sept_G = 16,
		/// <summary>KEIN Intervall 
		/// </summary>
		X = 255
	}

	/// <summary> AUFZÄHLUNG: eBasisIntervall
	/// <para>Aufzählung der Basisintervalle</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-05-17  16:17:10</para>
	/// <para>    ersteBearbeitung : 2016-05-17  16:17:10</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum eBasisIntervall
	{
		/// <summary>Basisintervall Prime
		/// </summary>
		Prime = 0,
		/// <summary>Basisintervall None (Sekunde)
		/// </summary>
		None = 1,
		/// <summary>Basisintervall Terz
		/// </summary>
		Terz = 2,
		/// <summary>Basisintervall Undezime (Quarte)
		/// </summary>
		Undez = 3,
		/// <summary>Basisintervall Quinte
		/// </summary>
		Quinte = 4,
		/// <summary>Basisintervall Tredezime (Sexte)
		/// </summary>
		Tredez = 5,
		/// <summary>Basisintervall Septime
		/// </summary>
		Sept = 6,
		/// <summary>KEIN Basisintervall 
		/// </summary>
		X = 255
	}

	/// <summary> AUFZÄHLUNG: eTonart
	/// <para>Aufzählung der Tonarten</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	///           Version          : 0
	/// <para>    Unterversion     : 1</para>
	///           Revision         : 1
	/// <para>    letzteBearbeitung: 2016-05-18  22:32:20</para>
	/// <para>    ersteBearbeitung : 2016-05-18  22:32:20</para>
	/// .
	/// <para>    getestet am      : </para>
	/// </summary>
	public enum eTonart
	{
		/// <summary>Tonart C
		/// </summary>
		C = 0,
		/// <summary>Tonart C#
		/// </summary>
		Cis = 1,
		/// <summary>Tonart Db
		/// </summary>
		Des = 2,
		/// <summary>Tonart D
		/// </summary>
		D = 3,
		/// <summary>Tonart D#
		/// </summary>
		Dis = 4,
		/// <summary>Tonart Eb
		/// </summary>
		Es = 5,
		/// <summary>Tonart E
		/// </summary>
		E = 6,
		/// <summary>Tonart F
		/// </summary>
		F = 7,
		/// <summary>Tonart F#
		/// </summary>
		Fis = 8,
		/// <summary>Tonart Gb
		/// </summary>
		Ges = 9,
		/// <summary>Tonart G
		/// </summary>
		G = 10,
		/// <summary>Tonart G#
		/// </summary>
		Gis = 11,
		/// <summary>Tonart Ab
		/// </summary>
		As = 12,
		/// <summary>Tonart A
		/// </summary>
		A = 13,
		/// <summary>Tonart A#
		/// </summary>
		Ais = 14,
		/// <summary>Tonart Bb
		/// </summary>
		B = 15,
		/// <summary>Tonart H
		/// </summary>
		H = 16
	}

	// ----------------------------------------------------------------------------------------------------

	/// <summary>Aufzählung : 
	/// 
	/// </summary>
	public class Aufzählungen
	{
	}
}
