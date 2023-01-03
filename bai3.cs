using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace bai2
{
    internal class bai3
    {
        static void Main(string[] args)
        {
            int num;
            int[] arrA;
            int[] arrB;
            string nhapSo;
            int[] arrC;

            do
            {
                Console.WriteLine("Nhap so Phan tu trong mang:");
                nhapSo = Console.ReadLine();
            } while (!int.TryParse(nhapSo, out num));


            Console.WriteLine("Nhap Mang A la:");
            arrA = NhapMang(num);
            Console.WriteLine("Nhap Mang B la:");
            arrB = NhapMang(num);

            //Cong Phan Tu tu trong 2 Mang
            arrC = CongHaiMang(arrA, arrB);
            XuatMang(arrC);


        }
        static int[] NhapMang(int arrLength)
        {
            int[] result = new int[arrLength];
            string nhapSo;
            for (int i = 0; i < arrLength; i++)
            {
                do
                {
                    Console.Write($"So Phan Tu thu {i}:");
                    nhapSo = Console.ReadLine();
                } while (!int.TryParse(nhapSo, out result[i]));
            }
            return result;
        }


        static void XuatMang(int[] arr)
        {
            Console.WriteLine("Mang Xuat ra la: ");
            foreach  (int item in arr)
            {
                Console.Write(item+"\t");
            }
        }
        static int[] CongHaiMang(int[] arrA, int[] arrB)
        {
            int[] result = new int[arrA.Length];

            for (int i = 0; i < arrA.Length; i++)
            {
                result[i] = arrA[i] + arrB[i];
            }
            return result;
        }
    }
}

