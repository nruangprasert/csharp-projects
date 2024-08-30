/* HexadecimalApp.cs
 * This application allows the user to enter any number of
 * hexidecimal characters (one character at a time). The
 * decimal equivalent is displayed, values are summed. 
 * After all values are entered, the sum of the values
 * entered is displayed both in hexadecimal and decimal
 * notation.
 */
using System;
using static System.Console;

namespace HexadecimalApp
{
    class HexadecimalApp
    {
        static void Main( )
        {
            bool enterMoreHexCharacters = true;
            char moreInput;
            char hexChar;
			int decimalValue,
                totalDecimalValue = 0;
            string totalHexValue;
            
            DisplayInformationAboutApp();
            do 
			{
				hexChar = GetHexChar( );
				decimalValue = ConvertHexToDecimal(hexChar);
                DisplayHexAndDecimal(hexChar, decimalValue);
                totalDecimalValue += decimalValue;
                Write("Do you want to enter another hexadecimal character? (Y or N): ");
                if (char.TryParse(ReadLine(), out moreInput) == false) // In case two characters entered
                {
                    WriteLine("Invalid characters entered - No recorded");
                    moreInput = 'n';
                }
                if (moreInput == 'y' || moreInput == 'Y')
                    enterMoreHexCharacters = true;
                else
                    enterMoreHexCharacters = false;
            } while (enterMoreHexCharacters);

            totalHexValue = ConvertDecimalToHex(totalDecimalValue);
            DisplayTotalOfValuesEntered(totalDecimalValue, totalHexValue);
            ReadKey();
		}

		static void DisplayInformationAboutApp()
		{
			WriteLine("***You will be prompted to input a hexadecimal character.  ***" +
                                "\n***The character is converted to its decimal equivalent.   ***" +
                                "\n***Valid entries are zero through nine and A through F.    ***" +
                                "\n***Both lowercase and uppercase characters are accepted.   ***" +
				                "\n***You may enter as many characters as you wish;           ***" +
                                "\n***The sum of all hex values entered will be reported.     ***" +
                                "\n\n\n\tPress any key to begin...");
            ReadKey();
            Clear();
		}	

        static void DisplayHexAndDecimal(char hexChar, int decimalValue)
        {
            Clear( );
            WriteLine("Hexadecimal Value: {0} - Decimal Value: {1}", hexChar, decimalValue);
        }

        static char GetHexChar( )
        {
            char hexChar;
            string inputValue;

            //Clear();
            Write("Enter a hexadecimal character - (single character): " );					            
		    inputValue = ReadLine();
            if(char.TryParse(inputValue, out hexChar) == false) // In case the user entered two characters
            {
                WriteLine("Invalid data entered - 0 recorded for the hex value");
                hexChar = '0';
            }
            return hexChar;
        }

        static string ConvertDecimalToHex(int decimalValue)
        {
            string hexResult = "";
            int individualCharacter;
            int remainder = decimalValue;
            do
            {
                if (decimalValue > 65536)
                {
                    individualCharacter = decimalValue / 65536;
                    remainder = decimalValue % 65536;
                }
                else
                    if (decimalValue > 4096)
                    {
                        individualCharacter = decimalValue / 4096;
                        remainder = decimalValue % 4096;
                    }
                    else
                        if (decimalValue > 256)
                        {
                            individualCharacter = decimalValue / 256;
                            remainder = decimalValue % 256;
                        }
                        else
                            if (decimalValue > 16)
                            {
                                individualCharacter = decimalValue / 16;
                                remainder = decimalValue % 16;
                            }
                            else
                            {
                                individualCharacter = decimalValue;
                                remainder = 0;
                            }
                decimalValue = remainder;
                hexResult += ConvertCharToHex(individualCharacter).ToString();
            } while (remainder != 0);
            return hexResult;
        }

        static int ConvertHexToDecimal(char hexChar)
		{				
            int decimalValue;
            switch (hexChar)
			{
				case '1':	decimalValue = 1;
					break;
				case '2':	decimalValue = 2;
					break;
				case '3':	decimalValue = 3;
					break;
				case '4':	decimalValue = 4;
					break;
				case '5':	decimalValue = 5;
					break;
				case '6':	decimalValue = 6;
					break;
				case '7':	decimalValue = 7;
					break;
				case '8':	decimalValue = 8;
					break;
				case '9':	decimalValue = 9;
					break;				
				case 'A':	
				case 'a':	decimalValue = 10;
					break;
				case 'B':	
				case 'b':	decimalValue = 11;
					break;
				case 'C':	
				case 'c':	decimalValue = 12;
					break;
				case 'D':	
				case 'd':	decimalValue = 13;
					break;
				case 'E':	
				case 'e':	decimalValue = 14;
					break;
				case 'F':								
				case 'f':	decimalValue = 15;
					break;
				default:	decimalValue = 0;
					break;
			}
            return decimalValue;

           //  For a quick conversion, could use Convert.ToUInt32( ) method.
           //  This would enable the hex value to consist of more than one character.
           //  WriteLine("Input a hexadecimal number");
           //  //convert the string to base 16 of an unsigned int
           //  hex = Convert.ToUInt32(ReadLine(),16);
		}

        static string ConvertCharToHex(int intHexChar)
		{				
            string charlValue;
            switch (intHexChar)
			{
				case 1:	charlValue = "1";
					break;
				case 2:	charlValue = "2";
					break;
				case 3:	charlValue = "3";
					break;
				case 4:	charlValue = "4";
					break;
				case 5:	charlValue = "5";
					break;
				case 6:	charlValue = "6";
					break;
				case 7:	charlValue = "7";
					break;
				case 8:	charlValue = "8";
					break;
				case 9:	charlValue = "9";
					break;				
				case 10:	charlValue = "A";
					break;
				case 11:	charlValue = "B";
					break;
				case 12:	charlValue = "C";
					break;
				case 13:	charlValue = "D";
					break;
				case 14:	charlValue = "E";
					break;
				case 15:	charlValue = "F";
					break;
                case 16:    charlValue = "10";
                    break;
                default:	charlValue = "0";
					break;
			}
            return charlValue;
           
            // For a quick conversion, could use Convert.ToUInt32( ) method.
            // This would enable the hex value to consist of more than one character.
            // WriteLine("Input a hexadecimal number");
            // //convert the string to base 16 of an unsigned int
            // hex = Convert.ToUInt32(ReadLine(),16);
		}

        static void DisplayTotalOfValuesEntered(int totalDecimalValue, string totalHexValue)
        {
            Clear();
            WriteLine("Total of all values entered:: {0} - Hexadecimal Notation: {1}", 
                                totalDecimalValue, totalHexValue);
        }
	}
}