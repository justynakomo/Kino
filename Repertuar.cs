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
    public class Repertuar
    {
        private DateTime data;
        public List<Seans> Seanse = new List<Seans>();

        public DateTime DataSenasu
        {
            get { return data; }
            set { data = value; }
        }

        public Repertuar()
        {
            data = DateTime.Now;
        }

        public Repertuar(DateTime dataseansu) : this()
        {
            data = dataseansu;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------------- Repertuar na dzień: " + Tools.TylkoData(data) + " -------------------");
            sb.AppendLine("");
            foreach(Seans p in Seanse)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }

        public void DodajSeans(Seans seans)
        {
            seans.OdswiezDateIGodzineSeansu(data);
            Seanse.Add(seans);
        }
    }
}



