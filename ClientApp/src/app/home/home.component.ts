import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Assingment from '../models/assingment';
import Course from '../models/course';
import Enrollment from '../models/enrollment';
import Student from '../models/student';
import Subject from '../models/subject';
import Teacher from '../models/teacher';
import { CourseService } from '../services/course.service';
import { StudentService } from '../services/student.service';
import { SubjectService } from '../services/subject.service';
import { TeacherService } from '../services/teacher.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  displayedColumns: string[] = ['id', 'name'];
  subjects: Subject[] = [];

  constructor(private subjectService: SubjectService) {
    let s = subjectService.getSubjects();
    s.subscribe((data) => {
      console.log(data);
      this.subjects = data;
    });
  }
}
