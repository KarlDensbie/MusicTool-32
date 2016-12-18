using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace michaL.Musik.Tools.Templates.NameWert_Z
{
    public partial class Anzeigebereich_NameWert_Z : UserControl
    {
        public Anzeigebereich_NameWert_Z ()
        {
            InitializeComponent();

			anzeigebereich1.setName( "Name: " );
			anzeigebereich2.setName( "altern. Name: " );
        }

		public string AnzName { set { anzeigebereich1.setData( value ); } }
		public string AnzAlt { set { anzeigebereich2.setData( value ); } }
    }
}
