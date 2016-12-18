﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicTool;
using MusicTool.Basisklassen;
using MusicTool.Datenbanken;
using MusicTool.Datenbanken.Datensätze;
using MusicTool.Eingabe;
using MusicTool.Fenster;
using MusicTool.Fenster.Testanzeigen;

namespace MusicTool.Fenster.Testanzeigen
{
	/// <summary> Klasse       : <b>wnd_StatusOn
	/// </b><para></para>
	/// <para>zeigt den Status oder eine Nachricht an
	/// </para>
	/// <b><i> </i></b>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public partial class wnd_StatusOn : Form
	{

		/// <summary>  Standardkonstruktor()
		/// <para>erledigt die Initialisierung des Fensters</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-13  12:20:17</para>
		/// <para>    ersteBearbeitung : 2016-12-13  12:20:17</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_StatusOn()
		{
			InitializeComponent();
		}

		/// <summary> Konstruktor(Methode)
		/// <para>instanziiert das Fenster mit dem Namen der aufrufenden Methode
		/// und zeigt an, das diese Methode gestartet wurde</para>
		/// </summary>
		/// <param name="Methode">Name der Methode, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-13  12:21:52</para>
		/// <para>    ersteBearbeitung : 2016-12-13  12:21:52</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_StatusOn(string Methode):this()
		{
			anzeigebereich1.setName( Methode );
			anzeigebereich1.setData( "wurde gestartet ... " );

			ShowDialog();
		}

		/// <summary> Konstruktor(Methode,Nachricht)
		/// <para>zeigt ein Fenster mit dem Namen einer Methode und einer Nachricht</para>
		/// </summary>
		/// <param name="Methode">Name der Methode, TYP: STRING</param>
		/// <param name="Nachricht">Nachricht der Methode, TYP: STRING</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-13  12:24:39</para>
		/// <para>    ersteBearbeitung : 2016-12-13  12:24:39</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public wnd_StatusOn(string Methode,string Nachricht):this()
		{
			anzeigebereich1.setName( Methode );
			anzeigebereich1.setData( Nachricht );

			ShowDialog();
		}

		/// <summary> Methode:  button1_Click(...)
		/// <para>schließt das Fenster</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-13  12:26:30</para>
		/// <para>    ersteBearbeitung : 2016-12-13  12:26:30</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		private void button1_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
