import { Injectable } from '@angular/core';
import { User } from './user.model';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class UserService {

  formData : User
  readonly rootUrl = 'https://localhost:44334/Users';
  constructor(private http : HttpClient) { }

  PostNewUser(formData: User){
    console.log(formData.userName + " " + formData.firstName + " " + formData.idUser+ " " + formData.lastName);
   return this.http.post(this.rootUrl ,formData)
  }
}
