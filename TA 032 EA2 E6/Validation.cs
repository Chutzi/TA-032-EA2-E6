using System;
using System.Text.RegularExpressions;

namespace TA_032_EA2_E6
{
    public class Validation
    {
        private string w = "hr";
        private string i = "1844441";
        private string winv = "rh";
        private string j = "jesus";
      
        public Validation() { }
        private void funcVoid(Regex reg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string cad, r;
            Regex regex = reg;

            do
            {
                Console.Write($"Cadenas utilizadas\nw = {w}\ni = {i}\nw' = {winv}\nj = {j}\n\n¡Bienvenido!\nIngrese la cadena a validar: ");
                cad = Console.ReadLine();
                if (regex.IsMatch(cad))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cadena valida\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cadena Invalida\n");
                }
                Console.ForegroundColor = ConsoleColor.White;
                while (true)
                {
                    Console.Write("Desea agregar mas cadenas? (s/n): ");
                    r = Console.ReadLine().ToLower();
                    if (r.Equals("s") || r.Equals("n"))                  
                        break;
                }
                Console.Clear();
            } while (r.Equals("s"));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("¡Que tenga un buen día!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public void Automatas2()
        {
            //0123456gc0123456cgcgyozedhyozedh
            //0123456gcgc0123456cgcgcgcgyozedhyozedh
            funcVoid(new Regex(@"^" + i + "(" + w + ")+" + i + "((" + winv + "){2})+(" + j + "){2}$"));
        }
    }
}
