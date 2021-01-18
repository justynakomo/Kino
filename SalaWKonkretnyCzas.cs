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
	public class SalaWKonkretnyCzas: Sala
	{
		private DateTime data;
		public DateTime DataSenasu
		{
			get { return data; }
			set { data = value; }
		}

		public SalaWKonkretnyCzas() : base() { }

		public SalaWKonkretnyCzas(string nazwaSali, DateTime d) : base(nazwaSali)
		{
			data = d;
		}
	}
}
