import { PagingParameters } from "@core/models/paging/PagingParameters";

export interface Result<T> {
    errors?:         Error[];
    resultObject?:   T;
    nextPageParams?: PagingParameters;
    prevPageParams?: PagingParameters;
}
