import { UserService } from '../user.service';
import { DataService } from '../data.service';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { User } from '../User';


@Component({
  selector: 'app-home',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {
  user: User;
  toolkit: number;
  food: number;
  water: number;
  wood: number;
  health: number;
 
  constructor(private userservice: UserService, private dataservice: DataService, private router: Router) { }

  ngOnInit() {
    //this.userservice.get().subscribe((data: any) => this.users = data);
    this.toolkit = this.dataservice.curUser.ToolKit;
    this.food = this.dataservice.curUser.Food;
    this.water = this.dataservice.curUser.Water;
    this.wood = this.dataservice.curUser.Wood;
    this.health = this.dataservice.curUser.Health;
  }

  
  exploreBoat(item: string) {
   // console.log("test");
    this.userservice.updateitem(item).subscribe((data: any) => {
    this.user = data;
      console.log(this.user);
      this.toolkit = this.user['toolKit'];

    });

    (<HTMLElement>document.getElementById("boat")).setAttribute('disabled', 'disabled');
    alert("You find a tool kit! Now explore more with the tool kit! ");
    (<HTMLInputElement>document.getElementById("forest")).disabled = false;
    (<HTMLInputElement>document.getElementById("danger")).disabled = false;
    (<HTMLInputElement>document.getElementById("lake")).disabled = false;
    (<HTMLInputElement>document.getElementById("animal")).disabled = false;
  }

  forest() {
    (<HTMLInputElement>document.getElementById("p2")).style.display = "inline";
    alert("You find a forest! Now you can search in the forest.");
    
  }

  exploreForest(item: string) {
    this.userservice.updateitem(item).subscribe((data: any) => {
      this.user = data;
      console.log(this.user);
      this.wood = this.user['wood'];
    });
    alert("You find some wood! The wood could be used to build a boat.");
    
  }

  lake() {
    (<HTMLInputElement>document.getElementById("p4")).style.display = "inline";
    alert("You find a lake! Now you can search this area.");
    
  }

  exploreLake(item: string) {
    this.userservice.updateitem(item).subscribe((data: any) => {
      this.user = data;
      console.log(this.user);
      this.water = this.user['water'];
    });
    alert("Now we have water to drink.");
  }

  danger() {
    (<HTMLInputElement>document.getElementById("p3")).style.display = "inline";
    this.dangerroute();
    
  }
  dangerroute() {
    alert("Oops! You are caught by a monster! The game is over.");
    this.router.navigate(['gameover']);
  }

  animal() {
    (<HTMLInputElement>document.getElementById("p5")).style.display = "inline";
    alert("There are some animals in this area!");

  }

  exploreAnimal(item: string) {
    this.userservice.updateitem(item).subscribe((data: any) => {
      this.user = data;
      console.log(this.user);
      this.food = this.user['food'];
    });
    alert("We get something to eat.");
  }

  createBoat() {
    if ((this.food + this.water) >= 100 && this.wood >= 150) {
      alert("Congratulations! You have successfully built a boat! Now you can go home!")
      this.router.navigate(['congratulation']);
    }
    else {
      alert("You don't have enough resources to build a boat.");
    }
  }
}
