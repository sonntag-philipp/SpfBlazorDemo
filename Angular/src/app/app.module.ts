import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {MatButtonModule} from '@angular/material/button';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {FlexLayoutModule} from '@angular/flex-layout';
import {MatListModule} from '@angular/material/list';
import {MatCardModule} from '@angular/material/card';
import { BlazorComponent } from './blazor/blazor.component';

@NgModule({
  declarations: [
    AppComponent,
    BlazorComponent
  ],
  imports: [
    BrowserModule,
    MatButtonModule,
    MatListModule,
    MatCardModule,
    FlexLayoutModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
