using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class CardDeck
    {
        CardDeck[] cards;
        string[] suits = { "Club", "Heart", "Diamond", "Spade" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public CardDeck()
        {
            cards = InitializeCard();
        }
        public void shuffle(CardDeck[] cards)
        {
            Random random = new Random();
            CardDeck card;
            for (int i = 0; i < 52; i++)
            {
                //use two random index and swap that two place 
                int index = random.Next(52);
                int index2 = random.Next(52);
                card = cards[index];
                cards[index] = cards[index2];
                cards[index2] = card;
            }
        }

        internal void display(Program.Cards[,] players)
        {
            throw new NotImplementedException();
        }

        internal Program.Cards[,] alotCards(Program.Cards[,] players)
        {
            throw new NotImplementedException();
        }

        public CardDeck[] InitializeCard()
        {
            CardDeck[] card = new CardDeck[52];
            int cardIndex = 0;
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    //store the cards with suita and rank in given order
                    card[cardIndex] = new CardDeck();
                    cardIndex++;
                }
            }
            return card;
        }

        //method allocate the cards to the player
        public CardDeck[,] alotCards(CardDeck[,] players)
        {
            int playersIndex = 0;
            shuffle(this.cards);
            for (int i = 0; i < players.GetLength(0); i++)
            {
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    //distribute the cards to each player in shuffled order
                    players[i, j] = cards[playersIndex];
                    playersIndex++;
                }
            }
            return players;
        }

        //display the distributed cards 
        public void display(CardDeck[,] players)
        {
            for (int i = 0; i < players.GetLength(0); i++)
            {
                Console.WriteLine("Player" + (i + 1) + " Cards: ");
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    Console.WriteLine(players[i, j].suits + "     " + players[i, j].rank + " ");
                }
            }
        }
    }
}
