import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html'
})
export class TeamsComponent {
  public teams: Teams[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Teams[]>(baseUrl + 'game/teams').subscribe(result => {
      this.teams = result;
    }, error => console.error(error));
  }
}

interface Teams {
  name: string;
  player1: string;
  player2: string;
  player3: string;
  player4: string;
  player5: string;
  player6: string;
  player7: string;
  player8: string;
  player9: string;
}
