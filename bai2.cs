using System.Reflection;

namespace bai2
{
    internal class bai2
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = NhapMang();
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
        }
        static int[] NhapMang()
        {
            int[] result = new int[0];
            string nhapSo;
            int i = -1;
            int soPhanTuNhapVao;
            do
            {
                do
                {
                    Console.Write($"Nhap so phan tu thu {i + 1}:");
                    nhapSo = Console.ReadLine();
                } while (!int.TryParse(nhapSo, out soPhanTuNhapVao));
                if (soPhanTuNhapVao != -1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    i++;
                    result[result.Length - 1] = soPhanTuNhapVao;
                }
                else
                {
                    break;
                }
            } while (true);
            return result;
        }

    }
}
