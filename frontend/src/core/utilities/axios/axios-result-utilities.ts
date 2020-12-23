import { AxiosError, AxiosResponse } from "axios";
import { Result }                    from "@core/models/result/result";
import { Error }                     from "@core/models/errors/error";

const convertAxiosResponseToResult = <T> (response: AxiosResponse<T>): Result<T> => {
    return {
        resultObject: response.data,
    } as Result<T>;
}

const convertAxiosErrorToResult = <T> (error: AxiosError): Result<T> => {
    const resultError = {
        message: error.message
    } as Error

    return {
        errors: [resultError]
    } as Result<T>;
}

export const AxiosUtilities = {
    convertAxiosResponseToResult,
    convertAxiosErrorToResult
};
