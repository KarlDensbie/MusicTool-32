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
using MusicTool._TEST;

namespace MusicTool.Fenster
{
	public partial class Startfenster : Form
	{
		public Startfenster()
		{
			InitializeComponent();
		}

		private void btn_TestTonDB_Click( object sender , EventArgs e )
		{
			Teste_TonDB.START();
		}
	}
}
