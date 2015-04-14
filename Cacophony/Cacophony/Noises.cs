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
            
            int pos = NameToPosition("A1");
            Console.WriteLine("Position: " + pos);
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
            
            // we assume the notes are coming in the correct format - [note, acc, octive] or [note, octive]
            char note = n[0]; // note value
            char acc = '\0'; // accidental - remember that chars are non nullable
            int octave = 0; // octive value
            if (Char.IsNumber(n[1])){ // if the second char is a number
                octave = (int)Char.GetNumericValue(n[1]);
            }
            else{
                acc = n[1];
                octave = (int)Char.GetNumericValue(n[2]);
            }

            switch(note)
            {
                case 'C':
                    pos = 4;
                    if(octave != 1) { // if the next character in the note name array is an integer
                        Console.WriteLine(octave);
                        pos = octaveIncrementer(pos, octave);
                    }

                    break;
                case 'D':
                    pos = 6;
                    if(octave != 1) {
                        pos = octaveIncrementer(pos, octave);
                    }
                    break;
                case 'E':
                    pos = 8;
                    if(octave != 1) {
                        pos = octaveIncrementer(pos, octave);
                    }
                    break;
                case 'F':
                    pos = 9;
                    if(octave != 1) {
                        pos = octaveIncrementer(pos, octave);
                    }
                    break;
                case 'G':
                    pos = 11;
                    if(octave != 1) {
                        pos = octaveIncrementer(pos, octave);
                    }
                    break;
                case 'A':
                    pos = 1;
                    if(octave != 0) { // A0 = 1
                        pos = pos + (octave * 13) - octave;     
                    }
                    break;
                case 'B':
                    pos = 3;
                    if(octave != 0) {
                        pos = pos + (octave * 13) - octave;
                    }
                    break;
            }
            return pos;
        }

        static private int octaveIncrementer(int position, int oct)
        {
            Console.WriteLine("pos and oct: " + position + " , " + oct);
            position = position + ((oct-1) * 13) - oct;
            Console.WriteLine("function returns: " + position);
            return position;
        }

        static private int accidentalIncrementer(int position, char acc)
        {
            
            return position;
        }
    }
}
