import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Tasks
{
  id: number;
  nombre: string;
  prioridad: string;
  estado: string;

}


@Injectable
  (
    { providedIn: 'root' }
  )

export class TasksService {

  private apiUrl = 'https://localhost:7169/';

  constructor(private http: HttpClient) { }

  getListado(): Observable<Tasks[]> {
    return this.http.get<Tasks[]>(this.apiUrl);
  }

}
