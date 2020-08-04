import * as React from "react";

export interface SubmitButton{
    label: string;
}

export const SubmitButton = (props: SubmitButton) =>
{
    return (
        <button type="submit" className="btn btn-primary">{props.label}</button>
    );
}