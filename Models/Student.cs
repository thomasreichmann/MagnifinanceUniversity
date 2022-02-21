namespace MagnifinanceUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
