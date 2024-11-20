using System.Runtime.InteropServices;

namespace AS_221120241020_Oğulcan_Erduran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Armstrong Sayısını Giriniz");
            int a, b, c = 0, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = a;
            while (a > 0)
            {
                d = a % 10;
                c = c + d * d * d;
                a = a / 10;


            }
            if (b==c)
            {
                Console.WriteLine("Armstrong Sayı");
            }
            else
                Console.WriteLine(" Armstrong Sayı Değil");
            Console.WriteLine();
                Console.ReadLine();
        }
    }
}
