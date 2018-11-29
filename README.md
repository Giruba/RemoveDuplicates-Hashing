Author: Giruba Beulah SE

# RemoveDuplicates-Hashing
C# program to remove duplicates from a string using Hashing

Logic/Algorithm
---------------
1. Initialize a charArray for the output string and initialize a HashMap 
[The HashMap is actually a bool array with size = 256 (Total number of printable ASCII chars)]

2. Iterate over the input string with two counters, one for the loop and one serving as the index of the output char array

  2.a The index of the bool array will the int value of the character.  
       Therefore if the boolArray[inputString[i]] is false, this means the hashMap has not encountered the character earlier.
       2.a.1 If the value at the bool array index is false, make it true
       2.a.2  Place the character in the output character array  
       
 3. Return a new string of the char array constructed so far
  
