import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandidateComponent } from './candidate/candidate.component';
import { CandidateService } from './candidate.service';
import { CandidateListComponent } from './candidate-list/candidate-list.component';
import { UserCreateComponent } from './user/user-create/user-create.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { UserEditComponent } from './user/user-edit/user-edit.component';
import { UserComponent } from './user/user.component';
import { UserService } from './shered/user.service';

@NgModule({
  declarations: [
    AppComponent,
    CandidateComponent,
    CandidateListComponent,
    UserCreateComponent,
    UserLoginComponent,
    UserEditComponent,
    UserComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    CandidateService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
