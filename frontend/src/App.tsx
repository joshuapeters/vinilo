import * as React    from "react";
import "./sass/app.scss";
import { HelloPage } from "./pages/hello-page";

export const App = () => {
    return (
      <HelloPage compiler = { "Typescript" } framework = { "React" }/>
    );
};
