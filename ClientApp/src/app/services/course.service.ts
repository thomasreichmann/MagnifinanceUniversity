import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import Course from '../models/course';

@Injectable({
  providedIn: 'root',
})
export class CourseService {
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {}

  getCourses() {
    return this.http.get<Course[]>(this.baseUrl + 'api/courses');
  }
}
