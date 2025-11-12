using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    internal class week3
    {
        public static void pilihan()
        {
            Console.WriteLine("Latihan Week 3");
            Console.Write("Week A/B: ");
            string week = Console.ReadLine().ToLower();
            if (week == "a")
            {
                Console.WriteLine("Latihan Week 3A");
                Console.WriteLine();

                Console.Write("Pilih latihan (1-5): ");
                int latihan = int.Parse(Console.ReadLine());
                switch (latihan)
                {
                    case 1:
                        L1A();
                        break;
                    case 2:
                        L2A();
                        break;
                    case 3:
                        //L3A();
                        break;
                    case 4:
                        //L4A();
                        break;
                    case 5:
                        //L5A();
                        break;
                    default:
                        Console.WriteLine("Latihan tidak tersedia.");
                        break;
                }
            }
            else if (week == "b")
            {
                Console.WriteLine("Latihan Week 3B");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
        }

        public static void L1A()
        {
            Console.WriteLine("Latihan 1 Week 3A");
            Console.WriteLine();

            Console.Write("Input total pembelanjaan: ");
            int totalPembelanjaan = int.Parse(Console.ReadLine());
            double diskon = 0;
            if (totalPembelanjaan > 1000000)
            {
                diskon = 0.1;
            }
            else
            {
                diskon = 0.05;
            }
            double totalDiskon = totalPembelanjaan * diskon;
            Console.WriteLine($"Nominal diskon: {totalDiskon}");
        }

        public static void L2A()
        {
            Console.WriteLine("Latihan 2 Week 3A");
            Console.WriteLine();

            Console.Write("Input total pembelanjaan: ");
            int totalPembelanjaan = int.Parse(Console.ReadLine());
            double diskon = 0, nominalDiskon;
            if (totalPembelanjaan > 1000000)
            {
                diskon = 0.1;
            }
            else
            {
                diskon = 0.05;
            }
            nominalDiskon = totalPembelanjaan * diskon;
            if (nominalDiskon > 50000)
            {
                nominalDiskon = 50000;
            }
            Console.WriteLine($"Nominal diskon: {nominalDiskon}");
        }

        public static void L3A()
        {
            int hargabuku, jumlahBuku;
            double pajak, total, totalPembelian;
            Console.Write("Input harga per buku: ");
            hargabuku = int.Parse(Console.ReadLine());
            Console.Write("Input jumlah buku: ");
            jumlahBuku = int.Parse(Console.ReadLine());
            totalPembelian = hargabuku * jumlahBuku;
            if (totalPembelian > 100000)
            {
                pajak = totalPembelian * 0.11;
            }
            else
            {
                pajak = 0;
            }
            total = totalPembelian + pajak;
            Console.WriteLine($"Total penjualan: {totalPembelian}");
            Console.WriteLine($"Pajak: {pajak}");
            Console.WriteLine($"Total pembelian: {total}");
        }
    }
}
