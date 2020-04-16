import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'spfa-blazor',
  templateUrl: './blazor.component.html',
  styleUrls: ['./blazor.component.scss']
})
export class BlazorComponent implements OnInit {

  public blazorPage = '';

  constructor(private httpClient: HttpClient) {
    httpClient.get<string>('https://localhost:5001').subscribe(
      blazorPage => {
        this.blazorPage = blazorPage;
      }
    );
  }

  ngOnInit(): void {
  }

}
