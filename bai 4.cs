using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrSoChan= new int[0];
            string nhap;
            int num;
            int[] arrSoLe= new int[0];
            int[] arr;
            do
            {
                Console.WriteLine("Nhap do dai Mang:");
                nhap = Console.ReadLine();
            } while (!int.TryParse(nhap, out num));

            arr = NhapMang(num);
            Console.WriteLine("Mang xuat ra la:");
            XuatMang(arr);
            
            TachMang(arr, ref arrSoChan, ref arrSoLe);
            Console.WriteLine("\nMang chan:");
            XuatMang(arrSoChan);
            Console.WriteLine("\nMang le:");
            XuatMang(arrSoLe);
        }
        static int[] NhapMang(int arrLength)
        {
            int[] result = new int[arrLength];
            string nhap;

            for (int i = 0; i < arrLength; i++)
            {
                do
                {
                    Console.Write($"Nhap so phan tu thu {i} vao: ");
                    nhap = Console.ReadLine();
                } while (!int.TryParse(nhap, out result[i]));
            }
            return result;
        }
        static void XuatMang(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
        }
        static void TachMang(int[] arr, ref int[] arrSoChan, ref int[] arrSoLe)
        {
            foreach (int item in arr)
            {
                if (KiemTraSoChan(item))
                {
                    Array.Resize(ref arrSoChan, arrSoChan.Length + 1);
                    arrSoChan[arrSoChan.Length - 1] = item;
                }
                else
                {
                    Array.Resize(ref arrSoLe, arrSoLe.Length + 1);
                    arrSoLe[arrSoLe.Length - 1] = item;
                }
            }
        }
        static bool KiemTraSoChan(int num)
        {
            bool result = false;
            if (num % 2 == 0)
            {
                result = true;
            }
            return result;
        }
    }
}