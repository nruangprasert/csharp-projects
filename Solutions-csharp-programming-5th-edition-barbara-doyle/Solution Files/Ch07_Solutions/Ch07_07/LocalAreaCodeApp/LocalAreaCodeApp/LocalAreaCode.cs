/*LocalAreaCode.cs
 *This class has as a data member an array which can store state area codes. 
 *It also have a method that enables users to test an area code to determine 
 *if a number is one of the area codes in the state exchange. 
 *The method uses a predefined method of the Array class and return true 
 *if the argument to the method is one of the state codes. The ToString( ) 
 *method is overridden to return the full list of area codes with each 
 *one surrounded by parentheses. 
 */ 
using System;

namespace LocalAreaCodeApp
{
    class LocalAreaCode
    {
        private int[] areaCode;

        public LocalAreaCode()
        {
        }
        public LocalAreaCode(int[] stateCode)
        {
            areaCode = new int[stateCode.Length];
            areaCode = stateCode;
        }
        
        public bool ValidStateCode(int aCode)
        {
            bool returnValue;
            Array.Sort(areaCode);
            if (Array.BinarySearch(areaCode, aCode) > -1)
                returnValue = true;
            else
                returnValue = false;
            return returnValue;
        }

        public override string ToString()
        {   string outPutValue = "";
            Array.Sort(areaCode);
            for(int i = 0; i < areaCode.Length; i++)
                outPutValue += "(" + areaCode[i] + ")\n";
            return outPutValue;
        }
    }
}