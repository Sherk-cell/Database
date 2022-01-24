using System;
using System.Collections.Generic;

namespace Database
{
    class give
    {
        public List<Inv> Giving;

        public give()
        {
            Giving = new List<Inv>();
        }

        public void Give (Inv aGive)
        {
            Giving.Add(aGive);
        }
        public List<Inv> GetInvs()
        {
            return Giving;
        }
    }
}
