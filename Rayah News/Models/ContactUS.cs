using System.ComponentModel.DataAnnotations;

namespace Rayah_News.Models
{
    public class ContactUS
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }

    }
}
