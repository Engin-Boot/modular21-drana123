using System;

namespace TelCo.ColorCoder
{
    class ColorToNumberReferenceManual:IManual
    {

        public void Printmanual() 
        {
            Console.WriteLine("Reference manual for user:/n");
            int start = 1;
            for (int i = 0; i < ColorFromPair.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorFromPair.colorMapMinor.Length; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", start, ColorFromPair.colorMapMajor[i], ColorFromPair.colorMapMinor[j]);
                    start++;
                }
            }

        }

    }
}
