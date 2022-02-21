namespace MagnifinanceUniversity.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public double Salary { get; set; }
        public virtual ICollection<Assingment> Assingments { get; set; }
    }
}
