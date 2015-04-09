using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacophony
{
    public class Noises
    {
        static void Main(string[] args)
        {
            int note = PositionToFreq(40);
            int pos = NameToPosition("C1");
            Console.WriteLine(pos);
            Console.ReadLine();
        }

        /// <summary>
        /// Static funtion for converting note position to frequency to pass to the internal beeper.
        /// </summary>
        /// <param name="pos">Note position on a piano</param>
        /// <returns>Frequency in Hertz</returns>
        public static int PositionToFreq(int pos)
        {
            return (int) Math.Floor(Math.Pow(2, (float)(pos - 49) / 12) * 440);
        }

        /// <summary>
        /// Function for converting conventional note name to position to pass to the PositionToFreq() function.
        /// </summary>
        /// <param name="name">Note name</param>
        /// <returns>Position on a piano</returns>
        public static int NameToPosition(String name)
        {
            int pos = 0;
            char[] n = name.ToUpper().ToCharArray();
            char val = n[0];
            // if 1-3
            
            // if 4+
            switch(val)
            {
                case 'C':
                    pos = 1;
                    break;
                case 'D':
                    pos = 3;
                    break;
                case 'E':
                    pos = 4;
                    break;
                case 'F':
                    pos = 4;
                    break;
                case 'G':
                    pos = 5;
                    break;
                case 'A':
                    pos = 6;
                    break;
                case 'B':
                    pos = 7;
                    break;
            }

            return pos;
        }

        private int octaveIncrementer(char c)
        {
            //if 
            return 0;
        }
    }
}
