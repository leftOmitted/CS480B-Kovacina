using quotable.core;
using System;

namespace quotable.console
{
    class Program
    {
		//the main meat of the program
        static void Main(string[] args)
        {
			//sets up the quotes and quote numbers

			var numberOfQuotes = (long)1;
			if (args.Length > 1) goto usage;
			if (args.Length == 1 )
			{
				bool result = long.TryParse(args[0], out numberOfQuotes);
				if (!result)
				{
					goto usage;
				}
			}

			var provider = new SimpleRandomQuoteProvider();
			//outputs the quotes
			foreach( var quote in provider.GetRandomQuotes(numberOfQuotes) )
			{
				Console.WriteLine(quote);
			}
			goto exit;

			usage:
			Console.Error.WriteLine("usage: dotnet run [numberOfQuotes]");
			exit:
			return;
        }
    }
}
