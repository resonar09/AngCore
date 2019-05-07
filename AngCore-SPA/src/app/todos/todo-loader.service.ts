import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const apiUrl = 'http://localhost:5000/api';

export interface Todo {
  name: string;
  description: string;
  completed: boolean;
}

@Injectable({
  // This service should be created
  // by the root application injector.
  providedIn: 'root'
})
export class TodosLoaderService {

  constructor(private http: HttpClient) { }

  loadTodos(): Observable<Todo[]> {
    return this.http.get<Todo[]>(apiUrl + '/todos');
  }
}
