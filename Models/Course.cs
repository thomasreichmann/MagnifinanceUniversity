namespace MagnifinanceUniversity.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
