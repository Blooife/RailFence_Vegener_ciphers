using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Ti
{
    static class Program
    {
        public class RailFence
       {
           public string text;
           public int len, n;
           public int[] trLen;
           public string[] strArray;
           public RailFence(string input, int rows)
           {
              // text = input.ToLower();
             //  text = Regex.Replace(text, "[^a-zA-Z]", "");
               text = input;
               len = text.Length;
               if (rows > len)
               {
                   n = len;
               }
               else
               {
                   n = rows;  
               }
           }

           public int[] CountTrLen()
           {
               int i;
               int[] trackLen = new int [n];
               int rem, period = 2 * (n - 1), row;
               for (i = 0; i < len; i++)
               {
                   try
                   {
                       rem = i % period;
                   }
                   catch
                   {
                       rem = 0;
                   }
                   row = n - 1 - Math.Abs(n - 1 - rem);
                   trackLen[row] += 1;
               }
               return trackLen;
           }
           public string[] MakeStrArray ()
           {
               int i;
               var cipherStr = new string[n];
               int rem, period = 2 * (n - 1), row;
               for (i = 0; i < len; i++)
               {
                   try
                   {
                       rem = i % period;
                   }
                   catch
                   {
                       rem = 0;
                   }
                   row = n - 1 - Math.Abs(n - 1 - rem);
                   cipherStr[row] += text[i];
               }
               return cipherStr;
           }

           public string Encode()
           {
               return strArray.Aggregate("", (x, y) => x + y);
           }

           public string Decode()
           {
               string[] strArr = new string[trLen.Length];
               string t = text;
               int ind = 0;
               for (int i = 0; i < trLen.Length; i++)
               {
                   strArr[ind] = t.Substring(0, trLen[i]);
                   t = t.Remove(0, trLen[i]);
                   ind++;
               }
               
               var decodeStr = string.Empty;
               int rem, period = 2 * (n - 1), row;
               for (int i = 0; i < len; i++)
               {
                   try {
                       rem = i % period;
                   }
                   catch {
                       rem = 0;
                   }
                   row = n - 1 - Math.Abs(n - 1 - rem);
                   decodeStr += char.ToString(strArr[row].First());
                   strArr[row] = strArr[row].Remove(0, 1);
               }
               return decodeStr;
           }
       }
      public class Vigenere
      {
                     public string text , key;
                     public int len;
                     public string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
      
                     public Vigenere(string t, string k)
                     {
                         text = t;
                         this.len = text.Length;
                         this.key = GetKey(k, this.len);
                     }
      
                     public string GetKey(string k, int l)
                     {
                         while (k.Length < l)
                         {
                             k += k;
                         }
      
                         return k.Substring(0, l);
                     }
      
                     public string VigCipher(string text, string key, int encr)
                     {
                         string res = string.Empty;
                         int n = alph.Length;
                         for (int i = 0; i < text.Length; i++)
                         {
                             var letterIndex = alph.IndexOf(text[i]);
                             var codeIndex = alph.IndexOf(key[i]);
                             res += alph[(n + letterIndex + (encr * codeIndex)) % n].ToString();
                             
                         }
                         return res;
                     }
      
                     public string Encode(string text, string key)
                     {
                         return VigCipher(text, key, 1);
                     }
      
                     public string Decode(string text, string key)
                     {
                         return VigCipher(text, key, -1);
                     }
      }  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}