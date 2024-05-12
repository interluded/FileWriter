using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            Console.WriteLine("Give me the full file path that you want to write: ");
            try
            {

                String path = Console.ReadLine();
                 
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                Console.WriteLine("This is the input of the text file");
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
                sr.Close();
                StreamWriter sw = new StreamWriter(path);
                Console.WriteLine("what do you want to write to this file? ");
                String content = Console.ReadLine();
                sw.WriteLine(content);
                sw.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
