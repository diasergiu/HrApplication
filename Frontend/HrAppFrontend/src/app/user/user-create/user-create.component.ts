import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shered/user.service';
import { NgForm } from '@angular/forms';
import { User } from 'src/app/shered/user.model';

@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html',
  styleUrls: ['./user-create.component.css']
})
export class UserCreateComponent implements OnInit {

  
  constructor(private service : UserService) { }

  user : User;

  ngOnInit() {
    this.user = new User();
    this.reset();
  }

  onSubmit(form : NgForm){
    this.service.PostNewUser(form.value).subscribe(
      res =>{
        this.reset();
      },
      err => {
        console.log(err);
      }
    )
  }
  
  reset(form?: NgForm){
    ("it works");
    if(form != null){
      form.form.reset();
      this.service.formData = {
        idUser: 0,
        userName: '',
        firstName : '',
        lastName : '',
        password : '',
      }
    }
  }

}
