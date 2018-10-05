using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseForEx2
{
    class Program
    {
        static void Main(string[] args)
        {
                string str = Console.ReadLine();
                const string a_lett = "Aa";
                int cnt = 0;
                for (int i = 0; i < str.Length; i++)
                    for (int j = 0; j < a_lett.Length; j++)     //на случай, если введена заглавная
                        if (str[i] == a_lett[j])
                            ++cnt;
                Console.Write(cnt);
                Console.ReadLine();
            
        }
    }
}
