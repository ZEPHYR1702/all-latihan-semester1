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
            L1A();
        }

        public static void L1A()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("\tLatihan 1A Week 10");
            Console.WriteLine("=================================\n");

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
            Console.WriteLine("Daftar semua pelanggan");
            for (int i = 0; i < listLama.Count; i++)
            {
                Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan");
            }
            
            //daftar semua pelanggan yang hanya langganan 1 bulan
            int counter1 = 0;
            Console.WriteLine("\nDaftar Pelanggan yang hanya langganan 1 bulan:");
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
            Console.WriteLine("\nDaftar semua pelanggan yang berlangganan paket premium");
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
            Console.WriteLine("\nLaporan pendapatan dari setiap pelanggan");
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
                    biaya = 186000 * (listLama[i] - (listLama[i]/12));
                    totalPremium += biaya;
                }
                Console.WriteLine($"{listNamaPelanggan[i]} - {listPaket[i]} - {listLama[i]} bulan - Rp{biaya}");

                total = total + biaya;
            }

            //laporan pendapatan dari masing-masing paket
            Console.WriteLine($"\nPendapatan dari paket Ponsel\t: Rp{totalPonsel}");
            Console.WriteLine($"Pendapatan dari paket Basic\t: Rp{totalBasic}");
            Console.WriteLine($"Pendapatan dari paket Standar\t: Rp{totalStandar}");
            Console.WriteLine($"Pendapatan dari paket Premium\t: Rp{totalPremium}");
            Console.WriteLine($"Total seluruh pendapatan\t: Rp{total}");
        }

        public static void L2A()
        {
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
            int jumlahPendapatan = 0;
            Console.WriteLine("\nDaftar semua mobil yang parkir");
            for (int i = 0; i < listLamaParkir.Count; i++)
            {
                int jam = listLamaParkir[i], biaya = 0, basePrice = 6000, hari = jam/24, sisaJam = jam % 24;

                if (jam <= 2)
                {
                    biaya = basePrice;
                }
                else
                {
                    biaya = basePrice + (jam - 2) * 1000;
                }

                if (biaya > 25000)
                {
                    biaya = 25000;
                }

                if (jam >= 24)
                {
                    biaya += 10000;
                }

                listBiaya.Add(biaya);
                Console.WriteLine($"{listNomorMobil[i]} - {listLamaParkir[i]} jam - Rp{biaya}");
                jumlahPendapatan += biaya;
            }
        }
    }
}
