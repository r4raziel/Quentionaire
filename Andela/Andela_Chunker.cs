using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire.Andela
{
    public class Andela_Chunker
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }

        public static IEnumerable<string> ChunkIter(string s, int chunks)
        {
            if (chunks < 1)
                throw new ArgumentException("chunks must be at least 1", nameof(chunks));

            if (string.IsNullOrEmpty(s))
                yield break;

            // If more chunks than string length, assume chunks == s.Length
            if (chunks > s.Length)
                chunks = s.Length;

            int baseLength = s.Length / chunks;
            int remainder = s.Length % chunks;
            int startIndex = 0;

            for (int i = 0; i < chunks; i++)
            {
                // First 'remainder' chunks get an extra character
                int currentLength = baseLength + (i < remainder ? 1 : 0);
                yield return s.Substring(startIndex, currentLength);
                startIndex += currentLength;
            }
        }

        public static string[] Chunk(string s, int chunks)
        {
            return ChunkIter(s, chunks).ToArray();
        }

        public static void process()
        {

            string A = "abcde";
            int chunks = 2;
            Console.WriteLine("Processing ...");
            Console.WriteLine("Result:" + string.Join(",", Chunk(A, chunks)));
        }
    }
}

// Task
// In this challenge, you'll complete two functions to split a string into evenly-sized chunks. One function will return an iterator while the other will return a primitive array of the resulting chunks.

// The procedures to perform the chunking should take two parameters, s and chunks, where s is the source string to chunk and chunks is the number of chunks the result array should contain.

// If the string cannot be partitioned evenly, excess characters should be distributed starting from the beginning of the list. The final array should have all pairs such that the length difference between any two elements is no greater than 1.

// Here is the class skeleton to flesh out, which is located in ./src/Chunker.cs in your workspace:

// public class Chunker 
// {
//     public static IEnumerable<string> ChunkIter(string s, int chunks) {}
//     public static string[] Chunk(string s, int chunks) {}
// }
// Argument constraints:

// Strings may be comprised of any characters in the ASCII range.
// 0 ≤ s.Length ≤ 106
// -1 ≤ chunks ≤ 106
// If fewer than 1 chunks are specified, throw an ArgumentException.
// If more chunks are specified than the string has the capacity to handle, assume chunks == s.Length.
// If s is an empty string and chunks > 0, return an empty array.
// Examples
// Given the string s = "abcdefg" and chunks = 3, return ["abc", "de", "fg"]. Note that the remainder of 1 was distributed to the first element in the list.

// Given the string s = "abcdefgh" and chunks = 3, return ["abc", "def", "gh"]. Again, note that the remainder of 2 was distributed to the first element in the list followed by the second element in the list.

// s="abcde", chunks=0 → throws ArgumentException
// s="abcde", chunks=1 → ["abcde"]
// s="abcde", chunks=2 → ["abc", "de"]
// s="abcde", chunks=3 → ["ab", "cd", "e"]
// s="abcde", chunks=4 → ["ab", "c", "d", "e"]
// s="abcde", chunks=5 → ["a", "b", "c", "d", "e"]
// s="abcde", chunks=6 → ["a", "b", "c", "d", "e"]