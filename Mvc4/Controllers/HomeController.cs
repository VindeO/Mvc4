using Mvc4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetPartialViews()
        {
            List<NoteTypesModel> s = new List<NoteTypesModel> { new NoteTypesModel { NodeType = "NoteType1" }, new NoteTypesModel { NodeType = "NoteType2" } };
            return PartialView(s);
        }

        public PartialViewResult GetNode()
        {
            NoteModel note = new NoteModel { NoteId = 1, NoteName = "Name" };
            return PartialView(note);
        }
    }
}
