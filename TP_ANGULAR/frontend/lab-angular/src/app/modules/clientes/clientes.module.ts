import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientesFormComponent } from './clientes-form/clientes-form.component';
import { ClientesListComponent } from './clientes-list/clientes-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    ClientesFormComponent,
    ClientesListComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RouterModule,
    AppRoutingModule,
    HttpClientModule,
    
  ],  
  exports:[
    ClientesFormComponent,
    ClientesListComponent
  ]
})
export class ClientesModule { }
