using System;
using System.Collections.Generic;
using System.Text;

namespace all_latihan
{
    internal class week2
    {
        public static void pilihan()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan Week 2 =====");
            Console.ResetColor();

            Console.Write("Pilih latihan Week 2A/B: ");
            string pilihan = Console.ReadLine()!.ToLower();

            if (pilihan == "a")
            {
                Console.Write("Pilih latihan nomor (1-7): ");
                int.TryParse(Console.ReadLine(), out int nomorLatihan);
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
                int.TryParse(Console.ReadLine(), out int nomorLatihan);
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1 Week 2A =====");
            Console.ResetColor();

            Console.Write("Masukan jumlah buku: ");
            int.TryParse(Console.ReadLine(), out int jumlahBuku);
            Console.Write("Masukan harga buku: ");
            int.TryParse(Console.ReadLine(), out int hargaBuku);
            int total = jumlahBuku * hargaBuku;
            Console.WriteLine($"Total yang harus dibayar adalah: {total}");
        }

        public static void L2A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2 Week 2A =====");
            Console.ResetColor();

            Console.Write("Masukan jumlah buku: ");
            int.TryParse(Console.ReadLine(), out int jumlahBuku);
            Console.Write("Masukan harga buku: ");
            int.TryParse(Console.ReadLine(), out int hargaBuku);
            Console.Write("Masukan ongkir: ");
            int.TryParse(Console.ReadLine(), out int ongkir);
            int total = (jumlahBuku * hargaBuku) + ongkir;
            Console.WriteLine($"Total yang harus dibayar adalah: {total}");
        }

        public static void L3A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 3 Week 2A =====");
            Console.ResetColor();

            int jumlahPart, hargaPart, totalAwal;
            double diskon, biayaLayanan;

