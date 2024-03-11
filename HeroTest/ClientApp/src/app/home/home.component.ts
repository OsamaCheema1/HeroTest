import { Component } from '@angular/core';
import { HeroService } from '../services/heroservice/hero.service';
import { Hero } from '../interfaces/hero';
import { NgOptimizedImage } from '@angular/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  heroesList: Hero[] = [];
  deleteHeroResult:string='';
  constructor(private heroService:HeroService){}
  ngOnInit(){
    this.heroService.getAllHeroes().subscribe(result=>{
      this.heroesList=result;
    })
  }
  deleteHero(heroId:number){
    this.heroService.deleteHero(heroId).subscribe(result=>{
      this.deleteHeroResult=result;
      
    })
    location.reload();
    
  }
}
