using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsOrSomething
{
    internal class Program
    {

        struct Peoples
        {
            public int health;
            public int damage;
            public bool isCool;
            public string name;

            public void Display()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("health: " + health);
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Cool? " + isCool);
            }
        }


        static void Main(string[] args)
        {
            Peoples Chad;
            Chad.health = 100;
            Chad.damage = 5;
            Chad.isCool = true;
            Chad.name = "Chad";

            Peoples Beta;
            Beta.health = 1;
            Beta.damage = 9001;
            Beta.isCool = false;
            Beta.name = "John";

            Console.WriteLine("Structs are Cool,\nand Heres why");
            Console.WriteLine();
            Chad.Display();
            Console.WriteLine("");
            Beta.Display();
            Console.WriteLine("");
            Console.WriteLine(Beta.health);
            Console.WriteLine("");
            Console.WriteLine(Chad.name);
            Console.ReadKey(true);
        }
    }
}
