import * as React from "react";
import { TextInput } from "@components/text-input";
import { SubmitButton } from "@components/button-submit";
import { PageHeader } from "@components/page-header";

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

                    <SubmitButton label = "Submit"/>
                </form>
            </div>
        </div>
    ); 
}

