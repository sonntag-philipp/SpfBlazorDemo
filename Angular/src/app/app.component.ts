import {Component, OnInit} from '@angular/core';
import * as signalR from '@aspnet/signalr';

@Component({
  selector: 'spfa-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  private hubConnection = new signalR.HubConnectionBuilder()
    .withUrl('https://localhost:5001/spfHub')
    .build();

  public messages: string[] = [];

  constructor() {

  }

  public ngOnInit(): void {
    this.hubConnection.start()
        .then(() => console.log('Connected!'))
        .catch(err => console.log('Error while starting connection: ' + err));

    this.hubConnection.on('BroadcastAsync', (msg: string) => {
      this.messages.push(msg);
    });
  }

  public sendMessage(): void {
    this.hubConnection.invoke('BroadcastAsync', 'Hallo von Angular :D')
      .catch(err => console.log);
  }
}
