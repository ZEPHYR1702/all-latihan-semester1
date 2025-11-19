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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan Week 9 =====");
            Console.ResetColor();

            Console.Write("Latihan berapa: ");
            int latihan = int.Parse(Console.ReadLine());
            switch (latihan)
            {
                case 1:
                    L1();
                    break;
                case 2:
                    L2();
                    break;
                default:
                    Console.WriteLine("Latihan tidak tersedia.");
                    break;
            }
        }

        public static void L1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1 Week 9 =====");
            Console.ResetColor();

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

            //pencarian terbanyak
            int max = 0, max2 = 0, countLantai = 0, countKamar = 0;
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

                if (count > max)
                {
                    max = count;
                    countLantai = i + 1;
                }
            }

            for (int j = 0; j < kamarPerLantai; j++)
            {
                int count = 0;
                for (int i = 0; i < lantai; i++)
                {
                    if (hotel[i, j] == 1)
                    {
                        count++;
                    }
                }
                if (count > max2)
                {
                    max2 = count;
                    countKamar = j + 1;
                }
            }

            Console.WriteLine($"Nomor lantai yang banyak terisi adalah: {countLantai}");
            Console.WriteLine($"Nomor lantai yang banyak terisi adalah: {countKamar}");
        }

        public static void L2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2 Week 9 =====");
            Console.ResetColor();

            Console.Write("Banyaknya baris = ");
            int baris = int.Parse(Console.ReadLine());
            Console.Write("Banyaknya kolom = ");
            int kolom = int.Parse(Console.ReadLine());

            char[,] sawah = new char[baris, kolom];
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    sawah[i, j] = 'T';
                }
            }

            Console.Write("Berapa petak sawah yang ditanami = ");
            int jumTanam = int.Parse(Console.ReadLine());
            int noBaris, noKolom;
            char tanaman;
            for (int i = 0; i < jumTanam; i++)
            {
                Console.Write("Nomor baris = ");
                noBaris = int.Parse(Console.ReadLine());
                Console.Write("Nomor kolom = ");
                noKolom = int.Parse(Console.ReadLine());
                Console.Write("Tanaman (P/C/G/J) = ");
                tanaman = char.Parse(Console.ReadLine().ToUpper());

                sawah[noBaris - 1, noKolom - 1] = tanaman;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Daftar tanaman di sawah =====");
            Console.ResetColor();
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write(sawah[i, j] + "\t");
                }
                Console.WriteLine();
            }

            char[] jenistanaman = new char[] { 'P', 'C', 'G', 'J' };
            string[] namaTanaman = new string[] { "Padi", "Cabai", "Gandum", "Jagung" };
            int[] daftarBiaya = new int[] { 100_000, 300_000, 150_000, 500_000 };
            int[] daftarHargJual = new int[] { 120_000, 450_000, 200_000, 800_000 };
            int totalBiaya = 0, totalPenjualan = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Laporan keuangan =====");
            Console.ResetColor();

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    for (int k = 0; k < jenistanaman.Length; k++)
                    {
                        if (sawah[i, j] == jenistanaman[k])
                        {
                            totalBiaya = totalBiaya + daftarBiaya[k];
                            totalPenjualan = totalPenjualan + daftarHargJual[k];
                        }
                    }
                }
            }
            Console.WriteLine("Total biaya yang digunakan untuk membeli bibit = " + totalBiaya);
            Console.WriteLine("Perkiraan total hasil penjualan = " + totalPenjualan);
            Console.WriteLine("Perkiraan total laba = " + (totalPenjualan - totalBiaya));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Laporan keuangan per jenis tanaman =====");
            Console.ResetColor();

            for (int k = 0; k < jenistanaman.Length; k++)
            {
                totalBiaya = 0;
                totalPenjualan = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (sawah[i, j] == jenistanaman[k])
                        {
                            totalBiaya = totalBiaya + daftarBiaya[k];
                            totalPenjualan = totalPenjualan + daftarHargJual[k];
                        }
                    }
                }
                Console.WriteLine("Tanaman " + namaTanaman[k]);
                Console.WriteLine("  Total biaya yang digunakan untuk membeli bibit = " + totalBiaya);
                Console.WriteLine("  Perkiraan total hasil penjualan = " + totalPenjualan);
                Console.WriteLine("  Perkiraan total laba = " + (totalPenjualan - totalBiaya));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Laporan keuangan per baris =====");
            Console.ResetColor();
            
            for (int i = 0; i < baris; i++)
            {
                totalBiaya = 0;
                totalPenjualan = 0;
                for (int j = 0; j < kolom; j++)
                {
                    for (int k = 0; k < jenistanaman.Length; k++)
                    {
                        if (sawah[i, j] == jenistanaman[k])
                        {
                            totalBiaya = totalBiaya + daftarBiaya[k];
                            totalPenjualan = totalPenjualan + daftarHargJual[k];
                        }
                    }
                }
                Console.WriteLine("Baris ke-" + (i + 1));
                Console.WriteLine("  Total biaya yang digunakan untuk membeli bibit = " + totalBiaya);
                Console.WriteLine("  Perkiraan total hasil penjualan = " + totalPenjualan);
                Console.WriteLine("  Perkiraan total laba = " + (totalPenjualan - totalBiaya));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Laporan keuangan per kolom =====");
            Console.ResetColor();
            
            for (int i = 0; i < kolom; i++)
            {
                totalBiaya = 0;
                totalPenjualan = 0;
                for (int j = 0; j < baris; j++)
                {
                    for (int k = 0; k < jenistanaman.Length; k++)
                    {
                        if (sawah[j, i] == jenistanaman[k])
                        {
                            totalBiaya = totalBiaya + daftarBiaya[k];
                            totalPenjualan = totalPenjualan + daftarHargJual[k];
                        }
                    }
                }
                Console.WriteLine("Kolom ke-" + (i + 1));
                Console.WriteLine("  Total biaya yang digunakan untuk membeli bibit = " + totalBiaya);
                Console.WriteLine("  Perkiraan total hasil penjualan = " + totalPenjualan);
                Console.WriteLine("  Perkiraan total laba = " + (totalPenjualan - totalBiaya));
            }
        }

        public static void L3()
        {
            Console.WriteLine("Latihan 3 Week 9");
        }

        public static void L4() 
        { 
            Console.WriteLine("Latihan 4 Week 9");
        }
    }
}
