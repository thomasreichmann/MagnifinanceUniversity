import Enrollment from './enrollment';

export default interface Student {
  id: number;
  name: string;
  birthDay: Date;
  enrolments: Enrollment[];
}
