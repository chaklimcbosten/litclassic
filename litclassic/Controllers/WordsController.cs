using litclassic.LitClassicBooksModels;
using litclassic.Models.ProxyModels;
using litclassic.Models.WordModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace litclassic.Controllers
{
    [Authorize]
    public class WordsController : Controller
    {
        private readonly IWordProxy _wordProxy;
        private readonly LitClassicBooksContext _db;

        public WordsController(IWordProxy wordProxy, LitClassicBooksContext db)
        {
            _wordProxy = wordProxy;
            _db = db;
        }

        // GET: Word
        [AllowAnonymous]
        public ActionResult Index()
        {
            var wordViewModel = new WordViewModel(_wordProxy, _db);

            wordViewModel.BuildModel(true, 16);

            ViewBag.Words = wordViewModel.Words;

            return View();
        }

        [AllowAnonymous]
        public ActionResult InfiniteScrolling()
        {
            var wordViewModel = new WordViewModel(_wordProxy, _db);

            wordViewModel.BuildModel(true, 8);

            ViewBag.Words = wordViewModel.Words;

            return PartialView("_Word");
        }

        [AllowAnonymous]
        public ActionResult Menu()
        {
            return PartialView("_Menu");
        }

        // GET: Word/Favourite
        [Authorize]
        public ActionResult Favourite()
        {
            return View();
        }
    }
}