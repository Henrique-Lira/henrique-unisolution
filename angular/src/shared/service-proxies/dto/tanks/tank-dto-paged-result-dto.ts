import { TankDto } from "./tank-dto";

export interface ITankDtoPagedResultDto {
    totalCount: number;
    items: TankDto[] | undefined;
}

export class TankDtoPagedResultDto implements ITankDtoPagedResultDto {
    totalCount: number;
    items: TankDto[] | undefined;

    constructor(data?: ITankDtoPagedResultDto) {
        if (data) {
            this.totalCount = data.totalCount;
            if (Array.isArray(data.items)) {
                this.items = data.items.map(item => new TankDto(item));
            }
        }
    }

    static fromJS(data: any): TankDtoPagedResultDto {
        data = typeof data === 'object' ? data : {};
        const result = new TankDtoPagedResultDto();
        result.totalCount = data.totalCount || 0;
        if (Array.isArray(data.items)) {
            result.items = data.items.map(item => new TankDto(item));
        }
        return result;
    }

    toJSON(data?: any): any {
        data = typeof data === 'object' ? data : {};
        data.totalCount = this.totalCount;
        if (Array.isArray(this.items)) {
            data.items = this.items.map(item => item.toJSON());
        }
        return data;
    }

    clone(): TankDtoPagedResultDto {
        const json = this.toJSON();
        const result = new TankDtoPagedResultDto();
        Object.assign(result, json);
        return result;
    }
}
