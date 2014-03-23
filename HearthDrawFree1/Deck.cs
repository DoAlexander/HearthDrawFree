using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthDrawFree
{
    class Deck
    {
        private List<card> deck = new List<card>();
        private string name;
        public string myName
        {
            get
            {
                return name;
            }
        }

        public
            Deck() { }

        public Deck(List<card> fcards, string fname)
        {
            name = fname;
            foreach (card cards in fcards)
            {
                deck.Add(cards);
            }
        }

        public int numCards()
        {
            return deck.Count;
        }

        public card getCard(int i)
        {
            return deck.ElementAt(i);
        }
    }
}
