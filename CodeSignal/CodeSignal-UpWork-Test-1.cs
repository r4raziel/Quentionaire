using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace questionnaire
{
//    Codewriting
//You are given an array of strings paths containing paths to some files or directories.All file paths start with "/".
//Note: File paths may contain special characters ".." to represent parent directory specifiers.For example, "/a/b/../" points to the same directory as "/a". It is guaranteed that all given file paths are valid.
//Your task is to find the longest common suffix path without file masks or special characters (e.g., "..", etc.). If there isn't any common suffix path, return an empty string as "".

//Example

//For

//paths = [
//          "/a/folder1/../folder1/a/leaf.txt",
//          "/b/folder2/../folder1/a/leaf.txt",
//          "/a/folder3/folder1/folder1/../a/leaf.txt"
//      ]
//    the output should be solution(paths) = "/folder1/a/leaf.txt".

//Explanation:
//If you simplify the paths, they will look as follows:

//path[0] = "/a/folder1/a/leaf.txt"
//path[1] = "/b/folder1/a/leaf.txt"
//path[2] = "/a/folder3/folder1/a/leaf.txt"
//As you can see, since the 3rd-level directories from the end differ across the file paths, the longest common suffix path among them is /folder1/a/leaf.txt.
//    For
//    paths = [
//  "/root/folder1/b/../a",
//  "/root/folder1/a/leaf",
//  "/root/folder1/a/b/../../a/branch"
//]
//the output should be solution(paths) = "".

//Explanation:
//If you simplify the given paths, they will look as follows:

//path[0] = "/root/folder1/a"
//path[1] = "/root/folder1/a/leaf"
//path[2] = "/root/folder1/a/branch"
//As you can see, there isn't any common suffix in all of paths, therefore an empty string "" is returned.

//Input/Output

//[execution time limit] 0.5 seconds(cs)

//[memory limit] 1 GB

//[input] array.string paths

//An array of strings representing file paths.It is guaranteed that:

//The maximum file depth is 1000.
//All directory and file names have a length between 1 and 15 (inclusive).
//Each file path paths[i] will always start with /, and all paths are always valid absolute paths.
//Guaranteed constraints:
//1 ≤ paths.length ≤ 103.

//[output] string
//    The longest common suffix path among all paths.

    internal class CodeSignal_UpWork_Test_1
    {
        public static void process()
        {
            int[] m = new int[256];
            List<char> charArray= new List<char>();
                
            string[] paths = new string[]
            {
              "/a/folder1/../folder1/a/leaf.txt",
              "/b/folder2/../folder1/a/leaf.txt",
              "/a/folder3/folder1/folder1/../a/leaf.txt"
            };            

            foreach (string path in paths)
            {   var arr = path.ToCharArray();
                for (var i = 0; i < path.Length; i++)
                { m[arr[i]]++; 
                }
            }

            for (var i = 0; i < m.Length; i++)
            {
                if (m[i] == 3)
                {
                    charArray.Add((char)i);
                }
            }
            if (charArray.Count > 0)
                Console.WriteLine(new string(charArray.ToArray()));
            else
                Console.WriteLine("Empty");
        }
    }
}
