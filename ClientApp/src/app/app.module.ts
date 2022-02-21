import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { UsersComponent } from './users/users.component';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { StudentsComponent } from './students/students.component';
import { CoursesComponent } from './courses/courses.component';
import { TeachersComponent } from './teachers/teachers.component';
import { SubjectsComponent } from './subjects/subjects.component';

let materialImports = [
  MatSliderModule,
  MatSidenavModule,
  MatButtonModule,
  MatTableModule,
  MatInputModule,
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FetchDataComponent,
    NavMenuComponent,
    UsersComponent,
    StudentsComponent,
    CoursesComponent,
    TeachersComponent,
    SubjectsComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'students', component: StudentsComponent },
      { path: 'courses', component: CoursesComponent },
      { path: 'teachers', component: TeachersComponent },
      { path: 'subjects', component: SubjectsComponent },
    ]),
    BrowserAnimationsModule,
    ...materialImports,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
