import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Players } from './playersModel';
import { DataService } from './data.service';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  providers: [DataService]
})
export class PlayersComponent implements OnInit {
  player: Players = new Players();   
  players: Players[];               
  tableMode: boolean = true;          

  constructor(private dataService: DataService) { }
  ngOnInit() {
    this.loadPlayers();    // загрузка данных при старте компонента  
  }

   // получаем данные через сервис
  loadPlayers() {
    this.dataService.getPlayers()
      .subscribe((data: Players[]) => this.players = data);
  }

  // создание данных
  create() {
    if (this.player.Id == null) {
      this.dataService.createPlayer(this.player)
        .subscribe((data: Players) => this.players.push(data));
    } 
    this.cancel();
  }

  // обновление
  update() {
    this.dataService.updatePlayer(this.player)
      .subscribe(data => this.loadPlayers());
  }

  editPlayer(p: Players) {
    this.player = p;
  }
  cancel() {
    this.player = new Players();
    this.tableMode = true;
  }
  delete(p: Players) {
    this.dataService.deletePlayer(p.Id)
      .subscribe(data => this.loadPlayers());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
}

