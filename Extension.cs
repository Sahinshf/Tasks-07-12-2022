using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_07_12_2022
{
    internal static class Extension
    {

        public static void customContains(this string mySentence, string str)
        {
            int i = 0;
            int t = 0;
            int k;
            for (k = 0; k < mySentence.Length; k++)
            {
                if (t == str.Length) // Bu şərt ödəndikdə cümlə daxil edilən yazını özündə saxlamış olur
                {
                    break;
                }

                if (str[i] == char.ToLower(mySentence[k]) || str[i] == char.ToUpper(mySentence[k])) //Şərti yoxlamaq üçün
                {
                    i++;
                    t++;

                }
                else
                {
                    if (str[0] == mySentence[k]) //Çünki yoxlayanda belə ola bilirdi ki yoxladığığımız string axtardığımız sözün n`ninci həddini ödəməsin amma ilk həddini ödəsəin 
                    {                            // Məsələn sentence:shahishahin axtardığımız söz: shahin olduğu zaman bu if kömək edir. Bu olmasa cavabı false verəcəkdi. 
                        k--;                        
                    }

                    i = 0;
                    t = 0;
                }
            }

            if (t == str.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
