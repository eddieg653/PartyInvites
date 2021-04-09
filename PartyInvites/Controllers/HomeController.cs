using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Collections.Generic;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // F i e l d s

        // C o n s t r u c t o r s

        // M e t h o d s
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListResponses()
        {
            List<GuestResponse> responses = Repository.GetResponses();
            List<GuestResponse> willAttend
              = responses.Where(responses => responses.WillAttend == true)
                           .OrderBy(responses => responses.Name)
                           .ToList(); //LInQ Lanuage Integrated Query
            return View(willAttend);
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View();// go look for RsvpForm.cshtml
            return answer;
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse gr) 
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(gr);

                return View("Thanks", gr);
            }
            else
            {
                return View();
            }
            Repository.AddResponse(gr);

            return View("Thanks", gr);// look for Thanks.csthml
        }
    }
}
