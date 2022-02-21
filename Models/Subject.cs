using System.ComponentModel.DataAnnotations.Schema;

namespace MagnifinanceUniversity.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Assingment> Assingments { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}
