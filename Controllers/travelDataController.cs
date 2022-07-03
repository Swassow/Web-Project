using logindemo.Data;
using logindemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace logindemo.Controllers
{
    public class travelDataController : Controller    
    {
        private readonly ApplicationDbContext _db;
        public travelDataController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<travelData> objTravelData = _db.travelDatas;
            return View(objTravelData);
        }
    }
}
