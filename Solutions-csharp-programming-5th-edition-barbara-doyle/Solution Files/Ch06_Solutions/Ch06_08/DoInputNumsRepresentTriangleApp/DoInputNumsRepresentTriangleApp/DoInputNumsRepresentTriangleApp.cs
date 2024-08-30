using System;
using static System.Console;

namespace DoInputNumsRepresentTriangleApp
{
    class DoInputNumsRepresentTriangleApp
    {
        static void Main( )
        {
            bool result;
            bool inputMoreValues = true;
            int firstInt,
                secondInt,
                thirdInt;

            DisplayInfo();

            do
            {
                firstInt = GetNumber("first");
                secondInt = GetNumber("second");
                thirdInt = GetNumber("third");

                result = DetermineWhetherTriangleOrNot(firstInt, secondInt, thirdInt);
                Write(ProduceMessage(result, firstInt, secondInt, thirdInt));
                GetInput(ref inputMoreValues);
            } while (inputMoreValues);

            WriteLine("\n\n\n\n");
        }

        static void DisplayInfo()
        {
           WriteLine("**************************************************************" +
                     "\n\n  This application enables you to determine whether " +
                     "\n  three line segments can form a triangle." +
                     "\n  You will be prompted to enter 3 integers to be the " +
                     "\n  the respective lengths of the three sides of a triangle." +
                     "\n\n**************************************************************" +
                     "\n\n\n\tPress any key to begin...");
            ReadKey();
            Clear();
        }

        static void GetInput(ref bool choice)
        {
            char input;

            Write("\n\n\nWould you like to try 3 more numbers? " +
                  "\n  Please enter 'y' for yes or another letter for no: ");
            if (char.TryParse(ReadLine(), out input) == false)
            {
                WriteLine("Invalid data entered - N recorded for the response");
                input = 'N';
            }
            switch (input)
            {
                case 'y':
                case 'Y': choice = true;
                    break;
                default: choice = false;
                    break;
            }
        }


        static bool DetermineWhetherTriangleOrNot(int int1, int int2, int int3)
        {
            bool isItTriangle = true;

            if (int1 > int2)
            {
                if (int1 > int3)
                {
                    // if int1 > int2 and int1 > int3
                    // that is, int1 is the largest of the three
                    isItTriangle = ((int2 + int3) > int1) ? true : false;
                }
                else
                {
                    // if int1 > int2 BUT int3 > int1
                    // that is, int3 is the largest of the three
                    isItTriangle = ((int1 + int2) > int3) ? true : false;
                }
            }
            else
            {
                if (int2 > int3)
                {
                    // if int2 > int1 and int2 > int3 
                    // that is, int2 is the largest of the three
                    isItTriangle = ((int1 + int3) > int2) ? true : false;
                }
                else
                {
                    // if int2 > int1 BUT int3> int2
                    //that is, int3 is the largest of the three
                    isItTriangle = ((int1 + int2) > int3) ? true : false;
                }
            }
            return isItTriangle;
        }

        static string ProduceMessage(bool isItTriangle, int int1, int int2, int int3)
        {
            Clear( );

            string result = "\tTriangle App" +
                            "\nLine segment #1: " + int1 +
                            "\nLine segment #2: " + int2 +
                            "\nLine segment #3: " + int3 +
                            "\n *** These numbers ";

            if (isItTriangle)
                result += "CAN ";
            else
                result += "CANNOT ";
            result += "represent sides of a triangle. *\n";
            return result;
        }

        static int GetNumber(string whichOne)
        {
            string inValue;
            int aNumber;
            Write("\nPlease enter the {0} integer: ", whichOne);
            inValue = ReadLine();
            while (int.TryParse(inValue, out aNumber) == false)
            {
                Write("\nInvalid data entered - " +
                                    "Please re-enter the {0} integer: ", whichOne);
                inValue = ReadLine();
            }
            return aNumber;
        }
    }
}
