using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Search_All_Words_Version
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("This program will search your string for a particular word and return the number of times it appears.\n");

			bool _continue = true;

			while (_continue)
			{

				Console.WriteLine("\nEnter a sentence.\n");

				string _sentence = Console.ReadLine();

				_sentence = _sentence.ToLower();



				string[] words = _sentence.Split(' ', '.', '/', ';', '\'', '\\', '!', '?', ',');

				string[] _searchTerms = _sentence.Split(' ', '.', '/', ';', '\'', '\\', '!', '?', ',');

				List<string> list = new List<string>();


				// for every string in the array called _searchTerms
				foreach (var item in _searchTerms)
				{

					int count = 0;
					//compare to every string in the words array
					foreach (string i in words)
					{
						//when current searchTerm appears in current word array 
						if (i.Equals(item))
						{

							//increment the count for the particular word 
							count = count + 1;
						}

					}

					//adds the string and count of occurances to a list then loops for all search terms
					list.Add("Found " + item + " " + count + " times.");
				}

				//adds the information from all search terms
				//added in previous function to new list called distinct
				List<string> distinct = list.Distinct().ToList();
				
				//outputs all strings in list distinct
				foreach (string item in distinct)
				{
					Console.WriteLine(item);

				}

				Console.WriteLine("\nEnter x to exit or any other key to continue.\n");




				char _key = Console.ReadKey().KeyChar;

				if (char.ToLower(_key) == 'x') { _continue = false; }
				Console.WriteLine("\n \n");


			}
		}
	}
}
