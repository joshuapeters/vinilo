const isNullOrUndefined = (value: any)    => (value == null);
const isNotNullOrUndefined = (value: any) => !isNullOrUndefined(value);

export const CoreUtilities = {
    isNullOrUndefined,
    isNotNullOrUndefined
}
