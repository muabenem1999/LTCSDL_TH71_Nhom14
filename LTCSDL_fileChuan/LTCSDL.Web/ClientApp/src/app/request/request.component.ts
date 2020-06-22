import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from 'src/assets/customer';
declare var $:any;

@Component({
  selector: 'app-request',
  templateUrl: './request.component.html',
  styleUrls: ['./request.component.css']
})
export class RequestComponent implements OnInit {

  customer:any={
    idC:"",
    FullName:"vuong",
    Email:"vuongpro",
    Phone:1234
  }

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) { }

  ngOnInit(){
    this.newCus();
  }
  newCus(){
    this.customer={
      FullName:"",
      Email:"",
      Phone:0
    }
  }

  addCustomer(){
    var x = this.customer;
    this.http.post("https://localhost:44392/api/Customer/create-customer",x).subscribe(result =>{
      var res:any = result;
      if(res.success){
        this.customer = res.data;
        window.location.reload();
      }
    },error=>console.error(error));
  }


}
