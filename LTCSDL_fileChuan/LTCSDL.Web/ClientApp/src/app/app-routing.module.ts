import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms'

import { HeaderComponent } from './header/header.component';
import { ServicesComponent } from './services/services.component';
import { DetailsComponent } from './details/details.component';
import { PricingComponent } from './pricing/pricing.component';
import { RequestComponent } from './request/request.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { from } from 'rxjs';
import { InfoComponent } from './info/info.component';

const routes: Routes = [
  { path: 'home', component: HeaderComponent,pathMatch: 'full' },
  { path: 'services', component: ServicesComponent },
  { path: 'details', component: DetailsComponent },
  { path: 'pricing', component: PricingComponent },
  { path: 'request', component: RequestComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'info', component: InfoComponent }
];

@NgModule({
  imports: 
    [CommonModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)],
    declarations: [],
  exports: [RouterModule]
})
export class AppRoutingModule { }
