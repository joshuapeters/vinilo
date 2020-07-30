import * as React    from "react";
import { HelloPage } from "@pages/hello-page";

import "./sass/app.scss";
import { AlbumCurationPage } from "@pages/curation/album-curation-page";

export const App = () => {
    return (
      <AlbumCurationPage/>
    );
};
