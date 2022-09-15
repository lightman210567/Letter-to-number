using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightman210567.LetterToNumber
{
    public class LetterConverter
    {
        public static int LetterConvert(char LetterToConvert)
        {
            int ConvertedLetter;

            LetterToConvert = Char.ToLower(LetterToConvert);

            switch (LetterToConvert)
            {
                case 'a':
                    ConvertedLetter = 1;
                    break;
                case 'b':
                    ConvertedLetter = 2;
                    break;
                case 'c':
                    ConvertedLetter = 3;
                    break;
                case 'd':
                    ConvertedLetter = 4;
                    break;
                case 'e':
                    ConvertedLetter = 5;
                    break;
                case 'f':
                    ConvertedLetter = 6;
                    break;
                case 'g':
                    ConvertedLetter = 7;
                    break;
                case 'h':
                    ConvertedLetter = 8;
                    break;
                case 'i':
                    ConvertedLetter = 9;
                    break;
                case 'j':
                    ConvertedLetter = 10;
                    break;
                case 'k':
                    ConvertedLetter = 11;
                    break;
                case 'l':
                    ConvertedLetter = 12;
                    break;
                case 'm':
                    ConvertedLetter = 13;
                    break;
                case 'n':
                    ConvertedLetter = 14;
                    break;
                case 'o':
                    ConvertedLetter = 15;
                    break;
                case 'p':
                    ConvertedLetter = 16;
                    break;
                case 'q':
                    ConvertedLetter = 17;
                    break;
                case 'r':
                    ConvertedLetter = 18;
                    break;
                case 's':
                    ConvertedLetter = 19;
                    break;
                case 't':
                    ConvertedLetter = 20;
                    break;
                case 'u':
                    ConvertedLetter = 21;
                    break;
                case 'v':
                    ConvertedLetter = 22;
                    break;
                case 'w':
                    ConvertedLetter = 23;
                    break;
                case 'x':
                    ConvertedLetter = 24;
                    break;
                case 'y':
                    ConvertedLetter = 25;
                    break;
                case 'z':
                    ConvertedLetter = 26;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Only letters from the English alphabet are supported. Please do not input any other type of character.");
            }

            return ConvertedLetter;
        }

        public static char NumberConvert(int NumberToConvert)
        {
            switch (NumberToConvert)
            {

            }
        }
    }
}
