using System;

namespace TelCo.ColorCoder
{
    class ColorToNumberReferenceManual
    {

        public static void PrintManual()
        {

            int start = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", start, ColorFromPair.colorMapMajor[i], ColorFromPair.colorMapMinor[j]);
                    start++;
                }
            }

        }

    }
}
