using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "My name is khan and i am not a terrorist";
            string CyphirText = EnryptString(Text);
            Console.WriteLine("CyphirText:" + CyphirText);
            string PlaintText= DecryptString(CyphirText);
            Console.WriteLine("PlaintText:" + PlaintText);
            Console.ReadLine();
        }

        public static string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
                
            }
            catch (FormatException fe)
            {
                decrypted = "";
            }
            return decrypted;
        }

        public static string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }  


    }


}
