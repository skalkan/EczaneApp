import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eczane',
  templateUrl: './eczane.component.html',
  styleUrls: ['./eczane.component.css']
})
export class EczaneComponent implements OnInit {
  eczanes: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEczanes();
  }

  getEczanes() {
    this.http.get('https://localhost:5001/api/eczanes').subscribe(response => {
      this.eczanes = response;
    }, error => {
      console.log(error);
    });
  }

}
