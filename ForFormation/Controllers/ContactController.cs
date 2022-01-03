using Microsoft.AspNetCore.Mvc;

namespace ForFormation.Controllers
{
    public class ContactController : Controller
    {
        #region Private
        private DefaultContext _context = null;
        #endregion
        #region Constructeur
        public ContactController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Contact contact)
        {
            if (ModelState.IsValid)
            {
                this._context.Contact.Add(contact);
                this._context.SaveChanges();
            }
            return this.View(contact);
        }
    }
}
