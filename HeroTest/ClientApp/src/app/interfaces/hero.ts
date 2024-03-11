import { Brand } from "./brand";

export interface Hero{
    Id:number;
    Name:string;
    Alias:string;
    IsActive:boolean; 
    BrandId:number;
    Brand?:Brand 
}