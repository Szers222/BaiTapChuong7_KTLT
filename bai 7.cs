namespace bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            string nhap;
            int num;
            int[] xoaSoPhanTu;
            int nhapX;
            int[] themSoNguyenTo;
            do
            {
                Console.WriteLine("Nhap do dai mang:");
                nhap = Console.ReadLine();
            } while (!int.TryParse(nhap, out num));

            arr = NhapMang(num);

            Console.WriteLine("Mang duoc xuat ra la: ");
            InRaManHinh(arr);

            nhapX = NhapX();
            xoaSoPhanTu = XoaSoPhanTuX(arr, nhapX);
            Console.WriteLine("Xoa so phan tu X trong mang: ");
            InRaManHinh(xoaSoPhanTu);

            themSoNguyenTo = ThemSoXVaoSoNguyenToDauTien(arr, nhapX);
            Console.WriteLine("\nMang duoc them vao:");
            InRaManHinh(themSoNguyenTo);

        }
        static int[] NhapMang(int arrLength)
        {
            int[] result = new int[arrLength];
            string nhap;

            for (int i = 0; i < arrLength; i++)
            {
                do
                {
                    Console.Write($"Nhap phan tu thu {i}: ");
                    nhap = Console.ReadLine();
                } while (!int.TryParse(nhap, out result[i]));
            }
            return result;
        }
        static void InRaManHinh(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
        }
        static int NhapX()
        {
            int result;
            string nhap;
            do
            {
                Console.WriteLine("\nNhap X:");
                nhap = Console.ReadLine();
            } while (!int.TryParse(nhap, out result));
            return result;
        }
        static int[] XoaSoPhanTuX(int[] arr, int num)
        {
            int[] result = new int[0];
            foreach (int item in arr)
            {
                if (item == num)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = item;
                }
            }
            return result;
        }
        static bool KiemTraSoNguyenTo(int num)
        {
            bool result = num>1;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }
        static int[] ThemSoXVaoSoNguyenToDauTien(int[] arr, int num)
        {
            int[] result = new int[0];
            bool isFirst = true;

            foreach (int item in arr)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = item;
                if (KiemTraSoNguyenTo(item) && isFirst == true)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = num;
                    isFirst = false;
                }
            }
            return result;
        }

    }
}