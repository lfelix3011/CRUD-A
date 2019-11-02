import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CRUDComponent } from './Components/crud/crud.component';
import { CRUDItemComponent } from './Components/crud-item/crud-item.component';
import { NavComponent } from './Components/nav/nav.component';
import { CrudInputComponent } from './Components/crud-input/crud-input.component';
import { SectorService } from './Services/sector.service';



@NgModule({
  declarations: [
    AppComponent,
    CRUDComponent,
    CRUDItemComponent,
    NavComponent,
    CrudInputComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()

  ],
  providers: [SectorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
