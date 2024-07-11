import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { firstValueFrom } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UrlConverterService {
  private url = environment.apiUrl;
  private headers = new HttpHeaders({
    'Access-Control-Allow-Origin': '*',
    'Content-Type': 'application/json'
  });

  constructor(private http: HttpClient) { }

  getAll() {
    return firstValueFrom(this.http.get(`${this.url}/api/Link`, { headers: this.headers }));
  }

  convert(param: string) {
    return firstValueFrom(this.http.post(`${this.url}/api/Link`, {url: param }));
  }
}