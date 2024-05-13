using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloK3
{
    class ClassDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> typeDictionary = new Dictionary<int, string>();
            typeDictionary.Add(1, "Tuan");
            typeDictionary.Add(2, "Huy");
            typeDictionary.Add(3, "Hung");
            Console.WriteLine(typeDictionary.Count);
            foreach (var item in typeDictionary)
            {
                Console.WriteLine("{0},{1}", item.Key, item.Value);
            }

            if (typeDictionary.ContainsKey(3))
            {
                string value = typeDictionary[3];
                Console.WriteLine(value);
                bool check = typeDictionary.Remove(3);
            }
            else
            {
                Console.WriteLine("No");
            }

            if (typeDictionary.ContainsValue("Tuan"))
            {

            }
            Console.WriteLine("___________________________________");
            foreach (var item in typeDictionary)
            {
                Console.WriteLine("{0},{1}", item.Key, item.Value);
            }
            typeDictionary.Clear();
            Console.WriteLine("___________________________________");
            foreach (var item in typeDictionary)
            {
                Console.WriteLine("{0},{1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
