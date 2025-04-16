import { Component } from '@angular/core';
import { HeaderComponent } from "./layout/header/header.component";
import { ShopComponent } from './features/shop/shop.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, ShopComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Skinet';
}
