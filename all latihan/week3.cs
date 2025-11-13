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
            Console.Write("Week 3 A/B: ");
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
                        L3A();
                        break;
                    case 4:
                        L4A();
                        break;
                    case 5:
                        L5A();
                        break;
                    default:
                        Console.WriteLine("Latihan tidak tersedia.");
                        break;
                }
            }
            else if (week == "b")
            {
                Console.WriteLine("Latihan Week 3B");
                Console.WriteLine();

                Console.Write("Pilih latihan (1-6)");
                int latihan = int.Parse(Console.ReadLine());

                switch (latihan)
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
                    case 6:
                        L6B();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                }
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
            Console.WriteLine("Latihan 3 Week 3A");
            Console.WriteLine();

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

        public static void L4A()
        {
            Console.WriteLine("Latihan 4 Week 3A");
            Console.WriteLine();

            int currentPoin, startDate, currentDate, poin = 50, getItem, tidakLogin;
            Console.Write("Input Player Name: ");
            string playerName = Console.ReadLine();
            Console.Write("Input Current Poins: ");
            currentPoin = int.Parse(Console.ReadLine());
            Console.Write("Input Start Date: ");
            startDate = int.Parse(Console.ReadLine());
            Console.Write("Input Current Date: ");
            currentDate = int.Parse(Console.ReadLine());
            tidakLogin = currentDate - startDate;
            if (tidakLogin >= 3)
            {
                getItem = currentPoin / poin;
                Console.WriteLine($"Hello, {playerName}. You get {getItem} new costumes.");
            }
            else
            {
                Console.WriteLine($"Hello, {playerName}. You have joined us for only {tidakLogin}. Unfortunately, a newbie player can’t buy new costumes");
            } 
        }

        public static void L5A()
        {
            Console.WriteLine("Latihan 5 Week 3A");
            Console.WriteLine();

            double gajiPokok, penjualanTahunIni, penjualanTahunLalu, peningkatan, bonus;
            Console.Write("Input penjualan tahun lalu: ");
            penjualanTahunLalu = double.Parse(Console.ReadLine());
            Console.Write("Input penjualan tahun ini: ");
            penjualanTahunIni = double.Parse(Console.ReadLine());
            Console.Write("Input gaji pokok: ");
            gajiPokok = double.Parse(Console.ReadLine());
            peningkatan = penjualanTahunIni - penjualanTahunLalu;
            if (penjualanTahunIni > penjualanTahunLalu)
            {
                bonus = (peningkatan + gajiPokok) * 0.05;
            }
            else
            {
                bonus = 0;
                peningkatan = 0;
            }
            Console.WriteLine($"Peningkatan = {peningkatan}");
            Console.WriteLine($"Bonus yang didapatkan: {bonus}");
        }

        public static void L1B()
        {
            Console.WriteLine("Latihan 1 Week 3B");
            Console.WriteLine();
            
            int inputLezat, inputIrit, totalAwal;
            double diskon, totalAkhir;
            Console.Write("Masukan jumlah pembelian paket irit: ");
            inputIrit = int.Parse(Console.ReadLine());
            Console.Write("Masukan jumlah pembelian paket lezat: ");
            inputLezat = int.Parse(Console.ReadLine());
            totalAwal = (inputIrit * 22500) + (inputLezat * 35000);
            if (inputIrit >= 3 || inputLezat >= 4)
            {
                diskon = totalAwal * 0.03;
            }
            else
            {
                diskon = 0;
            }
            totalAkhir = totalAwal - diskon;
            Console.WriteLine("Total yang harus dibayar adalah: " + totalAkhir);
        }

        public static void L2B()
        {
            Console.WriteLine("Latihan 2 Week 3B");
            Console.WriteLine();
            
            string jenisKelamin;
            int tanggal, totalMakanan, totalMinuman, totalBeli;
            double diskon, totalBayar;
            Console.Write("Masukan jenis kelamin anda (L/P): ");
            jenisKelamin = Console.ReadLine();

            Console.Write("Masukan tanggal hari ini (1-31): ");
            tanggal = int.Parse(Console.ReadLine());

            Console.Write("Masukan total makanan yang anda pesan: ");
            totalMakanan = int.Parse(Console.ReadLine());

            Console.Write("Masukan total minuman yang anda pesan: ");
            totalMinuman = int.Parse(Console.ReadLine());

            totalBeli = totalMakanan + totalMinuman;

            if ((jenisKelamin == "P" && tanggal == 22) && totalBeli > 250000)
            {
                diskon = 0.40 * totalMakanan;
            }
            else if ((jenisKelamin == "P" && tanggal == 22) && totalBeli <= 250000)
            {
                diskon = 0.1 * totalMakanan;
            }
            else
            {
                diskon = 0;
            }
            totalBayar = totalBeli - diskon;
            Console.WriteLine("Diskon anda sebesar: " + diskon);
            Console.WriteLine("Total yang harus dibayar: " + totalBayar);
        }

        public static void L3B()
        {
            Console.WriteLine("Latihan 3 Week 3B");
            Console.WriteLine();

            string kota;
            int jumlahBuku, hargaBuku, totalBuku, total = 0, ongkir = 0;

            Console.Write("Masukan jumlah buku yang dibeli : ");
            jumlahBuku = int.Parse(Console.ReadLine());
            Console.Write("Masukan harga buku : ");
            hargaBuku = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan kota tujuan:");
            Console.WriteLine("1. Jakarta");
            Console.WriteLine("2. Bandung");
            Console.WriteLine("3. Surabaya");
            Console.Write("input: ");
            kota = Console.ReadLine();

            totalBuku = jumlahBuku * hargaBuku;

            if (kota == "Jakarta" || kota == "1")
            {
                ongkir = 19000;
            }
            else if (kota == "Bandung" || kota == "2")
            {
                ongkir = 11000;
            }
            else if (kota == "Surabaya" || kota == "3")
            {
                ongkir = 5000;
            }
            else
            {
                Console.WriteLine("Kota tidak tersedia");
            }

            if (total > 100000)
            {
                ongkir = 0;
            }
            total = totalBuku + ongkir;
            Console.WriteLine("Ongkir : " + ongkir);
            Console.WriteLine("Total harga buku : " + total);
        }

        public static void L4B()
        {
            Console.WriteLine("Latihan 4 Week 3B");
            Console.WriteLine();

            int nilai;
            Console.Write("Masukkan Nilai Anda : ");
            nilai = int.Parse(Console.ReadLine());
            if (nilai >= 81 && nilai <= 100)
            {
                Console.WriteLine("Nisbi Anda: A");
            }
            else if (nilai >= 73 && nilai < 81)
            {
                Console.WriteLine("Nisbi Anda: AB");
            }
            else if (nilai >= 66 && nilai < 73)
            {
                Console.WriteLine("Nisbi Anda: B");
            }
            else if (nilai >= 60 && nilai < 66)
            {
                Console.WriteLine("Nisbi Anda: BC");
            }
            else if (nilai >= 55 && nilai < 60)
            {
                Console.WriteLine("Nisbi Anda: C");
            }
            else if (nilai >= 40 && nilai < 55)
            {
                Console.WriteLine("Nisbi Anda: D");
            }
            else
            {
                Console.WriteLine("Nisbi Anda: E");
            }

            if (nilai >= 55)
            {
                Console.WriteLine("Selamat Anda Lulus");
            }
            else
            {
                Console.WriteLine("Maaf Anda Tidak Lulus");
            }
        }

        public static void L5B()
        {
            Console.WriteLine("Latihan 5 Week 3B");
            Console.WriteLine();

            Console.Write("Input nama mahasiswa: ");
            string nama = Console.ReadLine();
            Console.Write("Input IPK mahasiswa: ");
            double ipk = double.Parse(Console.ReadLine());
            Console.Write("Input masa studi (semester): ");
            int masaStudi = int.Parse(Console.ReadLine());
            Console.Write("Pernah BSS/MSS (y/n): ");
            string pernahBSS = Console.ReadLine();
            if ((ipk >= 3.9 && ipk <= 4) && (masaStudi >= 1 && masaStudi <= 8) && pernahBSS.ToLower() == "n")
            {
                Console.WriteLine("Nama: " + nama);
                Console.WriteLine("IPK: " + ipk);
                Console.WriteLine("Masa Studi: " + masaStudi + " semester");
                Console.WriteLine("Status kelulusan: Summa Cumlaude");
            }
            else if ((ipk >= 3.5 && ipk < 3.9) && (masaStudi >= 1 && masaStudi <= 8) && pernahBSS.ToLower() == "n")
            {
                Console.WriteLine("Nama: " + nama);
                Console.WriteLine("IPK: " + ipk);
                Console.WriteLine("Masa Studi: " + masaStudi + " semester");
                Console.WriteLine("Status kelulusan: Cumlaude");
            }
            else if ((ipk >= 2.0 && ipk < 3.5) || (masaStudi >= 1 && masaStudi <= 14))
            {
                Console.WriteLine("Nama: " + nama);
                Console.WriteLine("IPK: " + ipk);
                Console.WriteLine("Masa Studi: " + masaStudi + " semester");
                Console.WriteLine("Status kelulusan: Regular");
            }
            else
            {
                Console.Write("input tidak valid");
            }
        }

        public static void L6B()
        {
            Console.WriteLine("Latihan 6 Week 3B");
            Console.WriteLine();

            int standar = 300_000, superior = 500_000, deluxe = 1_000_000, lamaNginap;
            double total = 0, diskon = 0.0;
            string nama, jenisKamar, member;
            Console.Write("Masukkan Nama Tamu: ");
            nama = Console.ReadLine();

            Console.WriteLine("Masukkan Jenis Kamar");
            Console.WriteLine("1. Standar");
            Console.WriteLine("2. Superior");
            Console.WriteLine("3. Deluxe");
            Console.Write("Pilihan Anda: ");

            jenisKamar = Console.ReadLine();
            Console.Write("Masukkan Lama Menginap: ");
            lamaNginap = int.Parse(Console.ReadLine());

            Console.Write("Apakah Anda Member (Y/N): ");
            member = Console.ReadLine();

            if (jenisKamar == "1" || jenisKamar.ToLower() == "standar")
            {
                total = standar * lamaNginap;
            }
            else if (jenisKamar == "2" || jenisKamar.ToLower() == "superior")
            {
                total = superior * lamaNginap;
            }
            else if (jenisKamar == "3" || jenisKamar.ToLower() == "deluxe")
            {
                total = deluxe * lamaNginap;
            }
            else
            {
                Console.WriteLine("Pilihan Anda Tidak Tersedia");
            }
            if (member.ToLower() == "y")
            {
                diskon = 0.1 * total;
                total = total - diskon;
            }
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jenis Kamar: " + jenisKamar);
            Console.WriteLine("Lama Menginap: " + lamaNginap + " Hari");
            Console.WriteLine("Diskon: Rp " + diskon);
            Console.WriteLine("Total Bayar: Rp " + total);
        }
    }
}
