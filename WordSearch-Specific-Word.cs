using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Search
{
	class Program
	{
		static void Main(string[] args)
		{

			// take a  setence
			// take a word
			// print how many times the word appears in the sentence


			Console.WriteLine("This program will search your string for a particular word and return the number of times it appears.\n");

			bool _continue = true;

			while (_continue)
			{

				Console.WriteLine("\nEnter a sentence.\n");

				string _sentence = Console.ReadLine();

				_sentence = _sentence.ToLower();


				Console.WriteLine("\nEnter a word to search for.\n");

				string _word = Console.ReadLine();

				_word = _word.ToLower();


				int _matchCount = 0;


				string[] words = _sentence.Split(' ', '.', '/', ';','\'','\\', '!', '?',',');



				foreach (var word in words)
				{

					if (word == _word)
					{

						_matchCount++;

					}


				}


				Console.WriteLine("\nThere are " + _matchCount + " instances of " + _word + " in " + _sentence);




				Console.WriteLine("\nEnter x to exit or any other key to continue.\n");




				char _key = Console.ReadKey().KeyChar;

				if (char.ToLower(_key) == 'x') { _continue = false; }
				Console.WriteLine("\n \n");
			}
		}
	}
}

// Beginning of code to return number of times every word in sentence appears. 


//string[] _searchTerms = _sentence.Split(' ', '.', '/', ';', '\'', '\\', '!', '?', ',');

//List<string> list = new List<string>();

//foreach (var item in _searchTerms)
//{

//	int count = 0;
//	foreach (string i in words)
//	{

//		if (i.Contains(item))
//		{
//			count = count + 1;
//		}

//	}

//	list.Add("Found " + item + " " + count + " times.");
//}
//List<string> distinct = list.Distinct().ToList();
//foreach (string item in distinct)
//{
//	Console.WriteLine(item);

//}






