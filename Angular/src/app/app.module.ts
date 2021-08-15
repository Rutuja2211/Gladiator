import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Pipe} from '@angular/core';
import { FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ContactComponent } from './contact/contact.component';
import { ContactService } from './service/contactService';
import { AddcontactComponent } from './addcontact/addcontact.component';
import{Routes,RouterModule} from '@angular/router';
import { SurnameFilterPipe } from './surname-filter.pipe';

var myRoutes:Routes=[
  //{path:"addContact",component:AddcontactComponent},
  
];


@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    ContactComponent,
    AddcontactComponent,
    SurnameFilterPipe,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(myRoutes),

  ],
  providers: [ContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }
