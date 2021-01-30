using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDicktionary<int, string> myDic = new MyDicktionary<int, string>();
            myDic.Add(0, "#WeLoveBassNation");
            myDic.Add(1, "Foobar");
            myDic.Add(2, "How are you world?");
            Console.WriteLine("Index bound: " + myDic.Count + "\n\n");
            myDic.List();
        }
    }
}
