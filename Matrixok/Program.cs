namespace Matrixok
{
    internal class Program
    {
        static int oszlopokSzama = 6;
        static int sorokSzama = 10;
        static int[,] szamokMatrix = new int[sorokSzama,oszlopokSzama];
        static Random rnd = new Random();
        static int[,] negyzetesMatrix = new int[10,10];

        static void F01(int[,]matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(min, max+1);
                }
            }

        }

        static void F02(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void F03()
        {
            int ossz = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A mátrixban lévő elemek összege: {ossz}");
            Console.WriteLine();
        }

        static void F04()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                int ossz = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"{i+1}. sor összege: {ossz}");
            }
            Console.WriteLine();
        }

        static void F05()
        {
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int ossz = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"{j+1}. oszlop összege: {ossz}");
            }
            Console.WriteLine();
        }

        static void BalAtlotoOsszeg(int[,]matrix)
        {
            int ossz = 0;
            Console.Write("Az atlo:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i,i],5}");
                ossz += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A matrix bal atlojanak oszege: {ossz}");
        }
        static void JobbAtloOsszege(int[,]matrix)
        {
            int ossz = 0;
            Console.Write("Az atlo:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, matrix.GetLength(1)-1-i],5}");
                ossz += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A matrix jobb atlojanak oszege: {ossz}");
        }
        static void Main(string[] args)
        {
           F01(szamokMatrix, 10, 99);
           F02(szamokMatrix);
           F03();
           F04();
           F05();
           Console.WriteLine("--------------------------------------------------------------");
           Console.WriteLine();
           F01(negyzetesMatrix,1,9);
           F02(negyzetesMatrix);
           BalAtlotoOsszeg(negyzetesMatrix);
           JobbAtloOsszege(negyzetesMatrix);

            int[,] masolat = negyzetesMatrix;
            masolat[0,0] = 100;

            Console.WriteLine("A masolat elemei:");
            F02(masolat);
            
            Console.WriteLine("A negyzetesMatrix elemei:");
            F02(negyzetesMatrix);

        }
    }
}
