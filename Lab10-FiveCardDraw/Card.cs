using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
	class Card
	{

		//card data
		string rank;
		string suit;
		int val;

		/// <summary>
		/// Gets or sets an integer valuefor the card. Different card games
		/// would assign different values.
		/// </summary>


		/// <summary>
		/// Creates a Card object with the given card rank and suit
		/// </summary>
		/// <param name="rank">A, K, Q, J, 10...2</param>
		/// <param name="suit">Use ASCII char for club, spade, heart or diamond</param>
		public Card(string rank, string suit, int val)
		{
			this.Rank = rank;
			this.Suit = suit;
			this.Val = val;
		}
		public int Value
			{
			get
			{
				return val;
			}
			set
			{
				val = value;
			}
		}


		public string Rank { get => rank; set => rank = value; }
		public string Suit { get => suit; set => suit = value; }
		public int Value { get => val; set => val = value; }

		public override string ToString()
		{
			return string.Format("{0,2}", rank, suit);
		}
	}
}
