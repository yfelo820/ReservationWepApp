import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public reservations: Reservation[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Reservation[]>(baseUrl + 'master').subscribe(result => {
      this.reservations = result;
    }, error => console.error(error));
  }
}

interface Reservation {
  place: string;
  date: string;
  rank: number;
}
