namespace Matrixok
{
    internal class Program
    {
        static int oszlopokSzama = 6;
        static int sorokSzama = 10;
        static int[,] szamokMatrix = new int[sorokSzama,oszlopokSzama];
        static Random rnd = new Random();

        static void F01()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    szamokMatrix[i, j] = rnd.Next(10, 100);
                }
            }

        }

        static void F02()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Console.Write(szamokMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
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
        }
        static void Main(string[] args)
        {
           F01();
           F02();
           F03();
           F04();

        }
    }
}
