using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();

        public int Score { get; set; }
        public bool DoubleRing { get; set; }
        public bool TripleRing { get; set; }
        public bool OuterBullseye { get; set; }
        public bool InnerBullseye { get; set; }

        public void Throw()
        {
            Score = random.Next(0, 21); //number to begin and number to end at, NOT INCLUSIVE; this is why 21, not 20.


            //5% chance of double ring shot and 5% chance of triple ring shot
            if (Score > 0)
            {
                int ringShot = random.Next(1, 101);

                if (ringShot < 6) DoubleRing = true;
                if (ringShot > 95) TripleRing = true;
            }
            
            //bullseye:
            if (Score == 0)
            {
                int bullseye = random.Next(1, 101);
                if (bullseye > 95)
                {
                    InnerBullseye = true;
                }
                else
                {
                    OuterBullseye = true;
                }
            }
        }
    }
}
