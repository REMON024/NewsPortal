import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
{ path: 'auth', loadChildren: () => import('./Module/auth/auth.module').then(m => m.AuthModule) },
{ path: 'user', loadChildren: () => import('./Module/user/user.module').then(m => m.UserModule) },
{ path: 'admins', loadChildren: () => import('./Module/admins/admins.module').then(m => m.AdminsModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true})],
  exports: [RouterModule]
})
 export class AppRoutingModule { }
