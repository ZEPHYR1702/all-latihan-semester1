using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    internal class week9
    {
        public static void pilihan()
        {
            Console.WriteLine("Latihan Week 9.");
            Console.Write("Latihan berapa: ");
            int latihan = int.Parse(Console.ReadLine());
            switch (latihan)
            {
                case 1:
                    L1();
                    break;
                default:
                    Console.WriteLine("Latihan tidak tersedia.");
                    break;
            }
        }

        public static void L1()
        {
            Console.WriteLine("Latihan 1 Week 9");
            Console.WriteLine();

            //input user
            Console.Write("Banyaknya lantai: ");
            int lantai = int.Parse(Console.ReadLine());
            Console.Write("Banyaknya kamar tiap lantai: ");
            int kamarPerLantai = int.Parse(Console.ReadLine());
            Console.Write("Banyaknya kamar yang tersewa: ");
            int kamarTersewa = int.Parse(Console.ReadLine());

            int[,] hotel = new int[lantai, kamarPerLantai];

            //input lantai dan kamar yang terisi
            Console.WriteLine("Masukkan nomor kamar yang tersewa:");
            for (int i = 0; i < kamarTersewa; i++)
            {
                Console.Write($"Lantai ke: ");
                int lantaiKamar = int.Parse(Console.ReadLine());
                Console.Write($"Kamar ke: ");
                int nomorKamar = int.Parse(Console.ReadLine());
                hotel[lantaiKamar - 1, nomorKamar - 1] = 1; 
            }
            Console.WriteLine();

            //visual kamar hotel
            Console.WriteLine("Visual kamar hotel");
            for (int i = lantai-1; i >= 0; i--)
            {
                for (int j = 0; j < hotel.GetLength(1); j++)
                {
                    Console.Write(hotel[i, j] + " ");
                }
                Console.WriteLine();
            }

            //banyak kamar tersewa per lantai
            for (int i = 0; i < lantai; i++)
            {
                int count = 0;
                for (int j = 0; j < kamarPerLantai; j++)
                {
                    if (hotel[i, j] == 1)
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine($"Banyaknya kamar yang tersewa di lantai {i+1} = {count}");
            }
            Console.WriteLine();

            //kordinat kamar yang masih kosong
            Console.WriteLine("Kamar yang masih kosong");
            for (int i = 0; i < lantai; i++)
            {
                for (int j = 0; j < kamarPerLantai; j++)
                {
                    if (hotel[i,j] == 0)
                    {
                        Console.WriteLine($"Lantai {i+1}, kamar {j+1}");
                    }
                }
            }
        }
    }
}
