using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace Chuong7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int soPhanTu;
            string nhap;
            int[] soChan;
            int[] soNguyenTo;
            float trungBinhCong;
            int soHoanThien;
            int timViTriCuoiX;
            int soNguyenToDauTien;
            int timSoMax;
            int timSoMin;
            int[] sapXepMang;
            bool kiemTraTangDan;
            do
            {
                Console.Write("Nhap so luong phan tu cua mang:");
                nhap = Console.ReadLine();
            } while (!int.TryParse(nhap, out soPhanTu));

            //Nhap Mang
            arr = NhapSoPhanTuMang(soPhanTu);

            //Xuat Mang
            Console.WriteLine("Mang nhap vao :");
            InManHinh(arr);

            //Tim so Chan
            soChan = TimSoChan(arr);
            Console.WriteLine("\nSo Chan co trong Mang la:");
            InManHinh(soChan);

            //So Nguyen To
            soNguyenTo = TimSoNguyenTo(arr);
            Console.WriteLine("\nSo Nguyen To co trong Mang la:");
            InManHinh(soNguyenTo);

            //TrungBinhCong
            trungBinhCong = TinhTrungBinhCong(arr);
            Console.Write($"\nTrung Binh Cong trong Mang la: \n{trungBinhCong}");

            //DemSoHoanThien
            soHoanThien = DemSoHoanThien(arr);
            Console.Write($"\nTong So Hoan Thien co trong Mang: \n{soHoanThien}");

            //Vi tri cuoi cua X
            timViTriCuoiX = TimViTriCuoiCuaX(arr, NhapX());
            Console.WriteLine($"Vi Tri Cuoi Cua X trong Mang la:\n{timViTriCuoiX}");

            //Vi tri dau tien so nguyen to
            soNguyenToDauTien = TimNguyenToDauTien(arr);
            Console.WriteLine($"So Nguyen To Dau Tien la: \n{soNguyenToDauTien}");

            //Tim So Max trong Mang
            timSoMax = TimSoMax(arr);
            Console.WriteLine($"So Max trong Mang la: \n{timSoMax}");

            //Tim So Max trong Mang
            timSoMin = TimSoMin(arr);
            Console.WriteLine($"So Max trong Mang la: \n{timSoMin}");

            //Sap Xep
            sapXepMang = SapXepCacViTri(arr);
            Console.WriteLine("Mang Sap Xep Theo Chieu Tang Dan:");
            InManHinh(sapXepMang);

            //Kiem tra Mang Tang Dan
            kiemTraTangDan = KiemTraMangTangDan(sapXepMang);
            Console.WriteLine(kiemTraTangDan ? "\nMang Tang Dan" : "\nkhong phai Mang Tang Dan");

        }
        static int[] NhapSoPhanTuMang(int arrLength)
        {
            int[] result = new int[arrLength];
            string nhap;
            for (int i = 0; i < arrLength; i++)
            {
                do
                {
                    Console.Write($"Nhap phan tu thu {i}:");
                    nhap = Console.ReadLine();
                } while (!int.TryParse(nhap, out result[i]));
            }
            return result;
        }
        static void InManHinh(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
        }
        static int[] TimSoChan(int[] arr)
        {
            int[] result = new int[0];

            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }
            return result;
        }
        static bool KiemTraSoNguyenTo(int num)
        {
            bool result;
            result = num > 1;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return result;
        }
        static int[] TimSoNguyenTo(int[] arr)
        {
            int[] result = new int[0];
            foreach (int item in arr)
            {
                if (KiemTraSoNguyenTo(item))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }
            return result;
        }
        static float TinhTrungBinhCong(int[] arr)
        {
            float result = 0;
            foreach (int item in arr)
            {
                result += item;
            }
            return result / arr.Length;
        }
        static bool KiemTraSoHoanThien(int num)
        {
            bool result;
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            result = sum == num;
            return result;
        }
        static int DemSoHoanThien(int[] arr)
        {
            int result = 0;

            foreach (int item in arr)
            {
                if (KiemTraSoHoanThien(item))
                {
                    result++;
                }
            }
            return result;
        }
        static int TimViTriCuoiCuaX(int[] arr, int x)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result = i;
                }
            }
            return result;
        }
        static int NhapX()
        {
            int result;
            string nhapX;
            do
            {
                Console.Write("\nNhap X:");
                nhapX = Console.ReadLine();
            } while (!int.TryParse(nhapX, out result)); ;
            return result;
        }
        static int TimNguyenToDauTien(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSoNguyenTo(arr[i]))
                {
                    result = arr[i];
                    break;
                }
            }
            return result;
        }
        static int TimSoMax(int[] arr)
        {
            int result = int.MinValue;
            foreach (int item in arr)
            {
                if (result < item)
                {
                    result = item;
                }
            }
            return result;
        }
        static int TimSoMin(int[] arr)
        {
            int result = int.MaxValue;
            foreach (int item in arr)
            {
                if (result > item)
                {
                    result = item;
                }
            }
            return result;
        }
        static int[] SapXepCacViTri(int[] arr)
        {
            int[] result = new int[arr.Length];
            int temp;

            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {

                        temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }
        static bool KiemTraMangTangDan(int[] arr)
        {
            bool result = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}