using SklepInternetowy.DAL;
using System.Linq;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class AlbumyController : Controller
    {
        private AlbumyContext db = new AlbumyContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwaKategorii, string searchQuery = null)
        {
            var kategoria = db.Kategorie.Include("Albumy").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategorii.ToUpper()).Single();

            var albumy = kategoria.Albumy.Where(a => (searchQuery == null ||
                                                          a.TytulAlbumu.ToLower().Contains(searchQuery.ToLower()) ||
                                                          a.AutorAlbumu.ToLower().Contains(searchQuery.ToLower())) &&
                                                          !a.Ukryty);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_AlbumyLista", albumy);
            }

            return View(albumy);
        }
        public ActionResult Szczegoly(int id)
        {
            var album = db.Albumy.Find(id);
            return View(album);
        }
        [ChildActionOnly]
        [OutputCache(Duration = 60000)]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }

        public ActionResult AlbumyPodpowiedzi(string term)
        {
            var albumy = db.Albumy.Where(a => !a.Ukryty && a.TytulAlbumu.ToLower().Contains(term.ToLower()))
                        .Take(5).Select(a => new { label = a.TytulAlbumu });

            return Json(albumy, JsonRequestBehavior.AllowGet);
        }
    }
}