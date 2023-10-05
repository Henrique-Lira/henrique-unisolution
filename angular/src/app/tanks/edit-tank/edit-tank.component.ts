import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { TankDto } from '@shared/service-proxies/dto/tanks/tank-dto';
import { TankServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-edit-tank',
  templateUrl: './edit-tank.component.html'
})
export class EditTankComponent extends AppComponentBase implements OnInit {
saving = false;
tank: TankDto = new TankDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public bsModalRef: BsModalRef,
  public _tankService: TankServiceProxy
) {
  super(injector);
}

ngOnInit(): void {
  this._tankService.get(this.id).subscribe((result: TankDto) => {
    this.tank = result;
  });
}

save(): void {
  this.saving = true;

  this._tankService
    .update(this.tank)
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
