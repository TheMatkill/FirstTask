using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var people = new Dictionary<string, string>()
            {
                ["Bethoven"] = "Symphony",
                ["Mozart"] = "Sonata",
                ["Bach"] = "Concerto",
                ["Chopin"] = "Opera",
                ["Vivaldi"] = "Piano Concerto",
                ["Haydn"] = "String Quartet",
                ["Tchaikovsky"] = "Piano Concerto",
                ["Handel"] = "Mass",
                ["Brahms"] = "Requiem",
                ["Verdi"] = "Suite"




            };

            var auth_key = Console.ReadLine();
            var res = people.TryGetValue(auth_key, out var result);
            if (res == true)
            {
                Console.WriteLine(people[auth_key]);
                res = people.Remove(auth_key);
                if (res == true) 
                    Console.WriteLine("Успешно удалено");
                foreach (var ppl in people)
                    Console.WriteLine($"{ppl.Key}:{ppl.Value}");
                people.Clear();
                Console.WriteLine("Весь словарь очищен");

            }
            else
            {
                Console.WriteLine("Данный ключ не найден в словаре");
            }

            



        }
    }
}
