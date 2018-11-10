using System;

namespace ThirtyDaysofTDD.UnitTests
{
    public class StringUtils
    {
        public static int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            try
            {
                var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
                var characterToCheckFor = Char.Parse(characterToScanFor);

                var numberOfOccurenes = 0;

                for (var charIdx = 0; charIdx < stringToCheckAsCharacterArray.GetUpperBound(0); charIdx++)
                {
                    if (stringToCheckAsCharacterArray[charIdx] == characterToCheckFor)
                    {
                        numberOfOccurenes++;
                    }
                }

                return numberOfOccurenes;

            }
            catch
            {
                throw new ArgumentException();
            }

        }
    }
}