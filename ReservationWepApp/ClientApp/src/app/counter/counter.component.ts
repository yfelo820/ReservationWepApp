import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent {
  
  public name:string = "";
  public type:string = "";
  public phone:string = "";
  public birthdate:string = ""; 

  public place:string = "";
  public rank:string = "";
  public date:string = "";  

  public opcionSeleccionado: string = '0';
  public contactIdSelect: string = '0';
  public contactId: string = '0';
  public contactIdNumber: number = 0;
  public contacts: Contact[];
  public contact: Contact = { name : " ", type : " ", phone : " ", birthDate : " " };

  public reservation: Reservation = { contactId : 0, place : " ", rank : 0, date : " " };

         http: HttpClient;
         baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;

        http.get<Contact[]>(baseUrl + 'master/contacts').subscribe(result => {
          this.contacts = result;
        }, error => console.error(error));
  }

  public addContact() {
    
    this.contact.name = this.name;
    this.contact.type = this.type;
    this.contact.phone = this.phone;
    this.contact.birthDate = this.birthdate;    
    //console.log(this.contact.name+" and "+this.contact.date); 
    //console.log("Al menos aqui llego: "+ this.name+" "+this.type+" "+this.phone+" "+this.date);          
    this.http.post<Contact>(this.baseUrl+'master/contact',this.contact).subscribe(
      result => { this.contact = result; console.log("inserte bien"); },
      error => console.error(error));     
    }

  public capturar(){
    this.type = this.opcionSeleccionado;
    console.log("Cambio");
  }

  public createReservation(){  

    this.reservation.contactId = this.contactIdNumber;  
    this.reservation.place = this.place;
    this.reservation.rank = Number(this.rank);
    this.reservation.date = this.date;
    //console.log(this.reservation.contactId+" - "+this.reservation.place+" - "+this.reservation.rank+" - "+this.reservation.date)

    this.http.post<Reservation>(this.baseUrl+'master/reservation',this.reservation).subscribe(
      result => { 
                  this.reservation = result;  
                  this.place = "";
                  this.rank = "";
                },
      error => console.error(error));    
  }

  public selectId()
  {
    this.contactId = this.contactIdSelect;

    console.log("contact Id: "+this.contactId);
    console.log("contact IdSelected: "+this.contactIdSelect);

    const params = new HttpParams()
    .set('name', this.contactId);

    this.http.get<number>(this.baseUrl + 'master/contactId',{params}).subscribe(result => {
      this.contactIdNumber = result;
      //console.log("contact IdNumber: "+this.contactIdNumber);
    }, error => console.error(error));      
  }

}

interface Contact {
  name: string;
  type: string;
  phone: string;
  birthDate: string;
}

interface Reservation {
  contactId: number;
  place: string;
  date: string;
  rank: number;
}
