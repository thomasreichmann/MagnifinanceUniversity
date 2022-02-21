import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Enrollment from '../models/enrollment';
import Student from '../models/student';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css'],
})
export class StudentsComponent {
  displayedColumns: string[] = ['id', 'name', 'birthDay', 'enrollments'];
  students: Student[] = [];

  constructor(
    private studentService: StudentService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    let s = studentService.getStudents();
    s.subscribe((data) => {
      console.log(data);
      this.students = data;
    });
  }

  getDate(dateStr: string) {
    let date = new Date(dateStr);
    var month = date.getUTCMonth() + 1; //months from 1-12
    var day = date.getUTCDate();
    var year = date.getUTCFullYear();

    return day + '-' + month + '-' + year;
  }

  getEnrollmentsResume(enrollments: Enrollment[]) {
    let resume = '';

    for (let i = 0; i < enrollments.length; i++) {
      const enrollment = enrollments[i];
      resume += `${enrollment.subject.title} {${enrollment.grade || '-'}}`;

      if (i < enrollments.length - 1) {
        resume += ', ';
      }
    }

    if (!resume) {
      resume = 'None';
    }

    return resume;
  }
}
