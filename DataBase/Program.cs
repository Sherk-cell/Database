using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Program
    {
        static void Main()
        {
            give actuallinv = new give();


            actuallinv.Give(new Inv("Sword", "Full", "5", "Basic sword nothing special "));
            actuallinv.Give(new Inv("Spear", "Full", "10", "Basic Spear for basic tasks"));
            actuallinv.Give(new Inv("Axe", "Half", "20", "Basic Axe for chopping wood"));

            while (true)
            {
                string Find;
                Console.WriteLine("\nType de item in je inventory om de stats tezien (HoofdLetter gevoelig)");
                Find = Console.ReadLine();
                Console.WriteLine("\n");

                foreach (Inv i in actuallinv.GetInvs())
                {
                    if (Find == i.GetItem())
                    {
                        Console.WriteLine("Item:" + i.GetItem() + "\n" + "Durabillity: "  + i.GetDura() + "\n" + "Damage: " + i.GetDamage() + "\n" + i.Getdesc());
                    }
                    
                }
            }
        }
    }
}