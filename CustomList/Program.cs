using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            _List list = new _List();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(12);
            list.Add(31);
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
