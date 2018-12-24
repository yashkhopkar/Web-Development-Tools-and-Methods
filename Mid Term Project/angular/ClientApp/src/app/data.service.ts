import { Injectable } from '@angular/core';
import { User } from './User';

@Injectable()
export class DataService {
  curUser: User = {
    UserId: -1,
    UserName: '',
    PassWord: '',
    Health: 100,
    Water: 10,
    Food: 0,
    Wood: 0,
    ToolKit: 0
  };
}

