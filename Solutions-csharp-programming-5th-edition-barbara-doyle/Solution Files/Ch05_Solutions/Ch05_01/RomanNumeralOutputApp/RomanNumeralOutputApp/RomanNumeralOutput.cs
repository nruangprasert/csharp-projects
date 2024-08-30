/* RomanNumeralOutput.cs
 * This class includes a single data member
 * representing a decimal value. An instance
 * method member returns the equivalent
 * roman numeral value.
 */
using System;

namespace RomanNumeralOutputApp
{
    class RomanNumeralOutput
    {
        private int number;

        public RomanNumeralOutput()
        {
        }

        public RomanNumeralOutput(int numberToConvert)
        {
            number = numberToConvert;
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string ReturnRomanNumeral()
        {
            string val;
            switch (number)
            {
                case 1:
                    val = "I";
                    break;
                case 2:
                    val = "II";
                    break;
                case 3:
                    val = "III";
                    break;
                case 4:
                    val = "IV";
                    break;
                case 5:
                    val = "V";
                    break;
                case 6:
                    val = "VI";
                    break;
                case 7 :
                    val = "VII";
                    break;
                case 8 :
                    val = "VIII";
                    break;
                case 9:
                    val = "IX";
                    break;
                case 10:
                    val = "X";
                    break;
                default:
                    val = "?";
                    break;
            }
            return val;
        }

        public override string ToString()
        {
            return "Decimal value:  " + number + 
                   "\nRoman numeral:  " +
                   ReturnRomanNumeral();
        }
    }
}
