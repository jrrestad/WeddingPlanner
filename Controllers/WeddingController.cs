using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Wedding_Planner_Two.Models;

namespace Wedding_Planner_Two.Controllers
{
    public class WeddingController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private MyContext db;
        public WeddingController(MyContext context)
        {
            db = context;
        }

        [HttpGet("/weddings")]
        public IActionResult All()
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }
            List<Wedding> allWeddings = db.Weddings
            .Include(wed => wed.Guests)
            .ThenInclude(wed => wed.UsersAttending)
            .Include(wed => wed.Creator)
            .OrderByDescending(wed => wed.CreatedAt)
            .ToList();
            return View("All", allWeddings);
        }


        [HttpGet("/weddings/{weddingId}")]
        public IActionResult Detail(int weddingId)
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }
            Wedding thisWedding = db.Weddings
            .Include(wed => wed.Guests)
            .ThenInclude(wed => wed.UsersAttending)
            .FirstOrDefault(wed => wed.WeddingId == weddingId);

            return View("Detail", thisWedding);
        }

        [HttpGet("/weddings/new")]
        public IActionResult New()
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }
            return View("New");
        }

        [HttpPost("/weddings/new/create")]
        public IActionResult Create(Wedding newWedding)
        {
            if (ModelState.IsValid)
            {
                newWedding.UserId = (int)uid;
                db.Add(newWedding);
                db.SaveChanges();
                return RedirectToAction("All");
            }
            return View("New");
        }

        [HttpGet("weddings/RSVP")]
        public IActionResult RSVP(Attending newAttending)
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }

            newAttending.UserId = (int)uid;
            // no need to pass in a new WeddingId because the form submission should already contain the WeddingId
            // newAttending.WeddingId = weddingId;

            // Check to make sure User isn't already attending (or has RSVP'd) for the wedding
            Attending alreadyAttending = db.Attendees
            .Include(wed => wed.WeddingsAttending)
            .ThenInclude(wed => wed.Creator)
            .FirstOrDefault(att => att.WeddingId == newAttending.WeddingId && att.UserId == uid);

            // If there is an Attending ID created where the WeddingId and the UserId match, we don't create a new one.
            if (alreadyAttending == null)
            {
                // Attendees is the dbcontext for creating a new Attending ID
                db.Attendees.Add(newAttending);
                db.SaveChanges();
            }
            
            return RedirectToAction("All");
        }

        [HttpGet("weddings/UNRSVP")]
        public IActionResult UNRSVP(int weddingId)
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }
            Attending thisAttending = db.Attendees
            .FirstOrDefault(att => att.WeddingId == weddingId && att.UserId == uid);

            if (thisAttending != null)
            {
                db.Attendees.Remove(thisAttending);
                db.SaveChanges();
            }

            return RedirectToAction("All");
        }

        [HttpGet("weddings/delete")]
        public IActionResult Delete(int weddingId)
        {
            if (uid == null)
            {
                return View("Index", "Home");
            }  
            Wedding thisWedding = db.Weddings
            .Include(wed => wed.Creator)
            .FirstOrDefault(wed => wed.WeddingId == weddingId);

            if (thisWedding.Creator.UserId == uid)
            {
                db.Weddings.Remove(thisWedding);
                db.SaveChanges();
            }
            return RedirectToAction("All");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
