using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTool.Fenster.Testanzeigen
{
	public partial class Anz_IntervallData : Form
	{
		/// <summary> Konstruktor(methode,name,altName,id,basisIntervall)
		/// <para></para>
		/// </summary>
		/// <param name="methode">aufrufende Methode, TYP: STRING</param>
		/// <param name="name">Name des Intervalls, TYP: STRING</param>
		/// <param name="altName">alternativer Name des Intervalls, TYP: STRING</param>
		/// <param name="id">ID des Intervalls, TYP: eIntervall</param>
		/// <param name="bas">Basis-Intervall, TYP: eBasisIntervall</param>
		/// .
		/// <remarks>
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-12-17  13:32:21</para>
		/// <para>    ersteBearbeitung : 2016-12-17  13:32:21</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </remarks>
		public Anz_IntervallData(string methode, string name , string altName , eIntervall id , eBasisIntervall bas )
		{
			InitializeComponent();

			lbl_Methode.Text = methode;
			anzeige1.IntervallName = name;
			anzeige1.AltName = altName;
			anzeige1.ID = id.ToString();
			anzeige1.BasisIntervall = bas.ToString();
		}

		private void btn_Verlassen_Click( object sender , EventArgs e )
		{
			this.Close();
		}
	}
}
