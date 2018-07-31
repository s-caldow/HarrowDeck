using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrowDeck.Models;

namespace HarrowDeck.HarrowDeck
{
    public class HarrowReading
    {
		private const int TraditionalNumCards = 9;
	    public Dictionary<string, string> Opposites;

	    public HarrowReading()
	    {
		    Opposites = new Dictionary<string, string>()
		    {
			    { "Good", "Evil"},
			    { "Evil", "Good"},
			    { "Chaotic", "Lawful"},
			    { "Lawful", "Chaotic"}
		    };
	    }

	    public Dictionary<string, HarrowCard> TraditionalReading(HarrowDeck deck)
	    {
			var hand = new Dictionary<string, HarrowCard>();
		    var shuffle = deck.Shuffle(TraditionalNumCards);

		    hand.Add("Lawful Good", deck.Deck[shuffle[0]]);
			hand.Add("Neutral Good", deck.Deck[shuffle[1]]);
		    hand.Add("Chaotic Good", deck.Deck[shuffle[2]]);

		    hand.Add("Lawful Neutral", deck.Deck[shuffle[3]]);
		    hand.Add("True Neutral", deck.Deck[shuffle[4]]);
		    hand.Add("Chaotic Neutral", deck.Deck[shuffle[5]]);

		    hand.Add("Lawful Evil", deck.Deck[shuffle[6]]);
		    hand.Add("Neutral Evil", deck.Deck[shuffle[7]]);
		    hand.Add("Chaotic Evil", deck.Deck[shuffle[8]]);

			return SetColor(hand);
	    }

	    public Dictionary<string, HarrowCard> StackTheDeck(Dictionary<string, HarrowCard> randomDeck, Dictionary<string, HarrowCard> stackedDeck)
	    {
		    foreach (var position in randomDeck.Keys)
		    {
			    if (stackedDeck[position] != null)
			    {
				    randomDeck[position] = stackedDeck[position];
			    }
		    }

		    return randomDeck;
	    }

	    public Dictionary<string, HarrowCard> SetColor(Dictionary<string, HarrowCard> hand)
	    {
			foreach (var key in hand.Keys.ToList())
		    {
			    var alignment = key.Split(" ");
			    var card = hand[key];
			    var valence = alignment[0];
			    var arousal = alignment[1];

			    var oppValence = Opposites.ContainsKey(valence) ? Opposites[valence] : "Neutral";
				var oppArousal = Opposites.ContainsKey(arousal) ? Opposites[arousal] : "Neutral";

			    if (card.Alignment.Contains(valence) && card.Alignment.Contains(arousal))
			    {
				    card.CardColor = "bright-green";
			    } else if (card.Alignment.Contains(valence))
			    {
				    if (!card.Alignment.Contains(oppArousal))
				    {
					    card.CardColor = "light-green";
					}
			    } else if (card.Alignment.Contains(arousal))
			    {
				    if (!card.Alignment.Contains(oppValence))
				    {
					    card.CardColor = "light-green";
					}
				} else if (card.Alignment.Contains(oppValence))
			    {
				    card.CardColor = "light-red";
				} else if (card.Alignment.Contains(oppArousal))
			    {
				    card.CardColor = "light-red";
				} else if (card.Alignment.Contains(oppArousal) && card.Alignment.Contains(oppValence))
			    {
				    card.CardColor = "bright-red";
				}

			    hand[key] = card;
		    }

		    return hand;
	    }
    }
}
