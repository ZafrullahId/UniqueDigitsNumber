using System;
using System.Collections.Generic;

namespace Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(UniqueDigitsCount(3));
        }

        public static int UniqueDigitsCount(int number)
        {
            double x = Math.Pow(10, number);
            List<string> list = new List<string>();
            for (int t = 0; t < x; t++)
            {
                string a = t.ToString();
                list.Add(a);

            }
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                 bool isUnique = true;
                if (list[i].Length == 1)
                {
                    count++;
                }
                else if (list[i].Length == 2)
                {
                    char[] a = list[i].ToCharArray();
                    for (int j = 0; j < a.Length-1; j++)
                    {
                        for (int z = 1; z < a.Length; z++)
                        {
                            if (a[j] == a[z])
                            {
                               isUnique = false;
                               break;
                            }
                            
                        }
                        if(isUnique == false)
                        {
                            break;
                        }
                    }
                    if(isUnique == true)
                    {
                        count++;
                    }
                }
                else if (list[i].Length > 2)
                {
                    char[] a = list[i].ToCharArray();
                    for (int j = 0; j < a.Length-1; j++)
                    {
                        for (int z = j+1; z < a.Length; z++)
                        {
                            if (a[j] == a[z])
                            {
                               isUnique = false;
                               break;
                            }
                            
                        }
                        if(isUnique == false)
                        {
                            break;
                        }
                    }
                    if(isUnique == true)
                    {
                        count++;
                    }
                }
               
            }
            return count;
        }
    }
}
