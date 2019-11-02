import { Component, OnInit } from '@angular/core';
import { SectorService } from '../../Services/sector.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-crud-input',
  templateUrl: './crud-input.component.html',
  styleUrls: ['./crud-input.component.css']
})
export class CrudInputComponent implements OnInit {

  constructor(private service: SectorService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
      this.service.formData = {
        Id: 0,
        Descripcion: ''
      };
    }
  }

  onSubmit(form: NgForm) {
    this.service.PostSector(form.value).subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Guardado Exitosamente', 'Registro de Sector Guardado Exitosamente');
      },
      err => {
        console.log(err);
      }
    );
  }

}
