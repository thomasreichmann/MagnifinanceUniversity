import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Course from '../models/course';
import Enrollment from '../models/enrollment';
import Student from '../models/student';
import Subject from '../models/subject';
import { CourseService } from '../services/course.service';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css'],
})
export class CoursesComponent {
  displayedColumns: string[] = ['id', 'name', 'subjects'];
  courses: Course[] = [];

  constructor(private courseService: CourseService) {
    let s = courseService.getCourses();
    s.subscribe((data) => {
      console.log(data);
      this.courses = data;
    });
  }

  getSubjectsResume(subjects: Subject[]) {
    let resume = '';

    for (let i = 0; i < subjects.length; i++) {
      const subject = subjects[i];
      resume += `${subject.title}`;

      if (i < subjects.length - 1) {
        resume += ', ';
      }
    }

    if (!resume) {
      resume = 'None';
    }

    return resume;
  }
}
