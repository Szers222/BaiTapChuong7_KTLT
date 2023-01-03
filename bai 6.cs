using System.Reflection;

namespace bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] arrDuong;
            int[] arrAm;

            arr = NhapMang();
            Console.WriteLine("Mang goc la:");
            XuatMang(arr);

            TachMang(arr,out arrDuong,out arrAm);
            Console.WriteLine("\nMang Duong la:");
            XuatMang(arrDuong);
            Console.WriteLine("\nMang Am la:");
            XuatMang(arrAm);
        }
        static int[] NhapMang()
        {
            int[] result = new int[0];
            string nhap;
            int i = -1;
            int soNhapVao;
            
            do
            {
                do
                {
                    Console.WriteLine($"Nhap phan tu thu {i+1} cua Mang la: ");
                    nhap = Console.ReadLine();
                } while (!int.TryParse(nhap, out soNhapVao));
                if (soNhapVao!=-1)
                {
                    Array.Resize(ref result, result.Length+1);
                    result[result.Length-1] = soNhapVao;
                }
                else
                {
                    break;
                }
                i++;
            } while (true);
            return result;
        }
        static void XuatMang(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item+"\t");
            }
        } 
        static void TachMang(int[] arr,out int[] arrDuong,out int[] arrAm)
        {
            arrDuong = new int[0];
            arrAm = new int[0];
            foreach (int item in arr)
            {
                if (item >= 0)
                {
                    Array.Resize(ref arrDuong, arrDuong.Length + 1);
                    arrDuong[arrDuong.Length - 1] = item;
                }
                else
                {
                    Array.Resize(ref arrAm, arrAm.Length + 1);
                    arrAm[arrAm.Length - 1] = item;
                }
            }
        }
    }
}