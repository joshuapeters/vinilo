import * as React from "react";


// Inputs
interface TextInputProps{
    label: string;
}

const TextInput = (props: TextInputProps) =>
    {
    return(
            <div className="form-group">
                <label>{props.label}</label>
                <input type="email" className="form-control"/>
            </div>
        );
    }


// Submit Button
interface SubmitButton{
    label: string;
}

const SubmitButton = (props: SubmitButton) =>
{
    return (
        <button type="submit" className="btn btn-primary">{props.label}</button>
    );
}

// Page Header
interface PageHeader{
    heading: string;
}

const PageHeader = (props: PageHeader) =>
{
    return (
        <div className="container">
            <h1>{props.heading}</h1>
        </div>
    );
   
}

//Page Execution
export const AlbumCurationPage = () => 
{
    return (
        <div>
            <PageHeader heading = "Add New Album"/>
            <div className="container">
                <form>
                    <TextInput label = "Artist Name"/>
                    <TextInput label = "Album Name"/>
                    <TextInput label = "Catalog Number"/>

                    <SubmitButton label = "Submit"/>
                </form>
            </div>
        </div>
    ); 
}

