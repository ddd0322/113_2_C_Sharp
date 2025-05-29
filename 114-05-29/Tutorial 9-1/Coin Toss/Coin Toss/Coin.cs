using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class Coin
    {
        private string sideUp;
        Random rand = new Random();

        public Coin()
        {
            sideUp = "正面"; // Default side is Heads
        }

        public void Toss()
        {
            // Randomly set the sideUp to either "正面" (Heads) or "反面" (Tails)
            if (rand.Next(2) == 0)
            {
                sideUp = "正面"; // Heads
            }
            else
            {
                sideUp = "反面"; // Tails
            }
        }
        public string GetSideUp()
        {
            return sideUp;
        }

    }
}
