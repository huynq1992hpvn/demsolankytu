using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Demsolankytuxuathien
{
    internal class Program
    {
        static int Demsolan(char ch, string cau)
        {
            int dem = 0;
            for (int i= 0; i < cau.Length; i++)
            {
                if (cau[i] == ch)
                {
                    dem++;
                }
            }
            return dem;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("nhap cau khai bao");
            string cau = Console.ReadLine();
            Console.WriteLine("nhap ky tu can dem: ");
            Console.WriteLine();
            char ch=Console.ReadKey().KeyChar;
            int solan = Demsolan((char)ch, cau);
            Console.WriteLine("So lan xuat hien cua ky tu {0} la {1}", ch, solan);

            Console.ReadKey();
        }
    }
}
