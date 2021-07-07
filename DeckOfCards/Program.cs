using System;

namespace DeckOfCards
{
    class Program
    {
        public class Cards
        {
            public string suit;
            public string rank;
            public Cards(string suit, string rank)
            {
                this.suit = suit;
                this.rank = rank;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deck of cards Problem !!!");
            CardDeck cardDeck = new CardDeck();
            Cards[,] players = new Cards[4, 9];
            players = cardDeck.alotCards(players);
            cardDeck.display(players);
        }

    }
}
