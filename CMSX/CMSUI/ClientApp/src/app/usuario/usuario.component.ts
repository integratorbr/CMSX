import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { UsuarioService } from '../services/usuario.service';

@Component({
  templateUrl: './usuario.component.html'
})

export class UsuarioComponent {
  public userList: UsuarioData[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UsuarioData[]>(baseUrl + 'Usuarios').subscribe(result => {
      this.userList = result;
    }, error => console.error(error));
  }

  /*getUsers() {
    this._userList.getUserList().subscribe(
      data => this.userList
    )
  }*/



  /*delete(employeeID) {
    var ans = confirm("Do you want to delete customer with Id: " + employeeID);
    if (ans) {
      this._employeeService.deleteEmployee(employeeID).subscribe((data) => {
        this.getEmployees();
      }, error => console.error(error))
    }
  }*/
}

interface UsuarioData {
  Userid: string;
  Nome: string;
}
