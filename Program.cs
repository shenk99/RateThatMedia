using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace social
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int index = 0;
            for (int x = 1; x <= 5; x++)
            {
                int sum = 0;
                string temp = "0";
                foreach (string s in Console.ReadLine().Split(' '))
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        char ch = s[i];
                        temp += ch;
                        sum += int.Parse(temp);
                        temp = "0";
                    }
                }



                if (sum > max)
                {
                    max = sum + int.Parse(temp);
                    index = x;
                }

            }
            Console.WriteLine(index + " " + max);
            Console.ReadLine();
        }
    }
}
