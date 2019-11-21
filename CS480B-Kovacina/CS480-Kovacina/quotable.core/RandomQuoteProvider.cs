using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{

	public interface RandomQuoteProvider
	{
		/// this is a random quote provider that's a little more complicated

		/// <param name="numberOfQuotes"></param>

		IEnumerable<string> GetRandomQuotes(long numberOfQuotes = 0);
	}
}