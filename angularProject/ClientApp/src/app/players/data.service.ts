import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Players } from './playersModel';

@Injectable()
export class DataService {

  private url = "/game/players";

  constructor(private http: HttpClient) {
  }

  getPlayers() {
    return this.http.get(this.url);
  }

  getPlayer(id: string) {
    return this.http.get(this.url + '/' + id);
  }

  createPlayer(player: Players) {
    return this.http.post(this.url, player);
  }
  updatePlayer(player: Players) {
    return this.http.put(this.url, player);
  }
  deletePlayer(id: string) {
    return this.http.delete(this.url + '/' + id);
  }
}
