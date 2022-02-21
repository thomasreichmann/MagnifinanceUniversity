import Assingment from './assingment';

export default interface Teacher {
  id: number;
  name: string;
  birthDay: Date;
  salary: number;
  assignments: Assingment[];
}
