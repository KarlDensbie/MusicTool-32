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
	public partial class Anz_ModusData : Form
	{
		/// <summary> Konstruktor(methode,modus)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="modus">anzuzeigender Modus, TYP: ds_Modus</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  21:35:50</para>
		/// <para>    ersteBearbeitung : 2016-12-17  21:35:50</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_ModusData(string methode,ds_Modus modus)
		{
			InitializeComponent();

			int _anzahl =modus.Anzahl;

			ab_Ton8.Visible = false;
			ab_Ton7.Visible = false;
			ab_Ton6.Visible = false;
			ab_Ton5.Visible = false;
			ab_Ton4.Visible = false;
			ab_Ton3.Visible = false;

			lbl_Methode.Text = methode;
			ab_ModusName.setName( "Modus: " );
			ab_ModusName.setData( modus.Name );

			for( int i = 0 ; i < _anzahl ; i++ ) {
				switch( i ) {
					case 0:
						ab_Ton1.setName( "1.Ton" );
						ab_Ton1.setData( modus.get( 0 ).IntervallName );
						break;
					case 1:
						ab_Ton2.setName( "2.Ton" );
						ab_Ton2.setData( modus.get( 1 ).IntervallName );
						break;
					case 2:
						ab_Ton3.setName( "3.Ton" );
						ab_Ton3.setData( modus.get( 2 ).IntervallName );
						ab_Ton3.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 568 , 207 ) );
						break;
					case 3:
						ab_Ton4.setName( "4.Ton" );
						ab_Ton4.setData( modus.get( 3 ).IntervallName );
						ab_Ton4.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 568 , 207 ) );
						break;
					case 5:
						ab_Ton5.setName( "5.Ton" );
						ab_Ton5.setData( modus.get( 4 ).IntervallName );
						ab_Ton5.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 568 , 207 ) );
						break;
					case 6:
						ab_Ton6.setName( "6.Ton" );
						ab_Ton6.setData( modus.get( 5 ).IntervallName );
						ab_Ton6.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 568 , 207 ) );
						break;
					case 7:
						ab_Ton7.setName( "7.Ton" );
						ab_Ton7.setData( modus.get( 6 ).IntervallName );
						ab_Ton7.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 568 , 207 ) );
						break;
					case 8:
						ab_Ton8.setName( "8.Ton" );
						ab_Ton8.setData( modus.get( 7 ).IntervallName );
						ab_Ton8.Visible = true;
						this.ClientSize = ( new System.Drawing.Size( 643 , 207));
						break;
				}
			}

			this.ShowDialog();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
