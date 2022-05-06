using System;

namespace Print_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPrintFile main = new MainPrintFile(new PDF());
            MainPrintFile main1 = new MainPrintFile(new Word());
            MainPrintFile main2 = new MainPrintFile(new Excel());
        }   
    }
}
