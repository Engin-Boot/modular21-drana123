using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class mainProgram 
    {
        private static void Main(string[] args)
        {
            ColorToNumberReferenceManual ReferenceManual=new ColorToNumberReferenceManual();
            Testing TestManual=new Testing();
            Manual Refmanual = new Manual(ReferenceManual); 

            Manual testmanual = new Manual(TestManual); 

            int pairNumber = 4;
            PairFromColor testPair1 = ColorFromPair.GetColorFromPairNumber(pairNumber);
              
            // Console.WriteLine("This is the Reference Manual for user:\n");
            // ReferenceManual.Printmanual();
            
            testPair1 = ColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            PairFromColor testPair2 = new PairFromColor() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = PairFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new PairFromColor() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = PairFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);



        }

    }
}