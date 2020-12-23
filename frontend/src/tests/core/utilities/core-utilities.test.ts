import { CoreUtilities } from "@core/utilities/core-utilities";

describe("CoreUtilities", () => {
    describe("isNullOrUndefined", () => {
      test("should return true if null value is passed in", async () => {
          const value = null;
          const isNullorUndefined = CoreUtilities.isNullOrUndefined(value);

          expect(isNullorUndefined).toBe(true);
      });
      test("should return false if instantiated value is passed in", async () => {
          const value = 2;
          const isNullorUndefined = CoreUtilities.isNullOrUndefined(value);

          expect(isNullorUndefined).toBe(false);
      })
    });
    describe("isNotNullOrUndefined", () => {
       test("should return true if value is instantiated", async () => {
           const value = 2;
           const isNotNullOrUndefined = CoreUtilities.isNotNullOrUndefined(value);

           expect(isNotNullOrUndefined).toBe(true);
       });
        test("should return false if value is null", async () => {
            const value = null;
            const isNotNullOrUndefined = CoreUtilities.isNotNullOrUndefined(value);

            expect(isNotNullOrUndefined).toBe(false);
        });
    });
})
