import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pricing',
  templateUrl: './pricing.component.html',
  styleUrls: ['./pricing.component.css']
})
export class PricingComponent implements OnInit {

  request:any ={
    data:[]
  }


  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) { }


  ngOnInit(): void {
    this.addCustomer2();
  }
  
  addCustomer2(){
    let x={}
    this.http.post("https://localhost:44392/api/Request/get-all",x).subscribe(result =>{
      this.request = result;
      this.request = this.request.data
      console.log(this.request)
    },error=>console.error(error));
  }
  

}
class Requesta{
  id: number;
  Name:string;
  Price:number;
    
}
