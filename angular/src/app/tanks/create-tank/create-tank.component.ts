import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { CreateTankDto } from '@shared/service-proxies/dto/tanks/create-tank-dto';
import { TankServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'app-create-tank',
  templateUrl: './create-tank.component.html'
})
export class CreateTankComponent extends AppComponentBase implements OnInit {
  saving = false;
  tank: CreateTankDto = new CreateTankDto();

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    public bsModalRef: BsModalRef,
    public _tankService: TankServiceProxy
  ) {
    super(injector);
  }

  ngOnInit(): void {
  }

  save(): void {
    this.saving = true;

    this._tankService
      .create(this.tank)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      });
  }
}
