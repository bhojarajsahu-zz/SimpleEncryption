using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEncryption
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the 1 for Encryption and 2 for decryption: ");
                int option = Convert.ToInt32(Console.ReadLine());


                //Console.WriteLine(text);


                if (option == 1)
                {
                    Console.WriteLine("Please enter the text to encrypt: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("Please enter the key: ");
                    string key = Console.ReadLine();
                    string eText = EncryptionDecryption.Encryption.Encrypt(text, key);
                    Console.WriteLine(eText);
                    Clipboard.SetText(eText, TextDataFormat.Text);
                    Console.WriteLine("Output copied to clipboard.");
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Please enter the text to decrypt: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("Please enter the key: ");
                    string key = Console.ReadLine();
                    string dText = EncryptionDecryption.Decryption.Decrypt(text, key);
                    Console.WriteLine(dText);
                }
                else
                    Console.WriteLine("Please choose a correct option.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error occurred.");
            }
        }
    }
}
