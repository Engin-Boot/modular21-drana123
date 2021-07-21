using System;

using System.Diagnostics;

namespace TelCo.ColorCoder
{

    class Testing : IManual
    {
        public void Printmanual()
        {
            Console.WriteLine("Testing reference manual/n **********/n");
            int start = 1;
            for (int i = 0; i < ColorFromPair.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorFromPair.colorMapMinor.Length; j++)
                {
                    PairFromColor testPair = ColorFromPair.GetColorFromPairNumber(start); 
                    Debug.Assert(testPair.majorColor == ColorFromPair.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == ColorFromPair.colorMapMinor[j]);

                    var test = new PairFromColor(); 
                  //test type:  PairFromColor
                    test.majorColor = ColorFromPair.colorMapMajor[i]; 
                    test.minorColor = ColorFromPair.colorMapMinor[j]; 

                    int pairNumber = PairFromColor.GetPairNumberFromColor(testPair);
                    Debug.Assert(start == pairNumber);
                    start++;
                }
            }
            Console.WriteLine("Testing reference manual Completed/n **********/n");
        }


    }
}