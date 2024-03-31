using System;
using System.Collections;

namespace HTMT_02
{
	public class Xulyheso
	{
        public static int[] Nhapmang()
        {
            int[] a = new int[32];
            Console.WriteLine("Nhập dãy nhị phân A của số nguyên : ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        public static int Nhap(string Ghichu)
        {
            Console.Write(Ghichu);
            int a = int.Parse(Console.ReadLine());
            return a;
        }

        public static void Xuatmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }


        public static void InBit(BitArray A, string X="")
        {
            int i = 0;
            Console.Write("{0}\t", X);
            foreach (bool Item in A)
            {
                i++;
                if (Item)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (i % 4 == 0)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void Bieudiensonguyenduoidangdaynhiphan(int N)
        {
            int[] a = { 2, 3 };
            BitArray A1 = new BitArray(32);
            A1 = new BitArray(a);
            int size = A1.Count;
            for (int i = 0; i < size / 2; i++)
            {
                bool m = A1[i];
                A1[i] = A1[size - i - 1];
                A1[size - i - 1] = m;
            }
            Console.WriteLine("Dãy nhị phân của số nguyên N: ");
            InBit(A1);
        }


        public static int Chuyensonhiphanthanhsonguyen(int[] a)
        {
            double T = 1;
            double K = 1;
            int kq = 0;
            int n = a.Length;
            if (a[0] == 1)
            {
                K = -1 * a[0] * Math.Pow(2, 31);
            }
            if (a[0] == 0)
            {
                K = a[0] * Math.Pow(2, 31);
            }
            for (int i = 1; i < n; i++)
            {
                T = a[i] * Math.Pow(2, n - i - 1);
                kq = (int)(kq + T);
            }
            kq = (int)(kq + K);
            return kq;
        }
    }
}

