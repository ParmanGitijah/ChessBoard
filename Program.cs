namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            // Jag får input av användaren som ska vara ett tal och döper den till number
            Console.WriteLine("Skriv in en siffra: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Frågar om svarta rutor. Använder dynamic för att möjliggöra för användaren att skriva tal & sträng
            Console.WriteLine("Hur ska svarta rutor se ut? ");
            dynamic blackBox = Console.ReadLine();

            // Frågar om vita rutor. Använder dynamic för att möjliggöra för användaren att skriva tal & sträng
            Console.WriteLine("Hur ska vita rutor se ut? ");
            dynamic whiteBox = Console.ReadLine();

            // Skriver två forloops för att möjliggöra raderna. Använder i och j. 
            for (int j = 0; j < number; j++)
            {
                for (int i = 0; i < number; i++)
                {
                    // använder modulos för att se om raden ska börja med whiteBox eller blackBox!
                    if ((j+i) % 2 == 0)
                    {
                        Console.Write(blackBox + " ");
                    }
                    else
                    {
                        Console.Write(whiteBox + " ");
                    }
                }
                // efter varje rad hjälper writeLine mig att börja på ny rad.
                Console.WriteLine();
            }
            // Koden väntar på intryck av användaren innan den avslutar. 
            Console.ReadLine()
        }
    }
}
