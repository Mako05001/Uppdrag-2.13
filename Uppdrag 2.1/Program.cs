using System;
namespace uppdrag2._13
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur mycket får första personen i lön?");
            string str1 = Console.ReadLine();
            int p1 = Convert.ToInt32(str1);
            Console.WriteLine("Hur mycket får andra personen i lön?");
            string strp2 = Console.ReadLine();
            int p2 = Convert.ToInt32(strp2);
            Console.WriteLine("Hur mycket får tredje personen i lön");
            string strp3 = Console.ReadLine();
            int p3 = Convert.ToInt32(strp3);
            int ptot = p1 + p2 + p3 / 3;
            int ptotal = ptot / 3;
            Console.Write("Medel lönen är ");
            Console.WriteLine(ptotal);
        }
    }
}
