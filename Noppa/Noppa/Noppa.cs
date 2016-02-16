using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Noppa
    {
        Random rnd = new Random();


        public void Heitto(int heitot)
        {
            int[] kuntti = new int[7];
            foreach (int k in kuntti)
            {
                kuntti[k] = 0;
            }
            int value;
            double ka = 0;
            Console.WriteLine("Dice is now thrown {0} times", heitot);
            for (int i = 0;i <= heitot; i++)
            {
                value = rnd.Next(1, 7);

                ka = ka + value;
                switch (value)
                {
                    case 1:
                        kuntti[1] = kuntti[1] + 1;
                        break;
                    case 2:
                        kuntti[2] = kuntti[2] + 1;
                        break;
                    case 3:
                        kuntti[3] = kuntti[3] + 1;
                        break;
                    case 4:
                        kuntti[4] = kuntti[4] + 1;
                        break;
                    case 5:
                        kuntti[5] = kuntti[5] + 1;
                        break;
                    case 6:
                        kuntti[6] = kuntti[6] + 1;
                        break;

                }

                
            }
            ka = ka / heitot;
            Console.WriteLine("Average is {0}", ka);
            for(int i = 1; i <= 6; i++)
            {
                Console.WriteLine(i + " count is {0}", kuntti[i]);
            }
        }
    }
}
