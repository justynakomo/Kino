using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po
{
	struct Tools
	{
		public static int PobierzIntZKonsoli(int min, int max, string komunikatNowejProby = "")
		{
			int x = 0;
			while(!int.TryParse(Console.ReadLine(), out x) || ( x < min || x > max ))
			{
				ClearLine(2);
				if(komunikatNowejProby != "")
					Console.WriteLine(komunikatNowejProby);
			}
			return x;
		}

		public static int PobierzZnakZKonsoli(int min, int max, string komunikatNowejProby = "")
		{
			int x = 0;
			while(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out x) || ( x < min || x > max ))
			{
				ClearLine(2);
				if(komunikatNowejProby != "")
					Console.WriteLine(komunikatNowejProby);
			}
			return x;
		}

		public static void ClearLine(int x = 1)
		{
			for(int i = 0; i < x; i++)
			{
				Console.SetCursorPosition(0, Console.CursorTop - 1);
				Console.Write(new string(' ', Console.WindowWidth));
				Console.SetCursorPosition(0, Console.CursorTop - 1);
			}
		}

		public static DateTime WyciagnijDate(DateTime data)
		{
			return new DateTime(data.Year, data.Month, data.Day);
		}

		public static DateTime WyciagnijGodzine(DateTime data)
		{
			return new DateTime(2021, 01, 01, data.Hour, data.Minute, 00);
		}

		public static string WypiszDateIGodzine(DateTime data)
		{
			return TylkoData(data) +" "+ TylkoGodzina(data);
		}

		public static string DataGodzinaJakoSciezka(DateTime data)
		{
			return data.Year.ToString() + "_" + data.Month.ToString() + "_" + data.Day + "_" + data.Hour.ToString() + "_" + data.Minute.ToString();
		}


		public static string TylkoData(DateTime data)
		{
			return data.Year.ToString() + "-" + data.Month.ToString() +"-"+data.Day;
		}

		public static string TylkoGodzina(DateTime data)
		{
			return data.Hour.ToString() + ":" + data.Minute.ToString();
		}
	}
}
