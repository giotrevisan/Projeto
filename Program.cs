namespace Projeto
{
    internal class Program
    {
        private static void BelongsInFibonacci(int num)
        {
            Console.Write("0 1");
            int first = 0;
            int second = 1;
            while (second < num)
            {
                int aux = first + second;
                first = second;
                second = aux;
                Console.Write($" {second}");
            }

            Console.WriteLine($"\nPresente: {(num == first || num == second ? "Sim" : "Não")}");
        }

        private static void VerifyString(string val)
        {
            int count = 0;
            char[] chars = { 'a', 'A' };
            int index = val.IndexOfAny(chars);
            while (index != -1)
            {
                count++;
                index = val.IndexOfAny(chars, index + 1);
            }

            Console.WriteLine($"A palavra {val} {(count == 0 ? "não possui" : $"possui {count}")} letra(s) 'A'");
        }

        static void Main(string[] args)
        {
            BelongsInFibonacci(37);
            BelongsInFibonacci(55);
            BelongsInFibonacci(126);

            VerifyString("Entremeios");
            VerifyString("tetrAbrometacresolsulfonoftaleínA");
        }
    }
}
