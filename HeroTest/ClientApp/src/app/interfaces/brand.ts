import { Hero } from "./hero";

export interface Brand {
    Id:number;
    Name:string; 
    IsActive:boolean; 
    Heroes?: Hero[]
}