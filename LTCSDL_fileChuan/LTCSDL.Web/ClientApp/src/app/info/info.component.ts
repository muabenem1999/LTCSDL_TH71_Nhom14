import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css']
})
export class InfoComponent implements OnInit {

  Customers:any ={
    data:[]
  }
  value = {
    idC:13
  }

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) { }

  ngOnInit() {
    this.searchCustomer();
  }

  searchCustomer(){
    let x={}
    this.http.post("https://localhost:44392/api/searchCustomer/get-all-customer",x).subscribe(result =>{
      this.Customers = result;
      this.Customers = this.Customers.data
      console.log(this.Customers)
    },error=>console.error(error));
  }
  getValue(d:number){
    this.value.idC = d
  }
  deleteCustomer(){
  let y =this.value
    this.http.post("https://localhost:44392/api/Customer/detele-customer",y).subscribe(result =>{
      this.Customers = result;
      window.location.reload();
    },error=>console.error(error));
  }

}
