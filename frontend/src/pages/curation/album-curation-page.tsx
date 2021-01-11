import * as React from "react";
import { TextInput } from "@atoms/text-input";
import { SubmitButton } from "@atoms/button-submit";
import { PageHeader } from "@atoms/page-header";
import { BUTTON_SIZE, BUTTON_TYPE } from "@core/enums/components/buttons/button-enums";

export const AlbumCurationPage = () =>
{
    const writeToConsole = (value: string) => console.log(value);

    return (
        <div>
            <PageHeader heading = "Add New Album"/>
            <div className="container">
                <form>
                    <TextInput label="Artist Name"    id="artist-name"    onUpdate={ writeToConsole }/>
                    <TextInput label="Album Name"     id="album-name"     onUpdate={ writeToConsole }/>
                    <TextInput label="Catalog Number" id="catalog-number" onUpdate={ writeToConsole }/>

                    <SubmitButton size = {BUTTON_SIZE.LARGE} type = {BUTTON_TYPE.PRIMARY} onClick = {() => true } label = "Submit"/>
                </form>
            </div>
        </div>
    );
}

