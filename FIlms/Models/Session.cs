using System.ComponentModel.DataAnnotations.Schema;

namespace FIlms.Models
{
    public class Session
    {
        [ForeignKey("Id")]
        public int Id { get; set; }
        public int FilmId { get; set; }
        public DateTime Time { get; set; }

    }
}
