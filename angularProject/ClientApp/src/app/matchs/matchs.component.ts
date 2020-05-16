import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-matchs',
  templateUrl: './matchs.component.html'
})
export class MatchsComponent {
  public matchs: Matchs[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Matchs[]>(baseUrl + 'game/matchs').subscribe(result => {
      this.matchs = result;
    }, error => console.error(error));
  }
}

interface Matchs {
  name: string;
  teamA: string;
  teamB: string;
}
