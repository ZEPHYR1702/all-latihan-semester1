using System;

public class week8
{
	public static void pilihan()
	{
		int pilihan;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("===== Latihan Week 8 =====");
		Console.ResetColor();

        Console.Write("Latihan Berapa(1-7): ");
		pilihan = int.Parse(Console.ReadLine());
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
			default:
				Console.WriteLine("Pilihan tidak valid.");
				break;
        }
    }

	public static void L1()
	{
        Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\n===== Latihan 1 Week 8 =====");
		Console.ResetColor();

		Console.WriteLine("Masukan data penjualan dalam satu minggu:");
		int[] penjualan = new int[7];
		
		for (int i = 0; i < 7; i++)
		{
			Console.Write($"Hari ke-{i + 1}: ");
			penjualan[i] = int.Parse(Console.ReadLine());
        }
		Console.WriteLine("Batas bawah: ");
		int batasBawah = int.Parse(Console.ReadLine());
		Console.WriteLine("Batas atas: ");
		int batasAtas = int.Parse(Console.ReadLine());
		Console.WriteLine($"Data penjualan antara {batasBawah} dan {batasAtas}:");
		for (int i = 0; i < 7; i++)
		{
			if (penjualan[i] >= batasBawah && penjualan[i] <= batasAtas)
			{
				Console.WriteLine($"Hari ke-{i + 1}: {penjualan[i]}");
            }
        }
    }

	public static void L2()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 2 Week 8 =====");
		Console.ResetColor();

		Console.WriteLine("Masukan data penjualan dalam satu minggu:");
		int[] penjualan = new int[7];
		int max = penjualan[0];
		int min = penjualan[0];

		for (int i = 0; i < 7; i++)
		{
			Console.Write($"Hari ke-{i + 1}: ");
			penjualan[i] = int.Parse(Console.ReadLine());
        }
		for (int i = 0; i < 7; i++)
		{
			if (penjualan[i] > max)
			{
				max = penjualan[i];
            }
			if (penjualan[i] < min)
			{
				min = penjualan[i];
			}
        }
		Console.WriteLine("Penjualan maksimum:");
		for (int i = 0; i < 7; i++)
		{
			if (penjualan[i] == max)
			{
				Console.WriteLine($"Hari ke-{i + 1}: {penjualan[i]}");
            }
        }
		Console.WriteLine("Penjualan minimum:");
		for (int i = 0; i < 7; i++)
		{
			if (penjualan[i] == min)
			{
				Console.WriteLine($"Hari ke-{i + 1}: {penjualan[i]}");
            }
        }
    }

	public static void L3()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 3 Week 8 =====");
		Console.ResetColor();

		Console.WriteLine("Masukan data penjualan dalam satu minggu:");
		int[] hari = new int[7];
		double persentase = 0, prediksi = 0;

		for (int i = 0; i < 7; i++)
		{
			Console.Write($"Hari ke-{i + 1}: ");
			hari[i] = int.Parse(Console.ReadLine());
        }

		Console.Write("Persentase kenaikan:");
		persentase = double.Parse(Console.ReadLine());
		persentase /= 100;
		Console.WriteLine();

		Console.WriteLine("Prediksi penjualan untuk minggu depan:");
		for (int i = 0; i < 7; i++)
		{
			prediksi = Math.Round(hari[i] + (hari[i] * persentase));
			Console.WriteLine($"Hari ke-{i + 1}: {prediksi}");
        }
    }

	public static void L4()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 4 Week 8 =====");
		Console.ResetColor();

		Console.WriteLine("Masukan data penjualan dalam satu minggu:");
		int[] penjualan = new int[14];

		for (int i = 0; i < 7; i++)
		{
			Console.Write($"Hari ke-{i + 1}: ");
			penjualan[i] = int.Parse(Console.ReadLine());
        }

		Console.WriteLine();
		Console.WriteLine("Prediksi penjualan minggu depan:");
		for (int i = 7; i < 14; i++)
		{
			double rata = (penjualan[i-3] + penjualan[i-2] + penjualan[i-1]) / 3.0;
			penjualan[i] = (int)Math.Round(rata);
			Console.WriteLine($"Hari ke-{i - 6}: {penjualan[i]}");
        }
    }

	public static void L5()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 5 Week 8 =====");
		Console.ResetColor();

		Console.WriteLine("Masukan data suhu tubuh siswa dalam derajat Celsius:");
		int[] suhu = new int[10];
		int jumlahSakit = 0;

		for (int i = 0; i < suhu.Length; i++)
		{
			Console.Write($"Siswa ke-{i + 1}: ");
			suhu[i] = int.Parse(Console.ReadLine());
        }
		Console.WriteLine();

		for (int i = 0; i < suhu.Length; i++)
		{
			if (suhu[i] > 37)
			{
				Console.WriteLine($"Siswa ke-{i + 1}: sedang demam ({suhu[i]} derajat Celcius)");
				jumlahSakit++;
            }
        }
		Console.WriteLine();
		Console.WriteLine($"Ada {jumlahSakit} yang harus pulang karena demam");
    }

	public static void L6()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 6 Week 8 =====");
		Console.ResetColor();

		Console.Write("Masukan jumlah mata kuliah: ");
		int jumlah = int.Parse(Console.ReadLine());

		int[] sks = new int[jumlah];
		char[] nilaiHuruf = new char[jumlah];

		double totalBobot = 0;
		int totalSks = 0;

		Console.WriteLine("Masukan data mata kuliah: ");
		for (int i = 0; i < jumlah; i++)
		{
			Console.Write($"SKS mata kuliah ke-{i + 1}: ");
			sks[i] = int.Parse(Console.ReadLine());
			Console.Write($"Nilai mata kuliah ke-{i + 1}: ");
			nilaiHuruf[i] = char.Parse(Console.ReadLine().ToUpper());

			int bobot = 0;
			switch(nilaiHuruf[i])
			{
				case 'A':
					bobot = 4;
					break;
				case 'B':
					bobot = 3;
					break;
				case 'C':
					bobot = 2;
					break;
				case 'D':
					bobot = 1;
					break;
				case 'E':
					bobot = 0;
					break;
            }
			totalBobot += bobot * sks[i];
			totalSks += sks[i];
        }
		double ips = totalBobot / totalSks;
		Console.WriteLine();
        Console.WriteLine($"IPS: {ips}");
    }

	public static void L7()
	{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===== Latihan 7 Week 8 =====");
		Console.ResetColor();

		int[] NRP = new int[30];
		int[] NTS = new int[30];
		int[] NAS = new int[30];
		double[] NA = new double[30];
		char[] grade = new char[30];

        Console.Write("Masukan jumlah mahasiswa: ");
		int jumlahMahasiswa = int.Parse(Console.ReadLine());

		for (int i = 0; i < jumlahMahasiswa; i++)
		{
			Console.WriteLine($"Data mahasiswa ke-{i + 1}:");
			Console.Write("NRP: ");
			NRP[i] = int.Parse(Console.ReadLine());
			Console.Write("NTS: ");
			NTS[i] = int.Parse(Console.ReadLine());
			Console.Write("NAS: ");
			NAS[i] = int.Parse(Console.ReadLine());
        }

		int pilihan;
		do
		{
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Hitung dan tampilkan NA dan grade");
            Console.WriteLine("2. Perbaiki nilai NAS berdasarkan NRP");
            Console.WriteLine("3. Rangkuman NTS");
            Console.WriteLine("4. Rangkuman NAS");
            Console.WriteLine("5. Tampilkan semua data mahasiswa");
            Console.WriteLine("6. Persentase nilai A-E");
            Console.WriteLine("7. Hitung minimal NAS agar lulus");
            Console.WriteLine("8. Mahasiswa dengan NA tertinggi");
            Console.WriteLine("9. Keluar");
            Console.Write("Pilih menu: ");
			pilihan = int.Parse(Console.ReadLine());

			switch (pilihan)
			{
                case 1:
                    for (int i = 0; i < jumlahMahasiswa; i++)
                    {
                        NA[i] = 0.4 * NTS[i] + 0.6 * NAS[i];
                        if (NA[i] >= 80) grade[i] = 'A';
                        else if (NA[i] >= 70) grade[i] = 'B';
                        else if (NA[i] >= 60) grade[i] = 'C';
                        else if (NA[i] >= 50) grade[i] = 'D';
                        else grade[i] = 'E';
                    }
                    Console.WriteLine("\nNRP\tNTS\tNAS\tNA\tGrade");
                    for (int i = 0; i < jumlahMahasiswa; i++)
                        Console.WriteLine($"{NRP[i]}\t{NTS[i]}\t{NAS[i]}\t{NA[i]:F1}\t{grade[i]}");
                    break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				case 5:
					break;
				case 6:
					break;
				case 7:
					break;
				case 8:
					break;
				case 9:
					break;
            }
        }
		while (pilihan != 9);
    }
}
