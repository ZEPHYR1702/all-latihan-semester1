using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    internal class week7
    {
        public static void pilihan()
        {
            Console.WriteLine("Latihan Week 7");
            Console.Write("Latihan Berapa(1-18): ");
            int pilihan = int.Parse(Console.ReadLine());
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
                case 4:
                    L4();
                    break;
                case 5:
                    L5();
                    break;
                case 6:
                    L6();
                    break;
                case 7:
                    L7();
                    break;
                case 8:
                    L8();
                    break;
                case 9:
                    L9();
                    break;
                case 10:
                    L10();
                    break;
                case 11:
                    L11();
                    break;
                case 12:
                    L12();
                    break;
                case 13:
                    L13();
                    break;
                case 14:
                    L14();
                    break;
                case 15:
                    L15();
                    break;
                case 16:
                    L16();
                    break;
                case 17:
                    L17();
                    break;
                case 18:
                    L18();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }

        public static void L1()
        {
            Console.WriteLine("Latihan 1 Week 7");
            Console.WriteLine();

            Console.Write("Inputkan batas bilangan: ");
            int batas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= batas; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine($"{j}x{i} = {j*i}");
                }
                Console.WriteLine();
            }
        }

        public static void L2()
        {
            Console.WriteLine("Latihan 2 Week 7");
            Console.WriteLine();

            Console.Write("Input batas akhir: ");
            int batasAkhir = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            while (b <= batasAkhir)
            {
                Console.WriteLine(b + " ");
                int temp = b;
                b = b + a;
                a = temp;
            }
            Console.WriteLine();
        }

        public static void L3()
        {
            Console.WriteLine("Latihan 3 Week 7");
            Console.WriteLine();

            Console.Write("Input jumlah baris : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void L4()
        {
            Console.WriteLine("Latihan 4 Week 7");
            Console.WriteLine();

            Console.Write("Jenis barang : ");
            int jenis = int.Parse(Console.ReadLine());

            for (int i = 1; i <= jenis; ++i)
            {
                Console.Write("Stok awal barang " + i + ": ");
                int stok = int.Parse(Console.ReadLine());

                Console.Write("Jumlah transaksi : ");
                int tr = int.Parse(Console.ReadLine());

                for (int j = 0; j < tr; ++j)
                {
                    Console.Write("Jumlah barang (keluar/masuk): ");
                    int jum = int.Parse(Console.ReadLine());
                    stok += jum;
                }

                Console.WriteLine();
                Console.WriteLine("Stok akhir barang " + i + " = " + stok);
                Console.WriteLine();
            }
        }

        public static void L5()
        {
            Console.WriteLine("Latihan 5 Week 7");
            Console.WriteLine();

            Console.Write("Input bilangan : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                for (int j = i; j <= n; ++j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void L6()
        {
            Console.WriteLine("Latihan 6 Week 7");
            Console.WriteLine();

            Console.Write("Input bilangan : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; --i)
            {
                for (int j = i; j >= 1; --j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void L7()
        {
            Console.WriteLine("Latihan 7 Week 7");
            Console.WriteLine();

            Console.Write("Input bilangan : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                for (int j = i; j < n; ++j)
                    Console.Write("  ");
                Console.WriteLine(i);
            }
        }

        public static void L8()
        {
            Console.WriteLine("Latihan 8 Week 7");
            Console.WriteLine();

            Console.Write("Inputkan jumlah tahun : ");
            int n = int.Parse(Console.ReadLine());
            int tab = 0;

            for (int t = 1; t <= n; ++t)
            {
                Console.WriteLine("TAHUN " + t);

                for (int b = 1; b <= 12; ++b)
                {
                    Console.Write("Input setoran bulan " + b + " : ");
                    int setoran = int.Parse(Console.ReadLine());
                    tab += setoran;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total saldo tabungan selama " + n + " tahun = " + tab);
        }

        public static void L9()
        {
            Console.WriteLine("Latihan 9 Week 7");
            Console.WriteLine();

            Console.Write("Baris tengah : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j <= i; ++j)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = n - 1; i > 0; --i)
            {
                for (int j = i; j > 0; --j)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public static void L10()
        {
            Console.WriteLine("Latihan 10 Week 7");
            Console.WriteLine();

            Console.Write("Input jumlah mahasiswa : ");
            int mhs = int.Parse(Console.ReadLine());
            Console.Write("Input jumlah tugas : ");
            int tgs = int.Parse(Console.ReadLine());

            double totalTugas = 0;

            for (int t = 1; t <= tgs; ++t)
            {
                Console.WriteLine();
                Console.WriteLine("TUGAS " + t);

                int total = 0;

                for (int m = 1; m <= mhs; ++m)
                {
                    Console.Write("Input nilai tugas mhs " + m + " : ");
                    int nilai = int.Parse(Console.ReadLine());
                    total += nilai;
                }

                double rata = total / (double)mhs;
                totalTugas += rata;

                Console.WriteLine("Nilai Rata2 Tugas " + t + " = " + rata);
            }

            double rataSemua = totalTugas / tgs;

            Console.WriteLine();
            Console.WriteLine("Nilai Rata2 Semua Tugas = " + rataSemua);
        }

        public static void L11()
        {
            Console.WriteLine("Latihan 11 Week 7");
            Console.WriteLine();

            int totalSks = 0;
            double totalBobot = 0;
            int accSks = 0;

            for (int i = 1; accSks < 24; ++i)
            {
                Console.WriteLine("Mata Kuliah " + i);

                Console.Write("Input sks mata kuliah " + i + " : ");
                int sks = int.Parse(Console.ReadLine());

                accSks += sks;
                if (accSks <= 24)
                {
                    Console.Write("Input nisbi mata kuliah " + i + " : ");
                    string nisbi = Console.ReadLine();

                    double bobot;
                    if (nisbi == "A")
                        bobot = 4.0;
                    else if (nisbi == "AB")
                        bobot = 3.5;
                    else if (nisbi == "B")
                        bobot = 3.0;
                    else if (nisbi == "BC")
                        bobot = 2.5;
                    else if (nisbi == "C")
                        bobot = 2.0;
                    else if (nisbi == "D")
                        bobot = 1.0;
                    else
                        bobot = 0;

                    totalBobot += bobot * sks;
                    totalSks += sks;
                }
                else
                {
                    Console.WriteLine("SKS melebihi 24 sks, mata kuliah ini tidak akan dimasukkan.");
                }
            }

            Console.WriteLine("Total SKS = " + totalSks);
            Console.WriteLine("IPK = " + totalBobot / totalSks);
        }

        public static void L12()
        {
            Console.WriteLine("Latihan 12 Week 7");
            Console.WriteLine();

            Console.Write("Nilai awal : ");
            int awal = int.Parse(Console.ReadLine());
            Console.Write("Nilai akhir : ");
            int akhir = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Bilangan prima = ");

            if (awal <= 2)
            {
                Console.Write("2 ");
                awal = 3;
            }
            else if (awal % 2 == 0)
            {
                awal += 1;
            }

            for (int i = awal; i <= akhir; i += 2)
            {
                int j = 3;
                while (j < i && i % j != 0)
                    j += 2;

                if (i == j)
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public static void L13()
        {
            Console.WriteLine("Latihan 13 Week 7");
            Console.WriteLine();

            Console.Write("Input batas awal : ");
            int awal = int.Parse(Console.ReadLine());
            Console.Write("Input batas akhir : ");
            int akhir = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;

            Console.Write("Fibonacci Prima = ");

            while (b < akhir)
            {
                int tmp = b;
                b += a;
                a = tmp;

                if (awal <= b && b <= akhir)
                {
                    if (b % 2 != 0)
                    {
                        int p = 3;
                        while (p < b && b % p != 0)
                            p += 2;

                        if (p == b)
                            Console.Write(b + " ");
                    }
                    else if (b == 2)
                    {
                        Console.Write("2 ");
                    }
                }
            }

            Console.WriteLine();
        }

        public static void L14()
        {
            Console.WriteLine("Latihan 14 Week 7");
            Console.WriteLine();

            Console.Write("Bilangan baris tengah : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                for (int j = n - 1 - i; j > 0; --j)
                    Console.Write("  ");
                for (int j = 2 * i + 1; j > 0; --j)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; --i)
            {
                for (int j = n - 1 - i; j > 0; --j)
                    Console.Write("  ");
                for (int j = 2 * i + 1; j > 0; --j)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public static void L15()
        {
            Console.WriteLine("Latihan 15 Week 7");
            Console.WriteLine();

            Console.Write("Bilangan penentu : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                for (int j = n - 1 - i; j > 0; --j)
                    Console.Write("  ");
                for (int j = 2 * i + 1; j > 0; --j)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = n - 1; j > 0; --j)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
            }

            for (int i = n * 2 - 1; i > 0; --i)
            { 
                Console.Write("* "); 
            }
            Console.WriteLine();
        }

        public static void L16()
        {
            Console.WriteLine("Latihan 16 Week 7");
            Console.WriteLine();

            Console.Write("Bilangan penentu : ");
            int n = int.Parse(Console.ReadLine());
            int len = n * 2 - 1;

            for (int i = n; i > 0; --i)
            {
                int s = 0;
                for (; s < i; ++s)
                    Console.Write("* ");
                for (int j = len - i - i; j > 0; --j)
                    Console.Write("  ");
                for (; s < i * 2 && s < len; ++s)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = 2; i <= n; ++i)
            {
                int s = 0;
                for (; s < i; ++s)
                    Console.Write("* ");
                for (int j = len - i - i; j > 0; --j)
                    Console.Write("  ");
                for (; s < i * 2 && s < len; ++s)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public static void L17()
        {
            Console.WriteLine("Latihan 17 Week 7");
            Console.WriteLine();

            Console.Write("Bilangan 1 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Bilangan 2 : ");
            int b = int.Parse(Console.ReadLine());

            int faktor = 0;
            if (a % 2 == 0 && b % 2 == 0)
                faktor = 2;

            int max = a;
            if (max < b)
                max = b;

            for (int p = 3; p < max; p += 2)
            {
                int i = 3;
                while (i < p && p % i != 0)
                    i += 2;

                if (i == p && a % p == 0 && b % p == 0)
                    faktor = p;
            }

            if (faktor != 0)
            {
                Console.WriteLine("Bilangan prima persekutuan terbesar = " + faktor);
            }
            else
            {
                Console.WriteLine("Tidak ada bilangan prima persekutuan terbesar");
            }
        }

        public static void L18()
        {
            Console.WriteLine("Latihan 18 Week 7");
            Console.WriteLine();

            int total = 0;
            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + i + i + j + k + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + i + j + i + k + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + i + j + k + i + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + j + i + i + k + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + j + i + k + i + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k <= 9; ++k)
                        {
                            if (k != j && k != i)
                            {
                                total += 1;
                                Console.Write("" + j + k + i + i + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Total kemungkinan = " + total);
        }
    }
}
