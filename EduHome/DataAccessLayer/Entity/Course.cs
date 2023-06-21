using System.ComponentModel.DataAnnotations;

namespace EduHome.DataAccessLayer.Entity
{
    public class Course
    {
        public int Id { get; set; }
        [Required ,MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string? Link { get; set; }
    }
}
