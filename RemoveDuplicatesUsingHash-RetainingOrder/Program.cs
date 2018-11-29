using System;

namespace RemoveDuplicatesUsingHash_RetainingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove duplicates in a string using Hashing!");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Enter the input string");
            String inputString = Console.ReadLine();
            Console.WriteLine();
            String resultantString = GetDuplicatesRemovedString(inputString);
            if (!string.IsNullOrEmpty(resultantString)) {
                Console.WriteLine("The resultant string is "+resultantString);
            }else{
                Console.WriteLine("The input string is empty!");
            }

            Console.ReadLine();
        }

        private static string GetDuplicatesRemovedString(string inputString) {
            if (string.IsNullOrEmpty(inputString)) {
                return inputString;
            }
            if (string.IsNullOrEmpty(inputString.Trim())) {
                return inputString.Trim();
            }
            bool[] hashChar = new bool[256];
            char[] charArray = new char[inputString.Length + 1];
            int newIndex = 0;

            for (int i = 0; i < inputString.Length; i++) {
                if (hashChar[inputString[i]] == false) {
                    hashChar[inputString[i]] = true;
                    charArray[newIndex++] = inputString[i];
                }
            }
            
            return new string(charArray);
        }
    }
}
