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
            Console.Beep(note, 500);
            System.Threading.Thread.Sleep(5000);
        }

        public static int PositionToFreq(int pos)
        {
            return (int) Math.Floor(Math.Pow(2, (float)(pos - 49) / 12) * 440);
        }
    }
}
