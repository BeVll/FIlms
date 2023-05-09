using System.ComponentModel.DataAnnotations.Schema;

namespace FIlms.Models
{
    public class Film
    {
        [ForeignKey("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
    }
}
