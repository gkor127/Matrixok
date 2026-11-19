namespace ijaszverseny
{
    internal class Program
    {
        static int[,] jatekosokPontjai;
        static Random rnd = new Random();
        static string[] jatekosokNevei(int jatekosokSzama)
        {
            string[] nevek = {"Anna", "Bence", "Csilla", "Dániel", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit","Kata", "László", "Márk", "Nóra", "Olivér", "Péter", "Réka", "Sándor", "Tamás", "Zsófia", "Ádám", "Balázs", "Dóra", "Emese", "Gergő", "Levente", "Lili", "Máté", "Viktória", "Zoltán" };
            string[] jatekosok = new string[jatekosokSzama];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                int index = rnd.Next(0, jatekosokSzama);
                jatekosok[i] = nevek[index];
            }
            return jatekosok;
        }
         private static int[,] Feltolt(int jatekosokSzama)
        {
            int[,] matrix = new int[jatekosokSzama, 5];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(0, 25);
                }
            }
            
            return matrix;
        }
        static void Main(string[] args)
        {
            Console.Write("jatekosok szama: ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());
            jatekosokPontjai = Feltolt(jatekosokSzama);
            
            string[] jatekosok = jatekosokNevei(15);
            foreach (var item in jatekosok)
            {
                Console.WriteLine(item);
            }
            Console.Write($"Az első játékos: {jatekosok[0]} Pontjai:");
            
            for (int i = 0; i < jatekosokPontjai.GetLength(1); i++)
            {
                Console.Write($"{jatekosokPontjai[0, i],4}");
            }
            Console.WriteLine();
        }

       
    }
}
