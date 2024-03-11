import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Hero } from 'src/app/interfaces/hero';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HeroService {
  constructor(private http:HttpClient) { }
  getAllHeroes(){
    return this.http.get<Hero[]>('https://localhost:7014/Heroes/GetAllHeroes');
  }
  deleteHero(heroId:number){
    return this.http.delete<string>('https://localhost:7014/Heroes/DeleteHero/'+heroId);
  }
  addHero(hero:any){
    return this.http.post<string>('https://localhost:7014/Heroes/AddHero',hero);
  }
}
