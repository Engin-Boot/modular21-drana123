using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class PairFromColor
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }


        public static int GetIndex(Color [] ColorArray,Color PairColor) 
        {
            for (int i = 0; i < ColorArray.Length; i++)
            {
                if (ColorArray[i] == PairColor) 
                {
                    return i;
            
                }
            }
                return -1;
        }
        public static int GetPairNumberFromColor(PairFromColor pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = GetIndex(ColorFromPair.colorMapMajor,pair.majorColor); 


            // Find the minor color in the array and get the index
            int minorIndex = GetIndex(ColorFromPair.colorMapMinor,pair.minorColor);
           
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColorFromPair.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
