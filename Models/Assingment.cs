namespace MagnifinanceUniversity.Models
{
    public class Assingment
    {
        public int AssingmentID { get; set; }
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
