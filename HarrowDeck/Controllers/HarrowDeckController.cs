using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrowDeck.HarrowDeck;
using HarrowDeck.Models;
using HarrowDeck.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HarrowDeck.Controllers
{
    public class HarrowDeckController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
	        var deck = new HarrowDeck.HarrowDeck();
            return View(deck.Deck);
        }

		[HttpGet]
	    public IActionResult Details(string name)
	    {
			var deck = new HarrowDeck.HarrowDeck().Deck;
		    return View(deck.Find(e => e.Name == name));
	    }

		[HttpGet]
	    public IActionResult TraditionalHand()
	    {
		    var deck = new HarrowDeck.HarrowDeck();
			var reading = new HarrowReading();
		    var spread = reading.TraditionalReading(deck);
		    var vm = new TraditionalHandViewModel();
		    vm.FullDeck = deck;
		    vm.TraditionalSpread = spread;

			return View(vm);
	    }

	    [HttpPost]
	    public IActionResult TraditionalHand(IEnumerable<string> keyValuePair)
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
