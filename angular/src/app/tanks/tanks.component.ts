import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { PagedListingComponentBase, PagedRequestDto,} from '@shared/paged-listing-component-base';
import { TankDto } from '@shared/service-proxies/dto/tanks/tank-dto';
import { TankDtoPagedResultDto } from '@shared/service-proxies/dto/tanks/tank-dto-paged-result-dto';
import { TankServiceProxy } from '@shared/service-proxies/service-proxies';
import { CreateTankComponent } from './create-tank/create-tank.component';
import { EditTankComponent } from './edit-tank/edit-tank.component';

class PagedTanksRequestDto extends PagedRequestDto {
  keyword: string;
  isActive: boolean | null;
}

@Component({
  selector: 'app-tanks',
  templateUrl: './tanks.component.html'
})
export class TanksComponent extends PagedListingComponentBase<TankDto> {
  tanks: TankDto[] = [];
  keyword = '';
  isActive: boolean | null;
  advancedFiltersVisible = false;

  constructor(
    injector: Injector,
    private _modalService: BsModalService,
    private _tankService: TankServiceProxy
  ) {
    super(injector);
  }

  list(
    request: PagedTanksRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;
    request.isActive = this.isActive;

    this._tankService
      .getAll(
        request.keyword,
        request.isActive,
        request.skipCount,
        request.maxResultCount
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: TankDtoPagedResultDto) => {
        this.tanks = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  createTank(): void {
    this.showCreateOrEditTankDialog();
  }

  editTank(tank: TankDto): void {
    this.showCreateOrEditTankDialog(tank.id);
  }

  clearFilters(): void {
    this.keyword = '';
    this.isActive = undefined;
    this.getDataPage(1);
  }

  delete(tank: TankDto): void {
    abp.message.confirm(
      this.l('TankDeleteWarningMessage', tank.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._tankService
            .delete(tank.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  showCreateOrEditTankDialog(id?: string): void {
    let createOrEditTankDialog: BsModalRef;
    if (!id || id === '') {
      createOrEditTankDialog = this._modalService.show(
        CreateTankComponent,
        {
          class: 'modal-lg'
        }
      );
    } else {
      createOrEditTankDialog = this._modalService.show(
        EditTankComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id
          }
        }
      );
    }

    createOrEditTankDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}
