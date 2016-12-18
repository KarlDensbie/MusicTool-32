using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace michaL.Musik.Anzeigen.TonAnzeige
{
    public partial class TonAnzeige: UserControl
    {
        public TonAnzeige()
        {
            InitializeComponent();
        }

		public string TonName { set { lbl_Name.Text = value; } }
		public string TonID { set { lbl_ID.Text = value; } }
		public string grundton { set { lbl_Grundton.Text = value; } }
		public string enhU { set { lbl_enhU.Text = value; } }
		public string enhO { set { lbl_enhO.Text = value; } }
	}
}
