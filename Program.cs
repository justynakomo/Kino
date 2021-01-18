using System.Windows.Forms;

namespace po
{
    class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KinoWPF());
        }
    }
}
