using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int,string> cities = new MyDictionary<int,string>();


            cities.Add(68, "Aksaray");
            cities.Add(70, "Karaman");
            cities.Add(26, "Eskişehir");
            cities.Show();

        }
    }
}
