import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { UserService } from './user.service';
import { DataService } from './data.service';
import { LogoutComponent } from './logout/logout.component';
import { GameComponent } from './game/game.component';
import { GameoverComponent } from './gameover/gameover.component';
import { CongratulationComponent } from './congratulation/congratulation.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    LoginComponent,
    MainComponent,
    LogoutComponent,
    GameComponent,
    GameoverComponent,
    CongratulationComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
      { path: 'logout', component: LogoutComponent },
      { path: 'main', component: MainComponent },
      { path: 'game', component: GameComponent },
      { path: 'congratulation', component: CongratulationComponent },
      { path: 'gameover', component: GameoverComponent },

    ])
  ],
  providers: [UserService, DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
