import * as React                                 from "react";
import { FunctionComponent, useEffect, useState } from "react";

export interface TextInputProps{
    label:         string;
    id:            string;
    initialValue?: string;
    onUpdate?:     (newValue: string) => void;
}

export const TextInput:FunctionComponent<TextInputProps> = (props: TextInputProps) => {

    const [value, setValue] = useState(props.initialValue ?? "");

    useEffect(() => {
        props.onUpdate(value);
    })

    return(
            <div className="form-group">
                <label htmlFor={props.id}>{props.label}</label>
                <input id={props.id} type="email" className="form-control" onChange={this.setValue} value={this.value}/>
            </div>
        );
    }
