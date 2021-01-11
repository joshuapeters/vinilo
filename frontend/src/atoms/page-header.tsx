import * as React from "react";

export interface PageHeader{
    heading: string;
}

export const PageHeader = (props: PageHeader) =>
{
    return (
        <div className="container">
            <h1>{props.heading}</h1>
        </div>
    );
   
}