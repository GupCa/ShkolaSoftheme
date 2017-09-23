import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { FavoriteBooksService } from '../services/favorite-books.service';
import { FavoriteBook } from '../models/favoritebook.model';

@Component({
  selector: 'app-favorite-books-list',
  templateUrl: './favorite-books-list.component.html',
  styleUrls: ['./favorite-books-list.component.css']
})
export class FavoriteBooksListComponent implements OnInit {

  favoritebooks$: Observable<FavoriteBook[]>;

  constructor(private favoriteBooksService: FavoriteBooksService) {
  }

  ngOnInit() {
    this.favoritebooks$ = this.favoriteBooksService.getFavoriteBooks();
  }

}
