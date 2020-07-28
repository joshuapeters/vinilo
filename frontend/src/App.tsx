import * as React    from "react";
import { HelloPage } from "@pages/hello-page";

import "./sass/app.scss";

export const App = () => {
    return (
      <HelloPage compiler = { "Typescript" } framework = { "React" }/>
    );
};
