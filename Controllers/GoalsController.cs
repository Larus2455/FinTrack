using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Controllers
{
    public class GoalsController : Controller
    {
        // GET: GoalsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GoalsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GoalsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoalsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GoalsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GoalsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GoalsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GoalsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
