import { Component, Input, OnInit } from '@angular/core';
import { Validator, FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Cliente } from 'src/app/models/cliente';
import { ClienteService } from '../service/cliente.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-clientes-form',
  templateUrl: './clientes-form.component.html',
  styleUrls: ['./clientes-form.component.scss']
})
export class ClientesFormComponent implements OnInit {

  clienteObject: Cliente = new Cliente();
  onModify: boolean = false;
  clientesForm!: FormGroup;
  id: string = '';

  constructor(private readonly fb: FormBuilder, private route: ActivatedRoute,
    private service: ClienteService) { }

  ngOnInit(): void {

    this.clientesForm = this.fb.group({
      id: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(5)]],
      compania: ['', [Validators.required, Validators.minLength(1)]],
      ciudad: ['', [Validators.required, Validators.minLength(1)]]
    });


    this.onModify = this.route.snapshot.data['onModify'];



    this.id = this.route.snapshot.paramMap.get('id') as string;
    if (this.id)
      this.obtenerObjeto(this.id);


  }

  enviarSubmit() {
    var nuevoCliente = new Cliente();
    nuevoCliente.id = this.clientesForm.get('id')?.value;
    nuevoCliente.ciudad = this.clientesForm.get('ciudad')?.value;
    nuevoCliente.Compania = this.clientesForm.get('compania')?.value;
    
    if (this.onModify) {
      this.service.UpdateClientes(nuevoCliente).subscribe({
        next: result => {
          
        },
        error: err => {
          Swal.fire({
            icon: 'error',
            title: 'Ups..',
            text: 'No se pudo modificar el cliente'
          });
        },
        complete: () => {
          Swal.fire({
            icon: 'success',
            title: 'Hecho',
            text: 'Cliente actualizado con exito'
          });
          this.clientesForm.reset();
        }
      });
    }
    else {
      this.service.InsertarCliente(nuevoCliente).subscribe({
        next: result => {

        },
        error: err => {
          Swal.fire({
            icon: 'error',
            title: 'Ups..',
            text: 'No se pudo insertar el cliente'
          });
        },
        complete: ()=>{
          Swal.fire({
            icon: 'success',
            title: 'Hecho',
            text: 'Cliente creado con exito'
          });
          this.clientesForm.reset();
        }
        
      })
    }

  }


  obtenerObjeto(id: string) {
    this.service.GetClienteById(id).subscribe(result => {
      this.clienteObject = result;
      this.cargarFormulario();
    });
  }

  cargarFormulario() {
    this.clientesForm = this.fb.group({
      id: [this.clienteObject.id, [Validators.required, Validators.minLength(1), Validators.maxLength(5)]],
      compania: [this.clienteObject.Compania, [Validators.required, Validators.minLength(1)]],
      ciudad: [this.clienteObject.ciudad, [Validators.required, Validators.minLength(1)]]
    });

  }




}
