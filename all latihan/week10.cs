using System;
using System.Collections.Generic;
using System.Text;

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
            string week = Console.ReadLine()!.ToLower();
            if (week == "a")
            {
                Console.Write("Masukan Latihan (1/2): ");
                int.TryParse(Console.ReadLine(), out int latihan);
                if (latihan == 1)
                    L1A();
                else if (latihan == 2)
                    L2A();
                else
                    Console.WriteLine("Latihan tidak ditemukan");
            }
            else
            {
                Console.Write("Masukan Latihan (1/2): ");
                int.TryParse(Console.ReadLine(), out int latihan);
                if (latihan == 1)
                    L1B();
                else if (latihan == 2)
                    L2B();
                else
                    Console.WriteLine("Latihan tidak ditemukan");
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
                namaPelanggan = Console.ReadLine()!;
                Console.Write("Paket yang dipilih: ");
                namaPaket = Console.ReadLine()!;
                Console.Write("Lama langganan: ");
                int.TryParse(Console.ReadLine(), out lamaLangganan);

                listNamaPelanggan.Add(namaPelanggan);
                listPaket.Add(namaPaket);
                listLama.Add(lamaLangganan);

                Console.Write("Ada pelanggan lagi (y/t): ");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
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
                nomorMobil = Console.ReadLine()!;
                Console.Write("Lama parkir (jam): ");
                int.TryParse(Console.ReadLine(), out lamaParkir);

                listNomorMobil.Add(nomorMobil);
                listLamaParkir.Add(lamaParkir);

                Console.Write("ada mobil lagi(y/t): ");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
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

        public static void L1B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 1B Week 10 =====");
            Console.ResetColor();

            //deklarasi
            int tanggalTransaksi, nominal;
            char jenisTransaksi, jawab;
            string uraian;

            List<int> listTanggalTransaksi = new List<int>();
            List<int> listNominal = new List<int>();
            List<char> listJenisTransaksi = new List<char>();
            List<string> listUraian = new List<string>();

            //input
            Console.Write("Bulan laporan transaksi: ");
            int.TryParse(Console.ReadLine(), out int bulanLaporan);
            Console.Write("Tahun laporan transaksi: ");
            int.TryParse(Console.ReadLine(), out int tahunLaporan);
            do
            {
                Console.Write("Tanggal transaksi (1-31): ");
                int.TryParse(Console.ReadLine(), out tanggalTransaksi);
                Console.Write("Jenis transaksi (M/K): ");
                jenisTransaksi = char.Parse(Console.ReadLine()!.ToUpper());
                Console.Write("Nominal transaksi: ");
                int.TryParse(Console.ReadLine(), out nominal);
                Console.Write("Keterangan transaksi: ");
                uraian = Console.ReadLine()!;

                listTanggalTransaksi.Add(tanggalTransaksi);
                listJenisTransaksi.Add(jenisTransaksi);
                listNominal.Add(nominal);
                listUraian.Add(uraian);

                Console.Write("Ada transaksi lagi (y/t): ");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
            }
            while (jawab == 'y');

            //daftar semua transaksi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n----- Laporan transaksi bulan {bulanLaporan} tahun {tahunLaporan} -----");
            Console.ResetColor();

            Console.WriteLine("Semua transaksi");
            Console.WriteLine($"Tanggal \t Jenis \t Nominal \t Keterangan");
            for (int i = 0; i < listTanggalTransaksi.Count; i++)
            {
                Console.WriteLine($"{listTanggalTransaksi[i]} \t\t {listJenisTransaksi[i]} \t Rp{listNominal[i]} \t {listUraian[i]}");
            }

            //daftar semua transaksi masuk
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n----- Laporan semua transaksi masuk -----");
            Console.ResetColor();

            int totalMasuk = 0;
            Console.WriteLine($"Tanggal \t Nominal \t Keterangan");
            for (int i = 0; i < listJenisTransaksi.Count; i++)
            {
                if (listJenisTransaksi[i] == 'M')
                {
                    Console.WriteLine($"{listTanggalTransaksi[i]} \t\t Rp{listNominal[i]} \t {listUraian[i]}");
                    totalMasuk += listNominal[i];
                }
            }
            Console.WriteLine($"Total transaksi masuk: Rp{totalMasuk}");

            //daftar semua transaksi keluar
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n----- Laporan semua transaksi keluar -----");
            Console.ResetColor();

            int totalKeluar = 0;
            Console.WriteLine($"Tanggal \t Nominal \t Keterangan");
            for (int i = 0; i < listJenisTransaksi.Count; i++)
            {
                if (listJenisTransaksi[i] == 'K')
                {
                    Console.WriteLine($"{listTanggalTransaksi[i]} \t\t Rp{listNominal[i]} \t {listUraian[i]}");
                    totalKeluar += listNominal[i];
                }
            }
            Console.WriteLine($"Total transaksi keluar: Rp{totalKeluar}");

            //saldo akhir
            int saldoAkhir = totalMasuk - totalKeluar;
            Console.WriteLine($"\nSaldo akhir bulan {bulanLaporan} tahun {tahunLaporan}: Rp{saldoAkhir}");
        }

        public static void L2B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n===== Latihan 2B Week 10 =====");
            Console.ResetColor();

            //deklarasi
            string namaPelayan, Stand;
            int totalPembelanjaan;
            char jawab;

            List<string> listNamaPelayan = new List<string>();
            List<string> listStand = new List<string>();
            List<int> listTotalPembelanjaan = new List<int>();

            do
            {
                Console.Write("Nama Pelayan: ");
                namaPelayan = Console.ReadLine()!;
                Console.Write("Stand yang dilayani(SM/SE): ");
                Stand = Console.ReadLine()!;
                Console.Write("Total pembelanjaan: ");
                int.TryParse(Console.ReadLine(), out totalPembelanjaan);

                listNamaPelayan.Add(namaPelayan);
                listStand.Add(Stand);
                listTotalPembelanjaan.Add(totalPembelanjaan);

                Console.Write("Ada pelayan lagi (y/t): ");
                jawab = char.Parse(Console.ReadLine()!.ToLower());
            }
            while (jawab == 'y');

            //daftar semua pelayan
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----- Daftar semua pelayan -----");
            Console.ResetColor();

            int totalPendapatan = 0;
            Console.WriteLine("No\tStand\tPelayan\tTotal Pembelanjaan");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < listNamaPelayan.Count; i++)
            {
                Console.WriteLine($"{i+1}\t{listNamaPelayan[i]}\t{listStand[i]}\tRp{listTotalPembelanjaan[i]}");
                totalPendapatan += listTotalPembelanjaan[i];
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"\nTotal pendapatan seluruh stand: Rp{totalPendapatan}");

            //transaksi stand super murah
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----- Transaksi Stand Super Murah -----\n");
            Console.ResetColor();

            int counter1 = 0;
            Console.WriteLine("No\tPelayan\t\tTotal Pembelanjaan");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < listStand.Count; i++)
            {
                if (listStand[i].ToLower() == "sm")
                {
                    counter1 += 1;
                    Console.WriteLine($"{counter1}\t{listNamaPelayan[i]}\t\tRp{listTotalPembelanjaan[i]}");
                }
            }

            //transaksi stand super enak
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----- Transaksi Stand Super Enak -----\n");
            Console.ResetColor();

            int counter2 = 0;
            Console.WriteLine("No\tPelayan\t\tTotal Pembelanjaan");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < listStand.Count; i++)
            {
                if (listStand[i].ToLower() == "se")
                {
                    counter2 += 1;
                    Console.WriteLine($"{counter2}\t{listNamaPelayan[i]}\t\tRp{listTotalPembelanjaan[i]}");
                }
            }

            //pendapatan anita (30% cut)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----- Pendapatan Untuk Anita -----");
            Console.ResetColor();

            double cut30 = 0;
            for (int i = 0; i < listTotalPembelanjaan.Count; i++)
            {
                cut30 = cut30 + listTotalPembelanjaan[i];
            }
            Console.WriteLine($"Total pendapatan Anita: {cut30 * 0.3}");

            //kelompok komisi
            List<string> listPekerja = new List<string>();
            List<int> listKomisiSM = new List<int>();
            List<int> listKomisiSE = new List<int>();
            int j;
            

            
            //komisi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Komisi Pelayan -----");
            Console.ResetColor();

            int counter3 = 0;
            Console.WriteLine("No\tPelayan\tSuper Enak\tSuperMurah");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < listTotalPembelanjaan.Count; i++)
            {
                counter3 += 1;
                if (listStand[i] == "sm")
                {
                    Console.WriteLine($"{counter3}\t{listNamaPelayan[i]}\t{0}\t\t{listTotalPembelanjaan[i] * 0.5}");
                }
                else
                {
                    Console.WriteLine($"{counter3}\t{listNamaPelayan[i]}\t{listTotalPembelanjaan[i] * 0.5}\t\t{0}");
                }
            }
        }
    }
}
