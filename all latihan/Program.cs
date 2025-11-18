using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace all_latihan
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== ALL LATIHAN ALPRO =====\n");
            Console.ResetColor();

            Console.Write("Week Berapa(1-14): ");
            int week = int.Parse(Console.ReadLine());
            switch (week)
            {
                case 1:
                    week1.pilihan();
                    break;
                case 2:
                    week2.pilihan();
                    break;
                case 3:
                    week3.pilihan();
                    break;
                case 4:
                    week4.pilihan();
                    break;
                case 5:
                    week5.pilihan();
                    break;
                case 6:
                    week6.pilihan();
                    break;
                case 7:
                    week7.pilihan();
                    break;
                case 8:
                    week8.pilihan();
                    break;
                case 9:
                    week9.pilihan();
                    break;
                case 10:
                    week10.pilihan();
                    break;
                case 11:
                    //week11.pilihan();
                    break;
                case 12:
                    //week12.pilihan();
                    break;
                case 13:
                    //week13.pilihan();
                    break;
                case 14:
                    //week14.pilihan();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
