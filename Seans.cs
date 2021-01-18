using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Xml.Serialization;
namespace po
{
    public class Seans
    {
        private Film film;
        private SalaWKonkretnyCzas sala;
        private DateTime dataSeansu;
       
        public DateTime GodzinaSeansu { get => dataSeansu; set => dataSeansu = value; }
        public Film Film { get => film; set => film = value; }
        public SalaWKonkretnyCzas Sala { get => sala; set => sala = value; }

        public Seans(){}

        public Seans(DateTime godzinaSeansu,Film f, Sala s):this()
        {
            GodzinaSeansu = godzinaSeansu;
            Film = f;
            sala = new SalaWKonkretnyCzas(s.NazwaSali , godzinaSeansu);
        }

        public void OdswiezDateIGodzineSeansu(DateTime data)
		{
            sala.DataSenasu = new DateTime(data.Year, data.Month, data.Day, GodzinaSeansu.Hour, GodzinaSeansu.Minute, GodzinaSeansu.Second);
		}

		public override string ToString()
		{
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(dataSeansu.Hour.ToString() + ":" + dataSeansu.Minute.ToString());
            sb.AppendLine(sala.ToString());
            sb.AppendLine(film.ToString());

            return sb.ToString();
        }

        public void Zapisz() => ZapiszXML(NazwaPliku(), sala);

        private static void ZapiszXML(string nPliku, SalaWKonkretnyCzas z)
        {
            XmlSerializer xser = new XmlSerializer(typeof(SalaWKonkretnyCzas));
            if(!File.Exists(nPliku))
            {
                FileStream file = File.Create(nPliku);
                file.Close();
            }

            StreamWriter wr = new StreamWriter(nPliku);
            xser.Serialize(wr, z);
            wr.Close();
        }

        public SalaWKonkretnyCzas Odczytaj() => OdczytajXML(NazwaPliku());

        public static SalaWKonkretnyCzas OdczytajXML(string nPliku)
        {
            if(!File.Exists(nPliku))
                return null;

            try
            {
                StreamReader stream = new StreamReader(nPliku);
                XmlSerializer xser = new XmlSerializer(typeof(SalaWKonkretnyCzas));
                SalaWKonkretnyCzas z = (SalaWKonkretnyCzas)xser.Deserialize(stream);
                stream.Close();
                return z;
            }
            catch(FileNotFoundException)
            {
                SystemSounds.Exclamation.Play();
                Console.WriteLine($"Plik (nazwa) nie istnieje!!");
            }
            return null;
        }

        public string NazwaPliku()
        {
           return  sala.NazwaSciezki() + "_Data_" + Tools.DataGodzinaJakoSciezka( sala.DataSenasu) + ".xml";
        }
    }
}
