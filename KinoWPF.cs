using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;

namespace po
{
    public partial class KinoWPF: Form
    {
        private static List<Repertuar> repertuars = new List<Repertuar>();
        private static int portfel = 500;
        private static List<Seans> aktualneSeanse = new List<Seans>();
        private static int aktualneMiejsce = -1;
        private static NaPewnoChceszZakupic oknoPytajace = null;
        private static StanPortfela oknoStanPortfela = null;

        public KinoWPF()
        {
            InitializeComponent();
            WczytajGotowke();
            repertuars = MojeBazy.MojeRepertuary();
            StanKonta.Text = portfel.ToString();
            WypiszRepertuary(repertuars);
        }

        private void ZmienionoRepertuar(object sender, EventArgs e)
        {
            aktualneSeanse = repertuars[ListaRepertuarow.SelectedIndex].Seanse;
            WypiszSeanseRepertuaru(aktualneSeanse);
            Miejsca.Controls.Clear();
            Informations.Text = "";
        }

        private void ZmienionoSeans(object sender, EventArgs e)
        {
            WypiszMiejscaSali(aktualneSeanse[Seanse.SelectedIndex]);
        }

        private void KliknietoMiejsce(object sender, EventArgs e)
		{
            Button clicked = (Button)sender;
            int.TryParse(clicked.Text, out aktualneMiejsce);
            aktualneMiejsce--;
            Application.EnableVisualStyles();

            if(oknoPytajace != null)oknoPytajace.Close();
            oknoPytajace = new NaPewnoChceszZakupic(this, aktualneMiejsce+1);
            oknoPytajace.Show();
        }

        public void ZakupMiejsce()
		{
            KliknietoMiejsce(aktualneMiejsce);
		}

        private void WypiszRepertuary(List<Repertuar> repertuary)
        {
            for(int i = 0; i < repertuary.Count; i++)
            {
                 DodajRepertuarDoListy( Tools.TylkoData(repertuary[i].DataSenasu));
            }
        }

        private void WypiszSeanseRepertuaru(List<Seans> seanse)
        {
            Seanse.Items.Clear();
            for(int i = 0; i < seanse.Count; i++)
            {
                DodajSeansDoListy(seanse[i].Film.KrotkieInfo());       
            }
        }

        private void WypiszMiejscaSali(Seans seans)
        {
            Miejsca.Controls.Clear();
            Informations.Text = "Data: " + seans.Sala.DataSenasu +"\n"+"Rodzaj: " + seans.Sala.NazwaSali + "\n" + seans.Film.Info();
            SalaWKonkretnyCzas temp = seans.Odczytaj();
            if(temp == null)
            {
                seans.Zapisz();
                temp = seans.Odczytaj();
            }
            else
            {
                seans.Sala = temp;
            }

            foreach(Miejsce item in temp.Miejsca)
            {
                DodajMiejsce(temp.Miejsca.IndexOf(item), item.Status == StanMiejsca.Pusty);
            }
        }

        private void KliknietoMiejsce(int x)
        {
            if(portfel < 20)
            {
                Application.EnableVisualStyles();

                if(oknoStanPortfela != null) oknoStanPortfela.Close();
                oknoStanPortfela = new StanPortfela();
                oknoStanPortfela.Show();
                return;
            }

            portfel -= 20;
            ZapiszGotowke();
            aktualneSeanse[Seanse.SelectedIndex].Sala.Miejsca[x].Status = StanMiejsca.Zarezerwowany;
            aktualneSeanse[Seanse.SelectedIndex].Zapisz();
            StanKonta.Text = portfel.ToString();
            WypiszMiejscaSali(aktualneSeanse[Seanse.SelectedIndex]);
        }

        private void DodajRepertuarDoListy(string txt) => ListaRepertuarow.Items.Add(txt);

        private void DodajSeansDoListy(string txt) => Seanse.Items.Add(txt);

        private void DodajMiejsce(int x, bool enabled) => Miejsca.Controls.Add(PanelMiejsca(x, enabled));

        private Panel PanelMiejsca(int x, bool enabled = true)
        {
            Panel p = new Panel { Size = new System.Drawing.Size(80,40)};
            p.Enabled = enabled;
            Button bttn = new Button { Text = ( x + 1 ).ToString() };
            bttn.Click += KliknietoMiejsce;
            p.Controls.Add(bttn);
            return p;
        }

        private void ZapiszGotowke()
        {
            string path = "portfel";
            if(!File.Exists(path))
            {
                using(StreamWriter file = File.CreateText(path))
                {
                    file.WriteLine(portfel);
                }
            }
            else
            {
                File.WriteAllText(path, string.Empty);
                using(StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(portfel);
                }
            }
        }
        private void WczytajGotowke()
        {
            string path = "portfel";
            if(!File.Exists(path))
                ZapiszGotowke();

            try
            {
                using(StreamReader file = new StreamReader(path))
                {
                    int.TryParse(file.ReadToEnd(), out portfel);
                    StanKonta.Text = portfel.ToString();
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

		private void KinoWPF_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Informations_Click(object sender, EventArgs e)
		{

		}
	}
}
