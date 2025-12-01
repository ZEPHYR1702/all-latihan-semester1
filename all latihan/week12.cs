using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace all_latihan
{
    internal class week12
    {
        public static void Pilihan()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Week 12 =====");
            Console.ResetColor();

            Console.Write("Pilih Latihan (1-3): ");
            int.TryParse(Console.ReadLine(), out int pilihan);
            switch (pilihan)
            {
                case 1:
                    L1();
                    break;
                case 2:
                    L2();
                    break;
                case 3:
                    L3();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    break;
            }
        }


        //SOAL 1
        public static void L1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1 Week 12 =====");
            Console.ResetColor();

            Console.Write("Masukan jumlah film yang sedang tayang: ");
            int.TryParse(Console.ReadLine(), out int jumlahFilm);

            string[] film = new string[jumlahFilm];
            InputJudulFilm(film);

            char jawab;
            do
            {
                int no = PilihFilm(film);
                Console.Write("Masukan jam tayang (0-23): ");
                int.TryParse(Console.ReadLine(), out int jamtayang);
                Console.Write("Masukan jumlah tiket yang dibeli: ");
                int.TryParse(Console.ReadLine(), out int jumlahTiket);

                TampilkanStruk(film[no], jamtayang, jumlahTiket);

                Console.Write("\nApakah ingin melakukan pemesanan lagi? (y/n)");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
            }
            while (jawab == 'y');
            Console.WriteLine("Terima kasih telah menggunakan layanan kami!");

        }
        
        static void TampilkanDaftarFilm(string[] film)
        {
            Console.WriteLine("\nTAMPILKAN FILM YANG SEDANG TAYANG");
            for (int i = 0; i < film.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {film[i]}");
            }
        }

        static int PilihFilm(string[] film)
        {
            TampilkanDaftarFilm(film);
            Console.Write("\nPilih nomor film: ");
            int.TryParse(Console.ReadLine(), out int n);
            return n-1;
        }

        static double HargaBerdasarJam(int jam)
        {
            double harga;
            if(jam < 12)
            {
                harga = 40000;
            }
            else if (jam <= 17)
            {
                harga = 50000;
            }
            else if (jam <= 21)
            {
                harga = 70000;
            }
            else
            {
                harga = 60000;
            }
            return harga;
        }

        static double HitungTotalHarga(int jumlah, double hargaTiket)
        {
            return jumlah * hargaTiket;
        }

        static void InputJudulFilm(string[] film)
        {
            for (int i = 0; i < film.Length; i++)
            {
                Console.Write($"Masukan judul film ke-{i + 1}: ");
                film[i] = Console.ReadLine()!;
            }
        }

        static void TampilkanStruk(string film, int jam, int jumlah)
        {
            Console.WriteLine("\nSTRUK PEMESANAN");
            Console.WriteLine($"Film:\t\t{film}");
            Console.WriteLine($"Jam Tayang:\t{jam}");
            Console.WriteLine($"Jumlah Tiket:\t\t{jumlah}");

            double hargaTiket = HargaBerdasarJam(jam);
            Console.WriteLine($"Total bayar: {HitungTotalHarga(jumlah, hargaTiket)}");
        }

        //SOAL 2
        public static void L2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2 Week 12 =====");
            Console.ResetColor();

            List<double> listMagnitudo = new List<double>();
            List<double> listKedalaman = new List<double>();
            List<double> listSkorResiko = new List<double>();
            List<string> listKategoriResiko = new List<string>();

            char jawab;
            do
            {
                Console.Write("\nMagnitudo gempa: ");
                double magnitude = double.Parse(Console.ReadLine()!);
                listMagnitudo.Add(magnitude);
                Console.Write("Kedalaman gempa (km): ");
                double kedalaman2 = double.Parse(Console.ReadLine()!);
                listKedalaman.Add(kedalaman2);
                int hitungSkorResiko = HitungSkorResiko(magnitude, kedalaman2);
                listSkorResiko.Add(hitungSkorResiko);
                string kategori = KategoriResiko(hitungSkorResiko);
                listKategoriResiko.Add(kategori);

                Console.Write("Ada gempa lain(y/t): ");
                char.TryParse(Console.ReadLine()!.ToLower(), out jawab);
            }
            while (jawab == 'y');
            


            Console.WriteLine("\nDaftar Gempa: ");
            for (int i = 0; i < listMagnitudo.Count; i++)
            {
                Console.WriteLine($"Gempa {i + 1}: Magnitudo {listMagnitudo[i]}, Kedalaman {listKedalaman[i]} km, Skor Resiko {listSkorResiko[i]}, Kategori {listKategoriResiko[i]}");
            }

            int counterResiko = 0;
            for (int i = 0; i < listKategoriResiko.Count; i++)
            {
                if (listKategoriResiko[i] == "Tinggi")
                {
                    counterResiko += 1;
                }
            }
            Console.WriteLine($"\nJumlah gempa dengan resiko tinggi: {counterResiko}");

            double rataRata = 0, jumlah = 0;
            for (int i = 0; i < listSkorResiko.Count; i++)
            {
                jumlah = jumlah + listSkorResiko[i];
                rataRata += 1;
            }
            Console.WriteLine($"Rata-rata skor resiko: {jumlah / rataRata}");
        }

        static int HitungSkorResiko(double magnitudo, double kedalaman)
        {
            int skor = 0;

            //poin magnitudo
            if (magnitudo < 3.0)
            {
                skor = 1;
            }
            else if (magnitudo < 6.0)
            {
                skor = 2;
            }
            else if (magnitudo < 7.0)
            {
                skor = 3;
            }
            else
            {
                skor = 5;
            }

            //poin kedalaman
            if (kedalaman < 70)
            {
                skor = 2 * skor + 3;
            }
            else if (kedalaman <= 300)
            {
                skor = 2 * skor + 2;
            }
            else
            {
                skor = 2 * skor + 1;
            }

            if(magnitudo >= 5.0)
            {
                skor = skor + (int)((magnitudo - 5) * 10);
            }

            return skor;
        }

        static string KategoriResiko(int skor)
        {
            string kategori;
            if (skor >= 12)
            {
                kategori = "Tinggi";
            }
            else if (skor >= 8 && skor <= 11)
            {
                kategori = "Sedang";
            }
            else
            {
                kategori = "Rendah";
            }
            return kategori;
        }

        //SOAL 3
        public static void L3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 3 Week 12 =====");
            Console.ResetColor();

            Console.Write("\nMasukan luas lahan (hektar): ");
            double.TryParse(Console.ReadLine(), out double luasLahan);
            Console.Write("Masukan hasil dasar panen (ton): ");
            double.TryParse(Console.ReadLine(), out double hasilDasar);
            Console.Write("Masukan curah hujan rata-rata (mm): ");
            double.TryParse(Console.ReadLine(), out double curahHujan);
            Console.Write("Masukan suhu rata-rata (°C): ");
            double.TryParse(Console.ReadLine(), out double suhu);
            Console.Write("Masukan indeks kesuburan tanah (0.0 - 1.0): ");
            double.TryParse(Console.ReadLine(), out double kesuburanTanah);

            int totalHasilPanen = (int)HitungHasilPanen(luasLahan, hasilDasar, curahHujan, suhu);
            double totalKebutuhanPupuk = HitungKebutuhanPupuk(luasLahan, kesuburanTanah);

            Console.WriteLine($"\nTotal hasil panen yang diharapkan: {totalHasilPanen} ton");
            Console.WriteLine($"Total kebutuhan pupuk: {totalKebutuhanPupuk} kg");
        }

        static double HitungHasilPanen(double luasLahan, double hasilDasar, double curahHujan, double suhu)
        {
            
            if (curahHujan >= 800 && curahHujan <= 1200)
            {
                curahHujan = 1.0;
            }
            else if (curahHujan < 800)
            {
                curahHujan = 0.8;
            }
            else
            {
                curahHujan = 0.9;
            }

            if (suhu >= 20 && suhu <= 30)
            {
                suhu = 1.0;
            }
            else
            {
                suhu = 0.85;
            }

            double hasilPanenPerHektar = hasilDasar * curahHujan * suhu;
            double totalHasilPanen = hasilPanenPerHektar * luasLahan;
            return totalHasilPanen;
        }

        static double HitungKebutuhanPupuk(double luasLahan, double kesuburanTanah)
        {
            if (kesuburanTanah < 0.5)
            {
                kesuburanTanah = 50;
            }
            else if (kesuburanTanah >= 0.5 && kesuburanTanah <= 0.8)
            {
                kesuburanTanah = 30;
            }
            else
            {
                kesuburanTanah = 15;
            }

            double totalPupuk = luasLahan * kesuburanTanah;
            return totalPupuk;
        }
    }
}
