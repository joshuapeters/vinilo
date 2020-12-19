import * as React from "react";

export interface TextInputProps{
    label: string;
    id: string;
}

export const TextInput = (props: TextInputProps) =>
    {
    return(
            <div className="form-group">
                <label htmlFor={props.id}>{props.label}</label>
                <input id={props.id} type="email" className="form-control"/>
            </div>
        );
    }