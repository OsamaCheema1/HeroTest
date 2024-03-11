import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Brand } from 'src/app/interfaces/brand';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BrandService {
  constructor(private http:HttpClient) { }
  getAllBrands(){
    return this.http.get<Brand[]>('https://localhost:7014/Heroes/GetALLBrands');
  }
}
