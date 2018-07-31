using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrowDeck.HarrowDeck;
using HarrowDeck.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HarrowDeck.Controllers
{
    public class HarrowDeckController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
	        var deck = new HarrowDeck.HarrowDeck();
            return View(deck.Deck);
        }

	    public IActionResult Details(string name)
	    {
			var deck = new HarrowDeck.HarrowDeck().Deck;
		    return View(deck.Find(e => e.Name == name));
	    }

	    public IActionResult TraditionalHand()
	    {
		    var deck = new HarrowDeck.HarrowDeck();
			var reading = new HarrowReading();

		    return View(reading.TraditionalReading(deck));
	    }

	    public IActionResult Help()
	    {
		    return View();
	    }
    }
}
