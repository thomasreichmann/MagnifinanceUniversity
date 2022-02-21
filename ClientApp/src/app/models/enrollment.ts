import Student from './student';
import Subject from './subject';

export default interface Enrollment {
  enrolmentId: number;
  subjectId: number;
  grade?: number;
  subject: Subject;
  student: Student;
}
