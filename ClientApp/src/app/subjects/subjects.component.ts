import { Component } from '@angular/core';
import Subject from '../models/subject';
import { SubjectService } from '../services/subject.service';

@Component({
  selector: 'app-subjects',
  templateUrl: './subjects.component.html',
  styleUrls: ['./subjects.component.css'],
})
export class SubjectsComponent {
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
