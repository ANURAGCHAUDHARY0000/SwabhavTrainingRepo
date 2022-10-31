using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    static class StringExtension
    {
        // this method belong to string class 
        public static string Foo(this string input)
        {
            return " Foo says Hello to " + input ;
        }

        public static string ToSnakeCase(this string input)
        {
            int n = input.Length;
            string str1 = "";

            for (int i = 0; i < n; i++)
            {
                
                if (input[i] == ' ')
                    str1 = str1 + '_';
                else
                    str1 = str1 +
                           Char.ToLower(input[i]);
            }
            return str1;
        }

    }
}
