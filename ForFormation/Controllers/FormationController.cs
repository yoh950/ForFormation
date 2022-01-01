using ForFormation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForFormation.Controllers
{
    public class FormationController : Controller
    {
        private readonly DefaultContext _context = null;
        private Avis context;

        public FormationController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from item in this._context.Formations
                        select item;

            return View(query.ToList());
        }

        public IActionResult DetailFormation(int id)
        {
            Formation formation = null;
            formation = this._context.Formations.FirstOrDefault(item => item.Id == id);
            if(formation == null)
            {
                return this.RedirectToAction("Index", "Formation");
            }
            

            return this.View(formation);
        }
    }
}
