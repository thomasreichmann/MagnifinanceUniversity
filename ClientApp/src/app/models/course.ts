import Subject from './subject';

export default interface Course {
  id: number;
  name: string;
  subjects: Subject[];
}
