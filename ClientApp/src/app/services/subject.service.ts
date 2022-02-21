import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import Subject from '../models/subject';
import Teacher from '../models/teacher';

@Injectable({
  providedIn: 'root',
})
export class SubjectService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {}

  getSubjects() {
    return this.http.get<Subject[]>(this.baseUrl + 'api/subjects');
  }
}
