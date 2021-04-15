using System;

namespace MyDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> student = new MyDictionary<int,string>();

            student.Add(152, "Yaren Çelik");
            student.Add(153, "Kerem Kara");
            student.Add(154, "Özlem Duru");

            student.ToList();
        }
    }
}
