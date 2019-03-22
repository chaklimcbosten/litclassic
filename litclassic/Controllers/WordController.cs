using litclassic.Models.ProxyModels;
using litclassic.Models.WordModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace litclassic.Controllers
{
    public class WordController : Controller
    {
        private readonly IWordProxy _wordProxy;
        private readonly LitClassicBooksContext _db;

        public WordController(IWordProxy wordProxy, LitClassicBooksContext db)
        {
            _wordProxy = wordProxy;
            _db = db;
        }

        // GET: Word
        public ActionResult Index()
        {
            var wordViewModel = new WordViewModel(_wordProxy, _db);

            wordViewModel.BuildModel(true, 1);

            ViewBag.Words = wordViewModel.Words;

            return View();
        }

        public ActionResult Menu()
        {
            if (User.Identity.IsAuthenticated)
            {

            }

            return PartialView("_Menu");
        }

        // GET: Word/Favourite
        [Authorize]
        public ActionResult Favourite()
        {
            return View();
        }

        // GET: Word/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Word/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Word/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Word/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Word/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Word/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Word/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}