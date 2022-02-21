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
import { TeacherService } from '../services/teacher.service';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css'],
})
export class TeachersComponent {
  displayedColumns: string[] = [
    'id',
    'name',
    'salary',
    'birthDay',
    'assignments',
  ];
  teachers: Teacher[] = [];

  constructor(private teacherService: TeacherService) {
    let s = teacherService.getTeachers();
    s.subscribe((data) => {
      console.log(data);
      this.teachers = data;
    });
  }

  getDate(dateStr: string) {
    let date = new Date(dateStr);
    var month = date.getUTCMonth() + 1; //months from 1-12
    var day = date.getUTCDate();
    var year = date.getUTCFullYear();

    return day + '-' + month + '-' + year;
  }

  getAssignmentsResume(assignments: Assingment[]) {
    let resume = '';

    for (let i = 0; i < assignments.length; i++) {
      const assignment = assignments[i];
      resume += `${assignment.subject.title}`;

      if (i < assignments.length - 1) {
        resume += ', ';
      }
    }

    if (!resume) {
      resume = 'None';
    }

    return resume;
  }
}
