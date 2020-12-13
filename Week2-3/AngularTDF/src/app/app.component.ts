import { Component } from '@angular/core';
import { User } from './user';
import { EnrollmentService } from './enrollment.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  topics = ['Angular', 'React', 'DotNet' , 'Redux'];
  userModel = new User('Sonal', 'sonal@test.com', 5342526265, 'default', 'morning', true);
  topicHasError = true;
  submitted = false;
  errorMsg = '';

  constructor(private _enrollmentService: EnrollmentService) {}

  validateTopic(value) {
    if (value === 'default') {
      this.topicHasError = true;
    } else {
      this.topicHasError = false;
    }
  }

  onSubmit() {
    this.submitted = true;
    this._enrollmentService.enroll(this.userModel)
      .subscribe(
        response => console.log('Success!', response),
        error => this.errorMsg = error.statusText
      )
  }
}