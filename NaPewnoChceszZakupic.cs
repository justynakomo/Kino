using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po
{
	public partial class NaPewnoChceszZakupic: Form
	{
		private KinoWPF glowneOkno = null;

		public NaPewnoChceszZakupic(KinoWPF glowne, int numerMiejsca)
		{
			InitializeComponent();
			glowneOkno = glowne;
			ZakupMiejsceTxt.Text = "Czy na pewno chcesz zakupić miejsce nr " + numerMiejsca.ToString() + "? \nKoszt biletu to 20 zł";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void TakButton(object sender, EventArgs e)
		{
			glowneOkno.ZakupMiejsce();
			this.Close();
		}

		private void NieButton(object sender, EventArgs e)
		{
			this.Close();
		}

		private void NaPewnoChceszZakupic_Load(object sender, EventArgs e)
		{

		}
	}
}
