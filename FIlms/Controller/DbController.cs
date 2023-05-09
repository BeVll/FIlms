using FIlms.Datebase;
using FIlms.Models;

namespace FIlms.Controller
{
    public class DbController
    {
        DBContext db;
        public DbController()
        {
            db = new DBContext();           
        }
        public List<Film> GetFilms()
        {
            return db.Films.ToList();
        }
        public Session GetSession(int id)
        {
            return db.Sessions.Where(s => s.Id == id).First();
        }
    }
}
