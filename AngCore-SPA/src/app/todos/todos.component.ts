import { Component, OnInit } from '@angular/core';
import { Todo, TodosLoaderService } from './todo-loader.service';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {
todosData: Todo[] = [];
  constructor(svc: TodosLoaderService) {
    // TODO: use OnInit to load
    svc.loadTodos()
      .subscribe(todos => this.todosData = todos);
   }

  ngOnInit() {
  }

}
