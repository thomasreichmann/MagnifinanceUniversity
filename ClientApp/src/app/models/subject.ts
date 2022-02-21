import Assingment from './assingment';
import Course from './course';
import Enrollment from './enrollment';

export default interface Subject {
  subjectId: number;
  title: string;
  assingments: Assingment[];
  enrolments: Enrollment[];
  courseId: number;
  course: Course;
}
