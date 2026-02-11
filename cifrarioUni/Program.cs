namespace cifrarioUni
{
    internal class Program
    {
        static void Cifrario(char[] alfabeto, string frase, string parola)
        {
            string[] fraseSenzaSpazi;

            fraseSenzaSpazi = frase.Split(' ');

            string fraseS = string.Join("",fraseSenzaSpazi);

            fraseS = fraseS.ToLower();  

            char[] p = parola.ToCharArray();

            char[] array = new char[fraseS.Length];

            char[] f = fraseS.ToCharArray();

            int j = 0;

            Console.WriteLine(fraseS);
            for(int i = 0;  i < array.Length; i++)
            {
                array[i] = parola[j];
                j++;
               if(j == p.Length)
               {
                    j = 0;
               }
               Console.Write(array[i]);


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
