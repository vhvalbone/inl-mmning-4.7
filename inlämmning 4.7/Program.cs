using System;
namespace inlämmning_4._7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord");
            string text = Console.ReadLine();
            Console.WriteLine("Skriv in exakt två tecken");
            string tecken = Console.ReadLine();

            bool finnsTecken1 = false;
            bool finnsTecken2 = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == tecken[0])
                {
                    finnsTecken1 = true;
                }
                if (text[i] == tecken[1])
                {
                    finnsTecken2 = true;
                }
            }

            if (finnsTecken1 && finnsTecken2)
            {
                Console.WriteLine("Båda tecknen finns i den första strängen");
            }
            else
            {
                Console.WriteLine("Minst ett av tecknen finns inte i den första strängen");
            }
        }
    }
}
