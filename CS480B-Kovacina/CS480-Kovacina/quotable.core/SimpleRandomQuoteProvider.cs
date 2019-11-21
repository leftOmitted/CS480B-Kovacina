using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
	///random quote provider that works really simply
	public class SimpleRandomQuoteProvider : RandomQuoteProvider
	{

		private static readonly string Quote1 = "I'm going to screech like a pteradactyl";
		private static readonly string Quote2 = "I'm going to wheeze like a strange gremlin";
		private static readonly string Quote3 = "How did this small gremlin creature get into my home?";
		private static readonly string Quote4 = "I have opinions";
		private readonly List<string> Quotes = new List<string>(){ Quote1, Quote2, Quote3, Quote4 };
		public IEnumerable<string> GetRandomQuotes(long numberOfQuotes = 0)
		{

			var random = new Random();

			var largestInt = (int)Math.Min(numberOfQuotes, Quotes.Count);

			for (int x = 0; x < numberOfQuotes; x++)
			{
				var idx = random.Next(largestInt);

				yield return Quotes[idx];
			}
		}
	}
}
