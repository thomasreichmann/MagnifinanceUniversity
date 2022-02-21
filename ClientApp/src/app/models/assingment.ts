import Subject from './subject';
import Teacher from './teacher';

export default interface Assingment {
  assignmentId: number;
  subjectId: number;
  teacherId: number;
  subject: Subject;
  teacher: Teacher;
}
