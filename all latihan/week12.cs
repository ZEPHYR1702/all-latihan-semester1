using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace all_latihan
{
    internal class week12
    {
        
        //SOAL 1
        public static void L1()
        {
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

                Console.Write("Apakah ingin melakukan pemesanan lagi? (y/n)");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
            }
            while (jawab == 'y');
            

        }
        
        static void TampilkanDaftarFilm(string[] film)
        {
            Console.WriteLine("TAMPILKAN FILM YANG SEDANG TAYANG");
            for (int i = 0; i < film.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {film[i]}");
            }
        }

        static int PilihFilm(string[] film)
        {
            TampilkanDaftarFilm(film);
            Console.Write("Pilih nomor film: ");
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
            Console.WriteLine("STRUK PEMESANAN");
            Console.WriteLine($"Film:\t\t{film}");
            Console.WriteLine($"Jam Tayang:\t{jam}");
            Console.WriteLine($"Jumlah Tiket:\t{jumlah}");

            double hargaTiket = HargaBerdasarJam(jam);
            Console.WriteLine($"Total bayar: {HitungTotalHarga(jumlah, hargaTiket)}");
        }

        //SOAL 2
        public static void L2()
        {
            List<double> listMagnitudo = new List<double>();
            List<double> listKedalaman = new List<double>();
            List<double> listSkorResiko = new List<double>();
            List<string> listKategoriResiko = new List<string>();

            char jawab;
            do
            {
                Console.Write("Magnitudo gempa: ");
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
                char.TryParse(Console.ReadLine(), out jawab);
            }
            while (jawab == 'y');
            


            Console.WriteLine("Daftar Gempa: ");
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
            Console.WriteLine($"Jumlah gempa dengan resiko tinggi: {counterResiko}");

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
            int counter = 0, jumlah = 0, counter2 = 0;

            //poin magnitudo
            if (magnitudo < 3.0)
            {
                counter += 1;
            }
            else if (magnitudo < 6.0)
            {
                counter += 2;
            }
            else if (magnitudo < 7.0)
            {
                counter += 3;
            }
            else
            {
                counter += 5;
            }

            //poin kedalaman
            if (kedalaman < 70)
            {
                counter2 += 3;
            }
            else if (kedalaman < 300)
            {
                counter2 += 2;
            }
            else
            {
                counter2 += 1;
            }

            jumlah = (counter * 2) + counter2;

            return jumlah;
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
    }
}
