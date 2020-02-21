using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "C# Programming"; // 14
            int l = subject.Length;
            string modified_subject = subject.ToLower();
            string modified_subject2 = subject.ToUpper();
            string modified_subject3 =  subject.Replace("C#","C++");
            Console.WriteLine(modified_subject3);


        }
    }
}
