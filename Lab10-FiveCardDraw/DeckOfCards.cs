using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
	class DeckOfCards
	{
		public List<Card> Deck { get; set; }
		private const int NUMBER_OF_CARDS = 52;

		public DeckOfCards()
		{
			//all faces and suits in two seperate arrays with card vLUES
			string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
			string[] suits = { "♠", "♣", "♥", "♦" };
			int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			//new deck
			Deck = new List<Card>();

			//populate entire deck arraymwith card objects
			for (int count = 0; count < NUMBER_OF_CARDS; count++)
			{
				Deck.Add(new Card(faces[count % 13], suits[count / 13], value[count % 13]));
			}
		}

		public void Shuffle()
		{
			Random randNum = new Random();
			int nRand;
			DeckOfCards temp;

			//swap every card in the deck with another random card
			for (int n = 0; n < Deck.Count; n++)
			{
				nRand = randNum.Next(1, Deck.Count);
				temp = Deck[n];
				Deck[n] = Deck[nRand];
				Deck[nRand] = temp;
			}
		}

		public static implicit operator DeckOfCards(Card v)
		{
			throw new NotImplementedException();
		}
	}
}


//#4 line 19 should read Console.WriteLine(card.value + card.suit)