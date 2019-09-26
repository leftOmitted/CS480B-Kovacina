using RandomQuoteProvider;
using SimpleRandomQuoteProvider;
namespace SimpleRandomQuoteProvider{
class SimpleRandomQuoteProvider:RandomQuoteProvider{
    new string quote1 = "A Cool Quote";
    new string quote2 = "A Cooler Quote";

    new string quote3 = "The Coolest Quote";

    public SimpleRandomQuoteProvider(){

    }

    public Ienumerable<string> quote(long quotes){
        if(quotes == 1){
            return (quote1);
        }
        else if (quotes == 2){
            return (quote1,quote2);
        }
        else{
            return (quote1,quote2,quote3);
        }
    }
}
}