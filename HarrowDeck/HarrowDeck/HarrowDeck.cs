using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrowDeck.Models;

namespace HarrowDeck.HarrowDeck
{
    public class HarrowDeck
    {
	    public List<HarrowCard> Deck { get; set; }

	    public List<int> Shuffle(int numCards)
	    {
		    var rand = new Random();
		    var shuffle = new List<int>();
		    for (int i = 0; i < numCards; i++)
		    {
				shuffle.Add(rand.Next(1, 54));
		    }

		    return shuffle;
	    }

	    public HarrowDeck()
	    {
		    Deck = new List<HarrowCard>();
		    Deck.Add(new HarrowCard
		    {
			    Name = "The Paladin",
			    Suite = "Strength",
			    Alignment = "Lawful Good",
			    Description = "This card represents standing resolutely against trouble, without backing down"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Keep",
			    Suite = "Strength",
			    Alignment = "Neutral Good",
			    Description = "This card represetns quiet, unshakeable strength that withstands any hardship"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Big Sky",
			    Suite = "Strength",
			    Alignment = "Chaotic Good",
			    Description = "This card represents momentus change, as when all the slaves of a nation are emancipated"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Forge",
			    Suite = "Strength",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents strength through diversity, or strength from many sources united against a single trial"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Bear",
			    Suite = "Strength",
			    Alignment = "True Neutral",
			    Description = "This card represents pure strength that cannot be truly tamed or trained"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Uprising",
			    Suite = "Strength",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents overwhelming strength that catches the subject up in something much more powerful"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Fiend",
			    Suite = "Strength",
			    Alignment = "Lawful Evil",
			    Description = "This card is a devil that devours the innocent, and can represent the deaths of many in a disaster"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Beating",
			    Suite = "Strength",
			    Alignment = "Neutral Evil",
			    Description = "This card represents an assult from all sides, or the mental dissolution of the self"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Cyclone",
			    Suite = "Strength",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents an unstoppable, destructive force unleashed through the plots of intelligent creatures"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Dance",
			    Suite = "Dexterity",
			    Alignment = "Lawful Good",
			    Description = "This card represents a complicated framework that requires the cooperation of all to avoid collapse"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Cricket",
			    Suite = "Dexterity",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents the grig, quick travel, and the reward at the end of a journey"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Juggler",
			    Suite = "Dexterity",
			    Alignment = "Chaotic Good",
			    Description = "This card represents destiny, deities and those who play with the fates of others"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Locksmith",
			    Suite = "Dexterity",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents the keys the subject needs to unlock his fate.  The card grants the tools needed to unlock some new place, puzzle or hoard"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Peacock",
			    Suite = "Dexterity",
			    Alignment = "True Neutral",
			    Description = "This card represents a great beauty that can only be preserved if petrified and frozen in time for eternity, as by a cockatrice's glare"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Rabbit Prince",
			    Suite = "Dexterity",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents the quiky vicissitudes of melee combat.  This card is the personification of the capriciousness of battle, and his broken sword indicates that defeat my come to anyone.  The card may also represetn younger members of royal or noble houses"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Avalanche",
			    Suite = "Dexterity",
			    Alignment = "Lawful Evil",
			    Description = "This card represents disaster; an unthinkng panick and destruction that overruns all"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Crows",
			    Suite = "Dexterity",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents murder, theft, and the violent loss of that which is loved"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Demon's Lantern",
			    Suite = "Dexterity",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents an impossible situation of traps, mind tricks and sleight of hand"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Trumpet",
			    Suite = "Constitution",
			    Alignment = "Lawful Good",
			    Description = "This card represents an archon who dives aggresively and righteously into danger"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Survivor",
			    Suite = "Constitution",
			    Alignment = "Neutral Good",
			    Description = "This card represents a creature that has managed to survive a terrible ordeal, when everyone thought him lost"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Desert",
			    Suite = "Constitution",
			    Alignment = "Chaotic Good",
			    Description = "This card represents an environment too difficult for anyone to survive without help"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Brass Dwarf",
			    Suite = "Constitution",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents a creature invulnerable to a current threat"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Teamster",
			    Suite = "Constitution",
			    Alignment = "True Neutral",
			    Description = "This card represents an external force that drives the subject on"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Mountain Man",
			    Suite = "Constitution",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents an encounter with a physical power outside of the subject's control"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Tangled Briar",
			    Suite = "Constitution",
			    Alignment = "Lawful Evil",
			    Description = "This card represents a historical thing or creature that will have some influence on the question"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Sickness",
			    Suite = "Constitution",
			    Alignment = "Neutral Evil",
			    Description = "This card represents corruption, plague, pestilence and disease"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Waxworks",
			    Suite = "Constitution",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents a place of torture, imprisonment, helplessness, and paralysis"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Hidden Truth",
			    Suite = "Intelligence",
			    Alignment = "Lawful Good",
			    Description = "This card represents the discovery of a greater truth within"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Wanderer",
			    Suite = "Intelligence",
			    Alignment = "Neutral Good",
			    Description = "This card represents a centaur who appreciates things that others discard as junk"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Joke",
			    Suite = "Intelligence",
			    Alignment = "Chaotic Good",
			    Description = "This card represents a monster that can only be defeated through trickery or the value of humor in circumventing difficult people"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Inquisitor",
			    Suite = "Intelligence",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents an immutable object that cannot be deceived or influenced"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Foreign Trader",
			    Suite = "Intelligence",
			    Alignment = "True Neutral",
			    Description = "This card represents spies, merchants and those who truck in information"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Vision",
			    Suite = "Intelligence",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents esoteric and arcane knowledge, or madness"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Rakshasa",
			    Suite = "Intelligence",
			    Alignment = "Lawful Evil",
			    Description = "This card represents domination, mental control and slavery"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Idiot",
			    Suite = "Intelligence",
			    Alignment = "Neutral Evil",
			    Description = "This card represents folly, greed, blackmail, bribery or hubris"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Snakebite",
			    Suite = "Intelligence",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents poison, venom, assassination and discord"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Winged Serpent",
			    Suite = "Wisdom",
			    Alignment = "Lawful Good",
			    Description = "This card represents the bridge of understanding between the towers of knowledge and judgement"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Midwife",
			    Suite = "Wisdom",
			    Alignment = "Neutral Good",
			    Description = "This card represents the enabler or conduit of new creation, information or arrivals"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Publican",
			    Suite = "Wisdom",
			    Alignment = "Chaotic Good",
			    Description = "This card represents fellowship and friendship, as well as unexpected, but relevant, insight"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Queen Mother",
			    Suite = "Wisdom",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents knowledge personified, fondness for enforcing the status quo and for those that serve a more powerful entity"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Owl",
			    Suite = "Wisdom",
			    Alignment = "True Neutral",
			    Description = "This card represents harsh wisdom of the natural order.  The owl holds a needle that can bind life together or pick it apart"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Carnival",
			    Suite = "Wisdom",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents illusions and false dreams"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Eclipse",
			    Suite = "Wisdom",
			    Alignment = "Lawful Evil",
			    Description = "This card represents a loss of faith and purpose, and the subject's doubt about his abilities or prospects"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Hag",
			    Suite = "Wisdom",
			    Alignment = "Neutral Evil",
			    Description = "This card represents insight used harm, control or pry secrets from the unsuspecting"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Madman",
			    Suite = "Wisdom",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents the permanently insane, lost amoung lunativs and psychopaths in asylums.  It is a card of emptiness"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Empty Throne",
			    Suite = "Charisma",
			    Alignment = "Lawful Good",
			    Description = "This card represents those who are gone, or a ghost of the past who has taught important lessons"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Theater",
			    Suite = "Charisma",
			    Alignment = "Neutral Good",
			    Description = "This card represents prophecy, with a true prophet acting a part as the puppet of the gods"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Unicorn",
			    Suite = "Charisma",
			    Alignment = "Chaotic Good",
			    Description = "This card represents who generously offers up that which is sought"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Marriage",
			    Suite = "Charisma",
			    Alignment = "Lawful Neutral",
			    Description = "This card represents a union of peoples, ideas, or kingdoms that might be as productive or as ruinous as the bonding of a salamander and a water weird"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Twin",
			    Suite = "Charisma",
			    Alignment = "True Neutral",
			    Description = "This card represents the duality or purpose or identity, or indecision and fence-sitting for the subject or the entire spread"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Courtesan",
			    Suite = "Charisma",
			    Alignment = "Chaotic Neutral",
			    Description = "This card represents political intrigue and the superficiality of social niceties"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Tyrant",
			    Suite = "Charisma",
			    Alignment = "Lawful Evil",
			    Description = "This card represents a ruler who harms those he rules"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Betrayal",
			    Suite = "Charisma",
			    Alignment = "Neutral Evil",
			    Description = "This card represents selfishness and envy"
		    });

		    Deck.Add(new HarrowCard
		    {
			    Name = "The Liar",
			    Suite = "Charisma",
			    Alignment = "Chaotic Evil",
			    Description = "This card represents destructive, threacherous love.  This card may also represent obession, star-crossed lovers or unrequited love"
		    });
		}
    }
}
