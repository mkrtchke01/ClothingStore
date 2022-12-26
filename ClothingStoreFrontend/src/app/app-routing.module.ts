import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/account/login/login.component';
import { RegisterComponent } from './components/account/register/register.component';
import { CatalogComponent } from './components/catalog/catalog.component';
import { AuthGuard } from './shared/guards/auth.guard';

const routes: Routes = [
  {path: 'SignIn', component: LoginComponent},
  {path:'SignUp', component: RegisterComponent},

  {path: '', component: CatalogComponent, canActivate: [AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
