using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrowDeck.Models;

namespace HarrowDeck.ViewModels
{
    public class TraditionalHandViewModel
    {
	    public Dictionary<string, HarrowCard> TraditionalSpread { get; set; }

	    public HarrowDeck.HarrowDeck FullDeck { get; set; }
    }
}
