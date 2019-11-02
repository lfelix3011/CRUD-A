import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CRUDComponent } from './Components/crud/crud.component';


const routes: Routes = [
  {path: '', redirectTo: '/crud', pathMatch: 'full'},
  {path: 'crud', component: CRUDComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
