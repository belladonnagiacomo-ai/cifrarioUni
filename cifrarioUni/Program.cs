namespace cifrarioUni
{
    internal class Program
    {
        static void Cifrario(char[] alfabeto, string frase, string parola, string Alfabeto)
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
               if(j == parola.Length)
               {
                    j = 0;
               }
               Console.Write(array[i]);


            }
            int pos = 0;
            int pos2 = 0;
            int somma = 0;
            string s = "";
            for(int i = 0; i < f.Length; i++)
            {
                pos = Alfabeto.IndexOf(f[i]);
                pos2 = Alfabeto.IndexOf(array[i]);

                somma = pos + pos2;
                
                if(somma > 25)
                {
                    somma = somma - 25;
                }
                s += Alfabeto[somma]; 
               
            }
            Console.WriteLine(" ");
            Console.WriteLine("La parola cifrata e: " + s);
        }
        static void Main(string[] args)
        {
            string Alfabeto = "abcdefghijklmnopqrstuvwxyz";
            char[] alfabeto = Alfabeto.ToCharArray();
            Console.WriteLine("Dammi una frase ");
            string frase = Console.ReadLine();
            Console.WriteLine("Dammi una parola ");
            string parola = Console.ReadLine();
            Cifrario(alfabeto, frase, parola, Alfabeto);
        }
    }
}
