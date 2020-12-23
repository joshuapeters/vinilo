import { Result }        from "@core/models/result/result";
import { CoreUtilities } from "@core/utilities/core-utilities";

const getDefaultResult = (): Result<any> => {
    return {
        errors: [{ message: "An unknown error occured! Please try again later." }]
    } as Result<any>;
}

const resultHasErrors = (result: Result<any>): boolean => {
    return CoreUtilities.isNotNullOrUndefined(result.errors) && result.errors.length > 0;
}

const resultDoesNotHaveErrors = (result: Result<any>): boolean => !resultHasErrors(result);

export const ResultUtilities = {
    getDefaultResult,
    resultHasErrors,
    resultDoesNotHaveErrors
}
