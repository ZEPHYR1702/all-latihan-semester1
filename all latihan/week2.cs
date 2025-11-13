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

            }
            else if(pilihan == "b")
            {
                 
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
            }
        }

        public static void L1A()
        {
            Console.Write("Masukan jumlah buku: ");
            int jumlahBuku = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga buku: ");
            int hargaBuku = int.Parse(Console.ReadLine());
            int total = jumlahBuku * hargaBuku;
            Console.WriteLine($"Total yang harus dibayar adalah: {total}");
        }

        public static void L2A()
        {
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
    }
}
