import { Component } from '@angular/core';
import { HeroService } from '../services/heroservice/hero.service';
import { Hero } from '../interfaces/hero';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BrandService } from '../services/brandservice/brand.service';
import { Brand } from '../interfaces/brand';

@Component({
  selector: 'app-add-hero',
  templateUrl: './add-hero.component.html',
  styleUrls: ['./add-hero.component.css']
})
export class AddHeroComponent {
  addHeroResult:string='';
  heroObj!:Hero;
  addHeroForm!: FormGroup;
  brandsList:Brand[]=[];

  constructor(private heroService:HeroService,private fb: FormBuilder,private brandService:BrandService){
    this.addHeroForm = this.fb.group({
      Name:['',Validators.required] ,
      Alias: ['',Validators.required],
      Brand: ['',Validators.required]
    });
  }
  ngOnInit(){
    this.brandService.getAllBrands().subscribe(result=>{
      this.brandsList=result;
    })
  }
  addHero(){
    this.heroService.addHero(this.addHeroForm.value).subscribe(result=>{
      this.addHeroResult=result;
    })
    location.href='';
    
  }

}
