using System;

namespace Otus_HW4.IO
{
    public class DataConsole : IDataConsole
    {
        public int Read()
        {
            return int.Parse(Console.ReadLine());
        }
       
        public void Write(string text) => Console.WriteLine(text);

        public void Clear()
        {
            Console.Clear();
        }

        public void NextLine()
        {
            Console.WriteLine("\r\n");
        }

    }
}
