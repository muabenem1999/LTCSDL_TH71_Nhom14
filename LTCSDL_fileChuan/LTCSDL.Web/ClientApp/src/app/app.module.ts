import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { HeaderComponent } from './header/header.component';
import { ServicesComponent } from './services/services.component';
import { DetailsComponent } from './details/details.component';
import { PricingComponent } from './pricing/pricing.component';
import { RequestComponent } from './request/request.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { InfoComponent } from './info/info.component';


@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    HeaderComponent,
    ServicesComponent,
    DetailsComponent,
    PricingComponent,
    RequestComponent,
    AboutComponent,
    ContactComponent,
    InfoComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    { provide: 'BASE_URL', useFactory: getBaseUrl }
],
  bootstrap: [AppComponent]
})
export class AppModule { }
export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}
