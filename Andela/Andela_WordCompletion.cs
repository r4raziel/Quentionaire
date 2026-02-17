// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Net;
// using System.Net.Http;
// using System.Text.Json;
// using System.Text.Json.Serialization;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace Questionaire.Andela
// {
//     [Route("")]
//     [ApiController]
//     public class Andela_StemsController : Controller
//     {
//         private const string uri = "https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt";
//         private static List<string> _cachedWords;

//         public StemsController()
//         {
//         }

//         [HttpGet]
//         public async Task<ActionResult> Get([FromQuery] string stem = "")
//         {
//             try
//             {
//                 // Load words if not cached
//                 if (_cachedWords == null)
//                 {
//                     _cachedWords = await FetchWordsAsync();
//                 }

//                 // Filter words by prefix (stem)
//                 var filteredWords = _cachedWords
//                     .Where(word => word.StartsWith(stem))
//                     .ToList();

//                 // Return 404 if no matches found
//                 if (filteredWords.Count == 0)
//                 {
//                     return NotFound();
//                 }

//                 // Return 200 with data wrapped in object
//                 return Ok(new { data = filteredWords });
//             }
//             catch (Exception ex)
//             {
//                 return BadRequest(new { error = ex.Message });
//             }
//         }

//         private async Task<List<string>> FetchWordsAsync()
//         {
//             using (var client = new HttpClient())
//             {
//                 var response = await client.GetAsync(uri);
//                 response.EnsureSuccessStatusCode();
//                 var content = await response.Content.ReadAsStringAsync();

//                 // Split by newline and filter out empty entries
//                 var words = content
//                     .Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
//                     .ToList();

//                 return words;
//             }
//         }

//     }
// }

// Task
// Overview
// For this challenge, you'll be implementing a simple server application that offers basic word completion.

// The server should offer one route, GET /, which can accept a query string stem that enables the client to specify the prefix of the words they'd like to retrieve. For example, given the following miniature word list:

// apple
// apples
// applesauce
// appetite
// a query of "apples" should return only ["apples", "applesauce"]. A query of "" or "a", "ap" or "app" should return all words, since "" and the other substrings are a prefix to all words in the word list. Likewise, if no query is provided, return the entire word list. A query like "pple" would return nothing, because it's not a prefix of any words in the list.

// The list of words that you'll be filtering for the challenge itself will be much larger (466,000 words), can be considered static (that is, its contents are never expected to change as far as your app's logic is concerned) and should be obtained from the following URL: https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt. Your code should make a HTTP request to retrieve the text file contents. The file is ordered alphabetically, contains one word per line and consists entirely of lowercase letters separated by newlines.

// All query strings will be matched exactly--there is no need to worry about case-insensitive matching or otherwise manipulating the incoming query.

// Keep performance in mind when fetching this dictionary file.

// Response format
// All requests should respond with status code 200 on success and 404 when there are no results for a particular query. Success responses will consist of the following JSON structure:

// {
//   "data": [...]
// }
// In this structure, the actual response data (the alphabetized list of matching words for the query prefix) will be contained inside of the data array. For the above simplified example word list and a GET /?stem=apples, the expected response body should look like:

// {
//   "data": ["apples", "applesauce"]
// }
// Had the request been GET /?stem=zebra, return a 404 because "zebra" is not a prefix to any of the words in the simplified list.

// You may wish to write a few of your own tests. A modifiable example file which will not be included with your final submission is located in tests/StemsControllerTests.cs. This file gives an idea of what the submission tests will consist of.