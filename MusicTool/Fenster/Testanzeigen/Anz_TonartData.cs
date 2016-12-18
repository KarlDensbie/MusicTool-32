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
using MusicTool.Fenster;
using MusicTool.Fenster.Testanzeigen;

namespace MusicTool.Fenster.Testanzeigen
{
	public partial class Anz_TonartData : Form
	{
		/// <summary> Konstruktor(methode,tonart)
		/// <para></para>
		/// </summary>
		/// <param name="methode">Name der aufrufenden Methode, TYP: STRING</param>
		/// <param name="tonart">Tonart-Objekt, TYP: ds_Tonart</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  17:20:32</para>
		/// <para>    ersteBearbeitung : 2016-12-17  17:20:32</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_TonartData(string methode, ds_Tonart tonart)
		{
			InitializeComponent();

			lbl_Methode.Text = methode;

			eIntervall itv;
			ab_Tonart.setName( "Tonart: " );
			ab_Tonart.setData( tonart.TonartName );
			itv = eIntervall.Prime;
			ab_Prime.setName( itv.ToString() );
			ab_Prime.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.None_K;
			ab_NoneK.setName( itv.ToString() );
			ab_NoneK.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.None_G;
			ab_NoneG.setName( itv.ToString() );
			ab_NoneG.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.None_Ü;
			ab_NoneÜ.setName( itv.ToString() );
			ab_NoneÜ.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Terz_K;
			ab_TerzK.setName( itv.ToString() );
			ab_TerzK.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Terz_G;
			ab_TerzG.setName( itv.ToString() );
			ab_TerzG.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Undez_V;
			ab_UndezV.setName( itv.ToString() );
			ab_UndezV.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Undez;
			ab_Undez.setName( itv.ToString() );
			ab_Undez.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Undez_Ü;
			ab_UndezÜ.setName( itv.ToString() );
			ab_UndezÜ.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Quinte_V;
			ab_QuinteV.setName( itv.ToString() );
			ab_QuinteV.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Quinte;
			ab_Quinte.setName( itv.ToString() );
			ab_Quinte.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Quinte_Ü;
			ab_QuinteÜ.setName( itv.ToString() );
			ab_QuinteÜ.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Tredez_K;
			ab_TredezK.setName( itv.ToString() );
			ab_TredezK.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Tredez_G;
			ab_TredezG.setName( itv.ToString() );
			ab_TredezG.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Sept_V;
			ab_SeptV.setName( itv.ToString() );
			ab_SeptV.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Sept_K;
			ab_SeptK.setName( itv.ToString() );
			ab_SeptK.setData( tonart.getTon( itv ).TonName );
			itv = eIntervall.Sept_G;
			ab_SeptG.setName( itv.ToString() );
			ab_SeptG.setData( tonart.getTon( itv ).TonName );
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
