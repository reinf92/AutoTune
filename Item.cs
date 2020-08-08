using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTune
{
    class Item
    {
        const int MAX_DURABILITE = 100;
        const int COST = 33;

        public int Durability { get; set; } = MAX_DURABILITE;
        public int Level { get; set; } = 1;

        public void DownDurability()
        {
            if (Durability < 34)
            {
                throw new Exception("This item cannot be tune");
            }

            Durability = Durability - COST;
        }

        public void SucceedTune()
        {
            Durability = MAX_DURABILITE; ;
            Level++;
        }
    }
}
