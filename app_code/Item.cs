using System;

namespace AutoTune
{
    class Item
    {
        const System.Int32 MAX_DURABILITY = 100;
        const System.Int32 MIN_DURABILITY = 1;
        const System.Int32 TUNE_COST = 33;

        public int Level { get; set; } = 1;
        public int Durability { get; set; } = MAX_DURABILITY;        
        public bool Status { get; set; } = true;

        public void TuneFailed()
        {
            if (Durability < 34)
            {
                throw new Exception("This item cannot be tune");
            }

            Durability -= TUNE_COST;

            if (Durability == 1)
            {
                Status = false;
            }
        }

        public void TuneSuccess()
        {
            Durability = MAX_DURABILITY; ;
            Level++;
        }

        public string GetString()
        {
            return "Level : " + Level + ", Durability : " + Durability + ", " + "Status : " + Status;
        }
    }
}
