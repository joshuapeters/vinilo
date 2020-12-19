import * as React                   from "react";
import { BUTTON_SIZE, BUTTON_TYPE } from "@core/enums/buttons/button-enums";

export interface SubmitButtonProps{
    label:   string;
    size:    BUTTON_SIZE;
    type:    BUTTON_TYPE;
    onClick: (args) => void;
}

export const SubmitButton = (props: SubmitButtonProps) =>
{
    return (
        <button
            className = { `button-submit ${props.type ?? "primary"} ${props.size ?? "small"}` }
            onClick   = { props.onClick }
            type      = "submit">
                { props.label }
        </button>
    );
}
