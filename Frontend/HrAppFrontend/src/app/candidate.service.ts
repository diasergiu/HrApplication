import { Injectable } from '@angular/core';
import { HttpHeaders,HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  private headers: HttpHeaders;
  private accesPointUrl: string = "https://localhost:44334/Candidates";
 
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'content-Type': 'application/json; charset=uft-8'})
   }

   public get(){
     return this.http.get(this.accesPointUrl, {headers: this.headers});
   }
   
   public add(payload){
     return this.http.post(this.accesPointUrl, payload, {headers : this.headers} );
   }

   public remove(payload){
     return this.http.delete(this.accesPointUrl + '/' + payload.id, {headers : this.headers});
   }

   public update(payload){
     return this.http.put(this.accesPointUrl + '/' + payload.id, payload, {headers : this.headers} );
   }
}
