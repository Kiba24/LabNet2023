import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/app/models/cliente';
import { ClienteService } from '../service/cliente.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-clientes-list',
  templateUrl: './clientes-list.component.html',
  styleUrls: ['./clientes-list.component.scss']
})
export class ClientesListComponent implements OnInit {

  public listClientes: Array<Cliente> = [];

  constructor(private service: ClienteService) { }

  ngOnInit(): void {

    this.getClientes();

  }

  getClientes() {
    this.service.GetClientes().subscribe(c => {
      this.listClientes = c;
    });
  }

  eliminarCliente(id: string) {

    this.service.DeleteCliente(id).subscribe({
      next: result => {
        this.getClientes();
      },
      error: err => {
        Swal.fire({
          icon: 'error',
          title: 'Ups...',
          text: 'No se pudo eliminar el cliente'
        });
      },
      complete: () => {
        Swal.fire({
          icon: 'success',
          title: 'Hecho',
          text: 'Cliente eliminado con exito'
        });
      }
    });

  }


}




