using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            _List list = new _List();
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
