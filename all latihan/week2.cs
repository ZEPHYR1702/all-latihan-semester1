using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    internal class week2
    {
        public static void pilihan()
        {
            Console.WriteLine("Latihan Week 2");
            Console.Write("Pilih latihan Week 2A/B: ");
            string pilihan = Console.ReadLine().ToLower();
            if (pilihan == "a")
            {
                Console.Write("Pilih latihan nomor (1-7): ");
                int nomorLatihan = int.Parse(Console.ReadLine());
                switch (nomorLatihan)
                {
                    case 1:
                        L1A();
                        break;
                    case 2:
                        L2A();
                        break;
                    case 3:
                        L3A();
                        break;
                    case 4:
                        L4A();
                        break;
                    case 5:
                        L5A();
                        break;
                    case 6:
                        L6A();
                        break;
                    case 7:
                        L7A();
                        break;
                    default:
                        Console.WriteLine("Latihan tidak tersedia");
                        break;
                }
            }
            else if (pilihan == "b")
            {
                Console.Write("Pilih latihan nomor (1-5): ");
                int nomorLatihan = int.Parse(Console.ReadLine());
                switch (nomorLatihan)
                {
                    case 1:
                        L1B();
                        break;
                    case 2:
                        L2B();
                        break;
                    case 3:
                        L3B();
                        break;
                    case 4:
                        L4B();
                        break;
                    case 5:
                        L5B();
                        break;
                    default:
                        Console.WriteLine("Latihan tidak tersedia");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
            }
        }

        public static void L1A()
        {
            Console.WriteLine("Latihan 1 Week 2A");
            Console.WriteLine();

            Console.Write("Masukan jumlah buku: ");
            int jumlahBuku = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga buku: ");
            int hargaBuku = int.Parse(Console.ReadLine());
            int total = jumlahBuku * hargaBuku;
            Console.WriteLine($"Total yang harus dibayar adalah: {total}");
        }

        public static void L2A()
        {
            Console.WriteLine("Latihan 2 Week 2A");
            Console.WriteLine();

            Console.Write("Masukan jumlah buku: ");
            int jumlahBuku = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga buku: ");
            int hargaBuku = int.Parse(Console.ReadLine());
            Console.Write("Masukan ongkir: ");
            int ongkir = int.Parse(Console.ReadLine());
            int total = (jumlahBuku * hargaBuku) + ongkir;
            Console.WriteLine($"Total yang harus dibayar adalah: {total}");
        }

        public static void L3A()
        {
            Console.WriteLine("Latihan 3 Week 2A");
            Console.WriteLine();

            int jumlahPart, hargaPart, totalAwal;
            double diskon, biayaLayanan;

            Console.Write("Masuka jumlah part: ");
            jumlahPart = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga part: ");
            hargaPart = int.Parse(Console.ReadLine());
            totalAwal = jumlahPart * hargaPart;
            diskon = 0.1 * totalAwal;
            biayaLayanan = 0.02 * totalAwal;
            Console.WriteLine($"Jumlah yang harus dibayar adalah: {totalAwal - diskon + biayaLayanan}");
        }

        public static void L4A()
        {
            Console.WriteLine("Latihan 4 Week 2A");
            Console.WriteLine();

            int hargaTiket, jumlahDarat, jumlahAir, totalDarat, totalAir;
            double diskonAir, diskonDarat, subtotal;

            Console.Write("Masukan harga tiket: ");
            hargaTiket = int.Parse(Console.ReadLine());
            Console.Write("Masukan jumlah wahana darat: ");
            jumlahDarat = int.Parse(Console.ReadLine());
            Console.Write("Masukan jumlah wahana air: ");
            jumlahAir = int.Parse(Console.ReadLine());

            totalAir = hargaTiket * jumlahAir;
            totalDarat = hargaTiket * jumlahDarat;
            diskonAir = 0.05 * totalAir;
            diskonDarat = 0.1 * totalDarat;
            subtotal = (totalAir - diskonAir) + (totalDarat - diskonDarat);
            Console.WriteLine($"Jumlah yang harus di bayar adalah {subtotal}");
        }

        public static void L5A()
        {
            Console.WriteLine("Latihan 5 Week 2A");
            Console.WriteLine();

            double kelilingSegitiga, luasSegtiga, inputAlas, inputTinggi, inputKeliling;

            Console.Write("Masukan input keliling: ");
            inputKeliling = double.Parse(Console.ReadLine());
            Console.Write("Masukan input alas: ");
            inputAlas = double.Parse(Console.ReadLine());
            Console.Write("Masukan input tinggi");
            inputTinggi = double.Parse(Console.ReadLine());

            kelilingSegitiga = inputKeliling * 3;
            luasSegtiga = 0.5 * inputAlas * inputTinggi;
            Console.WriteLine($"Keliling segitiga adalah: {kelilingSegitiga}");
            Console.WriteLine($"Luas segitiga adalah: {luasSegtiga}");
            Console.WriteLine("Asumsi keliling dan segitiga adalah dua segitiga yang berbeda");
        }

        public static void L6A()
        {
            Console.WriteLine("Latihan 6 Week 2A");
            Console.WriteLine();

            double s, cashback, p, saldoSisa, totalAwal;

            Console.Write("Input saldo saat ini: ");
            s = double.Parse(Console.ReadLine());
            Console.Write("Input transaksi anda: ");
            p = double.Parse(Console.ReadLine());

            totalAwal = s - p;
            cashback = 0.02 * p;
            saldoSisa = totalAwal - cashback;
            Console.WriteLine($"Cashback yang anda dapatkan adalah: {cashback}");
            Console.WriteLine($"Saldo sisa anda adalah: {saldoSisa}");
        }

        public static void L7A()
        {
            Console.WriteLine("Latihan 7 Week 2A");
            Console.WriteLine();

            double NA, ExerciseUTS, QTS, UTS, ExerciseUAS, QAS, UAS;

            Console.Write("Input nilai ExerciseUTS: ");
            ExerciseUTS = double.Parse(Console.ReadLine());
            Console.Write("Input nilai QTS: ");
            QTS = double.Parse(Console.ReadLine());
            Console.Write("Input nilai UTS: ");
            UTS = double.Parse(Console.ReadLine());
            Console.Write("Input nilai ExerciseUAS: ");
            ExerciseUAS = double.Parse(Console.ReadLine());
            Console.Write("Input nilai QAS: ");
            QAS = double.Parse(Console.ReadLine());
            Console.Write("Input nilai UAS: ");
            UAS = double.Parse(Console.ReadLine());

            NA = (ExerciseUTS * 0.1) + (QTS * 0.15) + (UTS * 0.25) + (ExerciseUAS * 0.1) + (QAS * 0.15) + (UAS * 0.25);
            Console.WriteLine($"Nilai NA anda adalah: {NA}");
        }

        public static void L1B()
        {
            Console.WriteLine("Latihan 1 Week 2B");
            Console.WriteLine();

            int jumlahProduk, danaTerkumpul;
            int hargaBarang = 300000;

            Console.Write("Masukan jumlah barang yang terjual: ");
            jumlahProduk = int.Parse(Console.ReadLine());
            danaTerkumpul = jumlahProduk * hargaBarang;
            Console.WriteLine("Jumlah uang yang terkumpul setelah penjualan adalah: Rp." + danaTerkumpul);
        }

        public static void L2B()
        {
            Console.WriteLine("Latihan 2 Week 2B");
            Console.WriteLine();

            int iblisLevelAtas = 300000;
            int iblisLevelBawah = 150000;
            int iblisIsDead, honorBawah, honorAtas, total;

            Console.Write("Masukan honor bawah yang didapat: ");
            honorAtas = int.Parse(Console.ReadLine());
            Console.Write("Masukan honor atas yang didapat: ");
            honorBawah = int.Parse(Console.ReadLine());
            iblisIsDead = honorAtas + honorBawah;
            total = (honorAtas * iblisLevelAtas) + (honorBawah * iblisLevelBawah);
            Console.WriteLine("Anda dibayar sebesar: Rp." + total);
            Console.WriteLine("Jumlah iblis yang anda bunuh: " + iblisIsDead);
        }

        public static void L3B()
        {
            Console.WriteLine("Latihan 3 Week 2B");
            Console.WriteLine();

            int hargaAirMinum = 12000;
            int duitAwal, jumlahBotol, kembalian;

            Console.Write("Masukan duit yang dimiliki Luffy: ");
            duitAwal = int.Parse(Console.ReadLine());
            if (duitAwal < 12000)
            {
                Console.WriteLine("Duitnya tidak cukup");
            }
            else
            {
                jumlahBotol = duitAwal / hargaAirMinum;
                kembalian = duitAwal % hargaAirMinum;
                Console.WriteLine("Dengan duit sebanyak " + duitAwal + ", Luffy bisa membeli sebanyak " + jumlahBotol);
                Console.WriteLine("Kembalian yang didapatkan Luffy: " + kembalian);
            }
        }

        public static void L4B()
        {
            Console.WriteLine("Latihan 4 Week 2B");
            Console.WriteLine();

            double hargaPizza = 150000;
            double inputPizza, totalAnggota, patungan, totalPizza;

            Console.Write("Masukan jumlah pizza yang dibeli: ");
            inputPizza = double.Parse(Console.ReadLine());
            Console.Write("Masukan jumlah anggota: ");
            totalAnggota = double.Parse(Console.ReadLine());
            totalPizza = inputPizza * hargaPizza;
            patungan = totalPizza / totalAnggota;
            Console.WriteLine("Totalnya adalah: " + totalPizza);
            Console.WriteLine("Setiap anggota harus urunan sebanyak: " + patungan);
        }

        public static void L5B()
        {
            Console.WriteLine("Latihan 5 Week 2B");
            Console.WriteLine();

            int hargaRamen;
            double diskon, total, duit, diskonan;

            Console.Write("Masukan duit yang dimiliki: ");
            duit = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga ramen: ");
            hargaRamen = int.Parse(Console.ReadLine());
            diskon = hargaRamen * 0.05;
            diskonan = (int)(hargaRamen - diskon);
            total = (int)(duit / diskonan);
            Console.WriteLine("Jumlah porsi ramen yang bisa dibeli sebanyak: " + total);
            Console.WriteLine("Kembalian yang didapatkan sebanyak: " + diskonan);
            Console.WriteLine("Diskonnya sebesar: " + diskon);
        }
    }
}
