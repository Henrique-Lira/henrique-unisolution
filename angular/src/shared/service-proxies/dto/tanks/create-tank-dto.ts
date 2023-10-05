export interface ICreateTankDto {
    id: string;
    capacity: number;
    productType: string;
  }

  export class CreateTankDto implements ICreateTankDto {
    id: string;
    capacity: number;
    productType: string;

    constructor(data?: ICreateTankDto) {
      if (data) {
        this.id = data.id;
        this.capacity = data.capacity;
        this.productType = data.productType;
      }
    }

    static fromJS(data: any): CreateTankDto {
      data = typeof data === "object" ? data : {};
      return new CreateTankDto({
        id: data["id"],
        capacity: data["capacity"],
        productType: data["productType"]
      });
    }

    toJSON(): any {
      return {
        id: this.id,
        capacity: this.capacity,
        productType: this.productType
      };
    }
  }
