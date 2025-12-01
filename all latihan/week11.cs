using System;
using System.Collections.Generic;
using System.Text;

namespace all_latihan
{
    internal class week11
    {
        //Develop a method to determine whether an integer is odd or even
        static void L1(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }
        }

        //Buat dua method untuk menghitung Luas dan Keliling Persegi Panjang
        static double L2A(double p, double l)
        {
            double luas = p * l;
            return luas;
        }

        static double L2B(double p, double l)
        {
            double keliling = 2 * (p + l);
            return keliling;
        }

        //Buat method KonversiNilaiHuruf(double nilai) yang mengembalikan nilai huruf (A, AB, B, BC, C, D, dan E) berdasar rentang nilai:
        static string L3(double nilai)
        {
            string nisbi;
            if (nilai <= 81 && nilai <= 100)
            {
                nisbi = "A";
            }
            else if (nilai <= 73 && nilai < 81)
            {
                nisbi = "AB";
            }
            else if (nilai <= 66 && nilai < 73)
            {
                nisbi = "B";
            }
            else if (nilai <= 60 && nilai < 66)
            {
                nisbi = "BC";
            }
            else if (nilai <= 55 && nilai < 60)
            {
                nisbi = "C";
            }
            else if (nilai <= 40 && nilai < 55)
            {
                nisbi = "D";
            }
            else
            {
                nisbi = "E";
            }
            return nisbi;
        }

        //Buat method CariNilaiTertinggi(int[] arrNilai) dan CariNilaiTerendah(int[] arrNilai).
        //Method mengembalikan nilai maksimum dan minimum dari array.
        static int L5(int[] arrNilai)
        {
            int max = arrNilai[0];
            foreach (int nilai in arrNilai)
            {
                if (nilai > max)
                {
                    max = nilai;
                }
            }
            return max;
        }


        //Buat method HitungRataRata(int[] arrNilai) untuk menghitung rata-rata.
        static double L4(int[] arrNilai)
        {
            double rataRata = 0, counter = 0;
            foreach (int nilai in arrNilai)
            {
                rataRata += nilai;
                counter++;
            }
            return rataRata / counter;
        }

        //Buat method HitungFaktorial(int n) yang menghitung nilai factorial dari bilangan bulat positif.
        static long L6(int n)
        {
            long faktorial = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        //Buat method ApakahPrima(int n) yang mengembalikan nilai true jika n adalah bilangan prima dan false jika bukan.
        static bool L7(int a)
        {
            bool hasil = true;
            for (int i = 2; i < a && hasil == true; i++)
            {
                if (a % i == 0)
                {
                    hasil = false;
                }
            }
            return hasil;
        }

        //Buat method HitungDiskon(long harga, double persenDiskon) yang mengembalikan harga setelah diskon.
        static double L8(long harga, double persenDiskon)
        {
            double hargaAkhir = harga - (harga * persenDiskon / 100);
            return hargaAkhir;
        }

        //Buat method ApakahPalidrom(int angka) yang menentukan apakah angka tersebut sama jika dibaca dari depan dan belakang.
        static string L9(long angka)
        {
            long digit, reverse = 0, temp;
            temp = angka;
            while (angka > 0)
            {
                digit = angka % 10;
                reverse = (reverse * 10) + digit;
                angka = angka / 10;
            }
            if (temp == reverse)
            {
                return "Palidrom";
            }
            else
            {
                return "Bukan Palidrom";
            }
        }

        //Buat method HitungNilaiAkhir(double tugas, double uts, double uas) yang mengembalikan nilai akhir dengan bobot 10% tugas, 40% uts, dan 50% uas.
        static double L10(double tugas, double uts, double uas)
        {
            double nilaiAkhir = (tugas * 0.1) + (uts * 0.4) + (uas * 0.5);
            return nilaiAkhir;
        }

        //Buat method HitungRataRata(int[] arrX) untuk menghitung rata-rata.
        //Buat method CetakKategori(int[] arrX) yang memanggil HitungRataRata(int[] arrX) dan menampilkan kategori:
        static string L11(int[] arrX)
        {
            double rataRata = L4(arrX);
            string kategori;
            if (rataRata >= 85 && rataRata <= 100)
            {
                kategori = "Sangat Baik";
            }
            else if (rataRata < 85)
            {
                kategori = "Baik";
            }
            else if (rataRata < 70)
            {
                kategori = "Cukup";
            }
            else if (rataRata < 55)
            {
                kategori = "Kurang";
            }
            else
            {
                kategori = "Sangat Kurang";
            }
            return kategori;
        }
    }
}
