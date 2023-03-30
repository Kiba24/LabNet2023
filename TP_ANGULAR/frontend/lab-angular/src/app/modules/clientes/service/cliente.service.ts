import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from 'src/app/models/cliente';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  endpoint:string = 'customers';
  

  constructor(private httpclient:HttpClient) { }

  public GetClientes() : Observable<Array<Cliente>>
  {
    let url = environment.api + this.endpoint;
    return this.httpclient.get<Array<Cliente>>(url);
  }

  public UpdateClientes( cliente : Cliente) : Observable<any>{
    let url = environment.api + this.endpoint;
    return this.httpclient.put(url,cliente);
  }

  public GetClienteById(id:string) : Observable<any>{
    let url = environment.api + this.endpoint;
    return this.httpclient.get(url + "/" + id);
  }

  public DeleteCliente(id: string): Observable<any> {
    let url = environment.api + this.endpoint;
    return this.httpclient.delete(url + "/" + id);
  }

  public InsertarCliente(cliente:Cliente) : Observable<any>{
    let url = environment.api + this.endpoint;
    return this.httpclient.post(url,cliente);
  }

}
