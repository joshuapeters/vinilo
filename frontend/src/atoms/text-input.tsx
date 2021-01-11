import * as React                                              from "react";
import { ChangeEvent, FunctionComponent, useEffect, useState } from "react";
import { CoreUtilities }                                       from "@core/utilities/core-utilities";

export interface TextInputProps{
    label:         string;
    id:            string;
    initialValue?: string;
    onUpdate?:     (newValue: string) => void;
}

export const TextInput:FunctionComponent<TextInputProps> = (props: TextInputProps) => {

    const [value, setValue] = useState(props.initialValue ?? "");

    useEffect(() => {
        if (CoreUtilities.isNotNullOrUndefined(props.onUpdate))
            props.onUpdate(value);
    }, [value]);

    const handleChange = (e: ChangeEvent<HTMLInputElement>): void => setValue(e.target.value);

    return(
        <div className="form-group">
            <label htmlFor={props.id}>{props.label}</label>
            <input
                id        = { props.id }
                type      = "email"
                className = "form-control"
                onChange  = { handleChange } value = { value }/>
        </div>
    );
}
