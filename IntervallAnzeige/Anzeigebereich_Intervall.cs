using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace michaL.Musik.Anzeigen.IntervallAnzeige
{
    public partial class Anzeigebereich_Intervall: UserControl
    {
        public Anzeigebereich_Intervall()
        {
            InitializeComponent();
        }

		public string IntervallName { set { lbl_Name.Text = value; } }
		public string AltName { set { lbl_AltName.Text = value; } }
		public string ID { set { lbl_ID.Text = value; } }
		public string BasisIntervall { set { lbl_BasisIntervall.Text = value; } }
	}
}
