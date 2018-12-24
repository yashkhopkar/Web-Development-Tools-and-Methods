import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-gameover',
  templateUrl: './gameover.component.html',
  styleUrls: ['./gameover.component.css']
})
export class GameoverComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  restart() {
    this.router.navigate(['main']);
    
  }

}
