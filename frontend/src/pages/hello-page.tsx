import * as React from "react";

export interface HelloPageProps { compiler: string; framework: string; }

export const HelloPage = (props: HelloPageProps) => <h1>Hello from {props.compiler} and {props.framework}!</h1>;
