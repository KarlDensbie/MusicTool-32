using System;
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

namespace MusicTool.Fenster.Testanzeigen
{
	public partial class Anz_Intervall_Objekt : Form
	{
		/// <summary>  Standardkonstruktor()
		/// <para>wird von allen anderen Konstruktoren aufgerufen</para>
		/// </summary>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:29:11</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:29:11</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_Intervall_Objekt()
		{
			InitializeComponent();

			gp_Name.setName( "Intervall : " );
			AltName.setName( "alternativer Name:" );
			BasisIntervall.setName( "Basis-Intervall : " );
			ID.setName( "ID : " );
			IntervallID.setName( "IntervallID : " );
			Typ.setName( "Typ : " );

			ShowDialog();
		}

		/// <summary> Konstruktor(methode,Intervall-Objekt)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="objekt">Intervall-Objekt, TYP: ds_Intervall</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:30:15</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:30:15</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_Intervall_Objekt(string methode, ds_Intervall objekt):this()
		{
			lbl_Methode.Text = methode;
			string _name = objekt.Name;
			string _altName = objekt.AltName;
			string _intervallName = objekt.IntervallName;
			string _altIntervallName = objekt.AltIntervallName;
			string _basisIntervall = objekt.BasisIntervall.ToString();
			string _intervallID = objekt.IntervallID.ToString();
			string _id = objekt.ID.ToString();
			string _typ = objekt.Typ.ToString();
			// --------------------------------------------------------
			gp_Name.setData( _name );
			AltName.setData( _altName );
			BasisIntervall.setData( _basisIntervall );
			IntervallID.setData( _intervallID );
			ID.setData( _id );
			Typ.setData( _typ );

			ShowDialog();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
