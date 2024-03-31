using System.Collections;
using HTMT_02;

namespace HTMT_02
{
    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine("*********************  Menu ******************");
            Console.WriteLine("1. Biểu diễn dãy bit nhị phân của số nguyên N.");
            Console.WriteLine("2. Số nguyên N của dãy nhị phân A.");
            Console.WriteLine("3. Thoát");
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int KQ;
            int choice = 0;
            Menu();
            do
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int N;
                        N = Xulyheso.Nhap("Số nguyên N:");
                        Xulyheso.Bieudiensonguyenduoidangdaynhiphan(N);
                        Console.WriteLine();
                        break;

                    case 2:
                        int[] A;
                        A = Xulyheso.Nhapmang();
                        Console.WriteLine("Dãy nhị phân A: ");
                        Xulyheso.Xuatmang(A);
                        KQ = Xulyheso.Chuyensonhiphanthanhsonguyen(A);
                        Console.WriteLine($"Số nguyên X của dãy nhị phân  là: {KQ}");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Thoát");
                        return;
                } 
            } while (choice != 3);
        }
    }
}
