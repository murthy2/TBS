using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TBS.Model;
using TBS.Repository;

namespace TBS.WebUI.Controllers
{
    public class TitlesController : Controller
    {
        #region ctors
        private readonly ITitleRepository service;
        private TitleDBContext db = new TitleDBContext();

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleRepository" /> class.
        /// </summary>
        /// <param name="response">The response.</param>
        public TitlesController(ITitleRepository _service)
        {
            service = _service;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref=TitleRepository" /> class.
        /// </summary>
        public TitlesController()
            : this(new TitleRepository())
        {
        }
        #endregion
        //
        // GET: /Titles/

        public ActionResult Index()
        {
            ViewBag.Message = "Titles";
            var model = service.GetTitles();
        
            return View(model);
        }

        // GET: /Titles/Details/Id
        public ActionResult Details(int id = 0)
        {
            var title = service.GetTitle(id);
            if (title == null)
            {
                return HttpNotFound();
            }
            return View(title);
        }

        // GET: /Titles/SearchIndex
        public ActionResult SearchIndex(string titleGenre, string searchString)
        {
            //dropdown list
            var GenreLst = new List<string>();

            var GenreQry = from d in db.Genres
                           orderby d.Name
                           select d.Name;
            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.titleGenre = new SelectList(GenreLst);

            //Search Criteria
            var model = service.SearchIndexSearchIndex(titleGenre, searchString);

            return View(model);
          
        }


        [HttpPost]
        public string SearchIndex(FormCollection fc, string searchString)
        {
            return "<h3> From [HttpPost]SearchIndex: " + searchString + "</h3>";
        }

    }
}
