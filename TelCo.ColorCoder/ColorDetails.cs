using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorDetails  
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        public static int GetPairNumberFromColor(ColorDetails pair)
        { 
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < ColorFromPair.colorMapMajor.Length; i++)
            {
                if (ColorFromPair.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < ColorFromPair.colorMapMinor.Length; i++)
            {
                if (ColorFromPair.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColorFromPair.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}