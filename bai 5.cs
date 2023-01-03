namespace bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrRandom;
            int num;
            string nhap;
            int soMax;
            int[] sapXep;
            bool kiemTraTrungLap;
            do
            {
                Console.WriteLine("Nhap do dai cua Mang:");
                nhap = Console.ReadLine();
            } while (!int.TryParse(nhap, out num));

            arrRandom = NhapSoNgauNhien(num);
            Console.WriteLine("Mang Random la:");
            XuatMang(arrRandom);

            //So Max Co trong Mang
            soMax = TimMax(arrRandom);
            Console.WriteLine($"\nSo Max trong Mang la : {soMax}");

            //Sap xep Mang giam dan
            sapXep = SapXepGiamDan(arrRandom);
            Console.WriteLine("Mang duoc sap xep:");
            XuatMang(sapXep);

            //KiemTraTrung
            kiemTraTrungLap = TimSoGiongNhau(arrRandom);
            if (kiemTraTrungLap)
            {
                Console.WriteLine("\nCo so Trung");
            }
            else
            {
                Console.WriteLine("\nKhong co so trung");
            }
        }
        static int[] NhapSoNgauNhien(int arrLength)
        {
            int[] result = new int[arrLength];
            Random rnd = new Random();

            for (int i = 0; i < arrLength; i++)
            {
                result[i] = rnd.Next(0, 1000);
                Console.WriteLine($"So phan tu ngau nhien thu {i} : {result[i]}");
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
        static int TimMax(int[] arr)
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
        static int[] SapXepGiamDan(int[] arr)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }
        static bool TimSoGiongNhau(int[] arr)
        {
            bool result = false;
            int[] temp = new int[arr.Length];
            Array.Copy(arr, temp, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (temp[i] == temp[j] && i != j)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}