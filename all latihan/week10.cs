using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    internal class week10
    {
        public static void pilihan()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Week 10 =====");
            Console.ResetColor();

            Console.Write("Masukan Week (A/B): ");
            string week = Console.ReadLine().ToLower();
            if (week == "a")
            {
                Console.Write("Masukan Latihan (1/2): ");
                int latihan = int.Parse(Console.ReadLine());
                if (latihan == 1)
                    L1A();
                else if (latihan == 2)
                    L2A();
                else
                    Console.WriteLine("Latihan tidak ditemukan");
            }
            else
            {
                Console.WriteLine("coming soon...");
            }
        }

        public static void L1A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1A Week 10 =====");
            Console.ResetColor();

            //deklarasi
            string namaPelanggan, namaPaket;
            int lamaLangganan;
            char jawab;

            List<string> listNamaPelanggan = new List<string>();
            List<string> listPaket = new List<string>();
            List<int> listLama = new List<int>();

            //input
            do
            {
                Console.Write("Nama Pelanggan: ");
                namaPelanggan = Console.ReadLine();
                Console.Write("Paket yang dipilih: ");
                namaPaket = Console.ReadLine();
                Console.Write("Lama langganan: ");
                lamaLangganan = int.Parse(Console.ReadLine());

                listNamaPelanggan.Add(namaPelanggan);
                listPaket.Add(namaPaket);
                listLama.Add(lamaLangganan);

                Console.Write("Ada pelanggan lagi (y/t): ");
                jawab = char.Parse(Console.ReadLine().ToLower());
            }
            while (jawab == 'y');

            //daftar semua pelanggan
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDaftar semua pelanggan");
            Console.WriteLine("-----------------------");
            Console.ResetColor();
            for (int i = 0; i < listLama.Count; i++)
            {
                Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan");
            }

            //daftar semua pelanggan yang hanya langganan 1 bulan
            int counter1 = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDaftar Pelanggan yang hanya langganan 1 bulan:");
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listLama.Count; i++)
            {
                if (listLama[i] == 1)
                {
                    counter1++;
                    Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan");
                }
            }
            if (counter1 == 0)
            {
                Console.WriteLine("Tidak ada");
            }

            //daftar semua yang langganan paket premium
            int counter2 = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDaftar semua pelanggan yang berlangganan paket premium");
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listPaket.Count; i++)
            {
                if (listPaket[i].ToLower() == "premium")
                {
                    counter2++;
                    Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan");
                }
            }
            if (counter2 == 0)
            {
                Console.WriteLine("Tidak ada");
            }

            //daftar pendapatan
            int biaya = 0, total = 0, totalPonsel = 0, totalBasic = 0, totalStandar = 0, totalPremium = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLaporan pendapatan dari setiap pelanggan");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < listLama.Count; i++)
            {
                if (listPaket[i].ToLower() == "ponsel")
                {
                    biaya = 54000 * listLama[i];
                    totalPonsel += biaya;
                }
                else if (listPaket[i].ToLower() == "basic")
                {
                    biaya = 65000 * listLama[i];
                    totalBasic += biaya;
                }
                else if (listPaket[i].ToLower() == "standar")
                {
                    biaya = 120000 * listLama[i];
                    if (listLama[i] >= 3)
                    {
                        biaya = biaya - 50000;
                    }
                    totalStandar += biaya;
                }
                else
                {
                    biaya = 186000 * (listLama[i] - (listLama[i] / 12));
                    totalPremium += biaya;
                }
                Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan - Rp{biaya}");

                total = total + biaya;
            }

            //laporan pendapatan dari masing-masing paket
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLaporan pendapatan dari masing-masing paket");
            Console.WriteLine("------------------------------------------");
            Console.ResetColor();

            Console.WriteLine($"Pendapatan dari paket Ponsel\t: Rp{totalPonsel}");
            Console.WriteLine($"Pendapatan dari paket Basic\t: Rp{totalBasic}");
            Console.WriteLine($"Pendapatan dari paket Standar\t: Rp{totalStandar}");
            Console.WriteLine($"Pendapatan dari paket Premium\t: Rp{totalPremium}");
            Console.WriteLine($"Total seluruh pendapatan\t: Rp{total}");
        }

        public static void L2A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2A Week 10 =====");
            Console.ResetColor();

            string nomorMobil;
            int lamaParkir;
            char jawab;

            List<string> listNomorMobil = new List<string>();
            List<int> listLamaParkir = new List<int>();
            List<int> listBiaya = new List<int>();

            //input
            do
            {
                Console.Write("Nomor mobil: ");
                nomorMobil = Console.ReadLine();
                Console.Write("Lama parkir (jam): ");
                lamaParkir = int.Parse(Console.ReadLine());

                listNomorMobil.Add(nomorMobil);
                listLamaParkir.Add(lamaParkir);

                Console.Write("ada mobil lagi(y/t): ");
                jawab = char.Parse(Console.ReadLine().ToLower());
            }
            while (jawab == 'y');

            //daftar semua mobil yang parkir
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDaftar semua mobil yang parkir");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            int totalPendapatan = 0;

            for (int i = 0; i < listLamaParkir.Count; i++)
            {
                int jam = listLamaParkir[i];
                int hari = jam / 24;
                int sisaJam = jam % 24;
                int biaya = hari * 125000;

                if (sisaJam > 0 && sisaJam <= 2)
                {
                    biaya += 6000;
                }
                else if (sisaJam >= 2)
                {
                    if ((sisaJam - 2) * 1000 + 6000 > 25000)
                    {
                        biaya += 25000;
                    }
                    else
                    {
                        biaya += (sisaJam - 2) * 1000 + 6000;
                    }
                }
                listBiaya.Add(biaya);
                totalPendapatan += biaya;
                Console.WriteLine($"{listNomorMobil[i]} - {jam} jam - Rp {biaya}");
            }
            Console.WriteLine();

            //Data semua mobil yang parkir minimal 1 hari
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data semua mobil yang parkir minimal 1 hari");
            Console.WriteLine("------------------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < listLamaParkir.Count; i++)
            {
                if (listLamaParkir[i] >= 24)
                {
                    Console.WriteLine($"{listNomorMobil[i]} - {listLamaParkir[i]} jam - Rp {listBiaya[i]}");
                }
            }
            Console.WriteLine($"\nTotal pendapatan parkir: Rp {totalPendapatan}");
        }
    }
}
