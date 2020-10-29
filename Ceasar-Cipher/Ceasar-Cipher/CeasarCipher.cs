using System;

namespace CeasarCipherNS
{
    public class CeasarCipher
    {


        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                char d = '0';
                
                return (char)((((ch + key) - d) % 10) + d);
            }
            else
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';

                return (char)((((ch + key) - d) % 26) + d);
            }


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch) || char.IsLetter(ch))
                {
                    output += cipher(ch, key);
                }
                else output += ch;
            }
            return output;
        }

        public static string Decipher(string input, int key)
        {

            string output = string.Empty;

            foreach (char ch in input)
            {

                if (char.IsDigit(ch))
                {
                    output += cipher(ch, 10 - (key% 10));
                }
                else if (char.IsLetter(ch))
                {
                    output += cipher(ch,26 - (key % 26));
                }
                else output += ch;
            }

            return output;
            
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n");
            

            Console.WriteLine("Encrypted Data");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            Console.Write("Press  to exit");

            Console.ReadKey();    
        }
    }
}
