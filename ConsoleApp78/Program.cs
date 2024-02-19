using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenikidisacisigirilenucgenindisacisi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen 1. dış açıyı giriniz");
            int disaci1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen 2. dış açıyı giriniz");
            int disaci2 = Int32.Parse(Console.ReadLine());

            int toplam = disaci1 + disaci2;
            int bilinmeyendisaci = 360 - toplam;

            Console.WriteLine("Bilinmeyen Üçüncü dış açı=" + bilinmeyendisaci);

            Console.ReadLine();

        }
    }
}