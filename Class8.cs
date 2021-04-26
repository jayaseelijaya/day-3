using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Class8
    {
        static void Main(string[] args)
        {
            
                string str1 = "My name is Vikash Verma";
                char ch;
                

                for (int i = 0; i < str1.Length; i++)
                {
                    //Checks for lower case character  
                    if (char.IsLower(str1[i]))
                    {
                        //Convert it into upper case using ToUpper() function  
                        ch = Char.ToUpper(str1[i]);
                        //Append that character to new character  
                        str2.Append(ch);
                    }
                    //Checks for lower case character  
                    else if (char.IsUpper(str1[i]))
                    {
                        //Convert it into lower case using ToLower() function  
                        ch = Char.ToLower(str1[i]);
                        //Append that character to new character  
                        str2.Append(ch);
                    }
                    else
                    {
                        ch = str1[i];
                        str2.Append(ch);
                    }
                }
                Console.WriteLine("String after case conversion : " + str2);
            Console.ReadLine();
            }
        }
    }
    