            Console.Write("Masuka jumlah part: ");
            int.TryParse(Console.ReadLine(), out jumlahPart);
            Console.Write("Masukan harga part: ");
            int.TryParse(Console.ReadLine(), out hargaPart);
            totalAwal = jumlahPart * hargaPart;
            diskon = 0.1 * totalAwal;
            biayaLayanan = 0.02 * totalAwal;
            Console.WriteLine($"Jumlah yang harus dibayar adalah: {totalAwal - diskon + biayaLayanan}");
        }

        public static void L4A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 4 Week 2A =====");
            Console.ResetColor();

            int hargaTiket, jumlahDarat, jumlahAir, totalDarat, totalAir;
            double diskonAir, diskonDarat, subtotal;

            Console.Write("Masukan harga tiket: ");
            int.TryParse(Console.ReadLine(), out hargaTiket);
            Console.Write("Masukan jumlah wahana darat: ");
            int.TryParse(Console.ReadLine(), out jumlahDarat);
            Console.Write("Masukan jumlah wahana air: ");
            int.TryParse(Console.ReadLine(), out jumlahAir);

            totalAir = hargaTiket * jumlahAir;
            totalDarat = hargaTiket * jumlahDarat;
            diskonAir = 0.05 * totalAir;
            diskonDarat = 0.1 * totalDarat;
            subtotal = (totalAir - diskonAir) + (totalDarat - diskonDarat);
            Console.WriteLine($"Jumlah yang harus di bayar adalah {subtotal}");
        }

        public static void L5A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 5 Week 2A =====");
            Console.ResetColor();

            double kelilingSegitiga, luasSegtiga, inputAlas, inputTinggi, inputKeliling;

            Console.Write("Masukan input keliling: ");
            double.TryParse(Console.ReadLine(), out inputKeliling);
            Console.Write("Masukan input alas: ");
            double.TryParse(Console.ReadLine(), out inputAlas);
            Console.Write("Masukan input tinggi");
            double.TryParse(Console.ReadLine(), out inputTinggi);

            kelilingSegitiga = inputKeliling * 3;
            luasSegtiga = 0.5 * inputAlas * inputTinggi;
            Console.WriteLine($"Keliling segitiga adalah: {kelilingSegitiga}");
            Console.WriteLine($"Luas segitiga adalah: {luasSegtiga}");
            Console.WriteLine("Asumsi keliling dan segitiga adalah dua segitiga yang berbeda");
        }

        public static void L6A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 6 Week 2A =====");
            Console.ResetColor();

            double s, cashback, p, saldoSisa, totalAwal;

            Console.Write("Input saldo saat ini: ");
            double.TryParse(Console.ReadLine(), out s);
            Console.Write("Input transaksi anda: ");
            double.TryParse(Console.ReadLine(), out p);

            totalAwal = s - p;
            cashback = 0.02 * p;
            saldoSisa = totalAwal - cashback;
            Console.WriteLine($"Cashback yang anda dapatkan adalah: {cashback}");
            Console.WriteLine($"Saldo sisa anda adalah: {saldoSisa}");
        }

        public static void L7A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 7 Week 2A =====");
            Console.ResetColor();

            double NA, ExerciseUTS, QTS, UTS, ExerciseUAS, QAS, UAS;

            Console.Write("Input nilai ExerciseUTS: ");
            double.TryParse(Console.ReadLine(), out ExerciseUTS);
            Console.Write("Input nilai QTS: ");
            double.TryParse(Console.ReadLine(), out QTS);
            Console.Write("Input nilai UTS: ");
            double.TryParse(Console.ReadLine(), out UTS);
            Console.Write("Input nilai ExerciseUAS: ");
            double.TryParse(Console.ReadLine(), out ExerciseUAS);
            Console.Write("Input nilai QAS: ");
            double.TryParse(Console.ReadLine(), out QAS);
            Console.Write("Input nilai UAS: ");
            double.TryParse(Console.ReadLine(), out UAS);

            NA = (ExerciseUTS * 0.1) + (QTS * 0.15) + (UTS * 0.25) + (ExerciseUAS * 0.1) + (QAS * 0.15) + (UAS * 0.25);
            Console.WriteLine($"Nilai NA anda adalah: {NA}");
        }

        public static void L1B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1 Week 2B =====");
            Console.ResetColor();

            int jumlahProduk, danaTerkumpul;
            int hargaBarang = 300000;

            Console.Write("Masukan jumlah barang yang terjual: ");
            int.TryParse(Console.ReadLine(), out jumlahProduk);
            danaTerkumpul = jumlahProduk * hargaBarang;
            Console.WriteLine("Jumlah uang yang terkumpul setelah penjualan adalah: Rp." + danaTerkumpul);
        }

        public static void L2B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2 Week 2B =====");
            Console.ResetColor();

            int iblisLevelAtas = 300000;
            int iblisLevelBawah = 150000;
            int iblisIsDead, honorBawah, honorAtas, total;

            Console.Write("Masukan honor bawah yang didapat: ");
            int.TryParse(Console.ReadLine(), out honorAtas);
            Console.Write("Masukan honor atas yang didapat: ");
            int.TryParse(Console.ReadLine(), out honorBawah);
            iblisIsDead = honorAtas + honorBawah;
            total = (honorAtas * iblisLevelAtas) + (honorBawah * iblisLevelBawah);
            Console.WriteLine("Anda dibayar sebesar: Rp." + total);
            Console.WriteLine("Jumlah iblis yang anda bunuh: " + iblisIsDead);
        }

        public static void L3B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 3 Week 2B =====");
            Console.ResetColor();

            int hargaAirMinum = 12000;
            int duitAwal, jumlahBotol, kembalian;

            Console.Write("Masukan duit yang dimiliki Luffy: ");
            int.TryParse(Console.ReadLine(), out duitAwal);
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 4 Week 2B =====");
            Console.ResetColor();

            double hargaPizza = 150000;
            double inputPizza, totalAnggota, patungan, totalPizza;

            Console.Write("Masukan jumlah pizza yang dibeli: ");
            double.TryParse(Console.ReadLine(), out inputPizza);
            Console.Write("Masukan jumlah anggota: ");
            double.TryParse(Console.ReadLine(), out totalAnggota);
            totalPizza = inputPizza * hargaPizza;
            patungan = totalPizza / totalAnggota;
            Console.WriteLine("Totalnya adalah: " + totalPizza);
            Console.WriteLine("Setiap anggota harus urunan sebanyak: " + patungan);
        }

        public static void L5B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 5 Week 2B =====");
            Console.ResetColor();

            int hargaRamen;
            double diskon, total, duit, diskonan;

            Console.Write("Masukan duit yang dimiliki: ");
            double.TryParse(Console.ReadLine(), out duit);
            Console.Write("Masukan harga ramen: ");
            int.TryParse(Console.ReadLine(), out hargaRamen);
            diskon = hargaRamen * 0.05;
            diskonan = (int)(hargaRamen - diskon);
            total = (int)(duit / diskonan);
            Console.WriteLine("Jumlah porsi ramen yang bisa dibeli sebanyak: " + total);
            Console.WriteLine("Kembalian yang didapatkan sebanyak: " + diskonan);
            Console.WriteLine("Diskonnya sebesar: " + diskon);
        }
    }
}
