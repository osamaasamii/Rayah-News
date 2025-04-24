using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rayah_News.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Data { get; set; }
        public string Topic { get; set; }
        public string Image {  get; set; }

        [ForeignKey("Category")]
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
