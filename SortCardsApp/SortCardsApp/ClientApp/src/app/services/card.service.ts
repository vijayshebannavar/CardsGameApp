import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  sortCards(inputs:string[]){
    var body = inputs;

    return this.http.post<string[]>(this.baseUrl + 'cards', body)
  }
}
