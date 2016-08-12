using PeopleDB.DAL;
using System.Web.Mvc;

namespace PeopleDB.Controllers
{
    public class FileController : Controller
    {
        private SchoolContext db = new SchoolContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            try
            {
                var fileToRetrieve = db.Files.Find(id);
                return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
            }
            catch (System.Exception ex)
            {
                return View();
            }
          
        }
    }
}