import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import Student from '../models/student';

@Injectable({
  providedIn: 'root',
})
export class StudentService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {}

  getStudents() {
    return this.http.get<Student[]>(this.baseUrl + 'api/students');
  }

  getStudent(id: string) {
    return this.http.get<Student>(this.baseUrl + `api/students/${id}`);
  }
}
