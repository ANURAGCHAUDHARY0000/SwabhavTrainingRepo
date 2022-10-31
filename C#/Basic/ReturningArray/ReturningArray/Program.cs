using System;
namespace ReturningArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
                for (int i = 0; i < GetNames().Length; i++)
                {
                    Console.WriteLine(GetNames()[i]);
                }
        }

            static string[] GetNames()
            {
                string[] ret = { "I", "Love", "Krishna"};
                return ret;
            }
             
        }
    }

