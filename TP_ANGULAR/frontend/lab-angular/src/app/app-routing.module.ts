import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { ClientesFormComponent } from './modules/clientes/clientes-form/clientes-form.component';
import { ClientesListComponent } from './modules/clientes/clientes-list/clientes-list.component';



const routes: Routes = [
  
  {path:'' , component: ClientesListComponent },
  {path:'form/Modify/:id' , component:ClientesFormComponent , data:{ 'onModify':true}},
  {path:'form/New' , component:ClientesFormComponent , data:{ 'onModify':false}},
  {path:'about', component: AboutComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
