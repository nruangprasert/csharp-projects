/* MetricWeightConverterApp.cs
 */

using System;
using static System.Console;


namespace MetricWeightConverterApp
{
    class MetricWeightConverterApp
    {
        static void Main( )
        {
            const double GRAMS_IN_A_POUND = 453.59237;

            string productName = "Poutine";
            double productPrice = 1.29;  // 2.09 per 100 grams
            double numberOfGrams = 100;
            double costPerGram;
            double costPerPound;

            costPerGram = productPrice / numberOfGrams;
            costPerPound = costPerGram * GRAMS_IN_A_POUND;

            WriteLine("\tMetric Converter\n");
            WriteLine("Product Name: {0}", productName);
            WriteLine("Price per {0} grams: {1:C}", numberOfGrams, productPrice);
            WriteLine("Cost per Pound: {0:C}", costPerPound);
            ReadKey();

        }
    }
}
