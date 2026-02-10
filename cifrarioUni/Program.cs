namespace cifrarioUni
{
    internal class Program
    {
        static void Cifrario(char[] alfabeto, string frase, string parola)
        {
            string[] fraseSenzaSpazi;
            fraseSenzaSpazi = frase.Split(' ');
            string fraseS = string.Join(' ');
            char[] f = frase.ToCharArray();
            char[] p = parola.ToCharArray();
            for(int i = 0;  i < f.Length; i++)
            {
               for(int j = 0; j < p.Length; j++)
               {
                    
               }
            }
        }
        static void Main(string[] args)
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Dammi una frase ");
            string frase = Console.ReadLine();
            Console.WriteLine("Dammi una parola ");
            string parola = Console.ReadLine();
            Cifrario(alfabeto, frase, parola);
        }
    }
}
