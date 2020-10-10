import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// Describes how application parts fit together

// NgModule decorator identifies AppModule as a Angular module class
// imports - BrowserModule that this and every application needs to run
// declarations - application's lone component which is also..
// bootstrap - root component that angular creates and inserts into

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
