using System;

namespace Database
{
    public class Inv
    {
        public string item { get; private set; }
        public string Durability { get; private set; }
        public string Damage { get; private set; }
        
        public string description { get; private set; }

        public Inv(string aItem, string aDurability, string aDamage, string Adescription)
        {
            item = aItem;
            Durability = aDurability;
            Damage = aDamage;
            description = Adescription;
        }
        public string GetItem()
        {
            return item;
        }
        public string GetDura()
        {
            return Durability;
        }
        public string GetDamage()
        {
            return Damage;
        }
        public string Getdesc()
        {
            return description;
        }
    }
}