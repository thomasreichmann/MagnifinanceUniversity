import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import Teacher from '../models/teacher';

@Injectable({
  providedIn: 'root',
})
export class TeacherService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {}

  getTeachers() {
    return this.http.get<Teacher[]>(this.baseUrl + 'api/teachers');
  }
}
