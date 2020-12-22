import * as React from "react";
import { TextInput } from "@components/text-input";
import { SubmitButton } from "@components/button-submit";
import { PageHeader } from "@components/page-header";
import { BUTTON_SIZE, BUTTON_TYPE } from "@core/enums/components/buttons/button-enums";

export const AlbumCurationPage = () =>
{
    return (
        <div>
            <PageHeader heading = "Add New Album"/>
            <div className="container">
                <form>
                    <TextInput label = "Artist Name" id = "artist-name" />
                    <TextInput label = "Album Name" id = "album-name" />
                    <TextInput label = "Catalog Number" id = "catalog-number" />

                    <SubmitButton size = {BUTTON_SIZE.LARGE} type = {BUTTON_TYPE.PRIMARY} onClick = {() => true } label = "Submit"/>
                </form>
            </div>
        </div>
    );
}

